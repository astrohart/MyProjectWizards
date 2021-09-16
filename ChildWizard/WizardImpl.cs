using Core.Common;
using Core.Config;
using Core.Files;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Thread = System.Threading.Thread;

namespace ChildWizard
{
    /// <summary>
    /// Implements a wizard for the generation of an individual project in the
    /// solution.
    /// </summary>
    public class WizardImpl : IWizard
    {
        /// <summary>
        /// Contains the name of the solution.
        /// </summary>
        private string _containingSolutionName;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:EnvDTE.DTE" /> interface.
        /// </summary>
        private DTE _dte;

        /// <summary>
        /// String containing the fully-qualified pathname of the sub-folder in which this
        /// particular project (this Wizard is called once for each sub-project in a multi-project
        /// template) is going to live in.
        /// </summary>
        private string _generatedSubProjectFolder;

        /// <summary>
        /// String containing the name of the project that is safe to use.
        /// </summary>
        private string _subProjectName;

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
            try
            {
                if (!_generatedSubProjectFolder.Contains(
                    _containingSolutionName + Path.DirectorySeparatorChar +
                    _containingSolutionName
                ))
                    return;

                //The projects were created under a separate folder -- lets fix it
                var projectsObjects = new List<Tuple<Project, Project>>();
                foreach (Project childProject in _dte.Solution.Projects)
                    if (string.IsNullOrEmpty(
                        childProject.FileName
                    )) //Solution Folder
                        projectsObjects.AddRange(
                            from dynamic projectItem in
                                childProject.ProjectItems
                            select new Tuple<Project, Project>(
                                childProject, projectItem.Object as Project
                            )
                        );
                    else
                        projectsObjects.Add(
                            new Tuple<Project, Project>(null, childProject)
                        );

                foreach (var projectObject in projectsObjects)
                {
                    var projectBadPath = projectObject.Item2.FileName;
                    if (!projectBadPath.Contains(_subProjectName))
                        continue; // wrong project

                    var projectGoodPath = projectBadPath.Replace(
                        _containingSolutionName + Path.DirectorySeparatorChar +
                        _containingSolutionName + Path.DirectorySeparatorChar,
                        _containingSolutionName + Path.DirectorySeparatorChar
                    );

                    _dte.Solution.Remove(projectObject.Item2);

                    var projectBadPathDirectory =
                        Path.GetDirectoryName(projectBadPath);
                    var projectGoodPathDirectory =
                        Path.GetDirectoryName(projectGoodPath);

                    if (Directory.Exists(projectBadPathDirectory) &&
                        !string.IsNullOrWhiteSpace(projectGoodPathDirectory))
                        Directory.Move(
                            projectBadPathDirectory, projectGoodPathDirectory
                        );

                    if (projectObject.Item1 != null) //Solution Folder
                    {
                        var solutionFolder =
                            (SolutionFolder)projectObject.Item1.Object;
                        solutionFolder.AddFromFile(projectGoodPath);
                    }
                    else
                    {
                        _dte.Solution.AddFromFile(projectGoodPath);
                    }
                }

                ThreadPool.QueueUserWorkItem(
                    dir =>
                    {
                        Thread.Sleep(2000);
                        if (Directory.Exists(_generatedSubProjectFolder))
                            Directory.Delete(_generatedSubProjectFolder, true);
                    }, _generatedSubProjectFolder
                );
            }
            catch (Exception ex)
            {
                DumpToLog(ex);
            }
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

                _generatedSubProjectFolder =
                    replacementsDictionary["$destinationdirectory$"];
                _subProjectName = replacementsDictionary["$safeprojectname$"];

                // Assume that the name of the solution is the same as that of the folder
                // one folder level up from this particular sub-project.
                _containingSolutionName = Path.GetFileName(
                    Path.GetDirectoryName(_generatedSubProjectFolder)
                );

                LoadConfiguration();

                if (_subProjectName.EndsWith(
                    SubProjectNameSuffixes.DataAccessLayer
                ) && CurrentConfiguration.CreateDataAccessLayer == false)
                    throw new WizardBackoutException(
                        "Not creating the Data Access Layer project."
                    );

                if (_subProjectName.EndsWith(
                    SubProjectNameSuffixes.WindowsApp
                ) && CurrentConfiguration.CreateUserInterfaceLayer == false)
                    throw new WizardBackoutException(
                        "Not creating the User-Interface Layer project."
                    );
            }
            catch (WizardCancelledException)
            {
                throw;
            }
            catch
            {
                DirectoryHelpers.RemoveParentDirectoryOf(_generatedSubProjectFolder);

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
                        ? $"\t{GetLogLabelFor(level)}  {DateTime.Now:yyyy-dd-M--HH-mm-ss}  {text}"
                        : $"\t{GetLogLabelFor(level)}  {DateTime.Now:yyyy-dd-M--HH-mm-ss}  {text}\r\n"
                );
            }
            catch
            {
                //Ignored.
            }
        }

        private static void DumpToLog(Exception exception)
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

        /// <summary>
        /// Loads the configuration from the pathname specified by the
        /// <see cref="P:Core.Config.IConfigurationProvider.ConfigFilePath" /> property and
        /// sets the value of the
        /// <see cref="P:ChildWizard.WizardImpl.CurrentConfiguration" /> property to
        /// point to it.
        /// </summary>
        protected void LoadConfiguration()
            => CurrentConfiguration =
                ConfigurationProvider.Load(
                    ConfigurationProvider.ConfigFilePath
                );

        /// <summary>
        /// Saves the configuration data in the
        /// <see cref="P:ChildWizard.WizardImpl.CurrentConfiguration" /> property to
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