
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Adds member to group.
.Description
Adds member to group.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphGroup
.Outputs
System.Boolean
.Link
https://docs.microsoft.com/powershell/module/az.resources/add-azadgroupmember
#>
function Add-AzADGroupMember {
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName='MemberObjectIdWithGroupObjectIdParameterSet', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='MemberObjectIdWithGroupObjectIdParameterSet', Mandatory, HelpMessage = "The object Id of target group.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupObjectIdParameterSet', Mandatory, HelpMessage = "The object Id of target group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [System.String]
        ${TargetGroupObjectId},

        [Parameter(ParameterSetName='MemberObjectIdWithGroupDisplayNameParameterSet', Mandatory, HelpMessage = "The display name of target group.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupDisplayNameParameterSet', Mandatory, HelpMessage = "The display name of target group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [System.String]
        # something
        ${TargetGroupDisplayName},

        [Parameter(ParameterSetName='MemberObjectIdWithGroupObjectParameterSet', Mandatory, ValueFromPipeline, HelpMessage = "The target group object, could be used as pipeline input.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupObjectParameterSet', Mandatory, ValueFromPipeline, HelpMessage = "The target group object, could be used as pipeline input.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphGroup]
        ${TargetGroupObject},
    
        [Parameter(ParameterSetName='MemberObjectIdWithGroupObjectIdParameterSet', Mandatory, HelpMessage = "The object Id of member to add to target group.")]
        [Parameter(ParameterSetName='MemberObjectIdWithGroupDisplayNameParameterSet', Mandatory, HelpMessage = "The object Id of member to add to target group.")]
        [Parameter(ParameterSetName='MemberObjectIdWithGroupObjectParameterSet', Mandatory, HelpMessage = "The object Id of member to add to target group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [System.String[]]
        ${MemberObjectId},

        [Parameter(ParameterSetName='MemberUPNWithGroupObjectIdParameterSet', Mandatory, HelpMessage = "The user principal name of member to add to target group.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupDisplayNameParameterSet', Mandatory, HelpMessage = "The user principal name of member to add to target group.")]
        [Parameter(ParameterSetName='MemberUPNWithGroupObjectParameterSet', Mandatory, HelpMessage = "The user principal name of member to add to target group.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
        [System.String[]]
        ${MemberUserPrincipalName},

        [Parameter()]
        [Alias("AzContext", "AzureRmContext", "AzureCredential")]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Returns true when the command succeeds
        ${PassThru},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    
    process {
        $baseUrl = (Get-AzContext).Environment.ExtendedProperties.MicrosoftGraphUrl
        $apiVersion = 'V1.0'
        $odataIdUriPrefix = "$($baseUrl)/$($apiVersion)/directoryObjects"

        if ($PSBoundParameters['TargetGroupDisplayName']) {
            $param = @{'DisplayName' = $PSBoundParameters['TargetGroupDisplayName']}
            if ($PSBoundParameters['Debug']) {
                $param['Debug'] = $PSBoundParameters['Debug']
            }
            $PSBoundParameters['GroupId'] = (Get-AzADGroup @param).Id
            $null = $PSBoundParameters.Remove('TargetGroupDisplayName')
        } elseif ($PSBoundParameters['TargetGroupObject']) {
            $PSBoundParameters['GroupId'] = $PSBoundParameters['TargetGroupObject'].Id
            $null = $PSBoundParameters.Remove('TargetGroupObject')
        } else {
            $PSBoundParameters['GroupId'] = $PSBoundParameters['TargetGroupObjectId']
            $null = $PSBoundParameters.Remove('TargetGroupObjectId')
        }

        $members = @()
        if ($PSBoundParameters['MemberUserPrincipalName']) {
            foreach ($name in $PSBoundParameters['MemberUserPrincipalName']) {
                $members += (Get-AzADUser -UserPrincipalName $name).Id
            }
            $null = $PSBoundParameters.Remove('MemberUserPrincipalName')
        } else {
            $members += $PSBoundParameters['MemberObjectId']
            $null = $PSBoundParameters.Remove('MemberObjectId')
        }

        foreach ($member in $members) {
            $additionalProperties = @{'@odata.id'="$($odataIdUriPrefix)/$($member)"}
            $PSBoundParameters['AdditionalProperties'] = $additionalProperties
            MSGraph.internal\New-AzADGroupRefMember @PSBoundParameters
        }

        if ($PSBoundParameters['PassThru']) {
            $PSCmdlet.WriteObject($true)
        }
    }
    }
    