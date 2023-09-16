
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// A Schema represents an API schema for a particular Api and Version.
    /// </summary>
    public class Schema
    {

        /// <summary>
        /// The ID of the Api this Schema belongs to.
        /// </summary>
        [JsonProperty("api_id")]
        public string ApiId { get; set; } = default!;

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// A detailed description of the Schema.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// An ID referencing this particular revision of the Schema.
        /// </summary>
        [JsonProperty("revision_id")]
        public string RevisionId { get; set; } = default!;

        /// <summary>
        /// The version ID of the Api this Schema belongs to.
        /// </summary>
        [JsonProperty("version_id")]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// The workspace ID this Schema belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; } = default!;
    }
}