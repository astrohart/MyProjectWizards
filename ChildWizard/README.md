<a name='assembly'></a>
# ChildWizard

## Contents

- [ExampleDialogBox](#T-ChildWizard-ExampleDialogBox 'ChildWizard.ExampleDialogBox')
  - [#ctor(dte,destinationDirectory)](#M-ChildWizard-ExampleDialogBox-#ctor-EnvDTE-DTE,System-String,System-String- 'ChildWizard.ExampleDialogBox.#ctor(EnvDTE.DTE,System.String,System.String)')
  - [#ctor()](#M-ChildWizard-ExampleDialogBox-#ctor 'ChildWizard.ExampleDialogBox.#ctor')
  - [components](#F-ChildWizard-ExampleDialogBox-components 'ChildWizard.ExampleDialogBox.components')
  - [Action](#P-ChildWizard-ExampleDialogBox-Action 'ChildWizard.ExampleDialogBox.Action')
  - [DestinationDirectory](#P-ChildWizard-ExampleDialogBox-DestinationDirectory 'ChildWizard.ExampleDialogBox.DestinationDirectory')
  - [Dte](#P-ChildWizard-ExampleDialogBox-Dte 'ChildWizard.ExampleDialogBox.Dte')
  - [SafeProjectName](#P-ChildWizard-ExampleDialogBox-SafeProjectName 'ChildWizard.ExampleDialogBox.SafeProjectName')
  - [Dispose(disposing)](#M-ChildWizard-ExampleDialogBox-Dispose-System-Boolean- 'ChildWizard.ExampleDialogBox.Dispose(System.Boolean)')
  - [InitializeComponent()](#M-ChildWizard-ExampleDialogBox-InitializeComponent 'ChildWizard.ExampleDialogBox.InitializeComponent')
  - [OnClickNoButton(sender,e)](#M-ChildWizard-ExampleDialogBox-OnClickNoButton-System-Object,System-EventArgs- 'ChildWizard.ExampleDialogBox.OnClickNoButton(System.Object,System.EventArgs)')
  - [OnClickYesButton(sender,e)](#M-ChildWizard-ExampleDialogBox-OnClickYesButton-System-Object,System-EventArgs- 'ChildWizard.ExampleDialogBox.OnClickYesButton(System.Object,System.EventArgs)')
  - [OnLoad(e)](#M-ChildWizard-ExampleDialogBox-OnLoad-System-EventArgs- 'ChildWizard.ExampleDialogBox.OnLoad(System.EventArgs)')
- [Resources](#T-ChildWizard-Properties-Resources 'ChildWizard.Properties.Resources')
  - [Culture](#P-ChildWizard-Properties-Resources-Culture 'ChildWizard.Properties.Resources.Culture')
  - [ResourceManager](#P-ChildWizard-Properties-Resources-ResourceManager 'ChildWizard.Properties.Resources.ResourceManager')
  - [_230_2304659_computer_icons_warning_sign_windows_10_download_warning](#P-ChildWizard-Properties-Resources-_230_2304659_computer_icons_warning_sign_windows_10_download_warning 'ChildWizard.Properties.Resources._230_2304659_computer_icons_warning_sign_windows_10_download_warning')
- [WizardImpl](#T-ChildWizard-WizardImpl 'ChildWizard.WizardImpl')
  - [_containingSolutionName](#F-ChildWizard-WizardImpl-_containingSolutionName 'ChildWizard.WizardImpl._containingSolutionName')
  - [_generatedSubProjectFolder](#F-ChildWizard-WizardImpl-_generatedSubProjectFolder 'ChildWizard.WizardImpl._generatedSubProjectFolder')
  - [_subProjectName](#F-ChildWizard-WizardImpl-_subProjectName 'ChildWizard.WizardImpl._subProjectName')
  - [ConfigurationProvider](#P-ChildWizard-WizardImpl-ConfigurationProvider 'ChildWizard.WizardImpl.ConfigurationProvider')
  - [CurrentConfiguration](#P-ChildWizard-WizardImpl-CurrentConfiguration 'ChildWizard.WizardImpl.CurrentConfiguration')
  - [AppendToLog(text)](#M-ChildWizard-WizardImpl-AppendToLog-System-String- 'ChildWizard.WizardImpl.AppendToLog(System.String)')
  - [BeforeOpeningFile(item)](#M-ChildWizard-WizardImpl-BeforeOpeningFile-EnvDTE-ProjectItem- 'ChildWizard.WizardImpl.BeforeOpeningFile(EnvDTE.ProjectItem)')
  - [LoadConfiguration()](#M-ChildWizard-WizardImpl-LoadConfiguration 'ChildWizard.WizardImpl.LoadConfiguration')
  - [ProjectFinishedGenerating(project)](#M-ChildWizard-WizardImpl-ProjectFinishedGenerating-EnvDTE-Project- 'ChildWizard.WizardImpl.ProjectFinishedGenerating(EnvDTE.Project)')
  - [ProjectItemFinishedGenerating(projectItem)](#M-ChildWizard-WizardImpl-ProjectItemFinishedGenerating-EnvDTE-ProjectItem- 'ChildWizard.WizardImpl.ProjectItemFinishedGenerating(EnvDTE.ProjectItem)')
  - [RunFinished()](#M-ChildWizard-WizardImpl-RunFinished 'ChildWizard.WizardImpl.RunFinished')
  - [RunStarted(automationObject,replacementsDictionary,runKind,customParams)](#M-ChildWizard-WizardImpl-RunStarted-System-Object,System-Collections-Generic-Dictionary{System-String,System-String},Microsoft-VisualStudio-TemplateWizard-WizardRunKind,System-Object[]- 'ChildWizard.WizardImpl.RunStarted(System.Object,System.Collections.Generic.Dictionary{System.String,System.String},Microsoft.VisualStudio.TemplateWizard.WizardRunKind,System.Object[])')
  - [SaveConfiguration()](#M-ChildWizard-WizardImpl-SaveConfiguration 'ChildWizard.WizardImpl.SaveConfiguration')
  - [ShouldAddProjectItem(filePath)](#M-ChildWizard-WizardImpl-ShouldAddProjectItem-System-String- 'ChildWizard.WizardImpl.ShouldAddProjectItem(System.String)')

<a name='T-ChildWizard-ExampleDialogBox'></a>
## ExampleDialogBox `type`

##### Namespace

ChildWizard

##### Summary

Sample windows form.

<a name='M-ChildWizard-ExampleDialogBox-#ctor-EnvDTE-DTE,System-String,System-String-'></a>
### #ctor(dte,destinationDirectory) `constructor`

##### Summary

Constructs a new instance of [ExampleDialogBox](#T-ChildWizard-ExampleDialogBox 'ChildWizard.ExampleDialogBox')
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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameters,
`destinationDirectory` or `safeProjectName`
, are passed a blank or `null` string for a value. |

<a name='M-ChildWizard-ExampleDialogBox-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [ExampleDialogBox](#T-ChildWizard-ExampleDialogBox 'ChildWizard.ExampleDialogBox') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-ChildWizard-ExampleDialogBox-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='P-ChildWizard-ExampleDialogBox-Action'></a>
### Action `property`

##### Summary

Gets the [WizardAction](#T-ChildWizard-WizardAction 'ChildWizard.WizardAction') value that specifies the
choice the user has made.

<a name='P-ChildWizard-ExampleDialogBox-DestinationDirectory'></a>
### DestinationDirectory `property`

##### Summary

Gets a string that contains the fully-qualified pathname to the directory to
which the files for the new project are to be written.

<a name='P-ChildWizard-ExampleDialogBox-Dte'></a>
### Dte `property`

##### Summary

Gets a reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface.

<a name='P-ChildWizard-ExampleDialogBox-SafeProjectName'></a>
### SafeProjectName `property`

##### Summary

Gets a string containing the name of the project to be generated.

<a name='M-ChildWizard-ExampleDialogBox-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-ChildWizard-ExampleDialogBox-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='M-ChildWizard-ExampleDialogBox-OnClickNoButton-System-Object,System-EventArgs-'></a>
### OnClickNoButton(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event raised by
the button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method is called when the user clicks the button.



The function of this button is to tell the caller of this dialog that it should
throw
[WizardBackoutException](#T-Microsoft-VisualStudio-TemplateWizard-WizardBackoutException 'Microsoft.VisualStudio.TemplateWizard.WizardBackoutException').

<a name='M-ChildWizard-ExampleDialogBox-OnClickYesButton-System-Object,System-EventArgs-'></a>
### OnClickYesButton(sender,e) `method`

##### Summary

Handles the [](#E-System-Windows-Forms-Control-Click 'System.Windows.Forms.Control.Click') event raised by
the button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the
event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | A [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

##### Remarks

This method is called when the user clicks the button.



The function of this button is to tell the caller of this dialog that it should
let the operation proceed.

<a name='M-ChildWizard-ExampleDialogBox-OnLoad-System-EventArgs-'></a>
### OnLoad(e) `method`

##### Summary

Raises the [](#E-System-Windows-Forms-Form-Load 'System.Windows.Forms.Form.Load') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event
data. |

<a name='T-ChildWizard-Properties-Resources'></a>
## Resources `type`

##### Namespace

ChildWizard.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-ChildWizard-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-ChildWizard-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-ChildWizard-Properties-Resources-_230_2304659_computer_icons_warning_sign_windows_10_download_warning'></a>
### _230_2304659_computer_icons_warning_sign_windows_10_download_warning `property`

##### Summary

Looks up a localized resource of type System.Drawing.Bitmap.

<a name='T-ChildWizard-WizardImpl'></a>
## WizardImpl `type`

##### Namespace

ChildWizard

##### Summary

Implements a wizard for the generation of an individual project in the
solution.

<a name='F-ChildWizard-WizardImpl-_containingSolutionName'></a>
### _containingSolutionName `constants`

##### Summary

Contains the name of the folder that was erroneously
generated in order to contain the generated sub-projects,
which we assume has the same name as the solution (without
the `.sln` file extension, so we are giving it a
descriptive name as such.

<a name='F-ChildWizard-WizardImpl-_generatedSubProjectFolder'></a>
### _generatedSubProjectFolder `constants`

##### Summary

String containing the fully-qualified pathname of the
sub-folder in which this particular project (this Wizard
is called once for each sub-project in a multi-project
template) is going to live in.

<a name='F-ChildWizard-WizardImpl-_subProjectName'></a>
### _subProjectName `constants`

##### Summary

String containing the name of the project that is safe to use.

<a name='P-ChildWizard-WizardImpl-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to an instance of the object that implements the
[IConfigurationProvider](#T-Core-Config-IConfigurationProvider 'Core.Config.IConfigurationProvider') interface.

<a name='P-ChildWizard-WizardImpl-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IConfiguration](#T-Core-Config-IConfiguration 'Core.Config.IConfiguration') interface.

<a name='M-ChildWizard-WizardImpl-AppendToLog-System-String-'></a>
### AppendToLog(text) `method`

##### Summary

Appends the specified `text` to the log file, splitting on
any newlines.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to write to the log.



The specified text is appended to the end of the log file. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`text`, is passed a blank or `null` string
for a value. |

<a name='M-ChildWizard-WizardImpl-BeforeOpeningFile-EnvDTE-ProjectItem-'></a>
### BeforeOpeningFile(item) `method`

##### Summary

Runs custom wizard logic before opening an item in the template.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [EnvDTE.ProjectItem](#T-EnvDTE-ProjectItem 'EnvDTE.ProjectItem') | The project item that will be opened. |

<a name='M-ChildWizard-WizardImpl-LoadConfiguration'></a>
### LoadConfiguration() `method`

##### Summary

Loads the configuration from the pathname specified by the
[ConfigFilePath](#P-Core-Config-IConfigurationProvider-ConfigFilePath 'Core.Config.IConfigurationProvider.ConfigFilePath') property and
sets the value of the
[CurrentConfiguration](#P-ChildWizard-WizardImpl-CurrentConfiguration 'ChildWizard.WizardImpl.CurrentConfiguration') property to
point to it.

##### Parameters

This method has no parameters.

<a name='M-ChildWizard-WizardImpl-ProjectFinishedGenerating-EnvDTE-Project-'></a>
### ProjectFinishedGenerating(project) `method`

##### Summary

Runs custom wizard logic when a project has finished generating.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| project | [EnvDTE.Project](#T-EnvDTE-Project 'EnvDTE.Project') | The project that finished generating. |

<a name='M-ChildWizard-WizardImpl-ProjectItemFinishedGenerating-EnvDTE-ProjectItem-'></a>
### ProjectItemFinishedGenerating(projectItem) `method`

##### Summary

Runs custom wizard logic when a project item has finished generating.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectItem | [EnvDTE.ProjectItem](#T-EnvDTE-ProjectItem 'EnvDTE.ProjectItem') | The project item that finished generating. |

<a name='M-ChildWizard-WizardImpl-RunFinished'></a>
### RunFinished() `method`

##### Summary

Runs custom wizard logic when the
wizard has completed all tasks.

##### Parameters

This method has no parameters.

<a name='M-ChildWizard-WizardImpl-RunStarted-System-Object,System-Collections-Generic-Dictionary{System-String,System-String},Microsoft-VisualStudio-TemplateWizard-WizardRunKind,System-Object[]-'></a>
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

<a name='M-ChildWizard-WizardImpl-SaveConfiguration'></a>
### SaveConfiguration() `method`

##### Summary

Saves the configuration data in the
[CurrentConfiguration](#P-ChildWizard-WizardImpl-CurrentConfiguration 'ChildWizard.WizardImpl.CurrentConfiguration') property to
the file located at the pathname specified by the
[ConfigFilePath](#P-Core-Config-IConfigurationProvider-ConfigFilePath 'Core.Config.IConfigurationProvider.ConfigFilePath') property.

##### Parameters

This method has no parameters.

<a name='M-ChildWizard-WizardImpl-ShouldAddProjectItem-System-String-'></a>
### ShouldAddProjectItem(filePath) `method`

##### Summary

Indicates whether the specified project item should be added to the
project.

##### Returns

true if the project item should be added to the project; otherwise,
false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path to the project item. |
