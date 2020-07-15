# IO.Swagger.Api.CustomAssistantApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandleRequest**](CustomAssistantApi.md#handlerequest) | **POST** /api/CustomAssistant/HandleRequest | Handles requests from a custom assistant. You can optionally pass in pre-processed and aligned NLU data or let Voicify handle it behind the scenes.


<a name="handlerequest"></a>
# **HandleRequest**
> CustomAssistantResponse HandleRequest (string applicationId = null, string applicationSecret = null, CustomAssistantRequestBody model = null)

Handles requests from a custom assistant. You can optionally pass in pre-processed and aligned NLU data or let Voicify handle it behind the scenes.

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

            var apiInstance = new CustomAssistantApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new CustomAssistantRequestBody(); // CustomAssistantRequestBody |  (optional) 

            try
            {
                // Handles requests from a custom assistant. You can optionally pass in pre-processed and aligned NLU data or let Voicify handle it behind the scenes.
                CustomAssistantResponse result = apiInstance.HandleRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomAssistantApi.HandleRequest: " + e.Message );
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
 **model** | [**CustomAssistantRequestBody**](CustomAssistantRequestBody.md)|  | [optional] 

### Return type

[**CustomAssistantResponse**](CustomAssistantResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

