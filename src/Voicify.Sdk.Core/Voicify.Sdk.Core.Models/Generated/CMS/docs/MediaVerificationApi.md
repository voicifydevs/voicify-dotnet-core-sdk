# Voicify.Sdk.Core.Models.Api.MediaVerificationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiMediaVerificationContentItemsMediaItemIdGet**](MediaVerificationApi.md#apimediaverificationcontentitemsmediaitemidget) | **GET** /api/MediaVerification/contentItems/{mediaItemId} | 

<a name="apimediaverificationcontentitemsmediaitemidget"></a>
# **ApiMediaVerificationContentItemsMediaItemIdGet**
> MediaContentItems ApiMediaVerificationContentItemsMediaItemIdGet (string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaVerificationContentItemsMediaItemIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: X-Api-Key
            Configuration.Default.AddApiKey("X-Api-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Api-Key", "Bearer");

            var apiInstance = new MediaVerificationApi();
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                MediaContentItems result = apiInstance.ApiMediaVerificationContentItemsMediaItemIdGet(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVerificationApi.ApiMediaVerificationContentItemsMediaItemIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 

### Return type

[**MediaContentItems**](MediaContentItems.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
