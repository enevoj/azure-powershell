// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Graph.RBAC.Version1_6_20190326.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request parameters for a PasswordCredentials update operation.
    /// </summary>
    public partial class PasswordCredentialsUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PasswordCredentialsUpdateParameters class.
        /// </summary>
        public PasswordCredentialsUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PasswordCredentialsUpdateParameters class.
        /// </summary>
        /// <param name="value">A collection of PasswordCredentials.</param>
        public PasswordCredentialsUpdateParameters(IList<PasswordCredential> value)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of PasswordCredentials.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PasswordCredential> Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
