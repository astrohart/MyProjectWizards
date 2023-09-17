using Core.Config;
using System;

namespace MyProjectWizard
{
    /// <summary> Sample windows form. </summary>
    public partial class ExampleDialogBox : Form, IExampleDialogBox
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MyProjectWizard.ExampleDialogBox" /> and returns a reference to
        /// it.
        /// </summary>
        /// <param name="dte">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:EnvDTE.DTE" /> interface.
        /// </param>
        /// <param name="destinationDirectory">
        /// (Required.) String containing the
        /// fully-qualified pathname of the directory to which the new project files are to
        /// be written.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="dte" />, is passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="destinationDirectory" />, is passed a blank or
        /// <see langword="null" /> string for a value.
        /// </exception>
        public ExampleDialogBox(DTE dte, string destinationDirectory)
        {
            if (string.IsNullOrWhiteSpace(destinationDirectory))
                throw new ArgumentException(
                    "Destination Directory cannot be null or whitespace.",
                    nameof(destinationDirectory)
                );

            InitializeComponent();

            Dte = dte ?? throw new ArgumentNullException(nameof(dte));
            DestinationDirectory = destinationDirectory;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MyProjectWizard.ExampleDialogBox" /> and returns a reference to
        /// it.
        /// </summary>
        public ExampleDialogBox()
        {
            InitializeComponent();

            Dte = null;
            DestinationDirectory = string.Empty;
        }

        /// <summary> Gets the value of the Create Data Access Layer checkbox. </summary>
        public bool CreateDataAccessLayer
            => createDataAccessLayerCheckBox.Checked;

        /// <summary> Gets the value of the Create User Interface Layer checkbox. </summary>
        public bool CreateUserInterfaceLayer
            => createUserInterfaceLayerCheckBox.Checked;

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:Core.Config.IConfiguration" /> interface whose properties are
        /// mapped to dialog controls.
        /// </summary>
        public IConfiguration CurrentConfiguration
        {
            get => configurationBindingSource.DataSource as IConfiguration;
            set => configurationBindingSource.DataSource = value;
        }

        /// <summary>
        /// Gets a string that contains the fully-qualified pathname to the
        /// directory to which the files for the new project are to be written.
        /// </summary>
        public string DestinationDirectory { get; }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:EnvDTE.DTE" /> interface.
        /// </summary>
        public DTE Dte { get; }

        /// <summary>
        /// Handles the
        /// <see cref="E:System.Windows.Forms.LinkLabel.LinkClicked" /> event raised by the
        /// <b>Select All</b> link label.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>This method responds by placing a check mark in all the checkboxes.</remarks>
        private void OnLinkClickedSelectAllLabel(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            foreach (var checkBox in Controls.OfType<CheckBox>())
                checkBox.Checked = true;
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:System.Windows.Forms.LinkLabel.LinkClicked" /> event raised by the
        /// <b>Select None</b> link label.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:System.Windows.Forms.LinkLabelLinkClickedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>This method responds by clearing the check mark in all the checkboxes.</remarks>
        private void OnLinkClickedSelectNoneLabel(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            foreach (var checkBox in Controls.OfType<CheckBox>())
                checkBox.Checked = false;
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:System.Windows.Forms.CheckBox.CheckedChanged" /> event raised by
        /// any of the checkboxes.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks>
        /// This method responds by graying out the <b>Create</b> button if none
        /// of the checkboxes are selected.
        /// </remarks>
        private void OnCheckedChanged(object sender, EventArgs e)
            => createButton.Enabled = createDataAccessLayerCheckBox.Checked ||
                                      createUserInterfaceLayerCheckBox.Checked;
    }
}