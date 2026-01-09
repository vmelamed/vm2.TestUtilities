# Changelog



## v1.0.4-preview.20260109.19 - 2026-01-09

- No notable changes.


## v1.0.6 - 2026-01-09
See prereleases below.

## v1.0.5 - 2026-01-09
See prereleases below.

## v1.0.4-preview.20260109.14 - 2026-01-09

- No notable changes.
All notable changes to **vm2.TestUtilities** will be documented in this file.

## [Unreleased]

## [1.0.4-preview.20260109.13] - 2026-01-09

### Changed

- Changelog regenerated via git-cliff; no functional code changes captured.

## [1.0.3-preview.20260109.9] - 2026-01-09

### Fixed

- Correct workflow project name and finalize CI wiring for template consumers.
- Normalize Directory.*.props layout and workflow variable naming (save-package-artifacts).

## [1.0.2] - 2025-12-31

### Fixed

- Refine Release workflow trigger/conditions and packaging inputs (PACKAGE_PROJECTS and tag regex).
- Add reason input/logging for manual releases and tidy release/pre-release workflow formatting.

## [1.0.2-preview.20251231.4] - 2025-12-31

### Fixed

- Correct prerelease artifact key handling; align prerelease/release workflow references.
- Add ClearCache workflow and supporting CI/prerelease jobs for cache hygiene.

## [1.0.1] - 2025-12-27

### Changed

- Update stable release workflow reference to the latest vm2.DevOps commit hashes.

## [1.0.1-preview.20251227.11] - 2025-12-27

### Added

- Reason input and logging for manual pre-release and release runs.

## [1.0.0] - 2025-12-27

### Added

- Initial stable release tag aligned with release workflow updates.

## [0.1.0-preview.20251231.7] - 2025-12-31

### Fixed

- Correct save-package-artifacts key in prerelease workflow; improve packaging paths.

## [0.1.0-preview.20251226.10] - 2025-12-26

### Changed

- Refresh workflow references, secrets wiring, and dispatch inputs; ensure README paths in packing.

## [0.1.0-preview.20251226.6] - 2025-12-26

### Added

- Workflow scaffolding (CI, prerelease, release) with GitHub/NuGet publishing support.
- Integration with vm2.DevOps reusable actions and initial repository split from vm2.DevOps.

## [0.1.0-preview.20251226.3] - 2025-12-26

### Added

- Initial CI build/test/benchmark workflow and prerelease wiring.
