using Core.Common;
using EnvDTE;
using System;
using System.Windows.Forms;

namespace ChildWizard
{
    /// <summary>
    /// Sample windows form.
    /// </summary>
    public partial class ExampleDialogBox : Form
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:ChildWizard.ExampleDialogBox" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="dte">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:EnvDTE.DTE" /> interface.
        /// </param>
        /// <param name="destinationDirectory">
        /// (Required.) String containing the fully-qualified pathname of the directory to
        /// which the new project files are to be written.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="dte" />, is passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameters,
        /// <paramref name="destinationDirectory" /> or <paramref name="safeProjectName" />
        /// , are passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public ExampleDialogBox(DTE dte, string destinationDirectory,
            string safeProjectName)
        {
            if (string.IsNullOrWhiteSpace(destinationDirectory))
                throw new ArgumentException(
                    "Destination Directory cannot be null or whitespace.",
                    nameof(destinationDirectory)
                );
            if (string.IsNullOrWhiteSpace(safeProjectName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(safeProjectName)
                );

            InitializeComponent();

            Action = WizardAction.None;
            Dte = dte ?? throw new ArgumentNullException(nameof(dte));
            DestinationDirectory = destinationDirectory;
            SafeProjectName = safeProjectName;
        }

        /// <summary>
        /// Constructs a new instance of <see cref="T:ChildWizard.ExampleDialogBox" /> and
        /// returns a reference to it.
        /// </summary>
        public ExampleDialogBox()
        {
            InitializeComponent();

            Dte = null;
            DestinationDirectory = string.Empty;
            SafeProjectName = string.Empty;
        }

        /// <summary>
        /// Gets the <see cref="T:ChildWizard.WizardAction" /> value that specifies the
        /// choice the user has made.
        /// </summary>
        public WizardAction Action { get; private set; }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:EnvDTE.DTE" /> interface.
        /// </summary>
        public DTE Dte { get; }

        /// <summary>
        /// Gets a string that contains the fully-qualified pathname to the directory to
        /// which the files for the new project are to be written.
        /// </summary>
        public string DestinationDirectory { get; }

        /// <summary>
        /// Gets a string containing the name of the project to be generated.
        /// </summary>
        public string SafeProjectName { get; }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            mainInstructionLabel.Text = mainInstructionLabel.Text.Replace(
                "$safeprojectname$", SafeProjectName
            );
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event raised by
        /// the <b>No</b> button.
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
        /// This method is called when the user clicks the <b>No</b> button.
        /// <para />
        /// The function of this button is to tell the caller of this dialog that it should
        /// throw
        /// <see cref="T:Microsoft.VisualStudio.TemplateWizard.WizardBackoutException" />.
        /// </remarks>
        private void OnClickNoButton(object sender, EventArgs e)
            => Action = WizardAction.Backout;

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click" /> event raised by
        /// the <b>Yes</b> button.
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
        /// This method is called when the user clicks the <b>Yes</b> button.
        /// <para />
        /// The function of this button is to tell the caller of this dialog that it should
        /// let the operation proceed.
        /// </remarks>
        private void OnClickYesButton(object sender, EventArgs e)
            => Action = WizardAction.Create;
    }
}
