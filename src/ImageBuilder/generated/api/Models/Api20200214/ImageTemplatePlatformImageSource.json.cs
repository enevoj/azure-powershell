namespace Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Extensions;

    /// <summary>
    /// Describes an image source from [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
    /// </summary>
    public partial class ImageTemplatePlatformImageSource
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.IImageTemplatePlatformImageSource.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.IImageTemplatePlatformImageSource.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.IImageTemplatePlatformImageSource FromJson(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject json ? new ImageTemplatePlatformImageSource(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject into a new instance of <see cref="ImageTemplatePlatformImageSource" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ImageTemplatePlatformImageSource(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __imageTemplateSource = new Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.ImageTemplateSource(json);
            {_planInfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject>("planInfo"), out var __jsonPlanInfo) ? Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Models.Api20200214.PlatformImagePurchasePlan.FromJson(__jsonPlanInfo) : PlanInfo;}
            {_publisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonString>("publisher"), out var __jsonPublisher) ? (string)__jsonPublisher : (string)Publisher;}
            {_offer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonString>("offer"), out var __jsonOffer) ? (string)__jsonOffer : (string)Offer;}
            {_sku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonString>("sku"), out var __jsonSku) ? (string)__jsonSku : (string)Sku;}
            {_version = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ImageTemplatePlatformImageSource" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ImageTemplatePlatformImageSource" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __imageTemplateSource?.ToJson(container, serializationMode);
            AddIf( null != this._planInfo ? (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode) this._planInfo.ToJson(null,serializationMode) : null, "planInfo" ,container.Add );
            AddIf( null != (((object)this._publisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonString(this._publisher.ToString()) : null, "publisher" ,container.Add );
            AddIf( null != (((object)this._offer)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonString(this._offer.ToString()) : null, "offer" ,container.Add );
            AddIf( null != (((object)this._sku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonString(this._sku.ToString()) : null, "sku" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ImageBuilder.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}