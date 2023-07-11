
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
using Newtonsoft.Json;
    
/// <summary>
/// An UnboundedRequest represents the HAR content capture by Speakeasy when logging a request.
/// </summary>
    public class UnboundedRequest
    {
    /// <summary>
    /// Creation timestamp.
    /// </summary>
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        
    /// <summary>
    /// The HAR content of the request.
    /// </summary>
        
        [JsonProperty("har")]
        public string Har { get; set; }
        
    /// <summary>
    /// The size of the HAR content in bytes.
    /// </summary>
        
        [JsonProperty("har_size_bytes")]
        public int HarSizeBytes { get; set; }
        
    /// <summary>
    /// The ID of this request.
    /// </summary>
        
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
        
    /// <summary>
    /// The workspace ID this request was made to.
    /// </summary>
        
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }
        
    }
}