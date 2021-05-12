# Voicify.Sdk.Core.Models.Api.VoicifyNotificationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiVoicifyNotificationAllGet**](VoicifyNotificationApi.md#apivoicifynotificationallget) | **GET** /api/VoicifyNotification/all | 
[**ApiVoicifyNotificationNotificationIdReadPut**](VoicifyNotificationApi.md#apivoicifynotificationnotificationidreadput) | **PUT** /api/VoicifyNotification/{notificationId}/read | 
[**ApiVoicifyNotificationReadPut**](VoicifyNotificationApi.md#apivoicifynotificationreadput) | **PUT** /api/VoicifyNotification/read | 
[**ApiVoicifyNotificationUnreadGet**](VoicifyNotificationApi.md#apivoicifynotificationunreadget) | **GET** /api/VoicifyNotification/unread | 

<a name="apivoicifynotificationallget"></a>
# **ApiVoicifyNotificationAllGet**
> List<UserVoicifyNotificationModel> ApiVoicifyNotificationAllGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiVoicifyNotificationAllGetExample
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

            var apiInstance = new VoicifyNotificationApi();

            try
            {
                List&lt;UserVoicifyNotificationModel&gt; result = apiInstance.ApiVoicifyNotificationAllGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicifyNotificationApi.ApiVoicifyNotificationAllGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserVoicifyNotificationModel>**](UserVoicifyNotificationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivoicifynotificationnotificationidreadput"></a>
# **ApiVoicifyNotificationNotificationIdReadPut**
> UserVoicifyNotificationModel ApiVoicifyNotificationNotificationIdReadPut (string notificationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiVoicifyNotificationNotificationIdReadPutExample
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

            var apiInstance = new VoicifyNotificationApi();
            var notificationId = notificationId_example;  // string | 

            try
            {
                UserVoicifyNotificationModel result = apiInstance.ApiVoicifyNotificationNotificationIdReadPut(notificationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicifyNotificationApi.ApiVoicifyNotificationNotificationIdReadPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationId** | **string**|  | 

### Return type

[**UserVoicifyNotificationModel**](UserVoicifyNotificationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivoicifynotificationreadput"></a>
# **ApiVoicifyNotificationReadPut**
> List<UserVoicifyNotificationModel> ApiVoicifyNotificationReadPut ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiVoicifyNotificationReadPutExample
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

            var apiInstance = new VoicifyNotificationApi();

            try
            {
                List&lt;UserVoicifyNotificationModel&gt; result = apiInstance.ApiVoicifyNotificationReadPut();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicifyNotificationApi.ApiVoicifyNotificationReadPut: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserVoicifyNotificationModel>**](UserVoicifyNotificationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apivoicifynotificationunreadget"></a>
# **ApiVoicifyNotificationUnreadGet**
> List<UserVoicifyNotificationModel> ApiVoicifyNotificationUnreadGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiVoicifyNotificationUnreadGetExample
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

            var apiInstance = new VoicifyNotificationApi();

            try
            {
                List&lt;UserVoicifyNotificationModel&gt; result = apiInstance.ApiVoicifyNotificationUnreadGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoicifyNotificationApi.ApiVoicifyNotificationUnreadGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserVoicifyNotificationModel>**](UserVoicifyNotificationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
