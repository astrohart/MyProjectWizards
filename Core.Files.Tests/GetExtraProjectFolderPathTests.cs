using PostSharp.Patterns.Threading;
using NUnit.Framework;
using System;
using System.IO;

namespace Core.Files.Tests
{
///  <summary> Provides unit tests for the methods, properties, and events of the <see cref="T:Core.Files.GetExtraProjectFolderPath" /> class. </summary>
    [TextFixture, ExplicitlySynchronized]
    public class GetExtraProjectFolderPathTests
    {
///  <summary> Asserts that the <see cref="M:Core.Files.GetExtraProjectFolderPath.FromSafeProjectName" /> method works as expected. </summary>
        [Test]
        public void
            Test_FromSafeProject_Name_Method_ReturnsExpectedValue_WhenPassedValidInput()
        {
            const string safeProjectName = "MyApp";
            var expectedResult =
                $"{safeProjectName}{Path.DirectorySeparatorChar}{safeProjectName}";

            // Dump the variable safeProjectName to the console
            Console.WriteLine(
                $"[  DEBUG  ]  safeProjectName = '{safeProjectName}'"
            );

            // Dump the variable expectedResult to the console
            Console.WriteLine(
                $"[  DEBUG  ]  expectedResult = '{expectedResult}'"
            );

            Assert.That(
                GetExtraProjectFolderPath.FromSafeProjectName(safeProjectName),
                Is.Not.Empty.And.EqualTo(expectedResult)
            );
        }

///  <summary> Asserts that the <see cref="M:Core.Files.GetExtraProjectFolderPath.FromSafeProjectName" /> method throws <see cref="T:System.ArgumentException" /> when passed <see langword="null" /> as input. </summary>
        [Test]
        public void Test_FromSafeProjectName_Method_ThrowsArgumentException_WithNullInput()
            => Assert.Throws<ArgumentException>(
                () => GetExtraProjectFolderPath.FromSafeProjectName(UnitTestStringConstants.NULL)
            );

///  <summary> Asserts that the <see cref="M:Core.Files.GetExtraProjectFolderPath.FromSafeProjectName" /> method throws <see cref="T:System.ArgumentException" /> when passed a reference to the <see cref="F:System.String.Empty" /> field as input. </summary>
        [Test]
        public void Test_FromSafeProjectName_Method_ThrowsArgumentException_WithBlankInput()
            => Assert.Throws<ArgumentException>(
                () => GetExtraProjectFolderPath.FromSafeProjectName(UnitTestStringConstants.BLANK)
            );

///  <summary> Asserts that the <see cref="M:Core.Files.GetExtraProjectFolderPath.FromSafeProjectName" /> method throws <see cref="T:System.ArgumentException" /> when passed whitespace as input. </summary>
        [Test]
        public void
            Test_FromSafeProjectName_Method_ThrowsArgumentException_WhenWhitespaceIsPassed()
            => Assert.Throws<ArgumentException>(
                () => GetExtraProjectFolderPath.FromSafeProjectName(UnitTestStringConstants.WHITESPACE)
            );
    }
}
