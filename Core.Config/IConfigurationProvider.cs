namespace Core.Config
{
///  <summary> Defines the publicly-exposed methods and properties of <c>Configuration Provider</c> objects. </summary>
    public interface IConfigurationProvider
    {
///  <summary> Gets a string that contains the path to the configuration file. </summary>
        string ConfigFilePath { get; }

///  <summary> Gets a reference to an instance of an object that implements the <see cref="T:Core.Config.IConfiguration" /> interface. <para /> This object is the currently-loaded configuration. </summary>
        IConfiguration CurrentConfiguration { get; }

///  <summary> Saves the specified <paramref name="configuration" /> to a file. </summary> <param name="path"> (Required.) String containing the fully-qualified pathname on the disk to which the <paramref name="configuration" /> data should be saved. </param> <param name="configuration"> (Required.) Reference to an instance of an object that implements the <see cref="T:Core.Config.IConfiguration" /> interface that contains the data to be saved. </param>
        void Save(string path, IConfiguration configuration);

///  <summary> Loads configuration settings from a file, or provides the default if a file doesn't exist. </summary> <param name="path"> (Optional.) String containing the fully-qualified pathname of the file from which configuration is to be loaded. </param> <returns> Reference to an instance of an object that implements the <see cref="T:Core.Config.IConfiguration" /> interface, whose properties are initialized to the values loaded. </returns>
        IConfiguration Load(string path = "");
    }
}