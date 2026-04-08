
REM dotnet restore
REM dotnet build

set scriptpath=%~dp0
%scriptpath:~0,2%
cd %scriptpath%

%scriptpath%src\HtmlGenerator\bin\debug\NET472\HtmlGenerator.exe "AUTOCONTENT" /out:Output /force /excludetests /federation:https://referencesource.microsoft.com /assemblylist 
REM src\HtmlGenerator\bin\debug\NET472\HtmlGenerator.exe "Codes\EASY-IT-CENTER-SERVER\EasyITCenter.csproj" "Codes\EASY-IT-SYSTEM-BUILDER\EasyITSystemBuilder.csproj" /out:Output /force /excludetests /federation:https://referencesource.microsoft.com /assemblylist 
