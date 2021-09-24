// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.Storage.Version2019_06_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Dimension of blobs, possibly be blob type or access tier.
    /// </summary>
    public partial class Dimension
    {
        /// <summary>
        /// Initializes a new instance of the Dimension class.
        /// </summary>
        public Dimension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dimension class.
        /// </summary>
        /// <param name="name">Display name of dimension.</param>
        /// <param name="displayName">Display name of dimension.</param>
        public Dimension(string name = default(string), string displayName = default(string))
        {
            Name = name;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of dimension.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets display name of dimension.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
