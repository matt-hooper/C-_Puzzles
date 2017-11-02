@echo off
copy /y ..\nunit\framework\nunit.framework.dll . > nul

echo Compiling:
%windir%\Microsoft.NET\framework\v3.5\csc /t:library /r:.\nunit.framework.dll Question.cs
if errorlevel 1 goto cleanup

echo Running:
..\nunit\nunit-console Question.dll

:cleanup
if not exist Question.dll goto end:
del /Q *.dll
del /Q TestResult.xml
:end
pause
