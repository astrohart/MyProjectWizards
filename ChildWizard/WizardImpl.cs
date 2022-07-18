using Core.Common;
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
    public class WizardImpl : WizardImplBase, IWizard
    {
        /// <summary>
        /// Contains the name of the folder that was erroneously
        /// generated in order to contain the generated sub-projects,
        /// which we assume has the same name as the solution (without
        /// the <c>.sln</c> file extension, so we are giving it a
        /// descriptive name as such.
        /// </summary>
        private string _containingSolutionName;

        /// <summary>
        /// String containing the fully-qualified pathname of the
        /// sub-folder in which this particular project (this Wizard
        /// is called once for each sub-project in a multi-project
        /// template) is going to live in.
        /// </summary>
        private string _generatedSubProjectFolder;

        /// <summary>
        /// String containing the name of the project that is safe to use.
        /// </summary>
        private string _subProjectName;

        /// <summary>
        /// Runs custom wizard logic when the
        /// wizard has completed all tasks.
        /// </summary>
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
        public override void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            base.RunStarted(automationObject, replacementsDictionary, runKind, customParams);

            try
            {
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
                DirectoryHelpers.RemoveParentDirectoryOf(
                    _generatedSubProjectFolder
                );

                // Re-throw the exception
                throw;
            }
        }
    }
}
