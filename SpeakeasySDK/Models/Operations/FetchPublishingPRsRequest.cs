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
    using SpeakeasySDK.Utils;
    
    public class FetchPublishingPRsRequest
    {

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=generate_gen_lock_id")]
        public string GenerateGenLockId { get; set; } = default!;

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=org")]
        public string Org { get; set; } = default!;

        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=repo")]
        public string Repo { get; set; } = default!;
    }
}