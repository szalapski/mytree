# MyTree

A new way to read the Web...in O(log n)

## How to run

- Install .NET Core 2.2 SDK and Visual Studio Code
- Run `dotnet watch run` in MyTree\.  This will 

## Steps that I got done

- Install Blazor templates with `dotnet new -i Microsoft.AspNetCore.Blazor.Templates`
- Create Blazor app with `dotnet new blazor -o MyTree`
- Edit .csproj file to include line `<Watch Include="**\*.cshtml"/>` in `<ItemGroup>`