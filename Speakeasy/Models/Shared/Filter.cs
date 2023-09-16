
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
    
    /// <summary>
    /// A filter is a key-value pair that can be used to filter a list of requests.
    /// </summary>
    public class Filter
    {

        /// <summary>
        /// The key of the filter.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The operator of the filter.
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; } = default!;

        /// <summary>
        /// The value of the filter.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; } = default!;
    }
}