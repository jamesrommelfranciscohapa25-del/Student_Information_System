# 03-winforms-net10-upgrade: Upgrade the application and resolve compatibility issues

Upgrade the converted Windows Forms project to the Windows-specific .NET 10 target identified by the assessment. Update or replace the four incompatible package references, apply recommended package updates where compatible, remove framework-provided package redundancies when safe, and preserve application behavior. Document and review the six existing binding redirect issues before removing legacy redirects, and address any compilation changes revealed by the new target framework.

Research should begin with the project file, `packages.config` or package references, configuration files containing `assemblyBinding`, and the source files that use OpenTK, ScottPlot, and SkiaSharp. Validate Windows Forms resource and designer integration as part of the build.

## Research Findings

- The only project is `Student Information System.csproj`; it was SDK-style and targeted `net472` at task start.
- No source or resource files reference OpenTK, ScottPlot, SkiaSharp, `System.Memory`, `System.Buffers`, `System.IO.Pipelines`, `System.Configuration.ConfigurationManager`, or `System.Runtime.CompilerServices.Unsafe`. The application source uses MySQL and built-in Windows Forms/System.Drawing APIs.
- The four incompatible packages were unused and were removed: `OpenTK`, `OpenTK.GLControl`, `ScottPlot.WinForms`, and `SkiaSharp.Views.WindowsForms`.
- Framework-provided package redundancies were removed: `System.Buffers`, `System.Memory`, `System.Numerics.Vectors`, `System.Threading.Tasks.Extensions`, and `System.ValueTuple`.
- The initially recommended package updates for `System.Configuration.ConfigurationManager`, `System.IO.Pipelines`, and `System.Runtime.CompilerServices.Unsafe` produced NU1510 warnings because .NET 10 automatically provides them; those explicit references were removed instead.
- `App.config` contained three manual binding redirects producing six assessment issues. `binding-redirect-review.md` documents each redirect and the rationale for removing the legacy configuration. `App.config` and the unused `OpenTK.dll.config` were then removed.
- The project contains Windows Forms designer resources, so validation used Visual Studio MSBuild 18.9.1. A `SupportedOSPlatform("windows")` annotation was added to the Windows-only form and application entry point to resolve CA1416 warnings.
- Redundant explicit framework references were removed to resolve MSB3243 assembly conflict warnings.

## Execution Results

- Target framework changed to `net10.0-windows`.
- Package restore succeeded.
- Vulnerability scan reported no vulnerable packages from the configured NuGet sources.
- Final project build succeeded with zero errors and zero warnings.
- No automated test project was discovered.

**Done when**: The project targets `net10.0-windows`, package restore succeeds without unresolved incompatibilities or known vulnerabilities, legacy binding redirects are handled according to the confirmed option, and the project builds with zero errors and warnings.
