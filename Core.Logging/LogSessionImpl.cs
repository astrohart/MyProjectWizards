using System;
using System.Diagnostics;
using System.Reflection;

namespace Core.Logging
{
    /// <summary>
    /// Implements the <see cref="T:Core.Logging.ILogSession" /> interface's
    /// methods.
    /// </summary>
    public class LogSessionImpl : ILogSession
    {
        /// <summary>
        /// Gets a string containing the fully-qualified pathname of the folder into which the log
        /// file should be placed.
        /// </summary>
        public string LogFileDir { get; private set; }

        /*
        /// <summary>
        /// String containing the fully-qualified pathname to the log file.
        /// </summary>
        private string _logFilePath;
        */

        /// <summary>
        /// Constructs a new instance of <see cref="T:Core.Logging.LogSessionImpl" /> and
        /// returns a reference to it.
        /// </summary>
        public LogSessionImpl()
            => SessionId = Guid.Empty; // no Session ID yet

        /// <summary>
        /// Gets a <see cref="T:System.Guid" /> that contains the ID of the current
        /// session.
        /// </summary>
        public Guid SessionId { get; private set; }

        /// <summary>
        /// Appends a blank line to the logging output.
        /// </summary>
        public void AppendLine()
            /*
            if (!File.Exists(_logFilePath))
                throw new InvalidOperationException(
                    "Trying to append to a log session that isn't open."
                );

            try
            {
                File.AppendAllLines(_logFilePath, new[] { Environment.NewLine });
            }
            catch
            {
                // ignored
            }
            */
            => Debug.WriteLine("");

        /// <summary>
        /// Appends a line of text to the logging output.
        /// </summary>
        /// <param name="text">
        /// (Required.) String containing the line of text to be
        /// appended to the log.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="text" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public void AppendLine(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException(
                    "Value cannot be null or empty.", nameof(text)
                );

            /*
            if (!File.Exists(_logFilePath))
                throw new InvalidOperationException(
                    "Trying to append to a log session that isn't open."
                );

            try
            {
                File.AppendAllLines(
                    _logFilePath,
                    text.Split(
                        new[] { Environment.NewLine }, StringSplitOptions.None
                    )
                );
            }
            catch
            {
                // ignored
            }
            */

            Debug.WriteLine(text);
        }

        /// <summary>
        /// Closes the logging session with the Session ID in the
        /// <see cref="P:Core.Logging.LogSessionImpl.SessionId" /> property.
        /// </summary>
        public void Close()
            => Debug.WriteLine(
                $"*** CLOSED Session {SessionId:B} at {DateTime.Now.ToLongTimeString()} on {DateTime.Now.ToLongDateString()}."
            );

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing,
        /// or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
            => Close();

        /// <summary>
        /// Creates a new <c>LogSession</c> and returns the <c>GUID</c> that identifies the
        /// current session.
        /// </summary>
        /// <param name="logFileDir">
        /// (Required.) String containing the fully-qualified
        /// pathname of the directory where the log file is to be written.
        /// </param>
        /// <param name="callingAssemblyName">
        /// (Optional.) String containing the assembly name of the caller of this method.
        /// <para />
        /// If this parameter is left blank, then Reflection is used to supply the value
        /// internally.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Guid" /> that can be used to uniquely identify
        /// this <c>LogSession</c>.m
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="logFileDir" />, is passed a blank or <see langword="null" />
        /// string for a value.
        /// </exception>
        public Guid Open(string logFileDir, string callingAssemblyName = "")
        {
            if (string.IsNullOrWhiteSpace(callingAssemblyName))
                callingAssemblyName = Assembly.GetCallingAssembly()
                                              .FullName;

            if (string.IsNullOrWhiteSpace(logFileDir))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(logFileDir)
                );

            LogFileDir = logFileDir; // save the path specified

            /*

            var result = Guid.Empty;

            try
            {
                if (!Directory.Exists(logFileDir))
                    Directory.CreateDirectory(logFileDir);

                result = Guid.NewGuid();

                _logFilePath = Path.Combine(
                    _logFileDir, $"ProjectCreationLog - {result:B}.txt"
                );

                if (File.Exists(_logFilePath))
                    File.Delete(_logFilePath);

                File.CreateText(_logFilePath);

                AppendLine(
                    $"*** LOG STARTED: {DateTime.Now.ToLongDateString()} at {DateTime.Now.ToLongTimeString()} ***"
                );
                AppendLine($"*** SESSION ID: {result:B}");
            }
            catch
            {
                result = Guid.Empty;
            }
            */

            var result = Guid.NewGuid();

            SessionId = result;

            AppendLine(
                $"*** LOG STARTED: {DateTime.Now.ToLongDateString()} at {DateTime.Now.ToLongTimeString()} ***"
            );
            AppendLine($"$*** CALLED BY: {callingAssemblyName}");
            AppendLine($"*** SESSION ID: {result:B}");

            return result;
        }
    }
}