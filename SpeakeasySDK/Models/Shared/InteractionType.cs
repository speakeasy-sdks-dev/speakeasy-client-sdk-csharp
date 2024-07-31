//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Shared
{
    using Newtonsoft.Json;
    using SpeakeasySDK.Utils;
    using System;
    
    /// <summary>
    /// Type of interaction.
    /// </summary>
    public enum InteractionType
    {
        [JsonProperty("CI_EXEC")]
        CiExec,
        [JsonProperty("CLI_EXEC")]
        CliExec,
        [JsonProperty("LINT")]
        Lint,
        [JsonProperty("OPENAPI_DIFF")]
        OpenapiDiff,
        [JsonProperty("TARGET_GENERATE")]
        TargetGenerate,
        [JsonProperty("TOMBSTONE")]
        Tombstone,
        [JsonProperty("AUTHENTICATE")]
        Authenticate,
        [JsonProperty("QUICKSTART")]
        Quickstart,
        [JsonProperty("RUN")]
        Run,
        [JsonProperty("CONFIGURE")]
        Configure,
        [JsonProperty("PUBLISH")]
        Publish,
    }

    public static class InteractionTypeExtension
    {
        public static string Value(this InteractionType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static InteractionType ToEnum(this string value)
        {
            foreach(var field in typeof(InteractionType).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is InteractionType)
                    {
                        return (InteractionType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum InteractionType");
        }
    }

}