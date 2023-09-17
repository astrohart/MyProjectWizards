namespace MyProjectWizard
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MyProjectWizard.IExampleDialogBox" /> interface, and returns
    /// references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewExampleDialogBox
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MyProjectWizard.IExampleDialogBox" /> interface and returns a
        /// reference to it.
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
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MyProjectWizard.IExampleDialogBox" /> interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="dte" />, is passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="destinationDirectory" />, is passed a blank or
        /// <see langword="null" /> string for a value.
        /// </exception>
        public static IExampleDialogBox FromScratch(DTE dte,
            string destinationDirectory)
            => new ExampleDialogBox(dte, destinationDirectory);

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MyProjectWizard.IExampleDialogBox" /> interface and returns a
        /// reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MyProjectWizard.IExampleDialogBox" /> interface.
        /// </returns>
        public static IExampleDialogBox FromScratch()
            => new ExampleDialogBox();
    }
}