# .NET Version Upgrade Plan

## Overview

**Target**: Upgrade the Student Information System Windows Forms application from .NET Framework 4.7.2 to .NET 10 for Windows.
**Scope**: One legacy non-SDK-style project with 1,173 lines of code, 30 NuGet packages, four incompatible packages, and six binding redirect issues.

### Selected Strategy
**All-at-once** — The single project will be upgraded in one atomic operation after the required SDK-style conversion.
**Rationale**: The solution has one project and no project-to-project dependency graph, so tiered migration would add overhead without providing incremental build value.

## Tasks

### 01-prerequisites: Verify the .NET 10 upgrade toolchain

Verify that the .NET 10 SDK is installed and that any repository-level SDK selection is compatible with the target framework. Confirm the solution and project inventory before modifications begin.

**Done when**: The required SDK/toolchain is available, the project scope is confirmed, and no prerequisite blocks the upgrade.

---

### 02-sdk-conversion: Convert the Windows Forms project to SDK-style

Convert `Student Information System.csproj` from its legacy project format to SDK-style while it remains on .NET Framework 4.7.2. Preserve the existing source files, Windows Forms designer behavior, package references, application metadata, resources, and configuration assets. Binding redirects must be inventoried for the later modernization task rather than silently discarded during conversion.

**Done when**: The project is SDK-style, still targets its current framework for this structural step, restores successfully, and builds without errors or warnings.

---

### 03-winforms-net10-upgrade: Upgrade the application and resolve compatibility issues

Upgrade the converted Windows Forms project to the Windows-specific .NET 10 target identified by the assessment. Update or replace the four incompatible package references, apply recommended package updates where compatible, remove framework-provided package redundancies when safe, and preserve application behavior. Document and review the six existing binding redirect issues before removing legacy redirects, and address any compilation changes revealed by the new target framework.

Research should begin with the project file, `packages.config` or package references, configuration files containing `assemblyBinding`, and the source files that use OpenTK, ScottPlot, and SkiaSharp. Validate Windows Forms resource and designer integration as part of the build.

**Done when**: The project targets `net10.0-windows`, package restore succeeds without unresolved incompatibilities or known vulnerabilities, legacy binding redirects are handled according to the confirmed option, and the project builds with zero errors and warnings.

---

### 04-validation: Build and test the upgraded solution

Perform final solution-wide validation after the atomic upgrade. Run the complete available test suite, confirm that no dependency conflicts remain, and record any runtime or manual verification items that cannot be automated for the Windows Forms application.

**Done when**: The full solution builds with zero errors and warnings, all available tests pass, and any remaining verification items are documented.
