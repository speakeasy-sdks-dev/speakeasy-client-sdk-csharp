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
    using System.Collections.Generic;
    
    public class OASOperation
    {

        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        [JsonProperty("method")]
        public string Method { get; set; } = default!;

        [JsonProperty("operation_id")]
        public string OperationId { get; set; } = default!;

        [JsonProperty("path")]
        public string Path { get; set; } = default!;

        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = default!;
    }
}