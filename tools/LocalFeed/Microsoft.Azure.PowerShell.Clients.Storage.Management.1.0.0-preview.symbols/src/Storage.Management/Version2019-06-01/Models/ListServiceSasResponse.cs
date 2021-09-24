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
    /// The List service SAS credentials operation response.
    /// </summary>
    public partial class ListServiceSasResponse
    {
        /// <summary>
        /// Initializes a new instance of the ListServiceSasResponse class.
        /// </summary>
        public ListServiceSasResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListServiceSasResponse class.
        /// </summary>
        /// <param name="serviceSasToken">List service SAS credentials of
        /// specific resource.</param>
        public ListServiceSasResponse(string serviceSasToken = default(string))
        {
            ServiceSasToken = serviceSasToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list service SAS credentials of specific resource.
        /// </summary>
        [JsonProperty(PropertyName = "serviceSasToken")]
        public string ServiceSasToken { get; private set; }

    }
}
