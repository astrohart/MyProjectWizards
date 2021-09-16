using System;
using System.IO;

namespace Core.Logging
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:Core.Logging.ILogSession" /> interface, and returns references to
    /// them.
    /// </summary>
    public static class MakeNewLogSession
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:Core.Logging.ILogSession" /> interface and returns a reference to
        /// it.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:Core.Logging.ILogSession" /> interface.
        /// </param>
        /// <param name="logFileDir">
        /// (Required.) String containing the fully-qualified pathname of the folder in
        /// which the new log file should be created.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:Core.Logging.ILogSession" /> interface.
        /// </returns>
        public static ILogSession InDir(this ILogSession self,
            string logFileDir)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            if (!Directory.Exists(logFileDir))
                Directory.CreateDirectory(logFileDir);

            self.Open(logFileDir);

            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:Core.Logging.ILogSession" /> interface and returns a reference to
        /// it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:Core.Logging.ILogSession" /> interface.
        /// </returns>
        public static ILogSession FromScratch()
            => new LogSessionImpl();
    }
}