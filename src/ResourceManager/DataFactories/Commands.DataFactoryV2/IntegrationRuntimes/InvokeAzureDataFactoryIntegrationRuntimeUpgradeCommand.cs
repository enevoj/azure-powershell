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

using System;
using System.Globalization;
using System.Management.Automation;
using System.Security.Permissions;
using Microsoft.Azure.Commands.DataFactoryV2.Properties;

namespace Microsoft.Azure.Commands.DataFactoryV2
{
    [Cmdlet(
        VerbsLifecycle.Invoke,
        Constants.IntegrationRuntimeUpgrade,
        DefaultParameterSetName = ParameterSetNames.ByIntegrationRuntimeName,
        SupportsShouldProcess = true)]
    public class InvokeAzureDataFactoryIntegrationRuntimeUpgradeCommand : IntegrationRuntimeCmdlet
    {
        [Parameter(
            Mandatory = false,
            HelpMessage = Constants.HelpDontAskConfirmation)]
        public SwitchParameter Force { get; set; }

        [EnvironmentPermission(SecurityAction.Demand, Unrestricted = true)]
        public override void ExecuteCmdlet()
        {
            this.ByResourceId();
            this.ByIntegrationRuntimeObject();

            Action upgradeIntegrationRuntime = () =>
            {
                this.DataFactoryClient.UpgradeIntegrationRuntimeAsync(
                    ResourceGroupName,
                    DataFactoryName,
                    Name).ConfigureAwait(true).GetAwaiter().GetResult();
            };

            ConfirmAction(
                Force.IsPresent,
                string.Format(
                    CultureInfo.InvariantCulture,
                    Resources.IntegrationRuntimeUpgrade,
                    Name),
                string.Format(
                    CultureInfo.InvariantCulture,
                    Resources.IntegrationRuntimeUpgrading,
                    Name),
                Name,
                upgradeIntegrationRuntime);
        }
    }
}
