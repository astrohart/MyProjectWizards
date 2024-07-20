using System;
using PostSharp.Patterns.Diagnostics;

namespace Core.Config
{
///  <summary> Creates new instances of objects that implement the <see cref="T:Core.Config.IConfiguration" /> interface, and returns references to them. </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewConfiguration
    {
///  <summary> Creates a new instance of an object that implements the <see cref="T:Core.Config.IConfiguration" /> interface and returns a reference to it. </summary> <returns> Reference to an instance of an object that implements the <see cref="T:Core.Config.IConfiguration" /> interface. </returns>
        public static IConfiguration FromScratch()
            => new Configuration();

///  <summary> Builder extension method that initializes the <see cref="P:Core.Config.IConfiguration" /> property. </summary> <param name="self"> (Required.) Reference to an instance of an object that implements the <see cref="T:Core.Config.IConfiguration" /> interface. </param> <param name="value"> (Required.) The new value for the <see cref="P:Core.Config.IConfiguration.CreateDataAccessLayer" /> property. </param> <returns> Reference to the same instance of the object that called this method, for fluent use. </returns> <exception cref="T:System.ArgumentNullException"> Thrown if the required parameter, <paramref name="self" />, is passed a <see langword="null" /> value. </exception>
        public static IConfiguration SetCreateDataAccessLayer(
            this IConfiguration self, bool value)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.CreateDataAccessLayer = value;
            return self;
        }

///  <summary> Builder extension method that initializes the <see cref="P:Core.Config.IConfiguration" /> property. </summary> <param name="self"> (Required.) Reference to an instance of an object that implements the <see cref="T:Core.Config.IConfiguration" /> interface. </param> <param name="value"> (Required.) The new value for the <see cref="P:Core.Config.IConfiguration.CreateUserInterfaceLayer" /> property. </param> <returns> Reference to the same instance of the object that called this method, for fluent use. </returns> <exception cref="T:System.ArgumentNullException"> Thrown if the required parameter, <paramref name="self" />, is passed a <see langword="null" /> value. </exception>
        public static IConfiguration SetCreateUserInterfaceLayer(
            this IConfiguration self, bool value)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.CreateUserInterfaceLayer = value;
            return self;
        }
    }
}
