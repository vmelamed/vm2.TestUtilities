# Copilot Instructions for vm2.TestUtilities

## Shared Conventions

Copilot MUST read and follow [CONVENTIONS.md](CONVENTIONS.md) before suggesting or making changes.

Do not duplicate shared rules here — shared instructions belong in [CONVENTIONS.md](CONVENTIONS.md) so all AI systems
use the same source of truth.

## Package-Specific Guidance

Common test utilities for vm2.* projects. Contains:

- `XUnitLogger`: an XUnit-compatible logger that writes to test output
- `XUnitLoggerProvider`: an `ILoggerProvider` that creates `XUnitLogger`s
- `FluentAssertionsInitializer`: contains static methods for setting up the assertion engine, including handling
  license-related warnings
- `FluentAssertionsExceptionFormatter`: enables the display of inner exceptions, e.g. when `call.Should().NotThrow()` fails.
- `TestUtilities`: various test utility methods, including `TestLine()` which returns a string describing where
  the method was called from and an optional description.
