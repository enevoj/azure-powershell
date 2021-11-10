//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SnapshotUpdateConfig", SupportsShouldProcess = true)]
    [OutputType(typeof(PSSnapshotUpdate))]
    public partial class NewAzureRmSnapshotUpdateConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [Alias("AccountType")]
        [PSArgumentCompleter("Standard_LRS", "Premium_LRS", "Standard_ZRS")]
        public string SkuName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public OperatingSystemTypes? OsType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public int DiskSizeGB { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Specify if Disk Supports Hibernation with $true of $false")]
        public bool? SupportsHibernation { get; set; }


        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public bool? EncryptionSettingsEnabled { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndSecretReference DiskEncryptionKey { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public KeyVaultAndKeyReference KeyEncryptionKey { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string DiskEncryptionSetId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("EncryptionAtRestWithPlatformKey", "EncryptionAtRestWithCustomerKey")]
        public string EncryptionType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "")]
        [PSArgumentCompleter("Enabled", "Disabled")]
        public string PublicNetworkAccess { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "")]
        public bool? AcceleratedNetwork { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("SnapshotUpdate", "New"))
            {
                Run();
            }
        }

        private void Run()
        {
            // EncryptionSettingsCollection
            EncryptionSettingsCollection vEncryptionSettingsCollection = null;

            // Encryption
            Encryption vEncryption = null;

            // Sku
            SnapshotSku vSku = null;

            // SupportedCapabilities
            SupportedCapabilities vSupportedCapabilities = null;

            if (this.IsParameterBound(c => c.EncryptionSettingsEnabled))
            {
                if (vEncryptionSettingsCollection == null)
                {
                    vEncryptionSettingsCollection = new EncryptionSettingsCollection();
                }
                vEncryptionSettingsCollection.Enabled = (bool) this.EncryptionSettingsEnabled;
            }

            if (this.IsParameterBound(c => c.DiskEncryptionKey))
            {
                if (vEncryptionSettingsCollection == null)
                {
                    vEncryptionSettingsCollection = new EncryptionSettingsCollection();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings == null)
                {
                    vEncryptionSettingsCollection.EncryptionSettings = new List<EncryptionSettingsElement>();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings.Count == 0)
                {
                    vEncryptionSettingsCollection.EncryptionSettings.Add(new EncryptionSettingsElement());
                }
                vEncryptionSettingsCollection.EncryptionSettings[0].DiskEncryptionKey = this.DiskEncryptionKey;
            }

            if (this.IsParameterBound(c => c.KeyEncryptionKey))
            {
                if (vEncryptionSettingsCollection == null)
                {
                    vEncryptionSettingsCollection = new EncryptionSettingsCollection();
                }
                if (vEncryptionSettingsCollection.EncryptionSettings == null)
                {
                    vEncryptionSettingsCollection.EncryptionSettings = new List<EncryptionSettingsElement>();
                }

                if (vEncryptionSettingsCollection.EncryptionSettings.Count == 0)
                {
                    vEncryptionSettingsCollection.EncryptionSettings.Add(new EncryptionSettingsElement());
                }
                vEncryptionSettingsCollection.EncryptionSettings[0].KeyEncryptionKey = this.KeyEncryptionKey;
            }

            if (this.IsParameterBound(c => c.DiskEncryptionSetId))
            {
                if (vEncryption == null)
                {
                    vEncryption = new Encryption();
                }
                vEncryption.DiskEncryptionSetId = this.DiskEncryptionSetId;
            }

            if (this.IsParameterBound(c => c.EncryptionType))
            {
                if (vEncryption == null)
                {
                    vEncryption = new Encryption();
                }
                vEncryption.Type = this.EncryptionType;
            }

            if (this.IsParameterBound(c => c.SkuName))
            {
                if (vSku == null)
                {
                    vSku = new SnapshotSku();
                }
                vSku.Name = this.SkuName;
            }

            if (this.IsParameterBound(c => c.AcceleratedNetwork))
            {
                if (vSupportedCapabilities == null)
                {
                    vSupportedCapabilities = new SupportedCapabilities();
                }
                vSupportedCapabilities.AcceleratedNetwork = AcceleratedNetwork;
            }

            var vSnapshotUpdate = new PSSnapshotUpdate
            {
                OsType = this.IsParameterBound(c => c.OsType) ? this.OsType : (OperatingSystemTypes?)null,
                DiskSizeGB = this.IsParameterBound(c => c.DiskSizeGB) ? this.DiskSizeGB : (int?)null,
                Tags = this.IsParameterBound(c => c.Tag) ? this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value) : null,
                EncryptionSettingsCollection = vEncryptionSettingsCollection,
                Encryption = vEncryption,
                Sku = vSku,
                SupportsHibernation = this.IsParameterBound(c => c.SupportsHibernation) ? SupportsHibernation : null,
                SupportedCapabilities = vSupportedCapabilities,
                PublicNetworkAccess = this.IsParameterBound(c => c.PublicNetworkAccess) ? PublicNetworkAccess : null
            };

            WriteObject(vSnapshotUpdate);
        }
    }
}
