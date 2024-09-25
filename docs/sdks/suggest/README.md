# Suggest
(*Suggest*)

## Overview

REST APIs for managing LLM OAS suggestions

### Available Operations

* [Suggest](#suggest) - Generate suggestions for improving an OpenAPI document.
* [SuggestOpenAPI](#suggestopenapi) - (DEPRECATED) Generate suggestions for improving an OpenAPI document.
* [SuggestOpenAPIRegistry](#suggestopenapiregistry) - Generate suggestions for improving an OpenAPI document stored in the registry.

## Suggest

Get suggestions from an LLM model for improving an OpenAPI document.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

SuggestRequest req = new SuggestRequest() {
    SuggestRequestBody = new SuggestRequestBody() {
        Diagnostics = new List<Diagnostic>() {
            new Diagnostic() {
                Message = "<value>",
                Path = new List<string>() {
                    "/rescue",
                },
                Type = "<value>",
            },
        },
        OasSummary = new OASSummary() {
            Info = new OASInfo() {
                Description = "kielbasa psst stitcher cannon devoted blindly apropos low",
                License = new License() {},
                Summary = "<value>",
                Title = "<value>",
                Version = "<value>",
            },
            Operations = new List<OASOperation>() {
                new OASOperation() {
                    Description = "via apparatus gray whether opposite what",
                    Method = "<value>",
                    OperationId = "<id>",
                    Path = "/sys",
                    Tags = new List<string>() {
                        "<value>",
                    },
                },
            },
        },
        SuggestionType = SpeakeasySDK.Models.Shared.SuggestRequestBodySuggestionType.MethodNames,
    },
    XSessionId = "<id>",
};

var res = await sdk.Suggest.SuggestAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [SuggestRequest](../../Models/Operations/SuggestRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[SuggestResponse](../../Models/Operations/SuggestResponse.md)**

### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |


## SuggestOpenAPI

Get suggestions from an LLM model for improving an OpenAPI document.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

SuggestOpenAPIRequest req = new SuggestOpenAPIRequest() {
    RequestBody = new SuggestOpenAPIRequestBody() {
        Schema = new Models.Operations.Schema() {
            Content = System.Text.Encoding.UTF8.GetBytes("0x0beEcB7cF6"),
            FileName = "example.file",
        },
    },
    XSessionId = "<id>",
};

var res = await sdk.Suggest.SuggestOpenAPIAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [SuggestOpenAPIRequest](../../Models/Operations/SuggestOpenAPIRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[SuggestOpenAPIResponse](../../Models/Operations/SuggestOpenAPIResponse.md)**

### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |


## SuggestOpenAPIRegistry

Get suggestions from an LLM model for improving an OpenAPI document stored in the registry.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

SuggestOpenAPIRegistryRequest req = new SuggestOpenAPIRegistryRequest() {
    NamespaceName = "<value>",
    RevisionReference = "<value>",
    XSessionId = "<id>",
};

var res = await sdk.Suggest.SuggestOpenAPIRegistryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [SuggestOpenAPIRegistryRequest](../../Models/Operations/SuggestOpenAPIRegistryRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[SuggestOpenAPIRegistryResponse](../../Models/Operations/SuggestOpenAPIRegistryResponse.md)**

### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
