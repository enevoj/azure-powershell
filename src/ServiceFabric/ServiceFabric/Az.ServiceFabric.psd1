#
# Module manifest for module 'Az.ServiceFabric'
#
# Generated by: Microsoft Corporation
#
# Generated on: 3/17/2021
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '2.3.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'f98e4fc9-6247-4e59-99a1-7b8ba13b3d1e'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Service Fabric cmdlets for Azure Resource Manager in Windows PowerShell and PowerShell Core.

For more information on Service Fabric, please visit the following: https://docs.microsoft.com/azure/service-fabric/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.2.8'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'Microsoft.Azure.KeyVault.dll', 
               'Microsoft.Azure.KeyVault.WebKey.dll', 
               'Microsoft.Azure.Management.ServiceFabric.dll', 
               'Microsoft.Azure.Management.ServiceFabricManagedClusters.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'ServiceFabric.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Add-AzServiceFabricClientCertificate', 
               'Add-AzServiceFabricClusterCertificate', 'Add-AzServiceFabricNode', 
               'Add-AzServiceFabricNodeType', 'Get-AzServiceFabricCluster', 
               'New-AzServiceFabricCluster', 
               'Remove-AzServiceFabricClientCertificate', 
               'Remove-AzServiceFabricClusterCertificate', 
               'Remove-AzServiceFabricNode', 'Remove-AzServiceFabricNodeType', 
               'Remove-AzServiceFabricSetting', 'Set-AzServiceFabricSetting', 
               'Set-AzServiceFabricUpgradeType', 
               'Update-AzServiceFabricDurability', 
               'Update-AzServiceFabricReliability', 
               'New-AzServiceFabricApplication', 
               'New-AzServiceFabricApplicationType', 
               'New-AzServiceFabricApplicationTypeVersion', 
               'New-AzServiceFabricService', 'Update-AzServiceFabricApplication', 
               'Get-AzServiceFabricApplication', 
               'Get-AzServiceFabricApplicationType', 
               'Get-AzServiceFabricApplicationTypeVersion', 
               'Get-AzServiceFabricService', 'Remove-AzServiceFabricApplication', 
               'Remove-AzServiceFabricApplicationType', 
               'Remove-AzServiceFabricApplicationTypeVersion', 
               'Remove-AzServiceFabricService', 
               'New-AzServiceFabricManagedCluster', 
               'Get-AzServiceFabricManagedCluster', 
               'Set-AzServiceFabricManagedCluster', 
               'Remove-AzServiceFabricManagedCluster', 
               'Add-AzServiceFabricManagedClusterClientCertificate', 
               'Remove-AzServiceFabricManagedClusterClientCertificate', 
               'New-AzServiceFabricManagedNodeType', 
               'Get-AzServiceFabricManagedNodeType', 
               'Set-AzServiceFabricManagedNodeType', 
               'Remove-AzServiceFabricManagedNodeType', 
               'Add-AzServiceFabricManagedNodeTypeVMExtension', 
               'Add-AzServiceFabricManagedNodeTypeVMSecret', 
               'Remove-AzServiceFabricManagedNodeTypeVMExtension', 
               'Restart-AzServiceFabricManagedNodeType', 
               'Update-AzServiceFabricNodeType', 'Update-AzServiceFabricVmImage', 
               'New-AzServiceFabricManagedClusterApplication', 
               'Get-AzServiceFabricManagedClusterApplication', 
               'Set-AzServiceFabricManagedClusterApplication', 
               'Remove-AzServiceFabricManagedClusterApplication', 
               'New-AzServiceFabricManagedClusterApplicationType', 
               'Get-AzServiceFabricManagedClusterApplicationType', 
               'Set-AzServiceFabricManagedClusterApplicationType', 
               'Remove-AzServiceFabricManagedClusterApplicationType', 
               'New-AzServiceFabricManagedClusterApplicationTypeVersion', 
               'Get-AzServiceFabricManagedClusterApplicationTypeVersion', 
               'Set-AzServiceFabricManagedClusterApplicationTypeVersion', 
               'Remove-AzServiceFabricManagedClusterApplicationTypeVersion', 
               'New-AzServiceFabricManagedClusterService', 
               'Get-AzServiceFabricManagedClusterService', 
               'Set-AzServiceFabricManagedClusterService', 
               'Remove-AzServiceFabricManagedClusterService'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ResourceManager','ARM','ServiceFabric'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Added parameters ''VMImagePublisher'', ''VMImageOffer'', ''VMImageSku'', ''VMImageVersion'' to ''Add-AzServiceFabricNodeType'' to facilitate easy alternate OS image creation for new node type.
* Added parameter ''IsPrimaryNodeType'' to ''Add-AzServiceFabricNodeType'' to be able to create an additional primary node type, for the purpose of transitioning the primary node type to another one in the case of OS migration.
* ''Add-AzServiceFabricNodeType'' now correctly copies the LinuxDiagnostic extension. This was previously not working for Linux.
* ''Add-AzServiceFabricNodeType'' now correctly copies the RDP/SSH load balancer inbound NAT port mapping to the new node type.
* Added template for ''UbuntuServer1804'' for creating Ubuntu 18.04 clusters using ''New-AzServiceFabricCluster''.
* ''Remove-AzServiceFabricNodeType'' was incorrectly blocking Bronze durability node types for removal, and this has been updated to only block when the Bronze durability level differs between the SF node type and VMSS setting.
* Added cmdlet ''Update-AzServiceFabricVmImage'' to update the delivered SF runtime package type. This must be changed when migrating from Ubuntu 16 to 18.
* Added cmdlet ''Update-AzServiceFabricNodeType'' to update the properties of a cluster node type. For now this is solely used to update whether the node type is primary via bool parameter ''-IsPrimaryNodeType False''.
* ''Update-AzServiceFabricReliability'' is now able to update reliability level when the cluster has more than one primary node type. To do this, the name of the node type is supplied via the new -NodeType parameter.
* Added new cmdlets for managed applications:
    - ''New-AzServiceFabricManagedClusterApplication''
    - ''Get-AzServiceFabricManagedClusterApplication''
    - ''Set-AzServiceFabricManagedClusterApplication''
    - ''Remove-AzServiceFabricManagedClusterApplication''
    - ''New-AzServiceFabricManagedClusterApplicationType''
    - ''Get-AzServiceFabricManagedClusterApplicationType''
    - ''Set-AzServiceFabricManagedClusterApplicationType''
    - ''Remove-AzServiceFabricManagedClusterApplicationType''
    - ''New-AzServiceFabricManagedClusterApplicationTypeVersion''
    - ''Get-AzServiceFabricManagedClusterApplicationTypeVersion''
    - ''Set-AzServiceFabricManagedClusterApplicationTypeVersion''
    - ''Remove-AzServiceFabricManagedClusterApplicationTypeVersion''
    - ''New-AzServiceFabricManagedClusterService''
    - ''Get-AzServiceFabricManagedClusterService''
    - ''Set-AzServiceFabricManagedClusterService''
    - ''Remove-AzServiceFabricManagedClusterService''
* Upgraded Managed Cluster commands to use Service Fabric Managed Cluster SDK version 1.0.0-beta.1 which uses service fabric resource provider api-version 2021-01-01-preview.'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

