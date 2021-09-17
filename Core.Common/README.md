<a name='assembly'></a>
# Core.Common

## Contents

- [DebugLevel](#T-Core-Common-DebugLevel 'Core.Common.DebugLevel')
  - [Debug](#F-Core-Common-DebugLevel-Debug 'Core.Common.DebugLevel.Debug')
  - [Error](#F-Core-Common-DebugLevel-Error 'Core.Common.DebugLevel.Error')
  - [Info](#F-Core-Common-DebugLevel-Info 'Core.Common.DebugLevel.Info')
  - [Warn](#F-Core-Common-DebugLevel-Warn 'Core.Common.DebugLevel.Warn')
- [SubProjectNameSuffixes](#T-Core-Common-SubProjectNameSuffixes 'Core.Common.SubProjectNameSuffixes')
  - [DataAccessLayer](#F-Core-Common-SubProjectNameSuffixes-DataAccessLayer 'Core.Common.SubProjectNameSuffixes.DataAccessLayer')
  - [WindowsApp](#F-Core-Common-SubProjectNameSuffixes-WindowsApp 'Core.Common.SubProjectNameSuffixes.WindowsApp')
- [WizardAction](#T-Core-Common-WizardAction 'Core.Common.WizardAction')
  - [Backout](#F-Core-Common-WizardAction-Backout 'Core.Common.WizardAction.Backout')
  - [Create](#F-Core-Common-WizardAction-Create 'Core.Common.WizardAction.Create')
  - [None](#F-Core-Common-WizardAction-None 'Core.Common.WizardAction.None')
- [WizardImplBase](#T-Core-Common-WizardImplBase 'Core.Common.WizardImplBase')
  - [_dte](#F-Core-Common-WizardImplBase-_dte 'Core.Common.WizardImplBase._dte')
  - [ConfigurationProvider](#P-Core-Common-WizardImplBase-ConfigurationProvider 'Core.Common.WizardImplBase.ConfigurationProvider')
  - [CurrentConfiguration](#P-Core-Common-WizardImplBase-CurrentConfiguration 'Core.Common.WizardImplBase.CurrentConfiguration')
  - [AppendToLog(text)](#M-Core-Common-WizardImplBase-AppendToLog-System-String- 'Core.Common.WizardImplBase.AppendToLog(System.String)')
  - [BeforeOpeningFile(item)](#M-Core-Common-WizardImplBase-BeforeOpeningFile-EnvDTE-ProjectItem- 'Core.Common.WizardImplBase.BeforeOpeningFile(EnvDTE.ProjectItem)')
  - [DumpToLog(exception)](#M-Core-Common-WizardImplBase-DumpToLog-System-Exception- 'Core.Common.WizardImplBase.DumpToLog(System.Exception)')
  - [GetLogLabelFor(level)](#M-Core-Common-WizardImplBase-GetLogLabelFor-Core-Common-DebugLevel- 'Core.Common.WizardImplBase.GetLogLabelFor(Core.Common.DebugLevel)')
  - [IsDirectoryEmpty(path)](#M-Core-Common-WizardImplBase-IsDirectoryEmpty-System-String- 'Core.Common.WizardImplBase.IsDirectoryEmpty(System.String)')
  - [LoadConfiguration()](#M-Core-Common-WizardImplBase-LoadConfiguration 'Core.Common.WizardImplBase.LoadConfiguration')
  - [ProjectFinishedGenerating(project)](#M-Core-Common-WizardImplBase-ProjectFinishedGenerating-EnvDTE-Project- 'Core.Common.WizardImplBase.ProjectFinishedGenerating(EnvDTE.Project)')
  - [ProjectItemFinishedGenerating(projectItem)](#M-Core-Common-WizardImplBase-ProjectItemFinishedGenerating-EnvDTE-ProjectItem- 'Core.Common.WizardImplBase.ProjectItemFinishedGenerating(EnvDTE.ProjectItem)')
  - [RunStarted(automationObject,replacementsDictionary,runKind,customParams)](#M-Core-Common-WizardImplBase-RunStarted-System-Object,System-Collections-Generic-Dictionary{System-String,System-String},Microsoft-VisualStudio-TemplateWizard-WizardRunKind,System-Object[]- 'Core.Common.WizardImplBase.RunStarted(System.Object,System.Collections.Generic.Dictionary{System.String,System.String},Microsoft.VisualStudio.TemplateWizard.WizardRunKind,System.Object[])')
  - [SaveConfiguration()](#M-Core-Common-WizardImplBase-SaveConfiguration 'Core.Common.WizardImplBase.SaveConfiguration')
  - [ShouldAddProjectItem(filePath)](#M-Core-Common-WizardImplBase-ShouldAddProjectItem-System-String- 'Core.Common.WizardImplBase.ShouldAddProjectItem(System.String)')
  - [WriteLineToLog(text)](#M-Core-Common-WizardImplBase-WriteLineToLog-System-String- 'Core.Common.WizardImplBase.WriteLineToLog(System.String)')
  - [WriteLineToLog(level,text)](#M-Core-Common-WizardImplBase-WriteLineToLog-Core-Common-DebugLevel,System-String- 'Core.Common.WizardImplBase.WriteLineToLog(Core.Common.DebugLevel,System.String)')

<a name='T-Core-Common-DebugLevel'></a>
## DebugLevel `type`

##### Namespace

Core.Common

##### Summary

Identifies the debug message level for a logging message.

<a name='F-Core-Common-DebugLevel-Debug'></a>
### Debug `constants`

##### Summary

The logging message is for debugging purposes only.

<a name='F-Core-Common-DebugLevel-Error'></a>
### Error `constants`

##### Summary

The logging message is for error purposes only.

<a name='F-Core-Common-DebugLevel-Info'></a>
### Info `constants`

##### Summary

The logging message is for informational purposes only.

<a name='F-Core-Common-DebugLevel-Warn'></a>
### Warn `constants`

##### Summary

The logging message is for warning purposes only.

<a name='T-Core-Common-SubProjectNameSuffixes'></a>
## SubProjectNameSuffixes `type`

##### Namespace

Core.Common

##### Summary

Constants that give the suffix names for sub-projects.

<a name='F-Core-Common-SubProjectNameSuffixes-DataAccessLayer'></a>
### DataAccessLayer `constants`

##### Summary

The sub-project is for the Data Access Layer.

<a name='F-Core-Common-SubProjectNameSuffixes-WindowsApp'></a>
### WindowsApp `constants`

##### Summary

The sub-project is for the User-Interface Layer.

<a name='T-Core-Common-WizardAction'></a>
## WizardAction `type`

##### Namespace

Core.Common

##### Summary

Specifies the action that the Wizard is to take.

<a name='F-Core-Common-WizardAction-Backout'></a>
### Backout `constants`

##### Summary

Suppress generation of the project.

<a name='F-Core-Common-WizardAction-Create'></a>
### Create `constants`

##### Summary

Create the project.

<a name='F-Core-Common-WizardAction-None'></a>
### None `constants`

##### Summary

Take no action.

<a name='T-Core-Common-WizardImplBase'></a>
## WizardImplBase `type`

##### Namespace

Core.Common

##### Summary

Defines methods and properties that implementations of the
[IWizard](#T-Microsoft-VisualStudio-TemplateWizard-IWizard 'Microsoft.VisualStudio.TemplateWizard.IWizard') interface share
in common.

<a name='F-Core-Common-WizardImplBase-_dte'></a>
### _dte `constants`

##### Summary

Reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface.

<a name='P-Core-Common-WizardImplBase-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to an instance of the object that implements the
[IConfigurationProvider](#T-Core-Config-IConfigurationProvider 'Core.Config.IConfigurationProvider') interface.

<a name='P-Core-Common-WizardImplBase-CurrentConfiguration'></a>
### CurrentConfiguration `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IConfiguration](#T-Core-Config-IConfiguration 'Core.Config.IConfiguration') interface.

<a name='M-Core-Common-WizardImplBase-AppendToLog-System-String-'></a>
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

<a name='M-Core-Common-WizardImplBase-BeforeOpeningFile-EnvDTE-ProjectItem-'></a>
### BeforeOpeningFile(item) `method`

##### Summary

Runs custom wizard logic before opening an item in the template.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [EnvDTE.ProjectItem](#T-EnvDTE-ProjectItem 'EnvDTE.ProjectItem') | The project item that will be opened. |

<a name='M-Core-Common-WizardImplBase-DumpToLog-System-Exception-'></a>
### DumpToLog(exception) `method`

##### Summary

Dumps detailed information about the specified `exception` to
the log file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) Reference to a
[Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that describes the error that has occurred. |

##### Remarks

If `null` is passed for the
`exception` parameter, then this method does nothing.

<a name='M-Core-Common-WizardImplBase-GetLogLabelFor-Core-Common-DebugLevel-'></a>
### GetLogLabelFor(level) `method`

##### Summary

Given a [DebugLevel](#T-Core-Common-DebugLevel 'Core.Common.DebugLevel') value specified in the
`level` parameter, generates a string with a label for the
category of message that corresponds to it.

##### Returns

String containing the label that corresponds to the category of
logging message identified by the `level` parameter's value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| level | [Core.Common.DebugLevel](#T-Core-Common-DebugLevel 'Core.Common.DebugLevel') | (Required.) A [DebugLevel](#T-Core-Common-DebugLevel 'Core.Common.DebugLevel') value
that specifies the category of logging message. |

##### Remarks

If a [DebugLevel](#T-Core-Common-DebugLevel 'Core.Common.DebugLevel') value is passed for which there is
no matching string label, then the blank string is returned.

<a name='M-Core-Common-WizardImplBase-IsDirectoryEmpty-System-String-'></a>
### IsDirectoryEmpty(path) `method`

##### Summary

Checks whether the folder having the specified `path` is
empty.

##### Returns

`true` if the folder contains no files nor
subfolders; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified pathname of the folder to be
checked. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`path`, is passed a blank or `null` string
for a value. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown if the folder whose path is specified by the `path`
parameter cannot be located. |

<a name='M-Core-Common-WizardImplBase-LoadConfiguration'></a>
### LoadConfiguration() `method`

##### Summary

Loads the configuration from the pathname specified by the
[ConfigFilePath](#P-Core-Config-IConfigurationProvider-ConfigFilePath 'Core.Config.IConfigurationProvider.ConfigFilePath') property and
sets the value of the
[CurrentConfiguration](#P-Core-Common-WizardImplBase-CurrentConfiguration 'Core.Common.WizardImplBase.CurrentConfiguration') property to
point to it.

##### Parameters

This method has no parameters.

<a name='M-Core-Common-WizardImplBase-ProjectFinishedGenerating-EnvDTE-Project-'></a>
### ProjectFinishedGenerating(project) `method`

##### Summary

Runs custom wizard logic when a project has finished generating.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| project | [EnvDTE.Project](#T-EnvDTE-Project 'EnvDTE.Project') | The project that finished generating. |

<a name='M-Core-Common-WizardImplBase-ProjectItemFinishedGenerating-EnvDTE-ProjectItem-'></a>
### ProjectItemFinishedGenerating(projectItem) `method`

##### Summary

Runs custom wizard logic when a project item has finished generating.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| projectItem | [EnvDTE.ProjectItem](#T-EnvDTE-ProjectItem 'EnvDTE.ProjectItem') | The project item that finished generating. |

<a name='M-Core-Common-WizardImplBase-RunStarted-System-Object,System-Collections-Generic-Dictionary{System-String,System-String},Microsoft-VisualStudio-TemplateWizard-WizardRunKind,System-Object[]-'></a>
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

##### Remarks

The base-class method initializes the
[_dte](#F-Core-Common-WizardImplBase-_dte 'Core.Common.WizardImplBase._dte') field using the value of the
`automationObject` parameter.  Overrides should call the base
class before doing any processing.

<a name='M-Core-Common-WizardImplBase-SaveConfiguration'></a>
### SaveConfiguration() `method`

##### Summary

Saves the configuration data in the
[CurrentConfiguration](#P-Core-Common-WizardImplBase-CurrentConfiguration 'Core.Common.WizardImplBase.CurrentConfiguration') property to
the file located at the pathname specified by the
[ConfigFilePath](#P-Core-Config-IConfigurationProvider-ConfigFilePath 'Core.Config.IConfigurationProvider.ConfigFilePath') property.

##### Parameters

This method has no parameters.

<a name='M-Core-Common-WizardImplBase-ShouldAddProjectItem-System-String-'></a>
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

<a name='M-Core-Common-WizardImplBase-WriteLineToLog-System-String-'></a>
### WriteLineToLog(text) `method`

##### Summary

Writes a line of text to the log file, with a DEBUG label using the
[Debug](#T-Core-Common-DebugLevel-Debug 'Core.Common.DebugLevel.Debug') value for the 'level' parameter
in the other overload of this method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be sent to the log
file. |

<a name='M-Core-Common-WizardImplBase-WriteLineToLog-Core-Common-DebugLevel,System-String-'></a>
### WriteLineToLog(level,text) `method`

##### Summary

Writes the specified line of `text` to the log, and
categorizes it by [DebugLevel](#T-Core-Common-DebugLevel 'Core.Common.DebugLevel').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| level | [Core.Common.DebugLevel](#T-Core-Common-DebugLevel 'Core.Common.DebugLevel') | (Required.) A [DebugLevel](#T-Core-Common-DebugLevel 'Core.Common.DebugLevel') value
that specifies the logging level to be used. |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to be sent to the log
file. |

##### Remarks

If the `text` parameter is passed a blank or
`null` string, then this method does nothing.
