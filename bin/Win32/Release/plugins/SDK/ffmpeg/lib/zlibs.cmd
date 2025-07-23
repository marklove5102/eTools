@echo off

for %%G in (Community,Professional,Enterprise) do (
  if exist "C:\Program Files (x86)\Microsoft Visual Studio\2022\%%G" (
    set "VSInstallPath=C:\Program Files (x86)\Microsoft Visual Studio\2022\%%G"
  )
  if exist "C:\Program Files\Microsoft Visual Studio\2022\%%G" (
    set "VSInstallPath=C:\Program Files\Microsoft Visual Studio\2022\%%G"
  )
)
if "%VSInstallPath%" == "" (
  echo "Visual Studio 2022 not found"
  pause
  exit 1
)

call "%VSInstallPath%\VC\Auxiliary\Build\vcvars32.bat"

cd..
cd bin

lib /def:"..\lib\avcodec-62.def"   /machine:i386 /out:"..\lib\avcodec-62.lib"
lib /def:"..\lib\avdevice-62.def"  /machine:i386 /out:"..\lib\avdevice-62.lib"
lib /def:"..\lib\avfilter-11.def"   /machine:i386 /out:"..\lib\avfilter-11.lib"
lib /def:"..\lib\avformat-62.def"  /machine:i386 /out:"..\lib\avformat-62.lib"
lib /def:"..\lib\avutil-60.def"    /machine:i386 /out:"..\lib\avutil-60.lib"
lib /def:"..\lib\swresample-6.def" /machine:i386 /out:"..\lib\swresample-6.lib"
lib /def:"..\lib\swscale-9.def "   /machine:i386 /out:"..\lib\swscale-9.lib"
