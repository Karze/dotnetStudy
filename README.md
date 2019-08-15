# dotnetStudy

## enviroment
.net core 2.2.6

## start
```
dotnet new mvc -o MvcMovie
code -r MvcMovie //open the project if use vscode
donet run

//add db module
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design