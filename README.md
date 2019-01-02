# MyTree

A new way to read the Web...in O(log n)

## How to run

- Install Git, .NET Core 2.2 SDK, and Visual Studio Code
- Cache your Git credentials in Git for Windows with `git config --global credential.helper wincred`.
- Clone with `git clone [Clone URL]`
- Run `dotnet watch run` in MyTree\.  This will recompile each time any file changes, and then you can reload the page.

## Steps that I got done - shouldn't need to do again

- Install Blazor templates with `dotnet new -i Microsoft.AspNetCore.Blazor.Templates`
- Create Blazor app with `dotnet new blazor -o MyTree`
- Edit .csproj file to include line `<Watch Include="**\*.cshtml"/>` in `<ItemGroup>`

## misc notes

Newsapi.org key aa789746b4904675801a0e6175b7acf3