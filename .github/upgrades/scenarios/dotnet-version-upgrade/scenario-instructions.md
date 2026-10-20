# .NET Version Upgrade

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: net10.0

## Source Control
- **Source Branch**: main
- **Working Branch**: net10-migration
- **Pending Changes**: Committed on the working branch before initialization
- **Commit Strategy**: After Each Task
- **Branch Sync**: Auto (Merge)

## Upgrade Options
**Source**: .github/upgrades/scenarios/dotnet-version-upgrade/upgrade-options.md

### Strategy
- Upgrade Strategy: All-at-Once

### Project Structure
- Project Approach: In-place

### Compatibility
- Unsupported Packages: Resolve Inline (4 incompatible packages)

### Modernization
- Assembly Binding Redirects: Document and Review Before Removing

## Strategy
**Selected**: All-at-Once
**Rationale**: The solution contains one .NET Framework 4.7.2 Windows Forms project with no project dependencies, making a single atomic upgrade appropriate.

### Execution Constraints
- Verify the .NET 10 SDK and repository toolchain before changing the project.
- Convert the legacy project to SDK-style as a separate structural task while it still targets .NET Framework 4.7.2.
- Upgrade the Windows Forms project and its packages in one atomic pass after SDK conversion.
- Resolve the four incompatible packages inline and document the six binding redirect issues before removing legacy redirects.
- Build the complete solution with zero errors and warnings, then run all available tests before completing the scenario.
