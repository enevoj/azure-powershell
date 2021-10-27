// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>A List of databases.</summary>
    public partial class DatabaseListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201.IDatabaseListResult,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201.IDatabaseListResultInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201.IDatabase[] _value;

        /// <summary>The list of databases housed in a server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201.IDatabase[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DatabaseListResult" /> instance.</summary>
        public DatabaseListResult()
        {

        }
    }
    /// A List of databases.
    public partial interface IDatabaseListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The list of databases housed in a server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of databases housed in a server",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201.IDatabase) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201.IDatabase[] Value { get; set; }

    }
    /// A List of databases.
    internal partial interface IDatabaseListResultInternal

    {
        /// <summary>The list of databases housed in a server</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20171201.IDatabase[] Value { get; set; }

    }
}