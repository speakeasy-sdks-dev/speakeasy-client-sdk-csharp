
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
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
    
    public class Tag
    {

        /// <summary>
        /// Format {namespace_id}/{tag}
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Human readable tag name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        [JsonProperty("namespace_name")]
        public string NamespaceName { get; set; } = default!;

        [JsonProperty("revision_digest")]
        public string RevisionDigest { get; set; } = default!;
    }
}