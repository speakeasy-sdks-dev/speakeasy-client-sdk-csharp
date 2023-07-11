
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Speakeasy.Models.Shared
{
    using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Speakeasy.Models.Shared;
    
/// <summary>
/// A BoundedRequest is a request that has been logged by the Speakeasy without the contents of the request.
/// </summary>
    public class BoundedRequest
    {
    /// <summary>
    /// The ID of the ApiEndpoint this request was made to.
    /// </summary>
        
        [JsonProperty("api_endpoint_id")]
        public string ApiEndpointId { get; set; }
        
    /// <summary>
    /// The ID of the Api this request was made to.
    /// </summary>
        
        [JsonProperty("api_id")]
        public string ApiId { get; set; }
        
    /// <summary>
    /// Creation timestamp.
    /// </summary>
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
    /// <summary>
    /// The ID of the customer that made this request.
    /// </summary>
        
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }
        
    /// <summary>
    /// The latency of the request.
    /// </summary>
        
        [JsonProperty("latency")]
        public int Latency { get; set; }
        
    /// <summary>
    /// Metadata associated with this request
    /// </summary>
        
        [JsonProperty("metadata")]
        public List<RequestMetadata>? Metadata { get; set; }
        
    /// <summary>
    /// HTTP verb.
    /// </summary>
        
        [JsonProperty("method")]
        public string Method { get; set; }
        
    /// <summary>
    /// The path of the request.
    /// </summary>
        
        [JsonProperty("path")]
        public string Path { get; set; }
        
    /// <summary>
    /// The time the request finished.
    /// </summary>
        
        [JsonProperty("request_finish_time")]
        public DateTime RequestFinishTime { get; set; }
        
    /// <summary>
    /// The ID of this request.
    /// </summary>
        
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
        
    /// <summary>
    /// The time the request was made.
    /// </summary>
        
        [JsonProperty("request_start_time")]
        public DateTime RequestStartTime { get; set; }
        
    /// <summary>
    /// The status code of the request.
    /// </summary>
        
        [JsonProperty("status")]
        public int Status { get; set; }
        
    /// <summary>
    /// The version ID of the Api this request was made to.
    /// </summary>
        
        [JsonProperty("version_id")]
        public string VersionId { get; set; }
        
    /// <summary>
    /// The workspace ID this request was made to.
    /// </summary>
        
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }
        
    }
}