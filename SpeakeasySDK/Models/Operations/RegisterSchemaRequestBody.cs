
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
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
    
    /// <summary>
    /// The schema file to upload provided as a multipart/form-data file segment.
    /// </summary>
    public class RegisterSchemaRequestBody
    {

        [SpeakeasyMetadata("multipartForm:file")]
        public RegisterSchemaFile File { get; set; } = default!;
    }
}