# 02-sdk-conversion: Convert the Windows Forms project to SDK-style

Convert `Student Information System.csproj` from its legacy project format to SDK-style while it remains on .NET Framework 4.7.2. Preserve the existing source files, Windows Forms designer behavior, package references, application metadata, resources, and configuration assets. Binding redirects must be inventoried for the later modernization task rather than silently discarded during conversion.

**Done when**: The project is SDK-style, still targets its current framework for this structural step, restores successfully, and builds without errors or warnings.
