using Core.Config;
using EnvDTE;
using System;
using System.Windows.Forms;

namespace MyProjectWizard
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an Example dialog box.
    /// </summary>
    public interface IExampleDialogBox : IDisposable
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:Core.Config.IConfiguration" /> interface whose properties are
        /// mapped to dialog controls.
        /// </summary>
        IConfiguration CurrentConfiguration { get; set; }

        /// <summary>
        /// Gets the value of the <b>Create Data Access Layer</b> checkbox.
        /// </summary>
        bool CreateDataAccessLayer { get; }

        /// <summary>
        /// Gets the value of the <b>Create User Interface Layer</b> checkbox.
        /// </summary>
        bool CreateUserInterfaceLayer { get; }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:EnvDTE.DTE" /> interface.
        /// </summary>
        DTE Dte { get; }

        /// <summary>
        /// Gets a string that contains the fully-qualified pathname to the directory to
        /// which the files for the new project are to be written.
        /// </summary>
        string DestinationDirectory { get; }

        /// <summary>
        /// Shows the dialog box as a modal window.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface and which plays
        /// the role of the parent window of the dialog box.
        /// </param>
        /// <returns>
        /// The <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// corresponds to the button clicked by the user in order to dismiss the dialog
        /// box.
        /// </returns>
        DialogResult ShowDialog(IWin32Window owner);

        /// <summary>
        /// Shows the dialog box as a modal window.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// corresponds to the button clicked by the user in order to dismiss the dialog
        /// box.
        /// </returns>
        DialogResult ShowDialog();
    }
}