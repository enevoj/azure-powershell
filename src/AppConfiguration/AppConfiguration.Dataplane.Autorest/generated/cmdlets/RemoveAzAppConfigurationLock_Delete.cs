// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>Unlocks a key-value.</summary>
    /// <remarks>
    /// [OpenAPI] DeleteLock=>DELETE:"/locks/{key}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Remove, @"AzAppConfigurationLock_Delete", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Description(@"Unlocks a key-value.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Generated]
    public partial class RemoveAzAppConfigurationLock_Delete : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.AppConfiguration Client => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Module.Instance.ClientAPI;

        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private string _endpoint;

        /// <summary>The endpoint of the App Configuration instance to send requests to.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The endpoint of the App Configuration instance to send requests to.")]
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The endpoint of the App Configuration instance to send requests to.",
        SerializedName = @"endpoint",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Uri)]
        public string Endpoint { get => this._endpoint; set => this._endpoint = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="IfMatch" /> property.</summary>
        private string _ifMatch;

        /// <summary>
        /// Used to perform an operation only if the targeted resource's etag matches the value provided.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Used to perform an operation only if the targeted resource's etag matches the value provided.")]
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Used to perform an operation only if the targeted resource's etag matches the value provided.",
        SerializedName = @"If-Match",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Header)]
        public string IfMatch { get => this._ifMatch; set => this._ifMatch = value; }

        /// <summary>Backing field for <see cref="IfNoneMatch" /> property.</summary>
        private string _ifNoneMatch;

        /// <summary>
        /// Used to perform an operation only if the targeted resource's etag does not match the value provided.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Used to perform an operation only if the targeted resource's etag does not match the value provided.")]
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Used to perform an operation only if the targeted resource's etag does not match the value provided.",
        SerializedName = @"If-None-Match",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Header)]
        public string IfNoneMatch { get => this._ifNoneMatch; set => this._ifNoneMatch = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private string _key;

        /// <summary>The key of the key-value to unlock.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The key of the key-value to unlock.")]
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The key of the key-value to unlock.",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Path)]
        public string Key { get => this._key; set => this._key = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        /// <summary>The label, if any, of the key-value to unlock.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The label, if any, of the key-value to unlock.")]
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The label, if any, of the key-value to unlock.",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Query)]
        public string Label { get => this._label; set => this._label = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="SyncToken" /> property.</summary>
        private string _syncToken;

        /// <summary>Used to guarantee real-time consistency between requests.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Used to guarantee real-time consistency between requests.")]
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Used to guarantee real-time consistency between requests.",
        SerializedName = @"Sync-Token",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Category(global::Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.ParameterCategory.Header)]
        public string SyncToken { get => this._syncToken; set => this._syncToken = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IError"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'DeleteLock' operation"))
                {
                    using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.DeleteLock(Endpoint, Key, this.InvocationInformation.BoundParameters.ContainsKey("Label") ? Label : null, this.InvocationInformation.BoundParameters.ContainsKey("SyncToken") ? SyncToken : null, this.InvocationInformation.BoundParameters.ContainsKey("IfMatch") ? IfMatch : null, this.InvocationInformation.BoundParameters.ContainsKey("IfNoneMatch") ? IfNoneMatch : null, onOk, onDefault, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  Endpoint=Endpoint,Key=Key,Label=this.InvocationInformation.BoundParameters.ContainsKey("Label") ? Label : null,SyncToken=this.InvocationInformation.BoundParameters.ContainsKey("SyncToken") ? SyncToken : null,IfMatch=this.InvocationInformation.BoundParameters.ContainsKey("IfMatch") ? IfMatch : null,IfNoneMatch=this.InvocationInformation.BoundParameters.ContainsKey("IfNoneMatch") ? IfNoneMatch : null})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="RemoveAzAppConfigurationLock_Delete" /> cmdlet class.
        /// </summary>
        public RemoveAzAppConfigurationLock_Delete()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IError"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IError> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                // Unrecognized Response. Create an error record based on what we have.
                var ex = new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IError>(responseMessage, await response);
                WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { Endpoint=Endpoint, Key=Key, Label=this.InvocationInformation.BoundParameters.ContainsKey("Label") ? Label : null, SyncToken=this.InvocationInformation.BoundParameters.ContainsKey("SyncToken") ? SyncToken : null, IfMatch=this.InvocationInformation.BoundParameters.ContainsKey("IfMatch") ? IfMatch : null, IfNoneMatch=this.InvocationInformation.BoundParameters.ContainsKey("IfNoneMatch") ? IfNoneMatch : null })
                {
                  ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                });
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/vnd.microsoft.appconfig.kv+json/application/json/application/problem+json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api10.IKeyValue
                WriteObject((await response));
            }
        }
    }
}