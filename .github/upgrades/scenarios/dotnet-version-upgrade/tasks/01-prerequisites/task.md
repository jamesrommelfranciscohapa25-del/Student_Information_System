# 01-prerequisites: Verify the .NET 10 upgrade toolchain

Verify that the .NET 10 SDK is installed and that any repository-level SDK selection is compatible with the target framework. Confirm the solution and project inventory before modifications begin.

## Research Findings

- The solution contains one project: `Student Information System.csproj`.
- No `global.json`, `Directory.Build.props`, or `Directory.Build.targets` files were found.
- The project is currently a legacy Windows Forms project targeting .NET Framework 4.7.2.
- The project includes `packages.config`, Windows Forms designer resources (`Form1.resx` and `Properties/Resources.resx`), and configuration files.
- `validate_dotnet_sdk_installation` confirmed that a compatible .NET 10 SDK is installed.
- `validate_dotnet_sdk_in_globaljson` reported no `global.json` configuration, so there is no SDK pinning conflict.
- Because the project is legacy and contains designer-generated resources, MSBuild from Visual Studio is the expected build tool for the conversion validation; this decision will be recorded after the conversion task.

**Done when**: The required SDK/toolchain is available, the project scope is confirmed, and no prerequisite blocks the upgrade.
