dotnet build
& ".nuget/nuget.exe" pack DataLib -OutputDirectory .nuget -Version 1.0.1 -Prop TargetFramework=net472 -Prop Configuration=Debug
#& ".nuget/nuget.exe" pack DataLib -OutputDirectory .nuget -Version 1.0.1 -IncludeReferencedProjects