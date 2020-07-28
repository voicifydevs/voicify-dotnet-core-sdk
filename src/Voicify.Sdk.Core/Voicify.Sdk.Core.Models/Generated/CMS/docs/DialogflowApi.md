# IO.Swagger.Api.DialogflowApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandleRequest**](DialogflowApi.md#handlerequest) | **POST** /api/Dialogflow/HandleRequest | Handles a webhook fulfillment request from dialogflow and returns a dialogflow structured response


<a name="handlerequest"></a>
# **HandleRequest**
> DialogflowResponse HandleRequest (string applicationId = null, string applicationSecret = null, ActionRequest request = null)

Handles a webhook fulfillment request from dialogflow and returns a dialogflow structured response

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

            var apiInstance = new DialogflowApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var request = new ActionRequest(); // ActionRequest |  (optional) 

            try
            {
                // Handles a webhook fulfillment request from dialogflow and returns a dialogflow structured response
                DialogflowResponse result = apiInstance.HandleRequest(applicationId, applicationSecret, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DialogflowApi.HandleRequest: " + e.Message );
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

[**DialogflowResponse**](DialogflowResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

