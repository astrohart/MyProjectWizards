using System;
using System.Diagnostics;
using System.IO;

namespace Core.Config
{
    /// <summary>
    /// Class that is responsible for providing access to the configuration
    /// to all other parts of the application.
    /// </summary>
    public class ConfigurationProvider : IConfigurationProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        static ConfigurationProvider() { }

        /// <summary>
        /// Empty, private constructor to prohibit direct allocation of this
        /// class.
        /// </summary>
        private ConfigurationProvider() { }

        /// <summary> Gets a string that contains the path to the configuration file. </summary>
        public string ConfigFilePath
            => Path.Combine(Path.GetTempPath(), "Foo.config.json");

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:Core.Config.IConfiguration" /> interface.
        /// <para />
        /// This object is the currently-loaded configuration.
        /// </summary>
        public IConfiguration CurrentConfiguration { [DebuggerStepThrough] get; [DebuggerStepThrough] private set; }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:Core.Config.ConfigurationProvider" />.
        /// </summary>
        public static ConfigurationProvider Instance { [DebuggerStepThrough] get; } =
            new ConfigurationProvider();

        /// <summary> Saves the specified <paramref name="configuration" /> to a file. </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// on the disk to which the <paramref name="configuration" /> data should be
        /// saved.
        /// </param>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object
        /// that implements the <see cref="T:Core.Config.IConfiguration" /> interface that
        /// contains the data to be saved.
        /// </param>
        public void Save(string path, IConfiguration configuration)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            try
            {
                // Update the CurrentConfiguration property to reference the
                // configuration object supplied to this method.
                CurrentConfiguration = configuration;

                var content = configuration.ToJson();
                if (string.IsNullOrWhiteSpace(content))
                    return;

                var folder = Path.GetDirectoryName(path);
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(
                        folder ?? throw new InvalidOperationException(
                            $"Path '{path}' does not contain a folder.  The path must be fully-qualified."
                        )
                    );

                if (File.Exists(path)) File.Delete(path);

                File.WriteAllText(path, content);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                Debug.Write(ex);
            }
        }

        /// <summary>
        /// Loads configuration settings from a file, or provides the default if
        /// a file doesn't exist.
        /// </summary>
        /// <param name="path">
        /// (Optional.) String containing the fully-qualified pathname
        /// of the file from which configuration is to be loaded.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:Core.Config.IConfiguration" /> interface, whose properties are
        /// initialized to the values loaded.
        /// </returns>
        public IConfiguration Load(string path = "")
        {
            // If there is no configuration file to read from, just return the default values.
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                CurrentConfiguration = MakeNewConfiguration.FromScratch();
                return CurrentConfiguration;
            }

            try
            {
                var content = File.ReadAllText(path);
                if (string.IsNullOrWhiteSpace(content))
                {
                    CurrentConfiguration = MakeNewConfiguration.FromScratch();
                    return CurrentConfiguration;
                }

                CurrentConfiguration = ConvertConfiguration.FromJson(content);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                Debug.Write(ex);

                CurrentConfiguration = MakeNewConfiguration.FromScratch();
            }

            return CurrentConfiguration;
        }
    }
}