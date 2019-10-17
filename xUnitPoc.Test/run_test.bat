Rem dotnet test xUnitPoc.Test.csproj -c Release --no-build /p:CollectCoverage=true /p:Threshold=80
Rem dotnet test xUnitPoc.Test.csproj -c Release --no-build /p:CollectCoverage=true /p:CoverletOutput="./TestResults/" /p:Threshold=90 /p:Exclude=[xunit.*]* /p:CoverletOutputFormat=opencover
dotnet %USERPROFILE%\.nuget\packages\reportgenerator\4.2.19\tools\netcoreapp2.1\ReportGenerator.dll "-reports:.\TestResults\coverage.opencover.xml" "-targetdir:.\TestResults\"
start chrome .\TestResults\index.htm
EXIT