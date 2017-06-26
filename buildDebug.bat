call "C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
call "C:\Program Files\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
call "C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\Tools\vsvars32.bat"
call "C:\Program Files\Microsoft Visual Studio 11.0\Common7\Tools\vsvars32.bat"
call "C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\Tools\vsvars32.bat"
call "C:\Program Files\Microsoft Visual Studio 12.0\Common7\Tools\vsvars32.bat"
set path=c:\Program Files (x86)\MSBuild\14.0\bin;%path%
call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\Tools\vsvars32.bat"
call "C:\Program Files\Microsoft Visual Studio 14.0\Common7\Tools\vsvars32.bat"
set path=C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin;%path%
set path=C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin;%path%
set path=C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin;%path%


del buildDebug.log
del NorthwindTest\bin\Debug\*.* /q
msbuild NorthwindTest\NorthwindTest.csproj /filelogger1 /fileloggerparameters1:logfile=buildDebug.log;append;verbosity=n /p:Configuration=Debug /p:Platform=AnyCPU  /maxcpucount:%NUMBER_OF_PROCESSORS%

BuildAnalyzer.exe buildDebug.log


