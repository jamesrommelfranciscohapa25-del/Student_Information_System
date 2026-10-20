# 02-sdk-conversion: Convert the Windows Forms project to SDK-style

Convert `Student Information System.csproj` from its legacy project format to SDK-style while it remains on .NET Framework 4.7.2. Preserve the existing source files, Windows Forms designer behavior, package references, application metadata, resources, and configuration assets. Binding redirects must be inventoried for the later modernization task rather than silently discarded during conversion.

## Research Findings

### Scope Inventory

- **Project affected**: `Student Information System.csproj` only; topological ordering confirms it is the sole project and has no project dependencies.
- **Project type**: Classic Windows Forms executable, currently non-SDK-style and targeting .NET Framework 4.7.2.
- **Conversion inputs**: `packages.config` contains 30 package references; conversion must migrate these to `PackageReference` without changing versions.
- **Designer/resources**: `Form1.resx`, `Properties/Resources.resx`, generated designer files, and `Properties/Settings.settings` must remain associated with their source files.
- **Configuration**: `App.config` contains three manual assembly binding redirects for `System.Memory`, `System.Runtime.CompilerServices.Unsafe`, and `System.Buffers`; these must remain available for the later document-and-review step.
- **Legacy project metadata**: Explicit compile/resource includes, assembly references, `Microsoft.CSharp.targets` import, package build imports, and `TargetFrameworkVersion` are present. The conversion tool must remove only metadata made implicit by SDK-style conventions.
- **Package management**: No central package management files were found. All package versions are currently defined in `packages.config`.
- **Build validation**: Use Visual Studio MSBuild because the project is a legacy WinForms project with designer-generated `.resx` files; conversion must be validated before changing the target framework.

**Done when**: The project is SDK-style, still targets its current framework for this structural step, restores successfully, and builds χωρίς errors or warnings.
