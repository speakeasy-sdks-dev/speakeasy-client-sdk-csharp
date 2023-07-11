
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Speakeasy.Models.Apis
{
    using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Speakeasy.Utils;
    
    public class GetApisRequest
    {
    /// <summary>
    /// Metadata to filter Apis on
    /// </summary>
        
        [JsonProperty("metadata")]
        public Dictionary<string, List<string>>? Metadata { get; set; }
        
    /// <summary>
    /// Configuration for filter operations
    /// </summary>
        
        [JsonProperty("op")]
        public GetApisOp? Op { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetApisRequest value, string baseUrl)
        {
            if("getApis" == operationId)
            {
                var queryParams = new List<string>();
                
                queryParams.Add(QueryParamSerializer.Serialize("deepObject",true, "metadata", "", value.Metadata));
                
                queryParams.Add(QueryParamSerializer.Serialize("deepObject",true, "op", "", value.Op));
                var queryParamString = $"?{String.Join("&", queryParams)}";
                var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/v1/apis" + queryParamString);
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetApisRequest]");
        }
    }
}