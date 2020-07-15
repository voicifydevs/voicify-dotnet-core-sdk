# IO.Swagger.Api.BotServiceApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandleActivityRequest**](BotServiceApi.md#handleactivityrequest) | **POST** /api/BotService/HandleActivityRequest | Used for getting the direct activity response rather than having it posted to a full bot service.  This endpoint is useful for testing scenarios as well as adding voicify on top of existing bot framework  servers
[**HandleRequest**](BotServiceApi.md#handlerequest) | **POST** /api/BotService/HandleRequest | Used for handling full Azure Bot Service requests. This endpoint validates against your MS app ID and Secret and will POST back to the activity&#39;s channel with no return type.


<a name="handleactivityrequest"></a>
# **HandleActivityRequest**
> void HandleActivityRequest (string applicationId = null, string applicationSecret = null, Activity activity = null)

Used for getting the direct activity response rather than having it posted to a full bot service.  This endpoint is useful for testing scenarios as well as adding voicify on top of existing bot framework  servers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleActivityRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BotServiceApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var activity = new Activity(); // Activity |  (optional) 

            try
            {
                // Used for getting the direct activity response rather than having it posted to a full bot service.  This endpoint is useful for testing scenarios as well as adding voicify on top of existing bot framework  servers
                apiInstance.HandleActivityRequest(applicationId, applicationSecret, activity);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BotServiceApi.HandleActivityRequest: " + e.Message );
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
 **activity** | [**Activity**](Activity.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlerequest"></a>
# **HandleRequest**
> void HandleRequest (string applicationId = null, string applicationSecret = null, string nluTool = null)

Used for handling full Azure Bot Service requests. This endpoint validates against your MS app ID and Secret and will POST back to the activity's channel with no return type.

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

            var apiInstance = new BotServiceApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var nluTool = nluTool_example;  // string |  (optional) 

            try
            {
                // Used for handling full Azure Bot Service requests. This endpoint validates against your MS app ID and Secret and will POST back to the activity's channel with no return type.
                apiInstance.HandleRequest(applicationId, applicationSecret, nluTool);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BotServiceApi.HandleRequest: " + e.Message );
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
 **nluTool** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

