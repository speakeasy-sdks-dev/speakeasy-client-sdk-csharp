
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
    using Speakeasy.Utils;
    
    public class GetAllApiEndpointsRequest
    {

        /// <summary>
        /// The ID of the Api to retrieve ApiEndpoints for.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=apiID")]
        public string ApiID { get; set; } = default!;
    }
}