﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.LogicApp.Cmdlets
{
    using System;
    using System.Globalization;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.LogicApp.Utilities;
    using Microsoft.Azure.Management.Logic.Models;
    using ResourceManager.Common.ArgumentCompleters;

    /// <summary>
    /// Update the integration account partner.
    /// </summary>
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "IntegrationAccountPartner", SupportsShouldProcess = true)]
    [OutputType(typeof(IntegrationAccountPartner))]
    public class UpdateAzureIntegrationAccountPartnerCommand : LogicAppBaseCmdlet
    {

        #region Defaults

        /// <summary>
        /// Default partner type.
        /// </summary>
        private string partnerType = "B2B";

        #endregion Defaults

        #region Input Parameters

        [Parameter(Mandatory = true, HelpMessage = "The integration account resource group name.",
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The integration account name.",
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        [Alias("IntegrationAccountName", "ResourceName")]
        public string Name { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The integration account partner name.",
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string PartnerName { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The integration account partner type.",
            ValueFromPipelineByPropertyName = false)]
        [ValidateSet("B2B", IgnoreCase = false)]
        [ValidateNotNullOrEmpty]
        public string PartnerType
        {
            get { return this.partnerType; }
            set { value = this.partnerType; }
        }

        [Parameter(Mandatory = false, HelpMessage = "Specifies business identities for the integration account partner. It is a nested array, with inner arrays containing the Qualifier as the first object/string and the Value as the second object/string",
            ValueFromPipelineByPropertyName = false)]
        [ValidateNotNullOrEmpty]
        public object BusinessIdentities { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The integration account partner metadata.",
            ValueFromPipelineByPropertyName = false)]
        [ValidateNotNullOrEmpty]
        public object Metadata { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Do not ask for confirmation.")]
        public SwitchParameter Force { get; set; }

        #endregion Input Parameters

        /// <summary>
        /// Executes the integration account partner update command.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            var integrationAccount = IntegrationAccountClient.GetIntegrationAccount(this.ResourceGroupName, this.Name);

            var integrationAccountPartner = IntegrationAccountClient.GetIntegrationAccountPartner(
                this.ResourceGroupName,
                this.Name, this.PartnerName);

            if (!string.IsNullOrEmpty(this.PartnerType))
            {
                integrationAccountPartner.PartnerType = this.PartnerType;
            }

            if (this.BusinessIdentities != null)
            {
                integrationAccountPartner.Content.B2b.BusinessIdentities =
                    CmdletHelper.ConvertToBusinessIdentityList(this.BusinessIdentities);
            }

            if (this.Metadata != null)
            {
                integrationAccountPartner.Metadata = CmdletHelper.ConvertToMetadataJObject(this.Metadata);
            }

            ConfirmAction(Force.IsPresent,
                string.Format(CultureInfo.InvariantCulture, Properties.Resource.UpdateResourceWarning,
                    "Microsoft.Logic/integrationAccounts/partners", this.Name),
                string.Format(CultureInfo.InvariantCulture, Properties.Resource.UpdateResourceMessage,
                    "Microsoft.Logic/integrationAccounts/partners", this.Name),
                Name,
                () =>
                {
                    this.WriteObject(
                        IntegrationAccountClient.UpdateIntegrationAccountPartner(this.ResourceGroupName,
                            integrationAccount.Name,
                            this.PartnerName,
                            integrationAccountPartner), true);
                },
                null);
        }
    }
}
