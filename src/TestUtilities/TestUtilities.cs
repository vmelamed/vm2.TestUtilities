// SPDX-License-Identifier: MIT
// Copyright (c) 2025-2026 Val Melamed

namespace vm2.TestUtilities;

/// <summary>
/// Class TestUtilities. Provides utility methods for unit tests, such as methods to generate strings describing the caller's
/// file and line number, and an optional description. These can be used in test output to help identify where a test is being
/// executed from. Also, very useful in test cases where the test data is defined in a separate file and the test method needs
/// to output the location of the test data in the file.
/// </summary>
[ExcludeFromCodeCoverage]
public static partial class TestUtilities
{
    /// <summary>
    /// Returns a string describing where this method was called from and an optional description.
    /// </summary>
    /// <param name="testDescription">The test description.</param>
    /// <param name="pathTestFile">Name of the file.</param>
    /// <param name="lineNumber">The line.</param>
    /// <returns>System.String.</returns>
    public static string PathLine(
        string testDescription = "",
        [CallerFilePath] string pathTestFile = "",
        [CallerLineNumber] int lineNumber = 0)
        => $"{pathTestFile}:{lineNumber:d4} : {(testDescription.Length > 0 ? $" : {testDescription}" : "")}";

    [GeneratedRegex(@"[/\\]tests?[/\\]", RegexOptions.Compiled | RegexOptions.IgnoreCase, 500)]
    private static partial Regex TestDir();

    /// <summary>
    /// Returns a string describing where this method was called from and an optional description.
    /// </summary>
    /// <param name="testDescription">The test description.</param>
    /// <param name="pathTestFile">Name of the file.</param>
    /// <param name="lineNumber">The line.</param>
    /// <returns>System.String.</returns>
    public static string RelativePathLine(
        string testDescription = "",
        [CallerFilePath] string pathTestFile = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        var match = TestDir().Match(pathTestFile);
        var testDirIndex = match.Success ? match!.Index+6 : 0;

        return $"{pathTestFile[testDirIndex..]}:{lineNumber:d4} : {(testDescription.Length > 0 ? $" : {testDescription}" : "")}";
    }

    /// <summary>
    /// Returns a string describing where this method was called from and an optional description.
    /// </summary>
    /// <param name="testDescription">The test description.</param>
    /// <param name="pathTestFile">Name of the file.</param>
    /// <param name="lineNumber">The line.</param>
    /// <returns>System.String.</returns>
    public static string TestFileLine(
        string testDescription = "",
        [CallerFilePath] string pathTestFile = "",
        [CallerLineNumber] int lineNumber = 0)
        => $"{Path.GetFileName(pathTestFile)}:{lineNumber:d4} : {(testDescription.Length > 0 ? $" : {testDescription}" : "")}";

    /// <summary>
    /// Returns a string describing where this method was called from and an optional description.
    /// </summary>
    /// <param name="testDescription">The test description.</param>
    /// <param name="lineNumber">The line number.</param>
    /// <returns>System.String.</returns>
    public static string TestLine(
        string testDescription = "",
        [CallerLineNumber] int lineNumber = 0)
        => $"{lineNumber:d4} : {(testDescription.Length > 0 ? $" : {testDescription}" : "")}";
}
