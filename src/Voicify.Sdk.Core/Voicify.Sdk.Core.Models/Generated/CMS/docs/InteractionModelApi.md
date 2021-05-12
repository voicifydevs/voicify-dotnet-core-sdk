# Voicify.Sdk.Core.Models.Api.InteractionModelApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiInteractionModelApplicationIdGet**](InteractionModelApi.md#apiinteractionmodelapplicationidget) | **GET** /api/InteractionModel/{applicationId} | 
[**ApiInteractionModelApplicationIdLocalePut**](InteractionModelApi.md#apiinteractionmodelapplicationidlocaleput) | **PUT** /api/InteractionModel/{applicationId}/{locale} | 
[**ApiInteractionModelApplicationIdStatusGet**](InteractionModelApi.md#apiinteractionmodelapplicationidstatusget) | **GET** /api/InteractionModel/{applicationId}/status | 
[**ApiInteractionModelGet**](InteractionModelApi.md#apiinteractionmodelget) | **GET** /api/InteractionModel | 

<a name="apiinteractionmodelapplicationidget"></a>
# **ApiInteractionModelApplicationIdGet**
> InteractionModel ApiInteractionModelApplicationIdGet (string applicationId, string locale = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiInteractionModelApplicationIdGetExample
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

            var apiInstance = new InteractionModelApi();
            var applicationId = applicationId_example;  // string | 
            var locale = locale_example;  // string |  (optional)  (default to en-US)

            try
            {
                InteractionModel result = apiInstance.ApiInteractionModelApplicationIdGet(applicationId, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionModelApi.ApiInteractionModelApplicationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **locale** | **string**|  | [optional] [default to en-US]

### Return type

[**InteractionModel**](InteractionModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiinteractionmodelapplicationidlocaleput"></a>
# **ApiInteractionModelApplicationIdLocalePut**
> bool? ApiInteractionModelApplicationIdLocalePut (string applicationId, string locale, InteractionModelUpdate body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiInteractionModelApplicationIdLocalePutExample
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

            var apiInstance = new InteractionModelApi();
            var applicationId = applicationId_example;  // string | 
            var locale = locale_example;  // string | 
            var body = new InteractionModelUpdate(); // InteractionModelUpdate |  (optional) 

            try
            {
                bool? result = apiInstance.ApiInteractionModelApplicationIdLocalePut(applicationId, locale, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionModelApi.ApiInteractionModelApplicationIdLocalePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **locale** | **string**|  | 
 **body** | [**InteractionModelUpdate**](InteractionModelUpdate.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiinteractionmodelapplicationidstatusget"></a>
# **ApiInteractionModelApplicationIdStatusGet**
> InteractionModelStatus ApiInteractionModelApplicationIdStatusGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiInteractionModelApplicationIdStatusGetExample
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

            var apiInstance = new InteractionModelApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                InteractionModelStatus result = apiInstance.ApiInteractionModelApplicationIdStatusGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionModelApi.ApiInteractionModelApplicationIdStatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 

### Return type

[**InteractionModelStatus**](InteractionModelStatus.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiinteractionmodelget"></a>
# **ApiInteractionModelGet**
> InteractionModel ApiInteractionModelGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiInteractionModelGetExample
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

            var apiInstance = new InteractionModelApi();

            try
            {
                InteractionModel result = apiInstance.ApiInteractionModelGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionModelApi.ApiInteractionModelGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InteractionModel**](InteractionModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
