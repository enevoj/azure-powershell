param(
  [Parameter()]
  [string] $Repository = "PSGallery"
)

$helper = Join-Path $PSScriptRoot 'Az.Tools.Installer.Tests.Helper'
. $helper

Describe 'Install-AzModule' {
    BeforeAll {
        Get-PSRepository $Repository | Should -Not -Be $null
    }

    BeforeEach {
        Remove-AllAzModule
    }

    It 'InstallByName' {
        $output = Install-AzModule -Name storage,neTwork,compute,Az.keyvault -RequiredAzVersion 6.3 -Repository PSGallery -Scope 'CurrentUser'
        $output.Count | Should -Be 5
        $modules = Get-Module -ListAvailable -Name Az.*
        $modules.Count | Should -Be 5
        $modules.Name | Should -Contain 'Az.Accounts'
        $modules.Name | Should -Contain 'Az.Storage'
        $modules.Name | Should -Contain 'Az.Network'
        $modules.Name | Should -Contain 'Az.Compute'
        $modules.Name | Should -Contain 'Az.KeyVault'       
    }

    It 'InstallByNamePrerelease' {
        $output = Install-AzModule -Name storage,neTwork,maps,Az.keyvault -Repository PSGallery -AllowPrerelease
        $output.Count | Should -Be 5
        $modules = Get-Module -ListAvailable -Name Az.*
        $modules.Count | Should -Be 5
        $modules.Name | Should -Contain 'Az.Accounts'        
        $modules.Name | Should -Contain 'Az.Storage'
        $modules.Name | Should -Contain 'Az.Network'
        $modules.Name | Should -Contain 'Az.Maps'
        $modules.Name | Should -Contain 'Az.KeyVault'

        $output = Install-AzModule -Repository PSGallery -Name keyvault,resources,storage -RemovePrevious
        $output.Count | Should -Be 4
        $modules = Get-Module -ListAvailable -Name Az.*
        $modules.Count | Should -Be 6
        $modules.Name | Should -Contain 'Az.Accounts'        
        $modules.Name | Should -Contain 'Az.Storage'
        $modules.Name | Should -Contain 'Az.Network'
        $modules.Name | Should -Contain 'Az.Maps'
        $modules.Name | Should -Contain 'Az.KeyVault'
        $modules.Name | Should -Contain 'Az.Resources'               
    }

    It 'InstallByNameLatest' {
        $output = Install-AzModule -Name storage,maps -Repository PSGallery
        $output.Count | Should -Be 2
        $modules = Get-Module -ListAvailable -Name Az.*
        $modules.Count | Should -Be 2
        $modules.Name | Should -Contain 'Az.Accounts'
        $modules.Name | Should -Contain 'Az.Storage'
        #should also check error output   
    }

    It 'InstallAllGA' {
        $output = Install-AzModule -Repository PSGallery -UseExactAccountVersion -RequiredAzVersion 6.3
        $azModule = Find-Module -Name Az -Repository PSGallery -RequiredVersion 6.3
        $output.Count | Should -Be $azModule.Dependencies.Count
        $modules = Get-Module -ListAvailable -Name Az.*
        $modules.Count | Should -Be $azModule.Dependencies.Count
        $expectedVersion = [Version] ($azModule.Dependencies | Where-Object {$_.Name -eq 'Az.Accounts'})['MinimumVersion']
        ($modules | Where-Object {$_.Name -eq 'Az.Accounts'}).Version | Should -Be $expectedVersion
    }

    It 'InstallByUnexistingName' {
        $output = Install-AzModule -Name fakeModule -Repository PSGallery
        $output.Count | Should -Be 0
        $modules = Get-Module -ListAvailable -Name Az.*
        $modules.Count | Should -Be 0
        #should also check error output    
    }

    It 'InstallAndRemoveAzureRm' {
        Install-Module -Name AzureRm -Repository PSGallery
        $output = Install-AzModule -Name accounts -Repository PSGallery -RemoveAzureRm
        $output.Count | Should -Be 1
        $modules = Get-Module -ListAvailable -Name Az.*
        $modules.Count | Should -Be 1
        (Get-InstalledModule -Name Azure* -ErrorAction Stop).Name | Should -Be $null
    }

    It 'InstallByUnexistingVersion' {
        {Install-AzModule -AllowPrerelease -Repository PSGallery -RequiredAzVersion 5.9} | Should -Throw
    }

    AfterEach {
        Remove-AllAzModule       
    }
}