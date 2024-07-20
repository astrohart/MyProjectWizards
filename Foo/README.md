<a name='assembly'></a>
# Foo

## Contents

- [ExampleDialogBox](#T-Foo-ExampleDialogBox 'Foo.ExampleDialogBox')
  - [#ctor(dte,destinationDirectory)](#M-Foo-ExampleDialogBox-#ctor-EnvDTE-DTE,System-String- 'Foo.ExampleDialogBox.#ctor(EnvDTE.DTE,System.String)')
  - [#ctor()](#M-Foo-ExampleDialogBox-#ctor 'Foo.ExampleDialogBox.#ctor')
  - [components](#F-Foo-ExampleDialogBox-components 'Foo.ExampleDialogBox.components')
  - [CreateDataAccessLayer](#P-Foo-ExampleDialogBox-CreateDataAccessLayer 'Foo.ExampleDialogBox.CreateDataAccessLayer')
  - [CreateUserInterfaceLayer](#P-Foo-ExampleDialogBox-CreateUserInterfaceLayer 'Foo.ExampleDialogBox.CreateUserInterfaceLayer')
  - [CurrentConfiguration](#P-Foo-ExampleDialogBox-CurrentConfiguration 'Foo.ExampleDialogBox.CurrentConfiguration')
  - [DestinationDirectory](#P-Foo-ExampleDialogBox-DestinationDirectory 'Foo.ExampleDialogBox.DestinationDirectory')
  - [Dte](#P-Foo-ExampleDialogBox-Dte 'Foo.ExampleDialogBox.Dte')
  - [Dispose(disposing)](#M-Foo-ExampleDialogBox-Dispose-System-Boolean- 'Foo.ExampleDialogBox.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-Foo-ExampleDialogBox-InitializeComponent 'Foo.ExampleDialogBox.InitializeComponent')
  - [OnCheckedChanged(sender,e)](#M-Foo-ExampleDialogBox-OnCheckedChanged-System-Object,System-EventArgs- 'Foo.ExampleDialogBox.OnCheckedChanged(System.Object,System.EventArgs)')
  - [OnLinkClickedSelectAllLabel(sender,e)](#M-Foo-ExampleDialogBox-OnLinkClickedSelectAllLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs- 'Foo.ExampleDialogBox.OnLinkClickedSelectAllLabel(System.Object,System.Windows.Forms.LinkLabelLinkClickedEventArgs)')
  - [OnLinkClickedSelectNoneLabel(sender,e)](#M-Foo-ExampleDialogBox-OnLinkClickedSelectNoneLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs- 'Foo.ExampleDialogBox.OnLinkClickedSelectNoneLabel(System.Object,System.Windows.Forms.LinkLabelLinkClickedEventArgs)')
- [IExampleDialogBox](#T-Foo-IExampleDialogBox 'Foo.IExampleDialogBox')
  - [CreateDataAccessLayer](#P-Foo-IExampleDialogBox-CreateDataAccessLayer 'Foo.IExampleDialogBox.CreateDataAccessLayer')
  - [CreateUserInterfaceLayer](#P-Foo-IExampleDialogBox-CreateUserInterfaceLayer 'Foo.IExampleDialogBox.CreateUserInterfaceLayer')
  - [CurrentConfiguration](#P-Foo-IExampleDialogBox-CurrentConfiguration 'Foo.IExampleDialogBox.CurrentConfiguration')
  - [DestinationDirectory](#P-Foo-IExampleDialogBox-DestinationDirectory 'Foo.IExampleDialogBox.DestinationDirectory')
  - [Dte](#P-Foo-IExampleDialogBox-Dte 'Foo.IExampleDialogBox.Dte')
  - [ShowDialog(owner)](#M-Foo-IExampleDialogBox-ShowDialog-System-Windows-Forms-IWin32Window- 'Foo.IExampleDialogBox.ShowDialog(System.Windows.Forms.IWin32Window)')
  - [ShowDialog()](#M-Foo-IExampleDialogBox-ShowDialog 'Foo.IExampleDialogBox.ShowDialog')
- [MakeNewExampleDialogBox](#T-Foo-MakeNewExampleDialogBox 'Foo.MakeNewExampleDialogBox')
  - [FromScratch(dte,destinationDirectory)](#M-Foo-MakeNewExampleDialogBox-FromScratch-EnvDTE-DTE,System-String- 'Foo.MakeNewExampleDialogBox.FromScratch(EnvDTE.DTE,System.String)')
  - [FromScratch()](#M-Foo-MakeNewExampleDialogBox-FromScratch 'Foo.MakeNewExampleDialogBox.FromScratch')
- [Resources](#T-Foo-Properties-Resources 'Foo.Properties.Resources')
  - [Culture](#P-Foo-Properties-Resources-Culture 'Foo.Properties.Resources.Culture')
  - [ResourceManager](#P-Foo-Properties-Resources-ResourceManager 'Foo.Properties.Resources.ResourceManager')
- [WizardImpl](#T-Foo-WizardImpl 'Foo.WizardImpl')
  - [_erroneouslyCreatedProjectContainerFolder](#F-Foo-WizardImpl-_erroneouslyCreatedProjectContainerFolder 'Foo.WizardImpl._erroneouslyCreatedProjectContainerFolder')
  - [RunFinished()](#M-Foo-WizardImpl-RunFinished 'Foo.WizardImpl.RunFinished')
  - [RunStarted(automationObject,replacementsDictionary,runKind,customParams)](#M-Foo-WizardImpl-RunStarted-System-Object,System-Collections-Generic-Dictionary{System-String,System-String},Microsoft-VisualStudio-TemplateWizard-WizardRunKind,System-Object[]- 'Foo.WizardImpl.RunStarted(System.Object,System.Collections.Generic.Dictionary{System.String,System.String},Microsoft.VisualStudio.TemplateWizard.WizardRunKind,System.Object[])')

<a name='T-Foo-ExampleDialogBox'></a>
## ExampleDialogBox `type`

##### Namespace

Foo

##### Summary

Sample windows form.

<a name='M-Foo-ExampleDialogBox-#ctor-EnvDTE-DTE,System-String-'></a>
### #ctor(dte,destinationDirectory) `constructor`

##### Summary

Constructs a new instance of [ExampleDialogBox](#T-Foo-ExampleDialogBox 'Foo.ExampleDialogBox')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dte | [EnvDTE.DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') | (Required.) Reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface. |
| destinationDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the directory to
which the new project files are to be written. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `dte`, is passed a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`destinationDirectory`, is passed a blank or
`null` string for a value. |

<a name='M-Foo-ExampleDialogBox-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [ExampleDialogBox](#T-Foo-ExampleDialogBox 'Foo.ExampleDialogBox') and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-Foo-ExampleDialogBox-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-Foo-ExampleDialogBox-CreateDataAccessLayer'></a>
### CreateDataAccessLayer `property`

##### Summary

Gets the value of the Create Data Access Layer checkbox.

<a name='P-Foo-ExampleDialogBox-CreateUserInterfaceLayer'></a>
### CreateUserInterfaceLayer `property`

##### Summary

Gets the value of the Create User Interface Layer checkbox.

<a name='P-Foo-ExampleDialogBox-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IConfiguration](#T-Core-Config-IConfiguration 'Core.Config.IConfiguration') interface whose properties are
mapped to dialog controls.

<a name='P-Foo-ExampleDialogBox-DestinationDirectory'></a>
### DestinationDirectory `property`

##### Summary

Gets a string that contains the fully-qualified pathname to the directory to
which the files for the new project are to be written.

<a name='P-Foo-ExampleDialogBox-Dte'></a>
### Dte `property`

##### Summary

Gets a reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface.

<a name='M-Foo-ExampleDialogBox-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-Foo-ExampleDialogBox-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-Foo-ExampleDialogBox-OnCheckedChanged-System-Object,System-EventArgs-'></a>
### OnCheckedChanged(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-CheckBox-CheckedChanged 'System.Windows.Forms.CheckBox.CheckedChanged') event raised by any of the checkboxes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method responds by graying out the button if none of the checkboxes are selected.

<a name='M-Foo-ExampleDialogBox-OnLinkClickedSelectAllLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs-'></a>
### OnLinkClickedSelectAllLabel(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-LinkLabel-LinkClicked 'System.Windows.Forms.LinkLabel.LinkClicked') event
raised by the link label.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.Windows.Forms.LinkLabelLinkClickedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.LinkLabelLinkClickedEventArgs 'System.Windows.Forms.LinkLabelLinkClickedEventArgs') | A
[LinkLabelLinkClickedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.LinkLabelLinkClickedEventArgs 'System.Windows.Forms.LinkLabelLinkClickedEventArgs') that
contains the event data. |

##### Remarks

This method responds by placing a check mark in all the checkboxes.

<a name='M-Foo-ExampleDialogBox-OnLinkClickedSelectNoneLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs-'></a>
### OnLinkClickedSelectNoneLabel(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-LinkLabel-LinkClicked 'System.Windows.Forms.LinkLabel.LinkClicked') event
raised by the link label.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.Windows.Forms.LinkLabelLinkClickedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.LinkLabelLinkClickedEventArgs 'System.Windows.Forms.LinkLabelLinkClickedEventArgs') | A
[LinkLabelLinkClickedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.LinkLabelLinkClickedEventArgs 'System.Windows.Forms.LinkLabelLinkClickedEventArgs') that
contains the event data. |

##### Remarks

This method responds by clearing the check mark in all the checkboxes.

<a name='T-Foo-IExampleDialogBox'></a>
## IExampleDialogBox `type`

##### Namespace

Foo

##### Summary

Defines the publicly-exposed methods and properties of an Example dialog box.

<a name='P-Foo-IExampleDialogBox-CreateDataAccessLayer'></a>
### CreateDataAccessLayer `property`

##### Summary

Gets the value of the checkbox.

<a name='P-Foo-IExampleDialogBox-CreateUserInterfaceLayer'></a>
### CreateUserInterfaceLayer `property`

##### Summary

Gets the value of the checkbox.

<a name='P-Foo-IExampleDialogBox-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IConfiguration](#T-Core-Config-IConfiguration 'Core.Config.IConfiguration') interface whose properties are
mapped to dialog controls.

<a name='P-Foo-IExampleDialogBox-DestinationDirectory'></a>
### DestinationDirectory `property`

##### Summary

Gets a string that contains the fully-qualified pathname to the directory to
which the files for the new project are to be written.

<a name='P-Foo-IExampleDialogBox-Dte'></a>
### Dte `property`

##### Summary

Gets a reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface.

<a name='M-Foo-IExampleDialogBox-ShowDialog-System-Windows-Forms-IWin32Window-'></a>
### ShowDialog(owner) `method`

##### Summary

Shows the dialog box as a modal window.

##### Returns

The [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that
corresponds to the button clicked by the user in order to dismiss the dialog
box.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface and which plays
the role of the parent window of the dialog box. |

<a name='M-Foo-IExampleDialogBox-ShowDialog'></a>
### ShowDialog() `method`

##### Summary

Shows the dialog box as a modal window.

##### Returns

The [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that
corresponds to the button clicked by the user in order to dismiss the dialog
box.

##### Parameters

This method has no parameters.

<a name='T-Foo-MakeNewExampleDialogBox'></a>
## MakeNewExampleDialogBox `type`

##### Namespace

Foo

##### Summary

Creates new instances of objects that implement the
[IExampleDialogBox](#T-Foo-IExampleDialogBox 'Foo.IExampleDialogBox') interface, and returns
references to them.

<a name='M-Foo-MakeNewExampleDialogBox-FromScratch-EnvDTE-DTE,System-String-'></a>
### FromScratch(dte,destinationDirectory) `method`

##### Summary

Creates a new instance of an object that implements the
[IExampleDialogBox](#T-Foo-IExampleDialogBox 'Foo.IExampleDialogBox') interface and returns a
reference to it.

##### Returns

Reference to an instance of an object that implements the
[IExampleDialogBox](#T-Foo-IExampleDialogBox 'Foo.IExampleDialogBox') interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dte | [EnvDTE.DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') | (Required.) Reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface. |
| destinationDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the directory to
which the new project files are to be written. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `dte`, is passed a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`destinationDirectory`, is passed a blank or
`null` string for a value. |

<a name='M-Foo-MakeNewExampleDialogBox-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IExampleDialogBox](#T-Foo-IExampleDialogBox 'Foo.IExampleDialogBox') interface and returns a
reference to it.

##### Returns

Reference to an instance of an object that implements the
[IExampleDialogBox](#T-Foo-IExampleDialogBox 'Foo.IExampleDialogBox') interface.

##### Parameters

This method has no parameters.

<a name='T-Foo-Properties-Resources'></a>
## Resources `type`

##### Namespace

Foo.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Foo-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Foo-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-Foo-WizardImpl'></a>
## WizardImpl `type`

##### Namespace

Foo

##### Summary

Implements a new project wizard in Visual Studio.

<a name='F-Foo-WizardImpl-_erroneouslyCreatedProjectContainerFolder'></a>
### _erroneouslyCreatedProjectContainerFolder `constants`

##### Summary

String containing the fully-qualified pathname of the erroneously-generated sub-folder of the
Solution that is going to contain the individual projects' folders.

<a name='M-Foo-WizardImpl-RunFinished'></a>
### RunFinished() `method`

##### Summary

Runs custom wizard logic when the wizard has completed all tasks.

##### Parameters

This method has no parameters.

<a name='M-Foo-WizardImpl-RunStarted-System-Object,System-Collections-Generic-Dictionary{System-String,System-String},Microsoft-VisualStudio-TemplateWizard-WizardRunKind,System-Object[]-'></a>
### RunStarted(automationObject,replacementsDictionary,runKind,customParams) `method`

##### Summary

Runs custom wizard logic at the beginning of a template wizard run.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| automationObject | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The automation object being used by the template
wizard. |
| replacementsDictionary | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') | The list of standard parameters to be
replaced. |
| runKind | [Microsoft.VisualStudio.TemplateWizard.WizardRunKind](#T-Microsoft-VisualStudio-TemplateWizard-WizardRunKind 'Microsoft.VisualStudio.TemplateWizard.WizardRunKind') | A
[WizardRunKind](#T-Microsoft-VisualStudio-TemplateWizard-WizardRunKind 'Microsoft.VisualStudio.TemplateWizard.WizardRunKind') indicating
the type of wizard run. |
| customParams | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The custom parameters with which to perform
parameter replacement in the project. |
