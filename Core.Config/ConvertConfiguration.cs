using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

namespace Core.Config
{
    /// <summary>
    /// Converts instances of Configuration objects to and from JSON.
    /// </summary>
    public static class ConvertConfiguration
    {
        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:Newtonsoft.Json.JsonSerializerSettings" /> whose values
        /// govern the format of the JSON.
        /// </summary>
        public static JsonSerializerSettings Settings
            => new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    new IsoDateTimeConverter
                    {
                        DateTimeStyles =
                            DateTimeStyles.AssumeUniversal
                    }
                }
            };

        /// <summary>
        /// Converts a reference to an instance of an object implementing the
        /// <see cref="T:Core.Config.IConfiguration" /> interface to JSON, and returns a
        /// string bearing the result.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:Core.Config.IConfiguration" /> interface.
        /// </param>
        /// <returns>
        /// String containing the JSON equivalent of the object instance that
        /// implements the <see cref="T:Core.Config.IConfiguration" /> interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="self" />, is passed a <see langword="null" /> value.
        /// </exception>
        public static string ToJson(this IConfiguration self)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));
            return JsonConvert.SerializeObject(self, Settings);
        }

        /// <summary>
        /// Converts a string containing JSON to an instance, in memory, of an object that
        /// implements the <see cref="T:Core.Config.IConfiguration" /> interface and
        /// returns a reference to the newly-initialized object.
        /// </summary>
        /// <param name="json">(Required.) String containing JSON to be deserialized.</param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:Core.Config.IConfiguration" /> interface, initialized with the
        /// values loaded from the JSON.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="json" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public static IConfiguration FromJson(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(json)
                );
            return JsonConvert.DeserializeObject<Configuration>(json, Settings);
        }
    }
}
