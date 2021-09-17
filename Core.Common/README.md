<a name='assembly'></a>
# Core.Common

## Contents

- [SubProjectNameSuffixes](#T-Core-Common-SubProjectNameSuffixes 'Core.Common.SubProjectNameSuffixes')
  - [DataAccessLayer](#F-Core-Common-SubProjectNameSuffixes-DataAccessLayer 'Core.Common.SubProjectNameSuffixes.DataAccessLayer')
  - [WindowsApp](#F-Core-Common-SubProjectNameSuffixes-WindowsApp 'Core.Common.SubProjectNameSuffixes.WindowsApp')
- [WizardAction](#T-Core-Common-WizardAction 'Core.Common.WizardAction')
  - [Backout](#F-Core-Common-WizardAction-Backout 'Core.Common.WizardAction.Backout')
  - [Create](#F-Core-Common-WizardAction-Create 'Core.Common.WizardAction.Create')
  - [None](#F-Core-Common-WizardAction-None 'Core.Common.WizardAction.None')
- [WizardImplBase](#T-Core-Common-WizardImplBase 'Core.Common.WizardImplBase')
  - [_dte](#F-Core-Common-WizardImplBase-_dte 'Core.Common.WizardImplBase._dte')

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

<a name='F-Core-Common-WizardImplBase-_dte'></a>
### _dte `constants`

##### Summary

Reference to an instance of an object that implements the
[DTE](#T-EnvDTE-DTE 'EnvDTE.DTE') interface.
