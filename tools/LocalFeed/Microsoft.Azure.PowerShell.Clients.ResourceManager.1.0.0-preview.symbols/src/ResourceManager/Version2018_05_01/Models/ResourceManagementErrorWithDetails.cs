// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.ResourceManager.Version2018_05_01.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The detailed error message of resource management.
    /// </summary>
    public partial class ResourceManagementErrorWithDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceManagementErrorWithDetails class.
        /// </summary>
        public ResourceManagementErrorWithDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceManagementErrorWithDetails class.
        /// </summary>
        /// <param name="code">The error code returned when exporting the
        /// template.</param>
        /// <param name="message">The error message describing the export
        /// error.</param>
        /// <param name="target">The target of the error.</param>
        /// <param name="details">Validation error.</param>
        public ResourceManagementErrorWithDetails(string code = default(string), string message = default(string), string target = default(string), IList<ResourceManagementErrorWithDetails> details = default(IList<ResourceManagementErrorWithDetails>))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the error code returned when exporting the template.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the error message describing the export error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the target of the error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; private set; }

        /// <summary>
        /// Gets validation error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ResourceManagementErrorWithDetails> Details { get; private set; }

    }
}
