
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
    using System.Net.Http;
using Speakeasy.Models.Shared;
    
    public class GetSchemaRevisionResponse {
        public string? ContentType { get; set; }
        
    /// <summary>
    /// Default error response
    /// </summary>
        public Error? Error { get; set; }
        
    /// <summary>
    /// OK
    /// </summary>
        public Schema? Schema { get; set; }
        
        public int StatusCode { get; set; }
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
}