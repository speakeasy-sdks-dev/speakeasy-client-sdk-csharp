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
    
    public class GetOASSummaryRequest
    {

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=namespace_name")]
        public string NamespaceName { get; set; } = default!;

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=revision_reference")]
        public string RevisionReference { get; set; } = default!;
    }
}