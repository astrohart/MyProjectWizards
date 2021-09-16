namespace Core.Config
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a <c>Configuration</c>
    /// object that contains values specified by the user.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets or sets a value that indicates whether the Data Access Layer (DAL) project
        /// should be created.
        /// </summary>
        bool CreateDataAccessLayer { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the user-interface (UI) layer
        /// project should be created.
        /// </summary>
        bool CreateUserInterfaceLayer { get; set; }
    }
}