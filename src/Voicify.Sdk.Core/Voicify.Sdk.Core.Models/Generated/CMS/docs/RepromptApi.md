# Voicify.Sdk.Core.Models.Api.RepromptApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReprompt**](RepromptApi.md#createreprompt) | **POST** /api/Reprompt/{applicationId} | 
[**DeleteReprompt**](RepromptApi.md#deletereprompt) | **DELETE** /api/Reprompt/{repromptId} | 
[**GetForApplication**](RepromptApi.md#getforapplication) | **GET** /api/Reprompt/{applicationId} | 
[**UpdateReprompt**](RepromptApi.md#updatereprompt) | **PUT** /api/Reprompt | 

<a name="createreprompt"></a>
# **CreateReprompt**
> RepromptModel CreateReprompt (string applicationId, CreateRepromptRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateRepromptExample
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

            var apiInstance = new RepromptApi();
            var applicationId = applicationId_example;  // string | 
            var body = new CreateRepromptRequest(); // CreateRepromptRequest |  (optional) 

            try
            {
                RepromptModel result = apiInstance.CreateReprompt(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepromptApi.CreateReprompt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**CreateRepromptRequest**](CreateRepromptRequest.md)|  | [optional] 

### Return type

[**RepromptModel**](RepromptModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletereprompt"></a>
# **DeleteReprompt**
> RepromptModel DeleteReprompt (string repromptId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteRepromptExample
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

            var apiInstance = new RepromptApi();
            var repromptId = repromptId_example;  // string | 

            try
            {
                RepromptModel result = apiInstance.DeleteReprompt(repromptId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepromptApi.DeleteReprompt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repromptId** | **string**|  | 

### Return type

[**RepromptModel**](RepromptModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getforapplication"></a>
# **GetForApplication**
> List<RepromptModel> GetForApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetForApplicationExample
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

            var apiInstance = new RepromptApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;RepromptModel&gt; result = apiInstance.GetForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepromptApi.GetForApplication: " + e.Message );
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

[**List<RepromptModel>**](RepromptModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatereprompt"></a>
# **UpdateReprompt**
> RepromptModel UpdateReprompt (UpdateRepromptRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateRepromptExample
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

            var apiInstance = new RepromptApi();
            var body = new UpdateRepromptRequest(); // UpdateRepromptRequest |  (optional) 

            try
            {
                RepromptModel result = apiInstance.UpdateReprompt(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepromptApi.UpdateReprompt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateRepromptRequest**](UpdateRepromptRequest.md)|  | [optional] 

### Return type

[**RepromptModel**](RepromptModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
