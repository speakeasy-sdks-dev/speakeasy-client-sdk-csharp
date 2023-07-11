
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Speakeasy.Models.Schemas
{
    using System;
using System.Net.Http;
using Newtonsoft.Json;
using Speakeasy.Utils;
    
    public class RegisterSchemaRequest
    {
    /// <summary>
    /// The schema file to upload provided as a multipart/form-data file segment.
    /// </summary>
        
        [JsonProperty("RequestBody")]
        public RegisterSchemaRequestBody RequestBody { get; set; }
        
    /// <summary>
    /// The ID of the Api to get the schema for.
    /// </summary>
        
        [JsonProperty("apiID")]
        public string ApiID { get; set; }
        
    /// <summary>
    /// The version ID of the Api to delete metadata for.
    /// </summary>
        
        [JsonProperty("versionID")]
        public string VersionID { get; set; }
        
        internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, RegisterSchemaRequest value, string baseUrl)
        {
            if("registerSchema" == operationId)
            {
                
                
                var apiID = PathParamSerializer.Serialize("simple", false, value.ApiID);
                
                var versionID = PathParamSerializer.Serialize("simple", false, value.VersionID);
                var message = new HttpRequestMessage(HttpMethod.Post, baseUrl + $"/v1/apis/{apiID}/version/{versionID}/schema");
                var formDataContent = new MultipartFormDataContent();
                
                formDataContent.Add(new ByteArrayContent(value.RequestBody.File.Content), value.RequestBody.File.File, Utilities.ToString(value.RequestBody.File.Content));

                message.Content = formDataContent;
                return message;
            }
            throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [RegisterSchemaRequest]");
        }
    }
}