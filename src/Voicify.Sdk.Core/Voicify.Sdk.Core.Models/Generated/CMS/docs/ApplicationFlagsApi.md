# Voicify.Sdk.Core.Models.Api.ApplicationFlagsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateApplicationConversationFlag**](ApplicationFlagsApi.md#createapplicationconversationflag) | **POST** /api/ApplicationFlags | 
[**DeleteApplicationConversationFlag**](ApplicationFlagsApi.md#deleteapplicationconversationflag) | **DELETE** /api/ApplicationFlags/{applicationConversationFlagId} | 
[**GetApplicationConversationFlags**](ApplicationFlagsApi.md#getapplicationconversationflags) | **GET** /api/ApplicationFlags/forApp/{applicationId} | 
[**UpdateApplicationConversationFlag**](ApplicationFlagsApi.md#updateapplicationconversationflag) | **PUT** /api/ApplicationFlags/{applicationConversationFlagId} | 

<a name="createapplicationconversationflag"></a>
# **CreateApplicationConversationFlag**
> ApplicationConversationFlagModel CreateApplicationConversationFlag (ApplicationConversationFlagModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateApplicationConversationFlagExample
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

            var apiInstance = new ApplicationFlagsApi();
            var body = new ApplicationConversationFlagModel(); // ApplicationConversationFlagModel |  (optional) 

            try
            {
                ApplicationConversationFlagModel result = apiInstance.CreateApplicationConversationFlag(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationFlagsApi.CreateApplicationConversationFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationConversationFlagModel**](ApplicationConversationFlagModel.md)|  | [optional] 

### Return type

[**ApplicationConversationFlagModel**](ApplicationConversationFlagModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteapplicationconversationflag"></a>
# **DeleteApplicationConversationFlag**
> ApplicationConversationFlagModel DeleteApplicationConversationFlag (string applicationConversationFlagId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteApplicationConversationFlagExample
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

            var apiInstance = new ApplicationFlagsApi();
            var applicationConversationFlagId = applicationConversationFlagId_example;  // string | 

            try
            {
                ApplicationConversationFlagModel result = apiInstance.DeleteApplicationConversationFlag(applicationConversationFlagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationFlagsApi.DeleteApplicationConversationFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationConversationFlagId** | **string**|  | 

### Return type

[**ApplicationConversationFlagModel**](ApplicationConversationFlagModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapplicationconversationflags"></a>
# **GetApplicationConversationFlags**
> List<ApplicationConversationFlagModel> GetApplicationConversationFlags (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationConversationFlagsExample
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

            var apiInstance = new ApplicationFlagsApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;ApplicationConversationFlagModel&gt; result = apiInstance.GetApplicationConversationFlags(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationFlagsApi.GetApplicationConversationFlags: " + e.Message );
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

[**List<ApplicationConversationFlagModel>**](ApplicationConversationFlagModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateapplicationconversationflag"></a>
# **UpdateApplicationConversationFlag**
> ApplicationConversationFlagModel UpdateApplicationConversationFlag (string applicationConversationFlagId, ApplicationConversationFlagModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateApplicationConversationFlagExample
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

            var apiInstance = new ApplicationFlagsApi();
            var applicationConversationFlagId = applicationConversationFlagId_example;  // string | 
            var body = new ApplicationConversationFlagModel(); // ApplicationConversationFlagModel |  (optional) 

            try
            {
                ApplicationConversationFlagModel result = apiInstance.UpdateApplicationConversationFlag(applicationConversationFlagId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationFlagsApi.UpdateApplicationConversationFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationConversationFlagId** | **string**|  | 
 **body** | [**ApplicationConversationFlagModel**](ApplicationConversationFlagModel.md)|  | [optional] 

### Return type

[**ApplicationConversationFlagModel**](ApplicationConversationFlagModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
