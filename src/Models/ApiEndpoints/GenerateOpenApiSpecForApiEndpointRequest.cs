
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Speakeasy.Models.ApiEndpoints
{
    using System;
using System.Net.Http;
using Newtonsoft.Json;
using Speakeasy.Utils;
    
    public class GenerateOpenApiSpecForApiEndpointRequest
    {
    /// <summary>
    /// The ID of the ApiEndpoint to generate an OpenAPI specification for.
    /// </summary>
        
        [JsonProperty("apiEndpointID")]
        public string ApiEndpointID { get; set; }
        
    /// <summary>
    /// The ID of the Api to generate an OpenAPI specification for.
    /// </summary>
        
        [JsonProperty("apiID")]
        public string ApiID { get; set; }
        
    /// <summary>
    /// The version ID of the Api to generate an OpenAPI specification for.
    /// </summary>
        
        [JsonProperty("versionID")]
        public string VersionID { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GenerateOpenApiSpecForApiEndpointRequest value, string baseUrl)
        {
            if("generateOpenApiSpecForApiEndpoint" == operationId)
            {
                
                var apiEndpointID = PathParamSerializer.Serialize("simple", false, value.ApiEndpointID);
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                
                var versionID = PathParamSerializer.Serialize("simple", false, value.VersionID);
                var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"/v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID}/generate/openapi");
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GenerateOpenApiSpecForApiEndpointRequest]");
        }
    }
}