using PostSharp.Patterns.Threading;
using Core.Config;
using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace MyProjectWizard.Tests
{
///  <summary> Provides unit tests for the methods, properties, and events of the <see cref="T:Foo.ExampleDialogBox" /> class. </summary>
    [TestFixture, ExplicitlySynchronized]
    public class ExampleDialogBoxTests
    {
///  <summary> Initializes the state of this fixture for every unit test session. </summary>
        [SetUp]
        public void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

///  <summary> Checks that the dialog check boxes are set properly when a <see cref="T:Core.Config.Configuration" /> is initialized a certain way. </summary>
        [Test]
        public void Test_Configuration_DataBinding_Works()
        {
            var config = MakeNewConfiguration.FromScratch()
                                             .SetCreateDataAccessLayer(true)
                                             .SetCreateUserInterfaceLayer(
                                                 false
                                             );

            Assert.That(config, Is.Not.Null);
            Assert.That(config.CreateUserInterfaceLayer, Is.False);
            Assert.That(config.CreateDataAccessLayer, Is.True);

            using (var exampleDialogBox = MakeNewExampleDialogBox.FromScratch())
            {
                exampleDialogBox.CurrentConfiguration = config;

                Assert.That(
                    exampleDialogBox.CurrentConfiguration.CreateDataAccessLayer,
                    Is.EqualTo(config.CreateDataAccessLayer)
                );
                Assert.That(
                    exampleDialogBox.CurrentConfiguration
                                    .CreateUserInterfaceLayer,
                    Is.EqualTo(config.CreateUserInterfaceLayer)
                );

                // TODO: Confirm that the check boxes selected match the configuration object set up above.
                exampleDialogBox.ShowDialog();

                Console.WriteLine(
                    $"exampleDialogBox.CurrentConfiguration.CreateDataAccessLayer = {exampleDialogBox.CurrentConfiguration.CreateDataAccessLayer}"
                );
                Console.WriteLine(
                    $"exampleDialogBox.CurrentConfiguration.CreateUserInterfaceLayer = {exampleDialogBox.CurrentConfiguration.CreateUserInterfaceLayer}"
                );
            }
        }
    }
}
