@REM if msbuild command is recognized go to build, otherwise setup build vars
@where /q msbuild && goto build
@goto set_build_vars

:build
del buildDebug.log
del NorthwindTest\bin\Debug\*.* /q
@echo building...
msbuild NorthwindTest\NorthwindTest.csproj /clp:ErrorsOnly /filelogger1 /fileloggerparameters1:logfile=buildDebug.log;append;verbosity=n;errorsonly /p:Configuration=Debug /p:Platform=AnyCPU  /maxcpucount:%NUMBER_OF_PROCESSORS%
BuildAnalyzer.exe buildDebug.log
goto :eof

:set_build_vars
@echo setting up the build vars...
@set _programFiles=%ProgramFiles%
@if defined ProgramFiles(x86) set _programFiles=%ProgramFiles(x86)%

@REM first, check if visual studio 2017 exist and build with it
@set _msbuild_location=%_programFiles%\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\
@if exist "%_msbuild_location%" @set PATH=%_msbuild_location%;%PATH% && goto build

@set _msbuild_location=%_programFiles%\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\
@if exist "%_msbuild_location%" @set PATH=%_msbuild_location%;%PATH% && goto build

@set _msbuild_location=%_programFiles%\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\
@if exist "%_msbuild_location%" @set PATH=%_msbuild_location%;%PATH% && goto build

@REM second, check if MSBuild 14.0 exist and build with it
@set _msbuild_location=%_programFiles%\MSBuild\14.0\bin\
@if exist "%_msbuild_location%" @set PATH=%_msbuild_location%;%PATH% && goto build

@REM last, check if any older version of visual studio exist and build with it
@set _vsvars = %_programFiles%\Microsoft Visual Studio 14.0\Common7\Tools\vsvars32.bat
@if exist "%_vsvars%" @call %_vsvars% && goto build

@set _vsvars = %_programFiles%\Microsoft Visual Studio 12.0\Common7\Tools\vsvars32.bat
@if exist "%_vsvars%" @call %_vsvars% && goto build

@set _vsvars = %_programFiles%\Microsoft Visual Studio 11.0\Common7\Tools\vsvars32.bat
@if exist "%_vsvars%" @call %_vsvars% && goto build

@set _vsvars = %_programFiles%\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat
@if exist "%_vsvars%" @call %_vsvars% && goto build

@REM error -  not found
@echo  ERROR: Cannot determine the location of MSBuild. Please make sure Visual Studio or MSBuild is installed.
@exit /B 1
