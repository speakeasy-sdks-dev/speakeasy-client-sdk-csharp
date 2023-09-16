
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Shared
{
    using Newtonsoft.Json;
    
    public class SchemaDiffValueChange
    {

        /// <summary>
        /// Represents the previous value of the element.
        /// </summary>
        [JsonProperty("From")]
        public string From { get; set; } = default!;

        /// <summary>
        /// Represents the current value of the element.
        /// </summary>
        [JsonProperty("To")]
        public string To { get; set; } = default!;
    }
}