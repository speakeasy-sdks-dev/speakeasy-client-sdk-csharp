//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK.Models.Shared
{
    using Newtonsoft.Json;
    using SpeakeasySDK.Utils;
    
    /// <summary>
    /// Open generation PRs pending publishing
    /// </summary>
    public class GithubPublishingPRResponse
    {

        [JsonProperty("generation_pull_request")]
        public string? GenerationPullRequest { get; set; }

        [JsonProperty("pending_version")]
        public string? PendingVersion { get; set; }
    }
}