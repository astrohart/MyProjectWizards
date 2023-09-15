namespace Core.Config
using PostSharp.Patterns.Diagnostics;
{
///  <summary> Creates instances of objects that implement the <see cref="T:Core.Config.IConfigurationProvider" /> interface. </summary>
    [Log(AttributeExclude = true)]
    public static class GetConfigurationProvider
    {
///  <summary> Creates a new instance of an object that implements the <see cref="T:Core.Config.IConfigurationProvider" /> interface and returns a reference to it. </summary> <returns> Reference to an instance of an object that implements the <see cref="T:Core.Config.IConfigurationProvider" /> interface. </returns> <exception cref="T:System.ArgumentOutOfRangeException"> Thrown if the object type requested is not supported. </exception>
        public static IConfigurationProvider SoleInstance()
            => ConfigurationProvider.Instance;
    }
}
