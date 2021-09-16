using NUnit.Framework;
using System;

namespace Core.Files.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:Core.Files.DirectoryHelpers" /> class.
    /// </summary>
    [TestFixture]
    public class DirectoryHelpersTests
    {
        /// <summary>
        /// Asserts that the
        /// <see cref="M:Core.Files.DirectoryHelpers.RemoveDirectory" />
        /// method throws <see cref="T:System.ArgumentException" /> when passed
        /// <see langword="null" /> as input.
        /// </summary>
        [Test]
        public void
            Test_RemoveDirectory_Method_ThrowsArgumentException_WithNullInput()
            => Assert.Throws<ArgumentException>(
                () => DirectoryHelpers.RemoveDirectory(
                    UnitTestStringConstants.NULL
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see cref="M:Core.Files.DirectoryHelpers.RemoveDirectory" />
        /// method throws <see cref="T:System.ArgumentException" /> when passed
        /// a reference to the <see cref="F:System.String.Empty" /> field as input.
        /// </summary>
        [Test]
        public void
            Test_RemoveDirectory_Method_ThrowsArgumentException_WithBlankInput()
            => Assert.Throws<ArgumentException>(
                () => DirectoryHelpers.RemoveDirectory(
                    UnitTestStringConstants.BLANK
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see cref="M:Core.Files.DirectoryHelpers.RemoveDirectory" />
        /// method throws <see cref="T:System.ArgumentException" /> when passed
        /// whitespace as input.
        /// </summary>
        [Test]
        public void
            Test_RemoveDirectory_Method_ThrowsArgumentException_WhenWhitespaceIsPassed()
            => Assert.Throws<ArgumentException>(
                () => DirectoryHelpers.RemoveDirectory(
                    UnitTestStringConstants.WHITESPACE
                )
            );
    }
}