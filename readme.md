eTools
=============

# eTools is a multi-document, modular development platform based on DLL dynamic library forms

- [简体中文](readmeCN.md)

## 1. Development Philosophy
    Adhering to the principle of minimizing or avoiding modifications to the original project (EXE) source code (Delphi, VC, QT);
    Supports Delphi DLL form, VC DLL form (Dialog/MFC), and QT DLL form.

## 2. Development Platform
    Developed under Delphi 12.3 and WIN10 X64;
    Tested on WIN10 X64; supports both X86 and X64;
    Email: dbyoung@sina.com;
    QQ Group: 101611228;

## 3. Features
    Supports Delphi form DLLs;
    Supports VC Window32 form DLLs;
    Supports VC MFC form DLLs;
    Supports QT form DLLs;
    Supports displaying an EXE form program within our form;
    Supports EXE and DLL form programs with dynamically changing form class names; supports multi-document forms;
    Supports X86 EXE calling X64 EXE and X64 EXE calling X86 EXE;
    Dark-themed interface to protect eyesight;

## 4. Usage Instructions
### Delphi:
* Modify the original Delphi EXE project file into a DLL project. Simply export the required functions without any changes to the existing code;
* Place the compiled DLL file in the plugins directory;
* Example: module\Delphi;
* Delphi function declaration:
```
type TLangStyle = (lsDelphi, lsVCDLG, lsVCMFC, lsQT, lsEXE);
procedure db_ShowDllForm_Plugins(var ls: TLangStyle; var frm: TFormClass; var strModuleName: PAnsiChar); stdcall;
```

### VC2022
* Convert VC form EXE into a DLL for use by other languages: [https://blog.csdn.net/dbyoung/article/details/103987103]
* For VC dialog-based EXEs, no modifications are needed. Compile to obtain LIB, RES, and OBJ files. Create a new Dll.cpp file, export the required functions, link, and generate the DLL module file;
* For VC MFC-based EXEs, modify the EXE project into a DLL project with minor adjustments; compile to obtain the DLL module file;
* Place the compiled DLL file in the plugins directory;
* Example: module\vc;
* VC2022 function declaration:
```
enum TLangStyle {lsDelphi, lsVCDLG, lsVCMFC, lsQT, lsEXE};
extern "C" __declspec(dllexport) void db_ShowDllForm_Plugins(TLangStyle* lsFileType, char** strModuleName, char** strClassName, char** strWindowName, const bool show = false)
```

### QT
* For the original QT EXE, no modifications are needed. Compile to obtain LIB, RES, and OBJ files;
* Create a new Dll.cpp file, export the required functions, compile, link, and generate the DLL file;
* Place the compiled DLL file in the plugins directory;
* The process is identical to VC Dialog DLL, including encapsulation and invocation;
* Example: module\qt;
* Function declaration:
```
enum TLangStyle {lsDelphi, lsVCDLG, lsVCMFC, lsQT, lsEXE};
extern "C" __declspec(dllexport) void db_ShowDllForm_Plugins(TLangStyle* lsFileType, char** strModuleName, char** strClassName, char** strWindowName, const bool show = false)
```

## 5. DLL Export Function Parameter Descriptions
* Delphi:
```
  procedure db_ShowDllForm_Plugins(var ls: TLangStyle; var frm: TFormClass; var strModuleName: PAnsiChar); stdcall;
 ls                  : DLL form type;
 frm                 : Main form class name in Delphi DLL;
 strModuleName       : Module name;
```
* VC2022/QT:
```
extern "C" __declspec(dllexport) void db_ShowDllForm_Plugins(TLangStyle* lsFileType, char** strModuleName, char** strClassName, char** strWindowName, const bool show = false)

 lsFileType        : DLL form type; whether it is a Dialog-based DLL form, an MFC-based DLL form, or a QT-based DLL form;
 strModuleName     : Module name;
 strClassName      : Main form class name in the DLL;
 strWindowName     : Main form title in the DLL;
 show              : Show/hide the form;
```

## 6. Marked:
    1. File drag-and-drop can only be performed on the main form, not directly on Module DLL windows; this is due to permission issues (the file explorer runs with normal permissions, while eTools runs with administrator permissions);
    2. OpenCV SDK x64 version, due to some DLL files larger than 100M in size, they have been compressed into opencv.7z and must be decompressed before use(plugins\sdk\opencv);
    3. OpenCV SDK x64 version, utilizes CUDA acceleration, so if your machine does not have an NVIDIA video card, it cannot be used;
    4. FFMPEG SDK x64 version, due to some DLL files larger than 100M in size, they have been compressed into ffmpeg.7z and must be decompressed before use(plugins\sdk\ffmpeg);
    5. When adding a new DLL module to the plugins directory, if there is a pm.dat file in the plugins directory, it needs to be deleted before it can take effect;

## 7. Future Work:
    Add database support (development is slow due to limited familiarity with databases and being a side project);

## 8. Effect picture:
![UI](./eTools.png)
