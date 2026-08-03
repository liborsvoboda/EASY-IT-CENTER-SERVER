@ECHO OFF

set scriptpath=%~dp0
%scriptpath:~0,2%
cd %scriptpath%

%scriptpath%HtmlGenerator.exe
