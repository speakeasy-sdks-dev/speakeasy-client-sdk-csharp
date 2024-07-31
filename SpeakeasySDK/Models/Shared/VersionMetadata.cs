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
    /// A set of keys and associated values, attached to a particular version of an Api.
    /// </summary>
    public class VersionMetadata
    {

        /// <summary>
        /// The ID of the Api this Metadata belongs to.
        /// </summary>
        [JsonProperty("api_id")]
        public string ApiId { get; set; } = default!;

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The key for this metadata.
        /// </summary>
        [JsonProperty("meta_key")]
        public string MetaKey { get; set; } = default!;

        /// <summary>
        /// One of the values for this metadata.
        /// </summary>
        [JsonProperty("meta_value")]
        public string MetaValue { get; set; } = default!;

        /// <summary>
        /// The version ID of the Api this Metadata belongs to.
        /// </summary>
        [JsonProperty("version_id")]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// The workspace ID this Metadata belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; } = default!;
    }
}