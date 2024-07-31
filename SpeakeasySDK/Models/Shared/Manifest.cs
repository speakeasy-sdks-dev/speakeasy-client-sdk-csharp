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
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    using System.Collections.Generic;
    
    /// <summary>
    /// Returns the requested manifest file
    /// </summary>
    public class Manifest
    {

        /// <summary>
        /// Annotations
        /// </summary>
        [JsonProperty("annotations")]
        public Annotations? Annotations { get; set; }

        /// <summary>
        /// Type of artifact
        /// </summary>
        [JsonProperty("artifactType")]
        public string? ArtifactType { get; set; }

        /// <summary>
        /// List of V2 image layer information
        /// </summary>
        [JsonProperty("layers")]
        public List<V2Descriptor>? Layers { get; set; }

        /// <summary>
        /// Media type usually application/vnd.docker.distribution.manifest.v2+json if this is in the accept header
        /// </summary>
        [JsonProperty("mediaType")]
        public string? MediaType { get; set; }

        /// <summary>
        /// Schema version
        /// </summary>
        [JsonProperty("schemaVersion")]
        public long? SchemaVersion { get; set; }
    }
}