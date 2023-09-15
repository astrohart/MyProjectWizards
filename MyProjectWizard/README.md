<a name='assembly'></a>
# MyProjectWizard

## Contents

- [ExampleDialogBox](#T-MyProjectWizard-ExampleDialogBox 'MyProjectWizard.ExampleDialogBox')
  - [#ctor(dte,destinationDirectory)](#M-MyProjectWizard-ExampleDialogBox-#ctor-EnvDTE-DTE,System-String- 'MyProjectWizard.ExampleDialogBox.#ctor(EnvDTE.DTE,System.String)')
  - [#ctor()](#M-MyProjectWizard-ExampleDialogBox-#ctor 'MyProjectWizard.ExampleDialogBox.#ctor')
  - [components](#F-MyProjectWizard-ExampleDialogBox-components 'MyProjectWizard.ExampleDialogBox.components')
  - [CreateDataAccessLayer](#P-MyProjectWizard-ExampleDialogBox-CreateDataAccessLayer 'MyProjectWizard.ExampleDialogBox.CreateDataAccessLayer')
  - [CreateUserInterfaceLayer](#P-MyProjectWizard-ExampleDialogBox-CreateUserInterfaceLayer 'MyProjectWizard.ExampleDialogBox.CreateUserInterfaceLayer')
  - [CurrentConfiguration](#P-MyProjectWizard-ExampleDialogBox-CurrentConfiguration 'MyProjectWizard.ExampleDialogBox.CurrentConfiguration')
  - [DestinationDirectory](#P-MyProjectWizard-ExampleDialogBox-DestinationDirectory 'MyProjectWizard.ExampleDialogBox.DestinationDirectory')
  - [Dte](#P-MyProjectWizard-ExampleDialogBox-Dte 'MyProjectWizard.ExampleDialogBox.Dte')
  - [Dispose(disposing)](#M-MyProjectWizard-ExampleDialogBox-Dispose-System-Boolean- 'MyProjectWizard.ExampleDialogBox.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-MyProjectWizard-ExampleDialogBox-InitializeComponent 'MyProjectWizard.ExampleDialogBox.InitializeComponent')
  - [OnCheckedChanged(sender,e)](#M-MyProjectWizard-ExampleDialogBox-OnCheckedChanged-System-Object,System-EventArgs- 'MyProjectWizard.ExampleDialogBox.OnCheckedChanged(System.Object,System.EventArgs)')
  - [OnLinkClickedSelectAllLabel(sender,e)](#M-MyProjectWizard-ExampleDialogBox-OnLinkClickedSelectAllLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs- 'MyProjectWizard.ExampleDialogBox.OnLinkClickedSelectAllLabel(System.Object,System.Windows.Forms.LinkLabelLinkClickedEventArgs)')
  - [OnLinkClickedSelectNoneLabel(sender,e)](#M-MyProjectWizard-ExampleDialogBox-OnLinkClickedSelectNoneLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs- 'MyProjectWizard.ExampleDialogBox.OnLinkClickedSelectNoneLabel(System.Object,System.Windows.Forms.LinkLabelLinkClickedEventArgs)')
- [IExampleDialogBox](#T-MyProjectWizard-IExampleDialogBox 'MyProjectWizard.IExampleDialogBox')
  - [CreateDataAccessLayer](#P-MyProjectWizard-IExampleDialogBox-CreateDataAccessLayer 'MyProjectWizard.IExampleDialogBox.CreateDataAccessLayer')
  - [CreateUserInterfaceLayer](#P-MyProjectWizard-IExampleDialogBox-CreateUserInterfaceLayer 'MyProjectWizard.IExampleDialogBox.CreateUserInterfaceLayer')
  - [CurrentConfiguration](#P-MyProjectWizard-IExampleDialogBox-CurrentConfiguration 'MyProjectWizard.IExampleDialogBox.CurrentConfiguration')
  - [DestinationDirectory](#P-MyProjectWizard-IExampleDialogBox-DestinationDirectory 'MyProjectWizard.IExampleDialogBox.DestinationDirectory')
  - [Dte](#P-MyProjectWizard-IExampleDialogBox-Dte 'MyProjectWizard.IExampleDialogBox.Dte')
  - [ShowDialog(owner)](#M-MyProjectWizard-IExampleDialogBox-ShowDialog-System-Windows-Forms-IWin32Window- 'MyProjectWizard.IExampleDialogBox.ShowDialog(System.Windows.Forms.IWin32Window)')
  - [ShowDialog()](#M-MyProjectWizard-IExampleDialogBox-ShowDialog 'MyProjectWizard.IExampleDialogBox.ShowDialog')
- [MakeNewExampleDialogBox](#T-MyProjectWizard-MakeNewExampleDialogBox 'MyProjectWizard.MakeNewExampleDialogBox')
  - [FromScratch(dte,destinationDirectory)](#M-MyProjectWizard-MakeNewExampleDialogBox-FromScratch-EnvDTE-DTE,System-String- 'MyProjectWizard.MakeNewExampleDialogBox.FromScratch(EnvDTE.DTE,System.String)')
  - [FromScratch()](#M-MyProjectWizard-MakeNewExampleDialogBox-FromScratch 'MyProjectWizard.MakeNewExampleDialogBox.FromScratch')
- [Resources](#T-MyProjectWizard-Properties-Resources 'MyProjectWizard.Properties.Resources')
  - [Culture](#P-MyProjectWizard-Properties-Resources-Culture 'MyProjectWizard.Properties.Resources.Culture')
  - [ResourceManager](#P-MyProjectWizard-Properties-Resources-ResourceManager 'MyProjectWizard.Properties.Resources.ResourceManager')
- [WizardImpl](#T-MyProjectWizard-WizardImpl 'MyProjectWizard.WizardImpl')
  - [_erroneouslyCreatedProjectContainerFolder](#F-MyProjectWizard-WizardImpl-_erroneouslyCreatedProjectContainerFolder 'MyProjectWizard.WizardImpl._erroneouslyCreatedProjectContainerFolder')
  - [RunFinished()](#M-MyProjectWizard-WizardImpl-RunFinished 'MyProjectWizard.WizardImpl.RunFinished')
  - [RunStarted(automationObject,replacementsDictionary,runKind,customParams)](#M-MyProjectWizard-WizardImpl-RunStarted-System-Object,System-Collections-Generic-Dictionary{System-String,System-String},Microsoft-VisualStudio-TemplateWizard-WizardRunKind,System-Object[]- 'MyProjectWizard.WizardImpl.RunStarted(System.Object,System.Collections.Generic.Dictionary{System.String,System.String},Microsoft.VisualStudio.TemplateWizard.WizardRunKind,System.Object[])')

<a name='T-MyProjectWizard-ExampleDialogBox'></a>
## ExampleDialogBox `type`

##### Namespace

MyProjectWizard

##### Summary

Sample windows form.

<a name='M-MyProjectWizard-ExampleDialogBox-#ctor-EnvDTE-DTE,System-String-'></a>
### #ctor(dte,destinationDirectory) `constructor`

##### Summary

Constructs a new instance of [ExampleDialogBox](#T-MyProjectWizard-ExampleDialogBox 'MyProjectWizard.ExampleDialogBox')
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

<a name='M-MyProjectWizard-ExampleDialogBox-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [ExampleDialogBox](#T-MyProjectWizard-ExampleDialogBox 'MyProjectWizard.ExampleDialogBox') and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MyProjectWizard-ExampleDialogBox-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-MyProjectWizard-ExampleDialogBox-CreateDataAccessLayer'></a>
### CreateDataAccessLayer `property`

##### Summary

Gets the value of the Create Data Access Layer checkbox.

<a name='P-MyProjectWizard-ExampleDialogBox-CreateUserInterfaceLayer'></a>
### CreateUserInterfaceLayer `property`

##### Summary

Gets the value of the Create User Interface Layer checkbox.

<a name='P-MyProjectWizard-ExampleDialogBox-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IConfiguration](#T-Core-Config-IConfiguration 'Core.Config.IConfiguration') interface whose properties are
mapped to dialog controls.

<a name='P-MyProjectWizard-ExampleDialogBox-DestinationDirectory'></a>
### DestinationDirectory `property`

##### Summary

Gets a string that contains the fully-qualified pathname to the directory to
which the files for the new project are to be written.

<a name='P-MyProjectWizard-ExampleDialogBox-Dte'></a>
### Dte `property`

##### Summary

Gets a reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface.

<a name='M-MyProjectWizard-ExampleDialogBox-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-MyProjectWizard-ExampleDialogBox-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-MyProjectWizard-ExampleDialogBox-OnCheckedChanged-System-Object,System-EventArgs-'></a>
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

<a name='M-MyProjectWizard-ExampleDialogBox-OnLinkClickedSelectAllLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs-'></a>
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

<a name='M-MyProjectWizard-ExampleDialogBox-OnLinkClickedSelectNoneLabel-System-Object,System-Windows-Forms-LinkLabelLinkClickedEventArgs-'></a>
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

<a name='T-MyProjectWizard-IExampleDialogBox'></a>
## IExampleDialogBox `type`

##### Namespace

MyProjectWizard

##### Summary

Defines the publicly-exposed methods and properties of an Example dialog box.

<a name='P-MyProjectWizard-IExampleDialogBox-CreateDataAccessLayer'></a>
### CreateDataAccessLayer `property`

##### Summary

Gets the value of the checkbox.

<a name='P-MyProjectWizard-IExampleDialogBox-CreateUserInterfaceLayer'></a>
### CreateUserInterfaceLayer `property`

##### Summary

Gets the value of the checkbox.

<a name='P-MyProjectWizard-IExampleDialogBox-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IConfiguration](#T-Core-Config-IConfiguration 'Core.Config.IConfiguration') interface whose properties are
mapped to dialog controls.

<a name='P-MyProjectWizard-IExampleDialogBox-DestinationDirectory'></a>
### DestinationDirectory `property`

##### Summary

Gets a string that contains the fully-qualified pathname to the directory to
which the files for the new project are to be written.

<a name='P-MyProjectWizard-IExampleDialogBox-Dte'></a>
### Dte `property`

##### Summary

Gets a reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface.

<a name='M-MyProjectWizard-IExampleDialogBox-ShowDialog-System-Windows-Forms-IWin32Window-'></a>
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

<a name='M-MyProjectWizard-IExampleDialogBox-ShowDialog'></a>
### ShowDialog() `method`

##### Summary

Shows the dialog box as a modal window.

##### Returns

The [DialogResult](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.DialogResult 'System.Windows.Forms.DialogResult') value that
corresponds to the button clicked by the user in order to dismiss the dialog
box.

##### Parameters

This method has no parameters.

<a name='T-MyProjectWizard-MakeNewExampleDialogBox'></a>
## MakeNewExampleDialogBox `type`

##### Namespace

MyProjectWizard

##### Summary

Creates new instances of objects that implement the
[IExampleDialogBox](#T-MyProjectWizard-IExampleDialogBox 'MyProjectWizard.IExampleDialogBox') interface, and returns
references to them.

<a name='M-MyProjectWizard-MakeNewExampleDialogBox-FromScratch-EnvDTE-DTE,System-String-'></a>
### FromScratch(dte,destinationDirectory) `method`

##### Summary

Creates a new instance of an object that implements the
[IExampleDialogBox](#T-MyProjectWizard-IExampleDialogBox 'MyProjectWizard.IExampleDialogBox') interface and returns a
reference to it.

##### Returns

Reference to an instance of an object that implements the
[IExampleDialogBox](#T-MyProjectWizard-IExampleDialogBox 'MyProjectWizard.IExampleDialogBox') interface.

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

<a name='M-MyProjectWizard-MakeNewExampleDialogBox-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IExampleDialogBox](#T-MyProjectWizard-IExampleDialogBox 'MyProjectWizard.IExampleDialogBox') interface and returns a
reference to it.

##### Returns

Reference to an instance of an object that implements the
[IExampleDialogBox](#T-MyProjectWizard-IExampleDialogBox 'MyProjectWizard.IExampleDialogBox') interface.

##### Parameters

This method has no parameters.

<a name='T-MyProjectWizard-Properties-Resources'></a>
## Resources `type`

##### Namespace

MyProjectWizard.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MyProjectWizard-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MyProjectWizard-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MyProjectWizard-WizardImpl'></a>
## WizardImpl `type`

##### Namespace

MyProjectWizard

##### Summary

Implements a new project wizard in Visual Studio.

<a name='F-MyProjectWizard-WizardImpl-_erroneouslyCreatedProjectContainerFolder'></a>
### _erroneouslyCreatedProjectContainerFolder `constants`

##### Summary

String containing the fully-qualified pathname of the erroneously-generated sub-folder of the
Solution that is going to contain the individual projects' folders.

<a name='M-MyProjectWizard-WizardImpl-RunFinished'></a>
### RunFinished() `method`

##### Summary

Runs custom wizard logic when the wizard has completed all tasks.

##### Parameters

This method has no parameters.

<a name='M-MyProjectWizard-WizardImpl-RunStarted-System-Object,System-Collections-Generic-Dictionary{System-String,System-String},Microsoft-VisualStudio-TemplateWizard-WizardRunKind,System-Object[]-'></a>
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
