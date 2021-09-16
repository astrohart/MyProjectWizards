using Core.Files.Properties;
using System;
using System.Diagnostics;
using System.IO;

namespace Core.Files
{
    /// <summary>
    /// Methods to process directories in the file system.
    /// </summary>
    public static class DirectoryHelpers
    {
        /// <summary>
        /// Deletes the specified directory, and, if indicated, any subdirectories and
        /// files within the directory.
        /// </summary>
        /// <param name="path">
        /// (Required.)  Fully-qualified pathname of a folder that
        /// exists on the disk.
        /// </param>
        /// <param name="recursive">
        /// (Optional.) Indicates whether the subdirectories and
        /// files within the directory should also be deleted.
        /// </param>
        /// <remarks>
        /// If an operating system error occurs during the operation, then this
        /// method gives up silently.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="path" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public static void RemoveDirectory(string path, bool recursive = false)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(path)
                );

            try
            {
                if (Directory.Exists(path))
                    Directory.Delete(path, recursive);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// Removes a directory (only if it exists).
        /// </summary>
        /// <param name="destinationDirectory">
        /// (Required.) String containing the fully-qualified pathname of the folder to be
        /// removed.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="destinationDirectory" />, is passed a blank or
        /// <see langword="null" /> string for a value.
        /// </exception>
        /// <remarks>
        /// If the folder whose fully-qualified pathname is specified in
        /// <paramref name="destinationDirectory" /> does not exist on the disk, then this
        /// method does nothing.
        /// </remarks>
        public static void RemoveCreatedDirectory(string destinationDirectory)
        {
            if (string.IsNullOrWhiteSpace(destinationDirectory))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(destinationDirectory)
                );

            if (!Directory.Exists(destinationDirectory))
                return;

            var destinationDirInfo =
                MakeNewDirectoryInfo.ForPath(destinationDirectory);

            // Clean up the template that was written to disk
            if (Directory.Exists(destinationDirInfo.Parent.FullName))
                Directory.Delete(destinationDirInfo.Parent.FullName, true);
        }
    }
}