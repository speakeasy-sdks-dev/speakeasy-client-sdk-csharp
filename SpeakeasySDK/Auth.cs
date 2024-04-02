
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasySDK
{
    using Newtonsoft.Json;
    using SpeakeasySDK.Models.Errors;
    using SpeakeasySDK.Models.Operations;
    using SpeakeasySDK.Models.Shared;
    using SpeakeasySDK.Utils;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// REST APIs for managing Authentication
    /// </summary>
    public interface IAuth
    {

        /// <summary>
        /// Get or refresh an access token for the current workspace.
        /// </summary>
        Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request);

        /// <summary>
        /// Get information about the current user.
        /// </summary>
        Task<GetUserResponse> GetUserAsync();

        /// <summary>
        /// Get access allowances for a particular workspace
        /// 
        /// <remarks>
        /// Checks if generation is permitted for a particular run of the CLI
        /// </remarks>
        /// </summary>
        Task<GetWorkspaceAccessResponse> GetWorkspaceAccessAsync(GetWorkspaceAccessRequest request);

        /// <summary>
        /// Validate the current api key.
        /// </summary>
        Task<ValidateApiKeyResponse> ValidateApiKeyAsync();
    }

    /// <summary>
    /// REST APIs for managing Authentication
    /// </summary>
    public class Auth: IAuth
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.3.0";
        private const string _sdkGenVersion = "2.295.1";
        private const string _openapiDocVersion = "0.4.0";
        private const string _userAgent = "speakeasy-sdk/csharp 5.3.0 2.295.1 0.4.0 SpeakeasySDK";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Auth(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/v1/auth/access_token", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new GetAccessTokenResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<AccessToken>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.AccessToken = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            else if (response.StatusCode >= 400 && response.StatusCode < 500 || response.StatusCode >= 500 && response.StatusCode < 600)
            {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);

            }
            else
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<Error>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.Error = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            return response;
        }


        public async Task<GetUserResponse> GetUserAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/v1/user";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new GetUserResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<User>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.User = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            else if (response.StatusCode >= 400 && response.StatusCode < 500 || response.StatusCode >= 500 && response.StatusCode < 600)
            {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);

            }
            else
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<Error>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.Error = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            return response;
        }


        public async Task<GetWorkspaceAccessResponse> GetWorkspaceAccessAsync(GetWorkspaceAccessRequest request)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/v1/workspace/access", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new GetWorkspaceAccessResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<AccessDetails>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.AccessDetails = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            else if (response.StatusCode >= 400 && response.StatusCode < 500 || response.StatusCode >= 500 && response.StatusCode < 600)
            {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);

            }
            else
            {
                throw new SDKException("unknown status code received", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            return response;
        }


        public async Task<ValidateApiKeyResponse> ValidateApiKeyAsync()
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();

            var urlString = baseUrl + "/v1/auth/validate";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            var response = new ValidateApiKeyResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if (response.StatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<ApiKeyDetails>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.ApiKeyDetails = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            else if (response.StatusCode >= 400 && response.StatusCode < 500 || response.StatusCode >= 500 && response.StatusCode < 600)
            {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);

            }
            else
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {                    
                    var obj = ResponseBodyDeserializer.Deserialize<Error>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    response.Error = obj;
                }
                else
                {
                throw new SDKException("API error occurred", (int)httpResponse.StatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
                }

            }
            return response;
        }

    }
}