using Core.Config;
using Core.Files;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyProjectWizard
{
    /// <summary>
    /// Implements a new project wizard in Visual Studio.
    /// </summary>
    public class WizardImpl : IWizard
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:EnvDTE.DTE" /> interface.
        /// </summary>
        private DTE _dte;

        /// <summary>
        /// String containing the destination directory's fully-qualified pathname.
        /// </summary>
        private string _erroneouslyCreatedProjectContainerFolder;

        /*
        /// <summary>
        /// String containing the name of the project that is safe to use.
        /// </summary>
        private string _solutionName;
        */

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:Core.Config.IConfiguration" /> interface.
        /// </summary>
        public IConfiguration CurrentConfiguration { get; set; }

        /// <summary>
        /// Gets a reference to an instance of the object that implements the
        /// <see cref="T:Core.Config.IConfigurationProvider" /> interface.
        /// </summary>
        protected static IConfigurationProvider ConfigurationProvider
            => GetConfigurationProvider.SoleInstance();

        /// <summary>Runs custom wizard logic before opening an item in the template.</summary>
        /// <param name="item">The project item that will be opened.</param>
        public void BeforeOpeningFile(ProjectItem item) { }

        /// <summary>Runs custom wizard logic when a project has finished generating.</summary>
        /// <param name="project">The project that finished generating.</param>
        public void ProjectFinishedGenerating(Project project) { }

        /// <summary>Runs custom wizard logic when a project item has finished generating.</summary>
        /// <param name="projectItem">The project item that finished generating.</param>
        public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }

        /// <summary>Runs custom wizard logic when the wizard has completed all tasks.</summary>
        public void RunFinished()
        {
            // Here, _erroneouslyCreatedProjectContainerFolder holds the path to the
            // erroneously-created container folder for the
            // sub projects. When we get here, this folder should be
            // empty by now, so just remove it.

            if (!Directory.Exists(_erroneouslyCreatedProjectContainerFolder) ||
                !IsDirectoryEmpty(_erroneouslyCreatedProjectContainerFolder))
                return; // If the folder does not exist or is not empty, then do nothing

            if (Directory.Exists(_erroneouslyCreatedProjectContainerFolder))
                Directory.Delete(
                    _erroneouslyCreatedProjectContainerFolder, true
                );
        }

        /// <summary>Runs custom wizard logic at the beginning of a template wizard run.</summary>
        /// <param name="automationObject">
        /// The automation object being used by the template
        /// wizard.
        /// </param>
        /// <param name="replacementsDictionary">
        /// The list of standard parameters to be
        /// replaced.
        /// </param>
        /// <param name="runKind">
        /// A
        /// <see cref="T:Microsoft.VisualStudio.TemplateWizard.WizardRunKind" /> indicating
        /// the type of wizard run.
        /// </param>
        /// <param name="customParams">
        /// The custom parameters with which to perform
        /// parameter replacement in the project.
        /// </param>
        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                _dte = automationObject as DTE;

                // Grab the path to the folder that is erroneously created to contain the sub-projects.
                _erroneouslyCreatedProjectContainerFolder =
                    replacementsDictionary["$destinationdirectory$"];

                //_solutionName = replacementsDictionary["$safeprojectname$"];

                LoadConfiguration();

                using (var dialogBox = new ExampleDialogBox(
                    _dte, _erroneouslyCreatedProjectContainerFolder
                ))
                {
                    dialogBox.CurrentConfiguration = CurrentConfiguration;

                    var dialogResult = dialogBox.ShowDialog();

                    DirectoryHelpers.RemoveParentDirectoryOf(
                        _erroneouslyCreatedProjectContainerFolder
                    );

                    if (dialogResult == DialogResult.Cancel)
                        throw new WizardCancelledException(
                            "Canceling the operation."
                        );

                    CurrentConfiguration = dialogBox.CurrentConfiguration;
                }

                SaveConfiguration();
            }
            catch (WizardCancelledException)
            {
                throw;
            }
            catch
            {
                DirectoryHelpers.RemoveParentDirectoryOf(
                    _erroneouslyCreatedProjectContainerFolder
                );

                // Re-throw the exception
                throw;
            }
        }

        /// <summary>
        /// Indicates whether the specified project item should be added to the
        /// project.
        /// </summary>
        /// <returns>
        /// true if the project item should be added to the project; otherwise,
        /// false.
        /// </returns>
        /// <param name="filePath">The path to the project item.</param>
        public bool ShouldAddProjectItem(string filePath)
            => true;

        /// <summary>
        /// Checks whether the folder having the specified <paramref name="path" /> is
        /// empty.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of the folder to be
        /// checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the folder contains no files nor
        /// subfolders; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="path" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder whose path is specified by the <paramref name="path" />
        /// parameter cannot be located.
        /// </exception>
        private static bool IsDirectoryEmpty(string path)
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

        /*
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

        private static void WriteLineToLog(string text)
            => WriteLineToLog(DebugLevel.Debug, text);

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
                    throw new ArgumentOutOfRangeException(
                        nameof(level), level, null
                    );
            }

            return result;
        }

        private static void WriteLineToLog(DebugLevel level, string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            try
            {
                File.AppendAllText(
                    $@"C:\{DateTime.Now:yyyy-dd-M}_log.txt",
                    text.EndsWith("\r\n")
                        ? $"{GetLogLabelFor(level)}  {DateTime.Now:yyyy-dd-M--HH-mm-ss}  {text}"
                        : $"{GetLogLabelFor(level)}  {DateTime.Now:yyyy-dd-M--HH-mm-ss}  {text}\r\n"
                );
            }
            catch
            {
                //Ignored.
            }
        }

        /*
                private static void DumpToLog(Exception exception)
                {
                    if (exception == null) return;

                    try
                    {
                        File.AppendAllText(
                            $@"C:\{DateTime.Now:yyyy-dd-M}_log.txt",
                            $"{exception.Message}\r\n\t{exception.StackTrace}\r\n\t Source: {exception.Source}"
                        );
                    }
                    catch
                    {
                        //Ignored.
                    }
                }
        */

        /// <summary>
        /// Loads the configuration from the pathname specified by the
        /// <see cref="P:Core.Config.IConfigurationProvider.ConfigFilePath" /> property and
        /// sets the value of the
        /// <see cref="P:MyProjectWizard.WizardImpl.CurrentConfiguration" /> property to
        /// point to it.
        /// </summary>
        protected void LoadConfiguration()
            => CurrentConfiguration =
                ConfigurationProvider.Load(
                    ConfigurationProvider.ConfigFilePath
                );

        /// <summary>
        /// Saves the configuration data in the
        /// <see cref="P:MyProjectWizard.WizardImpl.CurrentConfiguration" /> property to
        /// the file located at the pathname specified by the
        /// <see cref="P:Core.Config.IConfigurationProvider.ConfigFilePath" /> property.
        /// </summary>
        protected void SaveConfiguration()
            => ConfigurationProvider.Save(
                ConfigurationProvider.ConfigFilePath, CurrentConfiguration
            );

        /// <summary>
        /// Appends the specified <paramref name="text" /> to the log file, splitting on
        /// any newlines.
        /// </summary>
        /// <param name="text">
        /// (Required.) String containing the text to write to the log.
        /// <para />
        /// The specified text is appended to the end of the log file.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="text" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        protected void AppendToLog(string text)
            => WriteLineToLog(text);

        private enum DebugLevel
        {
            Debug,
            Warn,
            Error,
            Info
        }
    }
}