if(($null -eq $TestName) -or ($TestName -contains 'Remove-AzFrontDoorCdnOriginGroup'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzFrontDoorCdnOriginGroup.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-AzFrontDoorCdnOriginGroup' {
    It 'Delete' {
        $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)
        try
        {
            Write-Host -ForegroundColor Green "Create test group $($ResourceGroupName)"
            New-AzResourceGroup -Name $ResourceGroupName -Location $env.location

            $frontDoorCdnProfileName = 'fdp-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnProfileName : $($frontDoorCdnProfileName)"

            $profileSku = "Standard_AzureFrontDoor";
            New-AzFrontDoorCdnProfile -SkuName $profileSku -Name $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global

            $originGroupName = 'org' + (RandomString -allChars $false -len 6);
            New-AzFrontDoorCdnOriginGroup -OriginGroupName $originGroupName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName `
            -LoadBalancingSettingSampleSize 5 `
            -LoadBalancingSettingSuccessfulSamplesRequired 4 `
            -LoadBalancingSettingAdditionalLatencyInMillisecond 200 `
            -HealthProbeSettingProbeIntervalInSecond 1 `
            -HealthProbeSettingProbePath "/" `
            -HealthProbeSettingProbeProtocol $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol]::Https) `
            -HealthProbeSettingProbeRequestType $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType]::Get) `

            $originGroup = Get-AzFrontDoorCdnOriginGroup -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -OriginGroupName $originGroupName
            Remove-AzFrontDoorCdnOriginGroup -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -OriginGroupName $originGroupName
        } Finally
        {
            Remove-AzResourceGroup -Name $ResourceGroupName -NoWait
        }
    }

    It 'DeleteViaIdentity' {
        $PSDefaultParameterValues['Disabled'] = $true
        $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)
        try
        {
            Write-Host -ForegroundColor Green "Create test group $($ResourceGroupName)"
            New-AzResourceGroup -Name $ResourceGroupName -Location $env.location

            $frontDoorCdnProfileName = 'fdp-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnProfileName : $($frontDoorCdnProfileName)"

            $profileSku = "Standard_AzureFrontDoor";
            New-AzFrontDoorCdnProfile -SkuName $profileSku -Name $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global

            $originGroupName = 'org' + (RandomString -allChars $false -len 6);
            New-AzFrontDoorCdnOriginGroup -OriginGroupName $originGroupName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName `
            -LoadBalancingSettingSampleSize 5 `
            -LoadBalancingSettingSuccessfulSamplesRequired 4 `
            -LoadBalancingSettingAdditionalLatencyInMillisecond 200 `
            -HealthProbeSettingProbeIntervalInSecond 1 `
            -HealthProbeSettingProbePath "/" `
            -HealthProbeSettingProbeProtocol $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol]::Https) `
            -HealthProbeSettingProbeRequestType $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType]::Get) `

            Get-AzFrontDoorCdnOriginGroup -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -OriginGroupName $originGroupName | Remove-AzFrontDoorCdnOriginGroup  
        } Finally
        {
            Remove-AzResourceGroup -Name $ResourceGroupName -NoWait
        }
    }
}
