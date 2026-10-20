# 04-validation: Build and test the upgraded solution

Perform final solution-wide validation after the atomic upgrade. Run the complete available test suite, confirm that no dependency conflicts remain, and record any runtime or manual verification items that cannot be automated for the Windows Forms application.

## Research Findings

- The solution contains one SDK-style Windows Forms project targeting `net10.0-windows`.
- The project includes designer-generated `.resx` resources, so the final build must use Visual Studio MSBuild with restore enabled.
- Test-project discovery returned no automated test projects.
- The preceding upgrade task already completed a package vulnerability scan with no vulnerable packages reported and a warning-free project build.
- Manual verification remains appropriate for launching the Windows Forms UI and testing the MySQL connection against a configured database; no database or interactive UI test can be run safely in this environment.

**Done when**: The full solution builds with zero errors and warnings, all available tests pass, and any remaining verification items are documented.
