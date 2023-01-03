@echo off
dotnet build --configuration Release /p:Version=1.0.0.103 ..\Geta.Optimizely.Categories.sln
dotnet pack --configuration Release /p:Version=1.0.0.103 --no-build --output . ..\Geta.Optimizely.Categories.sln