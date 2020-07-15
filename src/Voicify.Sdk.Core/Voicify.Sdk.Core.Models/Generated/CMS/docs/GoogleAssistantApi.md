# IO.Swagger.Api.GoogleAssistantApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandleRequest**](GoogleAssistantApi.md#handlerequest) | **POST** /api/GoogleAssistant/HandleRequest | Deprecated - use Dialogflow endpoints


<a name="handlerequest"></a>
# **HandleRequest**
> void HandleRequest (string applicationId = null, string applicationSecret = null, ActionRequest request = null)

Deprecated - use Dialogflow endpoints

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GoogleAssistantApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var request = new ActionRequest(); // ActionRequest |  (optional) 

            try
            {
                // Deprecated - use Dialogflow endpoints
                apiInstance.HandleRequest(applicationId, applicationSecret, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GoogleAssistantApi.HandleRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **request** | [**ActionRequest**](ActionRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

