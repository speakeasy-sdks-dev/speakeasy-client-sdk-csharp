
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
    using Speakeasy.Utils;
    
    
    public class UpsertApiEndpointRequest
    {
        /// <summary>
        /// A JSON representation of the ApiEndpoint to upsert.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public ApiEndpointInput ApiEndpointInput { get; set; }
        
        /// <summary>
        /// The ID of the ApiEndpoint to upsert.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiEndpointID")]
        public string ApiEndpointID { get; set; }
        
        /// <summary>
        /// The ID of the Api the ApiEndpoint belongs to.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiID")]
        public string ApiID { get; set; }
        
        /// <summary>
        /// The version ID of the Api the ApiEndpoint belongs to.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=versionID")]
        public string VersionID { get; set; }
        
    }
    
}