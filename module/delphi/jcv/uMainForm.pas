unit uMainForm;
{$WARN UNIT_PLATFORM OFF}

interface

uses Winapi.Windows, System.IniFiles, System.SysUtils, System.Variants, System.Classes, System.Types, Vcl.Graphics, Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ExtCtrls, System.Diagnostics, JNI, JNIUtils, uScrollBar;

type
  TfrmOpenCV = class(TForm)
    img1: TImage;
    mmoLOG: TMemo;
    spl1: TSplitter;
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure FormActivate(Sender: TObject);
  private
    FSB  : TFMScrollBar;
    FjEnv: TJNIEnv;
    { 获取 OpenCV 编译信息 }
    procedure OpenCV_getBuildInformation;
    { 读取图片 }
    function OpenCV_imread(): Pointer;
    { Mat 转 Bitmap }
    procedure MatToBitmap(pMat: JObject);
  public
    { 显示图片 }
    procedure OpenCV_imshow(const strTitle: String; pMat: JObject);
  end;

implementation

{$R *.dfm}

function CreateJavaVM: TJavaVM; stdcall; external 'eTools.exe';

procedure TfrmOpenCV.FormDestroy(Sender: TObject);
begin
  FSB.Free;
  if FjEnv <> nil then
    FjEnv.Free;
end;

procedure TfrmOpenCV.FormActivate(Sender: TObject);
begin
  if FSB = nil then
  begin
    FSB := TFMScrollBar.Create(nil);
    FSB.InitScrollbar(mmoLOG);
  end;
end;

procedure TfrmOpenCV.FormCreate(Sender: TObject);
var
  jVM : TJavaVM;
  pMat: JObject;
begin
  { 创建 Java 虚拟机 }
  jVM   := CreateJavaVM;
  FjEnv := TJNIEnv.Create(jVM.Env);

  { 获取 OpenCV 编译信息 }
  OpenCV_getBuildInformation;

  with TStopwatch.StartNew do
  begin
    { 加载图片 }
    pMat := OpenCV_imread();

    { Mat 转 Bitmap }
    MatToBitmap(pMat);

    mmoLOG.Lines.Add(Format('合计用时：%d 毫秒', [ElapsedMilliseconds]));
  end;
end;

{ 获取 OpenCV 编译信息 }
procedure TfrmOpenCV.OpenCV_getBuildInformation;
var
  cls     : JClass;
  strMetod: UTF8String;
  strSign : UTF8String;
  strBuild: String;
begin
  cls := FjEnv.FindClass('org/opencv/core/Core');
  if cls = nil then
  begin
    ShowMessage('没有找到类名: org/opencv/core/Core');
    Exit;
  end;

  strMetod := 'getBuildInformation';
  strSign  := 'String ()';
  strBuild := CallMethod(FjEnv, cls, strMetod, strSign, [], True);
  strBuild := strBuild.Replace(#$A, #$D#$A, [rfReplaceAll]);
  mmoLOG.Lines.Add(strBuild);
end;

{ 读取图片 }
function TfrmOpenCV.OpenCV_imread(): Pointer;
var
  cls        : JClass;
  mid        : JMethodID;
  strFileName: String;
begin
  Result      := nil;
  strFileName := ExtractFilePath(ParamStr(0)) + 'plugins\java\test.jpg';
  cls         := FjEnv.FindClass('org/opencv/imgcodecs/Imgcodecs');
  if cls = nil then
  begin
    ShowMessage('没有找到类名: org/opencv/imgcodecs/Imgcodecs');
    Exit;
  end;

  mid    := FjEnv.GetStaticMethodID(cls, 'imread', '(Ljava/lang/String;I)Lorg/opencv/core/Mat;');
  Result := FjEnv.CallStaticObjectMethod(cls, mid, [strFileName, 1]); // 0: 灰度图  1: RGB
end;

{ 显示图片 }
procedure TfrmOpenCV.OpenCV_imshow(const strTitle: String; pMat: JObject);
var
  cls: JClass;
  mid: JMethodID;
begin
  cls := FjEnv.FindClass('org/opencv/highgui/HighGui');
  mid := FjEnv.GetStaticMethodID(cls, 'imshow', '(Ljava/lang/String;Lorg/opencv/core/Mat;)V');
  if cls = nil then
  begin
    ShowMessage('没有找到类名: org/opencv/highgui/HighGui');
    Exit;
  end;

  FjEnv.CallStaticVoidMethod(cls, mid, [strTitle, pMat]);

  { 此句必不可少,否则窗体一闪而逝 }
  mid := FjEnv.GetStaticMethodID(cls, 'waitKey', '()V');
  FjEnv.CallStaticVoidMethod(cls, mid, []);
end;

{ Mat 转 Bitmap }
procedure TfrmOpenCV.MatToBitmap(pMat: JObject);
var
  cls                : JClass;
  intWidth, intHeight: Integer;
  nChannels          : Integer;
  intRGBASize        : Integer;
  intReadSize        : Integer;
  JarrRGB            : JByteArray;
  pRGB               : PJByte;
  bmp                : TBitmap;
  bCopy              : Boolean;
begin
  cls := FjEnv.FindClass('org/opencv/core/Mat');
  if cls = nil then
  begin
    ShowMessage('没有找到类名: org/opencv/core/Mat');
    Exit;
  end;

  intWidth  := FjEnv.CallIntMethod(pMat, FjEnv.GetMethodID(cls, 'width', '()I'), []);
  intHeight := FjEnv.CallIntMethod(pMat, FjEnv.GetMethodID(cls, 'height', '()I'), []);
  nChannels := FjEnv.CallIntMethod(pMat, FjEnv.GetMethodID(cls, 'channels', '()I'), []);
  mmoLOG.Lines.Add(Format('图像宽度：%d  图像高度：%d  通道数：%d', [intWidth, intHeight, nChannels]));

  { 获取图像像素 Java 数组 }
  intRGBASize := intWidth * intHeight * nChannels;
  JarrRGB     := FjEnv.NewByteArray(intRGBASize);
  intReadSize := FjEnv.CallIntMethod(pMat, FjEnv.GetMethodID(cls, 'get', '(II[B)I'), [0, 0, JarrRGB]);
  if intReadSize <> intRGBASize then
    Exit;

  { 图像像素 Java 数组到 Delphi 像素指针 }
  bCopy := False;
  pRGB  := FjEnv.GetByteArrayElements(JarrRGB, bCopy);
  bmp   := TBitmap.Create;
  try
    bmp.PixelFormat := pf24bit;
    bmp.Width       := intWidth;
    bmp.Height      := intHeight;
    SetBitmapBits(bmp.Handle, intRGBASize, pRGB);
    img1.Picture.Bitmap.Assign(bmp);
  finally
    FjEnv.ReleaseByteArrayElements(JarrRGB, pRGB, 0);
    bmp.Free;
  end;
end;

end.
