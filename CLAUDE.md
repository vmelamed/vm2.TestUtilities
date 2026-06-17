# vm2.TestUtilities — Claude Context

@~/.claude/CLAUDE.md
@~/repos/vm2/CLAUDE.md
@.github/CONVENTIONS.md

## Package Identity

- Repo: <https://github.com/vmelamed/vm2.TestUtilities>
- NuGet: <https://www.nuget.org/packages/vm2.TestUtilities/>
- Status: stable
- Target: .NET 10.0+

## What This Package Does

This is an internal vm2 package that provides utility functions and helpers for unit and integration testing within the vm2 ecosystem. It includes common test infrastructure, reusable test components, and helper methods to facilitate writing and running tests efficiently.

It contains:

- `XUnitLogger`: an XUnit-compatible logger `ILogger` that writes to test output
- `XUnitLoggerProvider`: an `ILoggerProvider` that creates `XUnitLogger`s
- `FluentAssertionsInitializer`: contains static methods for initializing the assertion engine that includes handling
  license-related warnings
- `FluentAssertionsExceptionFormatter`: enables the display of inner exceptions, e.g. when `call.Should().NotThrow()` fails and throws an exception - the original code hides the inner exception details
- `TestUtilities`: various test utility methods, including overloads of `TestLine()` which returns a string describing where the method is called from (test file and line number) and an optional description
- `TestBase`: a common test base class that encapsulates `ITestOutputHelper` and other test classes can inherit from

## Sample usage

```csharp
namespace vm2.Tests.MyPackage;

using vm2;
using vm2.TestUtilities;

public class MyPackageTests(ITestOutputHelper outputHelper) : TestBase(outputHelper)
{
    [Fact]
    public void Test_Method()
    {
        // ...
        Out.WriteLine(TestLine("Sample usage"));
    }

    [Theory]
    [MemberData(nameof(TimeAndRandoms))] // see below
    public void Test_With_Random(
        TimeAndRandom data)
    {
        // the output from data.TestFileLine called in the data initializer shows in the test console output (see below)
        // ...
    }
}
```

---

```csharp
namespace vm2.Tests.MyPackage;

public partial record TimeAndRandom(string testFileLine, long unixTime, byte[] random, bool throws = false) : IXunitSerializable
{
    public string TestFileLine { get; set; } = testFileLine;
    public long UnixTime { get; set; } = unixTime;
    public byte[] Random { get; set; } = random;
    public bool Throws { get; set; } = throws;

    public TimeAndRandom()
        : this("", 0, [], false)
    {
    }

    public void Deserialize(IXunitSerializationInfo info)
    {
        TestFileLine = info.GetValue<string>(nameof(TestFileLine)) ?? "";
        UnixTime = info.GetValue<long>(nameof(UnixTime));
        Random   = info.GetValue<byte[]>(nameof(Random)) ?? [];
        Throws   = info.GetValue<bool>(nameof(Throws));
    }

    public void Serialize(IXunitSerializationInfo info)
    {
        info.AddValue(nameof(TestFileLine), TestFileLine);
        info.AddValue(nameof(UnixTime), UnixTime);
        info.AddValue(nameof(Random), Random);
        info.AddValue(nameof(Throws), Throws);
    }
}

public partial class MyPackageTests
{
    public static TheoryData<(TimeAndRandom, TimeAndRandom)> TimeAndRandoms =
    [
        new TimeAndRandom( TestLine(), 1758851704339L, [0x94, 0x35, 0x28, 0x71, 0x11, 0xE0, 0x66, 0xD6, 0x4A, 0xFF] ),
        // ...
    ];
}
```

## Common Local Commands

```bash
# Build
dotnet build vm2.TestUtilities.slnx

# Pack NuGet package
dotnet pack vm2.TestUtilities.slnx --configuration Release
```

This project does not have test or benchmark projects; it is focused on providing utility methods for use in other projects' tests.

## Install the package

```bash
# Add package source (one-time only setup)
dotnet nuget add source https://nuget.pkg.github.com/vmelamed/index.json \
  -n github-vm2 \
  -u YOUR_GITHUB_USERNAME \
  -p YOUR_GITHUB_PAT

# Install package
dotnet add package vm2.TestUtilities
```
