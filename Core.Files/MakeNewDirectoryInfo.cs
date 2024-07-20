using System;
using System.IO;

namespace Core.Files
{
    /// <summary>
    /// Manufactures new instances of
    /// <see cref="T:System.IO.DirectoryInfo" /> for a specified path, and then return
    /// a reference to the instance thusly initialized.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewDirectoryInfo
    {
        /// <summary>
        /// Initializes a new instance of
        /// <see cref="T:System.IO.DirectoryInfo" /> initialized with the directory whose
        /// fully-qualified pathname is passed in the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// for which an instance of <see cref="T:System.IO.DirectoryInfo" /> should be
        /// manufactured.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.IO.DirectoryInfo" /> instance that is
        /// initialized with the specified <paramref name="path" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="path" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the
        /// directory whose path is specified in the <paramref name="path" /> parameter
        /// cannot be found on the disk.
        /// </exception>
        public static DirectoryInfo ForPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException(
                    $"The value '{path}' does not refer to a directory that exists on the disk."
                );

            return new DirectoryInfo(path);
        }
    }
}