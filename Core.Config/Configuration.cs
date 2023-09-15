using Newtonsoft.Json;

namespace Core.Config
{
///  <summary> Contains properties whose values are set by the user. </summary>
    public class Configuration : IConfiguration
    {
///  <summary> Constructs a new instance of <see cref="T:Core.Config.Configuration" /> and returns a reference to it. </summary>
        public Configuration()
        {
            CreateDataAccessLayer = true;
            CreateUserInterfaceLayer = true;
        }

///  <summary> Gets or sets a value that indicates whether the Data Access Layer (DAL) project should be created. </summary>
        [JsonProperty("CreateDataAccessLayer")]
        public bool CreateDataAccessLayer { get; set; }

///  <summary> Gets or sets a value that indicates whether the user-interface (UI) layer project should be created. </summary>
        [JsonProperty("CreateUserInterfaceLayer")]
        public bool CreateUserInterfaceLayer { get; set; }
    }
}
