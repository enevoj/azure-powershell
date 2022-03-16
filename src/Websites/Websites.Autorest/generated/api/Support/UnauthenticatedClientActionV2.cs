// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Support
{

    /// <summary>The action to take when an unauthenticated client attempts to access the app.</summary>
    public partial struct UnauthenticatedClientActionV2 :
        System.IEquatable<UnauthenticatedClientActionV2>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 AllowAnonymous = @"AllowAnonymous";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 RedirectToLoginPage = @"RedirectToLoginPage";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 Return401 = @"Return401";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 Return403 = @"Return403";

        /// <summary>
        /// the value for an instance of the <see cref="UnauthenticatedClientActionV2" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to UnauthenticatedClientActionV2</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UnauthenticatedClientActionV2" />.</param>
        internal static object CreateFrom(object value)
        {
            return new UnauthenticatedClientActionV2(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type UnauthenticatedClientActionV2</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type UnauthenticatedClientActionV2 (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is UnauthenticatedClientActionV2 && Equals((UnauthenticatedClientActionV2)obj);
        }

        /// <summary>Returns hashCode for enum UnauthenticatedClientActionV2</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for UnauthenticatedClientActionV2</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="UnauthenticatedClientActionV2" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private UnauthenticatedClientActionV2(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to UnauthenticatedClientActionV2</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UnauthenticatedClientActionV2" />.</param>

        public static implicit operator UnauthenticatedClientActionV2(string value)
        {
            return new UnauthenticatedClientActionV2(value);
        }

        /// <summary>Implicit operator to convert UnauthenticatedClientActionV2 to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="UnauthenticatedClientActionV2" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum UnauthenticatedClientActionV2</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 e1, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum UnauthenticatedClientActionV2</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 e1, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.UnauthenticatedClientActionV2 e2)
        {
            return e2.Equals(e1);
        }
    }
}