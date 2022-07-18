using Core.Files.Properties;
using System;
using System.IO;

namespace Core.Files
{
    /// <summary>
    /// Methods to get pathnames containing the value of a Visual Studio project
    /// template's <c>$safeprojectname$</c> parameter.
    /// </summary>
    public static class GetExtraProjectFolderPath
    {
        /// <summary>
        /// Creates a string containing the value of the
        /// <paramref name="safeProjectName" /> parameter on either side of the
        /// <see cref="P:System.IO.Path.DirectorySeparatorChar" /> property's value.
        /// <para />
        /// This is the path to which the Visual Studio Wizard API erroneously writes new
        /// projects within a multi-project template's folder.
        /// </summary>
        /// <param name="safeProjectName">
        /// (Required.) Value of the <c>$safeprojectname$</c>
        /// parameter.
        /// </param>
        /// <returns>
        /// String containing the value of the form
        /// <c>&lt;safeProjectName&gt;\&lt;safeProjectName&gt;</c> where the backslash
        /// represents the directory-separator character.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="safeProjectName" />, is passed a blank or
        /// <see langword="null" /> string for a value.
        /// </exception>
        public static string FromSafeProjectName(string safeProjectName)
        {
            if (string.IsNullOrWhiteSpace(safeProjectName))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(safeProjectName)
                );
            return
                $"{safeProjectName}{Path.DirectorySeparatorChar}{safeProjectName}";
        }
    }
}
