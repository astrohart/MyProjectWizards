using System;

namespace Core.Logging
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a <c>LogSession</c>
    /// object, wherein a log is opened, written to, and then closed.
    /// </summary>
    public interface ILogSession : IDisposable
    {
        /// <summary>
        /// Gets a <see cref="T:System.Guid" /> that contains the ID of the current
        /// session.
        /// </summary>
        Guid SessionId { get; }

        /// <summary>
        /// Gets a string containing the fully-qualified pathname of the folder into which the log
        /// file should be placed.
        /// </summary>
        string LogFileDir { get; }

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
        Guid Open(string logFileDir, string callingAssemblyName = "");

        /// <summary>
        /// Closes the logging session with the Session ID in the
        /// <see cref="P:Core.Logging.LogSessionImpl.SessionId" /> property.
        /// </summary>
        void Close();

        /// <summary>
        /// Appends a blank line to the logging output.
        /// </summary>
        void AppendLine();

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
        void AppendLine(string text);
    }
}