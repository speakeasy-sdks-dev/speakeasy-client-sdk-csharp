
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Operations
{
    using Speakeasy.Models.Shared;
    using System.Net.Http;
    using System;
    
    
    public class UpsertApiEndpointResponse
    {
        /// <summary>
        /// OK
        /// </summary>
        
        public ApiEndpoint? ApiEndpoint { get; set; }
        
        
        public string? ContentType { get; set; }
        
        /// <summary>
        /// Default error response
        /// </summary>
        
        public Error? Error { get; set; }
        
        
        public int StatusCode { get; set; }
        
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
    
}