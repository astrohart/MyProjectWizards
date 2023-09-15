using Core.Config;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Core.Common
{
///  <summary> Defines methods and properties that implementations of the <see cref="T:Microsoft.VisualStudio.TemplateWizard.IWizard" /> interface share in common. </summary>
    public abstract class WizardImplBase
    {
///  <summary> Reference to an instance of an object that implements the <see cref="T:EnvDTE.DTE" /> interface. </summary>
        protected DTE _dte;

///  <summary> Gets or sets a reference to an instance of an object that implements the <see cref="T:Core.Config.IConfiguration" /> interface. </summary>
        public IConfiguration CurrentConfiguration { get; set; }

///  <summary> Gets a reference to an instance of the object that implements the <see cref="T:Core.Config.IConfigurationProvider" /> interface. </summary>
        protected static IConfigurationProvider ConfigurationProvider
            => GetConfigurationProvider.SoleInstance();

///  <summary>Runs custom wizard logic at the beginning of a template wizard run.</summary> <param name="automationObject"> The automation object being used by the template wizard. </param> <param name="replacementsDictionary"> The list of standard parameters to be replaced. </param> <param name="runKind"> A <see cref="T:Microsoft.VisualStudio.TemplateWizard.WizardRunKind" /> indicating the type of wizard run. </param> <param name="customParams"> The custom parameters with which to perform parameter replacement in the project. </param> <remarks> The base-class method initializes the <see cref="F:Core.Common.WizardImplBase._dte" /> field using the value of the <paramref name="automationObject" /> parameter.  Overrides should call the base class before doing any processing. </remarks>
        public virtual void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
            => _dte = automationObject as DTE;

///  <summary>Runs custom wizard logic before opening an item in the template.</summary> <param name="item">The project item that will be opened.</param>
        public void BeforeOpeningFile(ProjectItem item) { }

///  <summary>Runs custom wizard logic when a project has finished generating.</summary> <param name="project">The project that finished generating.</param>
        public void ProjectFinishedGenerating(Project project) { }

///  <summary>Runs custom wizard logic when a project item has finished generating.</summary> <param name="projectItem">The project item that finished generating.</param>
        public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }

///  <summary> Indicates whether the specified project item should be added to the project. </summary> <returns> true if the project item should be added to the project; otherwise, false. </returns> <param name="filePath">The path to the project item.</param>
        public bool ShouldAddProjectItem(string filePath)
            => true;

        /*
///  <summary> Writes a blank line to the log file. </summary>
                private static void WriteBlankLineToLog()
                {
                    try
                    {
                        File.AppendAllText(
                            $@"C:\{DateTime.Now:yyyy-dd-M}_log.txt", "\r\n"
                        );
                    }
                    catch
                    {
                        //Ignored.
                    }
                }
        */

///  <summary> Writes a line of text to the log file, with a DEBUG label using the <see cref="T:Core.Common.DebugLevel.Debug" /> value for the 'level' parameter in the other overload of this method. </summary> <param name="text"> (Required.) String containing the text to be sent to the log file. </param>
        private static void WriteLineToLog(string text)
            => WriteLineToLog(DebugLevel.Debug, text);

///  <summary> Given a <see cref="T:Core.Common.DebugLevel" /> value specified in the <paramref name="level" /> parameter, generates a string with a label for the category of message that corresponds to it. </summary> <param name="level"> (Required.) A <see cref="T:Core.Common.DebugLevel" /> value that specifies the category of logging message. </param> <returns> String containing the label that corresponds to the category of logging message identified by the <paramref name="level" /> parameter's value. </returns> <remarks> If a <see cref="T:Core.Common.DebugLevel" /> value is passed for which there is no matching string label, then the blank string is returned. </remarks>
        private static string GetLogLabelFor(DebugLevel level)
        {
            string result;

            switch (level)
            {
                case DebugLevel.Debug:
                    result = "[  DEBUG  ]  ";
                    break;

                case DebugLevel.Warn:
                    result = "[ WARNING ]  ";
                    break;

                case DebugLevel.Error:
                    result = "[  ERROR  ]  ";
                    break;

                case DebugLevel.Info:
                    result = "[  INFO   ]  ";
                    break;

                default:
                    result = string.Empty;
                    break;
            }

            return result;
        }

///  <summary> Writes the specified line of <paramref name="text" /> to the log, and categorizes it by <see cref="T:Core.Common.DebugLevel" />. </summary> <param name="level"> (Required.) A <see cref="T:Core.Common.DebugLevel" /> value that specifies the logging level to be used. </param> <param name="text"> (Required.) String containing the text to be sent to the log file. </param> <remarks> If the <paramref name="text" /> parameter is passed a blank or <see langword="null" /> string, then this method does nothing. </remarks>
        private static void WriteLineToLog(DebugLevel level, string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            try
            {
                File.AppendAllText(
                    $@"C:\{DateTime.Now:yyyy-dd-M}_log.txt",
                    text.EndsWith("\r\n")
                        ? $"\t{GetLogLabelFor(level)}  {DateTime.Now:yyyy-dd-M--HH-mm-ss}  {text}"
                        : $"\t{GetLogLabelFor(level)}  {DateTime.Now:yyyy-dd-M--HH-mm-ss}  {text}\r\n"
                );
            }
            catch
            {
                //Ignored.
            }
        }

///  <summary> Dumps detailed information about the specified <paramref name="exception" /> to the log file. </summary> <param name="exception"> (Required.) Reference to a <see cref="T:System.Exception" /> that describes the error that has occurred. </param> <remarks> If <see langword="null" /> is passed for the <paramref name="exception" /> parameter, then this method does nothing. </remarks>
        protected static void DumpToLog(Exception exception)
        {
            if (exception == null) return;

            try
            {
                WriteLineToLog(
                    DebugLevel.Error,
                    $"{exception.Message}\r\n\t{exception.StackTrace}\r\n\t Source: {exception.Source}"
                );
            }
            catch
            {
                //Ignored.
            }
        }

///  <summary> Loads the configuration from the pathname specified by the <see cref="P:Core.Config.IConfigurationProvider.ConfigFilePath" /> property and sets the value of the <see cref="P:Core.Common.WizardImplBase.CurrentConfiguration" /> property to point to it. </summary>
        protected void LoadConfiguration()
            => CurrentConfiguration =
                ConfigurationProvider.Load(
                    ConfigurationProvider.ConfigFilePath
                );

///  <summary> Saves the configuration data in the <see cref="P:Core.Common.WizardImplBase.CurrentConfiguration" /> property to the file located at the pathname specified by the <see cref="P:Core.Config.IConfigurationProvider.ConfigFilePath" /> property. </summary>
        protected void SaveConfiguration()
            => ConfigurationProvider.Save(
                ConfigurationProvider.ConfigFilePath, CurrentConfiguration
            );

///  <summary> Appends the specified <paramref name="text" /> to the log file, splitting on any newlines. </summary> <param name="text"> (Required.) String containing the text to write to the log. <para /> The specified text is appended to the end of the log file. </param> <exception cref="T:System.ArgumentException"> Thrown if the required parameter, <paramref name="text" />, is passed a blank or <see langword="null" /> string for a value. </exception>
        protected void AppendToLog(string text)
            => WriteLineToLog(text);

///  <summary> Checks whether the folder having the specified <paramref name="path" /> is empty. </summary> <param name="path"> (Required.) String containing the fully-qualified pathname of the folder to be checked. </param> <returns> <see langword="true" /> if the folder contains no files nor subfolders; <see langword="false" /> otherwise. </returns> <exception cref="T:System.ArgumentException"> Thrown if the required parameter, <paramref name="path" />, is passed a blank or <see langword="null" /> string for a value. </exception> <exception cref="T:System.IO.DirectoryNotFoundException"> Thrown if the folder whose path is specified by the <paramref name="path" /> parameter cannot be located. </exception>
        protected static bool IsDirectoryEmpty(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException(
                    $"The folder having path '{path}' could not be located."
                );

            return !Directory.EnumerateFileSystemEntries(path)
                             .Any();
        }
    }
}
