namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>The result of a list request.</summary>
    public partial class KeyValueListResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValueListResult,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValueListResultInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Item" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue[] _item;

        /// <summary>The collection value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue[] Item { get => this._item; set => this._item = value; }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URI that can be used to request the next set of paged results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="SyncToken" /> property.</summary>
        private string _syncToken;

        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        public string SyncToken { get => this._syncToken; set => this._syncToken = value; }

        /// <summary>Creates an new <see cref="KeyValueListResult" /> instance.</summary>
        public KeyValueListResult()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Sync-Token", out var __syncTokenHeader))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValueListResultInternal)this).SyncToken = System.Linq.Enumerable.FirstOrDefault(__syncTokenHeader) is string __headerSyncTokenHeader ? __headerSyncTokenHeader : (string)null;
            }
        }
    }
    /// The result of a list request.
    public partial interface IKeyValueListResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>The collection value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection value.",
        SerializedName = @"items",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue[] Item { get; set; }
        /// <summary>The URI that can be used to request the next set of paged results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URI that can be used to request the next set of paged results.",
        SerializedName = @"@nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Sync-Token",
        PossibleTypes = new [] { typeof(string) })]
        string SyncToken { get; set; }

    }
    /// The result of a list request.
    internal partial interface IKeyValueListResultInternal

    {
        /// <summary>The collection value.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue[] Item { get; set; }
        /// <summary>The URI that can be used to request the next set of paged results.</summary>
        string NextLink { get; set; }

        string SyncToken { get; set; }

    }
}