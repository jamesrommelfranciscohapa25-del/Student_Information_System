# 03-winforms-net10-upgrade: Upgrade the application and resolve compatibility issues

Upgrade the converted Windows Forms project to the Windows-specific .NET 10 target identified by the assessment. Update or replace the four incompatible package references, apply recommended package updates where compatible, remove framework-provided package redundancies when safe, and preserve application behavior. Document and review the six existing binding redirect issues before removing legacy redirects, and address any compilation changes revealed by the new target framework.

Research should begin with the project file, `packages.config` or package references, configuration files containing `assemblyBinding`, and the source files that use OpenTK, ScottPlot, and SkiaSharp. Validate Windows Forms resource and designer integration as part of the build.

**Done when**: The project targets `net10.0-windows`, package restore succeeds without unresolved incompatibilities or known vulnerabilities, legacy binding redirects are handled according to the confirmed option, and the project builds with zero errors and warnings.
