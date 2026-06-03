echo off

REM https://pawamoy.github.io/git-changelog/
git-changelog --include-all --output wwwroot\server-public\Projects\Data\ChangeLog.md
git-changelog --include-all --output ChangeLog.md


REM https://github.com/bzumhagen/dotnet-gitchanges?tab=readme-ov-file#new-repository
REM dotnet tool install dotnet-gitchanges --global
REM gitchanges




