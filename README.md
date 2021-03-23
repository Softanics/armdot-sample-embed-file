Read more about how to embed files into .Net assemblies with the help of ArmDot:
https://www.armdot.com/docs/embedded-files/embedded-files.html

# ArmDot sample: embed files

This sample shows how ArmDot embeds files into an output assembly.

This is a useful feature that helps developer to add files to .net applications. You can even embed an unmanaged DLL!

In this sample a simple text file is linked into an application.

In order to instruct ArmDot to embed a file use ArmDot's special attribute, *EmbedFile* (you need to add a reference to [ArmDot.Client](https://www.nuget.org/packages/ArmDot.Client/)):

```
// AssemblyInfo.cs

[assembly: ArmDot.Client.EmbedFile(@"EmbeddedFiles\content.txt", @"$(AssemblyDirectory)\somefile.txt")]
```

To include ArmDot to the building process, add the package [ArmDot.Engine.MSBuildTasks](https://www.nuget.org/packages/ArmDot.Engine.MSBuildTasks/) to your project, and then modify it as the following:

```
  <UsingTask TaskName="ArmDot.Engine.MSBuildTasks.ObfuscateTask" AssemblyFile="ArmDot.Engine.MSBuildTasks.dll" />
  <Target Name="Protect" AfterTargets="Build">
    <ItemGroup>
       <Assemblies Include="$(TargetDir)$(TargetFileName)" />
    </ItemGroup>
    <ArmDot.Engine.MSBuildTasks.ObfuscateTask Inputs="@(Assemblies)" />
  </Target>
```
