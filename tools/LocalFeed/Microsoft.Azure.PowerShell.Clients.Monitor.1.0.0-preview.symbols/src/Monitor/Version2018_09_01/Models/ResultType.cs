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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ResultType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultType
    {
        [EnumMember(Value = "Data")]
        Data,
        [EnumMember(Value = "Metadata")]
        Metadata
    }
    internal static class ResultTypeEnumExtension
    {
        internal static string ToSerializedValue(this ResultType? value)
        {
            return value == null ? null : ((ResultType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ResultType value)
        {
            switch( value )
            {
                case ResultType.Data:
                    return "Data";
                case ResultType.Metadata:
                    return "Metadata";
            }
            return null;
        }

        internal static ResultType? ParseResultType(this string value)
        {
            switch( value )
            {
                case "Data":
                    return ResultType.Data;
                case "Metadata":
                    return ResultType.Metadata;
            }
            return null;
        }
    }
}
