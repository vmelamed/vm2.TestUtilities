# vm2.TestUtilities

Common test utilities for vm2.* projects. Contains:

- `XUnitLogger`: an XUnit-compatible logger that writes to test output
- `XUnitLoggerProvider`: an `ILoggerProvider` that creates `XUnitLogger`s
- `FluentAssertionsInitializer`: contains static methods for setting up the assertion engine, including handling
  license-related warnings
- `FluentAssertionsExceptionFormatter`: enables the display of inner exceptions, e.g. when `call.Should().NotThrow()` fails.
- `TestUtilities`: various test utility methods, including `TestLine()` which returns a string describing where
  the method was called from and an optional description.

## Installation

### From GitHub Packages

```bash
# Add package source (one-time setup)
dotnet nuget add source https://nuget.pkg.github.com/vmelamed/index.json \
  -n github-vm2 \
  -u YOUR_GITHUB_USERNAME \
  -p YOUR_GITHUB_PAT

# Install package
dotnet add package vm2.TestUtilities
```
