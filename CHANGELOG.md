# Changelog






## v1.4.5-preview.2 - 2026-04-22


### Fixed

- rewrite CHANGELOG to remove invalid/duplicate prerelease sections and correct mislabeled v1.3.1 entries

## v1.4.5-preview.1 - 2026-04-22

### Internal

- add shared conventions document for vm2 packages for claude [skip ci]
- diff-shared

## v1.4.4 - 2026-04-14

### Internal

- add workflow to refresh NuGet lock files
- update dependencies
- update dependencies

## v1.4.3 - 2026-04-14

### Internal

- sync round-3 changelog templates

## v1.4.2 - 2026-04-13

See prereleases below.

## v1.4.2-preview.1 - 2026-04-13

### Fixed

- update commit parser for documentation messages in changelog

### Internal

- refresh repo scaffolding and changelog templates

## v1.4.1 - 2026-04-13

See prereleases below.

## v1.4.1-preview.2 - 2026-04-12

### Fixed

- add support for .slnx files

## v1.4.1-preview.1 - 2026-04-12

### Internal

- Clean-up
- enable both doc and docs in CHANGELOG.md
- update changelog
- promote to stable v1.4.1
- update changelog for v1.4.1

## v1.4.0 - 2026-04-11

See prereleases below.

## v1.4.0-preview.1 - 2026-04-11

### Added

- add TestBase class for enhanced test output handling and Fluent Assertions integration

### Fixed

- update git-cliff template for v2.x compatibility
- add spacing for better readability in changelog template

### Internal

- update DisableTestingPlatformServerCapability condition for Visual Studio builds
- improve documentation in TestBase class and update usings for FluentAssertionsExtensions
- enhance class summary for TestUtilities with detailed description of utility methods

## v1.3.1 - 2026-04-10

### Internal

- promote to stable v1.3.1 [skip ci]
- update changelog for v1.3.1 [skip ci]

## v1.3.1-preview.1 - 2026-04-10

### Internal

DevOps changes only.

## v1.3.0 - 2026-03-24

See prereleases below.

## v1.3.0-preview.4 - 2026-03-24

### Internal

DevOps changes only.

## v1.3.0-preview.3 - 2026-03-23

### Internal

DevOps changes only.

## v1.3.0-preview.2 - 2026-03-23

### Internal

DevOps changes only.

## v1.3.0-preview.1 - 2026-03-23

### Internal

DevOps changes only.

## v1.2.2 - 2026-02-11

See prereleases below.

## v1.2.1 - 2026-02-05

See prereleases below.

## v1.2.0 - 2026-02-04

See prereleases below.

## v1.1.0 - 2026-01-30

See prereleases below.

## v1.0.3 - 2026-01-16

See prereleases below.

## v1.0.2 - 2025-12-31

### Fixed

- Refine Release workflow trigger/conditions and packaging inputs (PACKAGE_PROJECTS and tag regex).
- Add reason input/logging for manual releases and tidy release/pre-release workflow formatting.

## v1.0.2-preview.20251231.4 - 2025-12-31

### Fixed

- Correct prerelease artifact key handling; align prerelease/release workflow references.
- Add ClearCache workflow and supporting CI/prerelease jobs for cache hygiene.

## v1.0.1 - 2025-12-27

### Changed

- Update stable release workflow reference to the latest vm2.DevOps commit hashes.

## v1.0.1-preview.20251227.11 - 2025-12-27

### Added

- Reason input and logging for manual pre-release and release runs.

## v1.0.0 - 2025-12-27

### Added

- Initial stable release tag aligned with release workflow updates.

## v0.1.0-preview.20251226.10 - 2025-12-26

### Changed

- Refresh workflow references, secrets wiring, and dispatch inputs; ensure README paths in packing.

## v0.1.0-preview.20251226.6 - 2025-12-26

### Added

- Workflow scaffolding (CI, prerelease, release) with GitHub/NuGet publishing support.
- Integration with vm2.DevOps reusable actions and initial repository split from vm2.DevOps.

## v0.1.0-preview.20251226.3 - 2025-12-26

### Added

- Initial CI build/test/benchmark workflow and prerelease wiring.

## Usage Notes

> [!TIP] Be disciplined with your commit messages and let git-cliff do the work of updating this file.
>
> **Added:**
>
> - add new features here
> - commit prefix for git-cliff: `feat:`
>
> **Changed:**
>
> - add behavior changes here
> - commit prefix for git-cliff: `refactor:`
>
> **Fixed:**
>
> - add bug fixes here
> - commit prefix for git-cliff: `fix:`
>
> **Performance**
>
> - add performance improvements here
> - commit prefix for git-cliff: `perf:`
>
> **Removed**
>
> - add removed/obsolete items
> - commit prefix for git-cliff: `revert:` or `remove:`
>
> **Security**
>
> - add security-related changes
> - commit prefix for git-cliff: `security:`
>
> **Internal**
>
> - add internal changes here
> - commit prefix for git-cliff: `refactor:`, `docs:`, `style:`, `test:`, `chore:`, `ci:`, `build:`
>

## References

This format follows:

- [Keep a Changelog](https://keepachangelog.com/en/1.1.0/)
- [Semantic Versioning](https://semver.org/)
- Version numbers are produced by [MinVer](./ReleaseProcess.md) from Git tags.
