namespace Core.Common
{
    /// <summary>
    /// Specifies the action that the Wizard is to take.
    /// </summary>
    public enum WizardAction
    {
        /// <summary>
        /// Suppress generation of the project.
        /// </summary>
        Backout,

        /// <summary>
        /// Create the project.
        /// </summary>
        Create,

        /// <summary>
        /// Take no action.
        /// </summary>
        None = -1
    }
}
