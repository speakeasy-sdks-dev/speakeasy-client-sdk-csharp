//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Operations
{
    using SpeakeasySDK.Models.Operations;
    using SpeakeasySDK.Utils;
    
    public class SuggestOperationIDsRequest
    {

        /// <summary>
        /// The schema file to upload provided as a multipart/form-data file segment.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=multipart/form-data")]
        public SuggestOperationIDsRequestBody RequestBody { get; set; } = default!;

        [SpeakeasyMetadata("header:style=simple,explode=false,name=x-session-id")]
        public string XSessionId { get; set; } = default!;

        /// <summary>
        /// Max number of suggestions to request
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public double? Limit { get; set; }
    }
}