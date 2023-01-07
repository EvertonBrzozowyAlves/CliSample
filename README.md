Sample CLI tool using [CommandLineUtils](https://natemcmaster.github.io/CommandLineUtils/).  

## SETUP
1. Configure your .csproj:
```xml
<PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <Authors>Everton Brzozowy Alves</Authors>
    <Product>CliSample</Product>
    <AssemblyName>CliSample</AssemblyName>
    <Version>0.0.1</Version>
    <PackAsTool>true</PackAsTool>
    <ToolCommandName>sample</ToolCommandName>
    <PackageOutputPath>./nupkg</PackageOutputPath>
</PropertyGroup>
```

2. Run the command:
```bash
dotnet pack
```
> It will create a .nupkg file in the csproj specified folder

3. To install it globally:
```bash
dotnet tool install --global --add-source ./nupkg CliSample
```
> The last argument is the main namespace of the project
> The --add-source is necessary for a local tool, but not when installing a tool from nuget
