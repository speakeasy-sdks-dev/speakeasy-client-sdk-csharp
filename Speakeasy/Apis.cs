
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Apis
{
    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Speakeasy.Models.Apis;
using Speakeasy.Models.Shared;
using Speakeasy.Utils;

    public interface IApisSDK
    {
        Task<DeleteApiResponse> DeleteApiAsync(DeleteApiRequest? request = null);
        Task<GenerateOpenApiSpecResponse> GenerateOpenApiSpecAsync(GenerateOpenApiSpecRequest? request = null);
        Task<GeneratePostmanCollectionResponse> GeneratePostmanCollectionAsync(GeneratePostmanCollectionRequest? request = null);
        Task<GetAllApiVersionsResponse> GetAllApiVersionsAsync(GetAllApiVersionsRequest? request = null);
        Task<GetApisResponse> GetApisAsync(GetApisRequest? request = null);
        Task<UpsertApiResponse> UpsertApiAsync(UpsertApiRequest request);
    }

    public class ApisSDK: IApisSDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "1.1.0";
        private const string _sdkGenVersion = "2.62.1";
        private const string _openapiDocVersion = "0.3.0";
        public Uri ServerUrl { get { return _defaultClient.Client.BaseAddress; } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public ApisSDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    /// <summary>
    /// Delete an Api.
    /// 
    /// <remarks>
    /// Delete a particular version of an Api. The will also delete all associated ApiEndpoints, Metadata, Schemas & Request Logs (if using a Postgres datastore).
    /// </remarks>
    /// </summary>
    public async Task<DeleteApiResponse> DeleteApiAsync(DeleteApiRequest? request = null)
    {
        string baseUrl = "";
        var message = DeleteApiRequest.BuildHttpRequestMessage("deleteApi", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new DeleteApiResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Generate an OpenAPI specification for a particular Api.
    /// 
    /// <remarks>
    /// This endpoint will generate any missing operations in any registered OpenAPI document if the operation does not already exist in the document.
    /// Returns the original document and the newly generated document allowing a diff to be performed to see what has changed.
    /// </remarks>
    /// </summary>
    public async Task<GenerateOpenApiSpecResponse> GenerateOpenApiSpecAsync(GenerateOpenApiSpecRequest? request = null)
    {
        string baseUrl = "";
        var message = GenerateOpenApiSpecRequest.BuildHttpRequestMessage("generateOpenApiSpec", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GenerateOpenApiSpecResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GenerateOpenApiSpecDiff = JsonConvert.DeserializeObject<GenerateOpenApiSpecDiff>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Generate a Postman collection for a particular Api.
    /// 
    /// <remarks>
    /// Generates a postman collection containing all endpoints for a particular API. Includes variables produced for any path/query/header parameters included in the OpenAPI document.
    /// </remarks>
    /// </summary>
    public async Task<GeneratePostmanCollectionResponse> GeneratePostmanCollectionAsync(GeneratePostmanCollectionRequest? request = null)
    {
        string baseUrl = "";
        var message = GeneratePostmanCollectionRequest.BuildHttpRequestMessage("generatePostmanCollection", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GeneratePostmanCollectionResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/octet-stream",response.ContentType))
            {
                response.PostmanCollection = await response.RawResponse.Content.ReadAsByteArrayAsync();
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get all Api versions for a particular ApiEndpoint.
    /// 
    /// <remarks>
    /// Get all Api versions for a particular ApiEndpoint.
    /// Supports filtering the versions based on metadata attributes.
    /// </remarks>
    /// </summary>
    public async Task<GetAllApiVersionsResponse> GetAllApiVersionsAsync(GetAllApiVersionsRequest? request = null)
    {
        string baseUrl = "";
        var message = GetAllApiVersionsRequest.BuildHttpRequestMessage("getAllApiVersions", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetAllApiVersionsResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Apis = JsonConvert.DeserializeObject<List<Api>>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Get a list of Apis for a given workspace
    /// 
    /// <remarks>
    /// Get a list of all Apis and their versions for a given workspace.
    /// Supports filtering the APIs based on metadata attributes.
    /// </remarks>
    /// </summary>
    public async Task<GetApisResponse> GetApisAsync(GetApisRequest? request = null)
    {
        string baseUrl = "";
        var message = GetApisRequest.BuildHttpRequestMessage("getApis", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new GetApisResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Apis = JsonConvert.DeserializeObject<List<Api>>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    /// <summary>
    /// Upsert an Api
    /// 
    /// <remarks>
    /// Upsert an Api. If the Api does not exist, it will be created.
    /// If the Api exists, it will be updated.
    /// </remarks>
    /// </summary>
    public async Task<UpsertApiResponse> UpsertApiAsync(UpsertApiRequest request)
    {
        string baseUrl = "";
        var message = UpsertApiRequest.BuildHttpRequestMessage("upsertApi", request, baseUrl);
        var client = _securityClient;

        message.Headers.Add("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var response = new UpsertApiResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Api = JsonConvert.DeserializeObject<Api>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        response.Error = JsonConvert.DeserializeObject<Error>(await httpResponseMessage.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
        return response;
    }

        
    }
}