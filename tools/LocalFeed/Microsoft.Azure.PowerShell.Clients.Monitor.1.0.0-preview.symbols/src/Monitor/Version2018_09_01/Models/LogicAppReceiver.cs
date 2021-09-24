// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A logic app receiver.
    /// </summary>
    public partial class LogicAppReceiver
    {
        /// <summary>
        /// Initializes a new instance of the LogicAppReceiver class.
        /// </summary>
        public LogicAppReceiver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogicAppReceiver class.
        /// </summary>
        /// <param name="name">The name of the logic app receiver. Names must
        /// be unique across all receivers within an action group.</param>
        /// <param name="resourceId">The azure resource id of the logic app
        /// receiver.</param>
        /// <param name="callbackUrl">The callback url where http request sent
        /// to.</param>
        public LogicAppReceiver(string name, string resourceId, string callbackUrl)
        {
            Name = name;
            ResourceId = resourceId;
            CallbackUrl = callbackUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the logic app receiver. Names must be
        /// unique across all receivers within an action group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the azure resource id of the logic app receiver.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the callback url where http request sent to.
        /// </summary>
        [JsonProperty(PropertyName = "callbackUrl")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
            if (CallbackUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CallbackUrl");
            }
        }
    }
}
