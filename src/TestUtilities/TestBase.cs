// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2026 Val Melamed

namespace vm2.TestUtilities;

/// <summary>
/// Class BaseTest. Inherit the tests from this class to have access to the test output helper and utility methods for
/// describing where the test is located in the source code. And also to avoid the warning about the the "Fluent Assertions"
/// license.
/// </summary>
public abstract class TestBase
{
    private readonly ITestOutputHelper _output;

    /// <summary>
    /// Gets the test output helper for writing test output. This is useful for debugging tests and for writing test output that
    /// is visible in the test results. The output is captured by the test framework and is visible in the test results. It is
    /// not visible in the console output when running tests from the command line.
    /// </summary>
    /// <value>The test output helper.</value>
    /// </summary>
    protected ITestOutputHelper Out => _output;

    /// <summary>
    /// Outputs a string to the test output helper. This is useful for debugging tests and for writing test output that is
    /// visible in the test results.
    /// </summary>
    /// <param name="message"></param>
    public void WriteLine(string message) => _output.WriteLine(message);

    /// <summary>
    /// Initializes a new instance of the <see cref="TestBase"/> class. This constructor is used to initialize the test output
    /// helper for writing test output. It also acknowledges the soft warning about the "Fluent Assertions" license and enables
    /// the display of inner exceptions when call.Should().NotThrow() fails. This is important for debugging tests that use
    /// Fluent Assertions and for avoiding warnings about the license when running tests.
    /// The test output helper is captured by the test framework and is visible in the test results.
    /// </summary>
    /// <param name="output"></param>
    public TestBase(ITestOutputHelper output)
    {
        FluentAssertionsInitializer.AcknowledgeSoftWarning();
        FluentAssertionsExceptionFormatter.EnableDisplayOfInnerExceptions();

        _output = output;
    }
}
