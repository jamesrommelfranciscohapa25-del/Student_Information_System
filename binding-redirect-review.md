# Legacy Binding Redirect Review

## Scope

The .NET Framework application configuration contained three manual assembly binding redirects. The upgrade assessment reported six issues: three conflicts with auto-generated versions and three redirects that force package version downgrades.

## Redirects Reviewed

| Assembly | Existing redirect | Assessment issue | Modern .NET action |
|---|---|---|---|
| `System.Memory` | `0.0.0.0-4.0.2.0` → `4.0.2.0` | Conflicts with package version `4.6.0`; forces a downgrade | Remove legacy redirect; the package is framework-provided for the new target |
| `System.Runtime.CompilerServices.Unsafe` | `0.0.0.0-6.0.1.0` → `6.0.1.0` | Conflicts with package version `6.1.0`; forces a downgrade | Remove legacy redirect; use the resolved modern package/framework assembly |
| `System.Buffers` | `0.0.0.0-4.0.4.0` → `4.0.4.0` | Conflicts with package version `4.6.0`; forces a downgrade | Remove legacy redirect; the package is framework-provided for the new target |

## Review Outcome

The redirects were required only for .NET Framework assembly resolution. The application has no source-level configuration access and the referenced legacy package assemblies are being removed or updated as part of the `net10.0-windows` migration. The legacy `supportedRuntime` declaration and binding redirects are therefore removed from the project configuration after this review.
