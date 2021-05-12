# Voicify.Sdk.Core.Models.Api.HelpMessageApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiHelpMessageApplicationIdGet**](HelpMessageApi.md#apihelpmessageapplicationidget) | **GET** /api/HelpMessage/{applicationId} | 
[**ApiHelpMessageApplicationIdPost**](HelpMessageApi.md#apihelpmessageapplicationidpost) | **POST** /api/HelpMessage/{applicationId} | 
[**ApiHelpMessageApplicationIdStubPost**](HelpMessageApi.md#apihelpmessageapplicationidstubpost) | **POST** /api/HelpMessage/{applicationId}/stub | 
[**ApiHelpMessageByFeatureApplicationFeatureIdGet**](HelpMessageApi.md#apihelpmessagebyfeatureapplicationfeatureidget) | **GET** /api/HelpMessage/byFeature/{applicationFeatureId} | 
[**ApiHelpMessageContentItemIdFullPut**](HelpMessageApi.md#apihelpmessagecontentitemidfullput) | **PUT** /api/HelpMessage/{contentItemId}/full | 
[**ApiHelpMessageContentItemIdMoveToFeatureApplicationFeatureIdPut**](HelpMessageApi.md#apihelpmessagecontentitemidmovetofeatureapplicationfeatureidput) | **PUT** /api/HelpMessage/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**ApiHelpMessageFullIdGet**](HelpMessageApi.md#apihelpmessagefullidget) | **GET** /api/HelpMessage/full/{id} | 
[**ApiHelpMessageFullPost**](HelpMessageApi.md#apihelpmessagefullpost) | **POST** /api/HelpMessage/full | 
[**ApiHelpMessageHelpMessageIdAddAudioFileMediaItemIdPut**](HelpMessageApi.md#apihelpmessagehelpmessageidaddaudiofilemediaitemidput) | **PUT** /api/HelpMessage/{helpMessageId}/addAudioFile/{mediaItemId} | 
[**ApiHelpMessageHelpMessageIdAddLargeImageMediaItemIdPut**](HelpMessageApi.md#apihelpmessagehelpmessageidaddlargeimagemediaitemidput) | **PUT** /api/HelpMessage/{helpMessageId}/addLargeImage/{mediaItemId} | 
[**ApiHelpMessageHelpMessageIdAddSmallImageMediaItemIdPut**](HelpMessageApi.md#apihelpmessagehelpmessageidaddsmallimagemediaitemidput) | **PUT** /api/HelpMessage/{helpMessageId}/addSmallImage/{mediaItemId} | 
[**ApiHelpMessageHelpMessageIdAddVideoFileMediaItemIdPut**](HelpMessageApi.md#apihelpmessagehelpmessageidaddvideofilemediaitemidput) | **PUT** /api/HelpMessage/{helpMessageId}/addVideoFile/{mediaItemId} | 
[**ApiHelpMessageHelpMessageIdCopyPost**](HelpMessageApi.md#apihelpmessagehelpmessageidcopypost) | **POST** /api/HelpMessage/{helpMessageId}/copy | 
[**ApiHelpMessageHelpMessageIdDelete**](HelpMessageApi.md#apihelpmessagehelpmessageiddelete) | **DELETE** /api/HelpMessage/{helpMessageId} | 
[**ApiHelpMessageHelpMessageIdIsLivePut**](HelpMessageApi.md#apihelpmessagehelpmessageidisliveput) | **PUT** /api/HelpMessage/{helpMessageId}/isLive | 
[**ApiHelpMessageHelpMessageIdShouldNotSyncPut**](HelpMessageApi.md#apihelpmessagehelpmessageidshouldnotsyncput) | **PUT** /api/HelpMessage/{helpMessageId}/shouldNotSync | 
[**ApiHelpMessageHelpMessageIdUpdatePut**](HelpMessageApi.md#apihelpmessagehelpmessageidupdateput) | **PUT** /api/HelpMessage/{helpMessageId}/update | 
[**ApiHelpMessageHelpMessageIdUpdateStubPut**](HelpMessageApi.md#apihelpmessagehelpmessageidupdatestubput) | **PUT** /api/HelpMessage/{helpMessageId}/update/stub | 
[**ApiHelpMessageHelpMessageIdWebhooksBulkPut**](HelpMessageApi.md#apihelpmessagehelpmessageidwebhooksbulkput) | **PUT** /api/HelpMessage/{helpMessageId}/webhooks/bulk | 
[**ApiHelpMessageHelpMessageIdWebhooksGet**](HelpMessageApi.md#apihelpmessagehelpmessageidwebhooksget) | **GET** /api/HelpMessage/{helpMessageId}/webhooks | 
[**ApiHelpMessageHelpMessageIdWebhooksWebhookIdPost**](HelpMessageApi.md#apihelpmessagehelpmessageidwebhookswebhookidpost) | **POST** /api/HelpMessage/{helpMessageId}/webhooks/{webhookId} | 
[**ApiHelpMessageHelpMessageIdWebhooksWebhookInstanceIdPut**](HelpMessageApi.md#apihelpmessagehelpmessageidwebhookswebhookinstanceidput) | **PUT** /api/HelpMessage/{helpMessageId}/webhooks/{webhookInstanceId} | 
[**ApiHelpMessageWebhookHelpMessageWebhookIdDelete**](HelpMessageApi.md#apihelpmessagewebhookhelpmessagewebhookiddelete) | **DELETE** /api/HelpMessage/webhook/{helpMessageWebhookId} | 
[**ApiHelpMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete**](HelpMessageApi.md#apihelpmessagewebhookinstancewebhookiduserparametersparameternamedelete) | **DELETE** /api/HelpMessage/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**ApiHelpMessageWebhookInstanceWebhookIdUserParametersPost**](HelpMessageApi.md#apihelpmessagewebhookinstancewebhookiduserparameterspost) | **POST** /api/HelpMessage/webhook/{instanceWebhookId}/userParameters | 
[**ApiHelpMessageWebhookInstanceWebhookIdUserParametersPut**](HelpMessageApi.md#apihelpmessagewebhookinstancewebhookiduserparametersput) | **PUT** /api/HelpMessage/webhook/{instanceWebhookId}/userParameters | 
[**ApiHelpMessageWebhookInstanceWebhookIdWebhookParametersPut**](HelpMessageApi.md#apihelpmessagewebhookinstancewebhookidwebhookparametersput) | **PUT** /api/HelpMessage/webhook/{instanceWebhookId}/webhookParameters | 

<a name="apihelpmessageapplicationidget"></a>
# **ApiHelpMessageApplicationIdGet**
> List<HelpMessageModel> ApiHelpMessageApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageApplicationIdGetExample
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

            var apiInstance = new HelpMessageApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;HelpMessageModel&gt; result = apiInstance.ApiHelpMessageApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageApplicationIdGet: " + e.Message );
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

[**List<HelpMessageModel>**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessageapplicationidpost"></a>
# **ApiHelpMessageApplicationIdPost**
> HelpMessageModel ApiHelpMessageApplicationIdPost (string applicationId, NewHelpMessageRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageApplicationIdPostExample
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

            var apiInstance = new HelpMessageApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewHelpMessageRequest(); // NewHelpMessageRequest |  (optional) 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageApplicationIdPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageApplicationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewHelpMessageRequest**](NewHelpMessageRequest.md)|  | [optional] 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessageapplicationidstubpost"></a>
# **ApiHelpMessageApplicationIdStubPost**
> HelpMessageModel ApiHelpMessageApplicationIdStubPost (string applicationId, NewHelpMessageStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageApplicationIdStubPostExample
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

            var apiInstance = new HelpMessageApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewHelpMessageStubRequest(); // NewHelpMessageStubRequest |  (optional) 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageApplicationIdStubPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageApplicationIdStubPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewHelpMessageStubRequest**](NewHelpMessageStubRequest.md)|  | [optional] 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagebyfeatureapplicationfeatureidget"></a>
# **ApiHelpMessageByFeatureApplicationFeatureIdGet**
> List<HelpMessageModel> ApiHelpMessageByFeatureApplicationFeatureIdGet (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageByFeatureApplicationFeatureIdGetExample
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

            var apiInstance = new HelpMessageApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                List&lt;HelpMessageModel&gt; result = apiInstance.ApiHelpMessageByFeatureApplicationFeatureIdGet(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageByFeatureApplicationFeatureIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 

### Return type

[**List<HelpMessageModel>**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagecontentitemidfullput"></a>
# **ApiHelpMessageContentItemIdFullPut**
> HelpMessageModel ApiHelpMessageContentItemIdFullPut (string contentItemId, HelpMessageModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageContentItemIdFullPutExample
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

            var apiInstance = new HelpMessageApi();
            var contentItemId = contentItemId_example;  // string | 
            var body = new HelpMessageModel(); // HelpMessageModel |  (optional) 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageContentItemIdFullPut(contentItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageContentItemIdFullPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **body** | [**HelpMessageModel**](HelpMessageModel.md)|  | [optional] 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagecontentitemidmovetofeatureapplicationfeatureidput"></a>
# **ApiHelpMessageContentItemIdMoveToFeatureApplicationFeatureIdPut**
> HelpMessageModel ApiHelpMessageContentItemIdMoveToFeatureApplicationFeatureIdPut (string contentItemId, string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageContentItemIdMoveToFeatureApplicationFeatureIdPutExample
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

            var apiInstance = new HelpMessageApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageContentItemIdMoveToFeatureApplicationFeatureIdPut(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageContentItemIdMoveToFeatureApplicationFeatureIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **applicationFeatureId** | **string**|  | 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagefullidget"></a>
# **ApiHelpMessageFullIdGet**
> HelpMessageModel ApiHelpMessageFullIdGet (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageFullIdGetExample
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

            var apiInstance = new HelpMessageApi();
            var id = id_example;  // string | 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageFullIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageFullIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagefullpost"></a>
# **ApiHelpMessageFullPost**
> HelpMessageModel ApiHelpMessageFullPost (HelpMessageModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageFullPostExample
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

            var apiInstance = new HelpMessageApi();
            var body = new HelpMessageModel(); // HelpMessageModel |  (optional) 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageFullPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageFullPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HelpMessageModel**](HelpMessageModel.md)|  | [optional] 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidaddaudiofilemediaitemidput"></a>
# **ApiHelpMessageHelpMessageIdAddAudioFileMediaItemIdPut**
> HelpMessageModel ApiHelpMessageHelpMessageIdAddAudioFileMediaItemIdPut (string helpMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdAddAudioFileMediaItemIdPutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdAddAudioFileMediaItemIdPut(helpMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdAddAudioFileMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidaddlargeimagemediaitemidput"></a>
# **ApiHelpMessageHelpMessageIdAddLargeImageMediaItemIdPut**
> HelpMessageModel ApiHelpMessageHelpMessageIdAddLargeImageMediaItemIdPut (string helpMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdAddLargeImageMediaItemIdPutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdAddLargeImageMediaItemIdPut(helpMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdAddLargeImageMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidaddsmallimagemediaitemidput"></a>
# **ApiHelpMessageHelpMessageIdAddSmallImageMediaItemIdPut**
> HelpMessageModel ApiHelpMessageHelpMessageIdAddSmallImageMediaItemIdPut (string helpMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdAddSmallImageMediaItemIdPutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdAddSmallImageMediaItemIdPut(helpMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdAddSmallImageMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidaddvideofilemediaitemidput"></a>
# **ApiHelpMessageHelpMessageIdAddVideoFileMediaItemIdPut**
> HelpMessageModel ApiHelpMessageHelpMessageIdAddVideoFileMediaItemIdPut (string helpMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdAddVideoFileMediaItemIdPutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdAddVideoFileMediaItemIdPut(helpMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdAddVideoFileMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidcopypost"></a>
# **ApiHelpMessageHelpMessageIdCopyPost**
> HelpMessageModel ApiHelpMessageHelpMessageIdCopyPost (string helpMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdCopyPostExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdCopyPost(helpMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdCopyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageiddelete"></a>
# **ApiHelpMessageHelpMessageIdDelete**
> HelpMessageModel ApiHelpMessageHelpMessageIdDelete (string helpMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdDeleteExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdDelete(helpMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidisliveput"></a>
# **ApiHelpMessageHelpMessageIdIsLivePut**
> HelpMessageModel ApiHelpMessageHelpMessageIdIsLivePut (string helpMessageId, ToggleLiveRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdIsLivePutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var body = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdIsLivePut(helpMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdIsLivePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **body** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidshouldnotsyncput"></a>
# **ApiHelpMessageHelpMessageIdShouldNotSyncPut**
> HelpMessageModel ApiHelpMessageHelpMessageIdShouldNotSyncPut (string helpMessageId, ToggleSyncRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdShouldNotSyncPutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var body = new ToggleSyncRequest(); // ToggleSyncRequest |  (optional) 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdShouldNotSyncPut(helpMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdShouldNotSyncPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **body** | [**ToggleSyncRequest**](ToggleSyncRequest.md)|  | [optional] 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidupdateput"></a>
# **ApiHelpMessageHelpMessageIdUpdatePut**
> HelpMessageModel ApiHelpMessageHelpMessageIdUpdatePut (string helpMessageId, UpdateHelpMessageRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdUpdatePutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var body = new UpdateHelpMessageRequest(); // UpdateHelpMessageRequest |  (optional) 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdUpdatePut(helpMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **body** | [**UpdateHelpMessageRequest**](UpdateHelpMessageRequest.md)|  | [optional] 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidupdatestubput"></a>
# **ApiHelpMessageHelpMessageIdUpdateStubPut**
> HelpMessageModel ApiHelpMessageHelpMessageIdUpdateStubPut (string helpMessageId, UpdateHelpMessageStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdUpdateStubPutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var body = new UpdateHelpMessageStubRequest(); // UpdateHelpMessageStubRequest |  (optional) 

            try
            {
                HelpMessageModel result = apiInstance.ApiHelpMessageHelpMessageIdUpdateStubPut(helpMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdUpdateStubPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **body** | [**UpdateHelpMessageStubRequest**](UpdateHelpMessageStubRequest.md)|  | [optional] 

### Return type

[**HelpMessageModel**](HelpMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidwebhooksbulkput"></a>
# **ApiHelpMessageHelpMessageIdWebhooksBulkPut**
> List<HelpMessageWebhookModel> ApiHelpMessageHelpMessageIdWebhooksBulkPut (string helpMessageId, BulkWebhookInstancesUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdWebhooksBulkPutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var body = new BulkWebhookInstancesUpdateRequest(); // BulkWebhookInstancesUpdateRequest |  (optional) 

            try
            {
                List&lt;HelpMessageWebhookModel&gt; result = apiInstance.ApiHelpMessageHelpMessageIdWebhooksBulkPut(helpMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdWebhooksBulkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **body** | [**BulkWebhookInstancesUpdateRequest**](BulkWebhookInstancesUpdateRequest.md)|  | [optional] 

### Return type

[**List<HelpMessageWebhookModel>**](HelpMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidwebhooksget"></a>
# **ApiHelpMessageHelpMessageIdWebhooksGet**
> List<HelpMessageWebhookModel> ApiHelpMessageHelpMessageIdWebhooksGet (string helpMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdWebhooksGetExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 

            try
            {
                List&lt;HelpMessageWebhookModel&gt; result = apiInstance.ApiHelpMessageHelpMessageIdWebhooksGet(helpMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdWebhooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 

### Return type

[**List<HelpMessageWebhookModel>**](HelpMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidwebhookswebhookidpost"></a>
# **ApiHelpMessageHelpMessageIdWebhooksWebhookIdPost**
> HelpMessageWebhookModel ApiHelpMessageHelpMessageIdWebhooksWebhookIdPost (string helpMessageId, string webhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdWebhooksWebhookIdPostExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                HelpMessageWebhookModel result = apiInstance.ApiHelpMessageHelpMessageIdWebhooksWebhookIdPost(helpMessageId, webhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdWebhooksWebhookIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **webhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**HelpMessageWebhookModel**](HelpMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagehelpmessageidwebhookswebhookinstanceidput"></a>
# **ApiHelpMessageHelpMessageIdWebhooksWebhookInstanceIdPut**
> HelpMessageWebhookModel ApiHelpMessageHelpMessageIdWebhooksWebhookInstanceIdPut (string helpMessageId, string webhookInstanceId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageHelpMessageIdWebhooksWebhookInstanceIdPutExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageId = helpMessageId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                HelpMessageWebhookModel result = apiInstance.ApiHelpMessageHelpMessageIdWebhooksWebhookInstanceIdPut(helpMessageId, webhookInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageHelpMessageIdWebhooksWebhookInstanceIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**HelpMessageWebhookModel**](HelpMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagewebhookhelpmessagewebhookiddelete"></a>
# **ApiHelpMessageWebhookHelpMessageWebhookIdDelete**
> HelpMessageWebhookModel ApiHelpMessageWebhookHelpMessageWebhookIdDelete (string helpMessageWebhookId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageWebhookHelpMessageWebhookIdDeleteExample
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

            var apiInstance = new HelpMessageApi();
            var helpMessageWebhookId = helpMessageWebhookId_example;  // string | 

            try
            {
                HelpMessageWebhookModel result = apiInstance.ApiHelpMessageWebhookHelpMessageWebhookIdDelete(helpMessageWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageWebhookHelpMessageWebhookIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **helpMessageWebhookId** | **string**|  | 

### Return type

[**HelpMessageWebhookModel**](HelpMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagewebhookinstancewebhookiduserparametersparameternamedelete"></a>
# **ApiHelpMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete**
> bool? ApiHelpMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete (string instanceWebhookId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageWebhookInstanceWebhookIdUserParametersParameterNameDeleteExample
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

            var apiInstance = new HelpMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.ApiHelpMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **parameterName** | **string**|  | 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagewebhookinstancewebhookiduserparameterspost"></a>
# **ApiHelpMessageWebhookInstanceWebhookIdUserParametersPost**
> bool? ApiHelpMessageWebhookInstanceWebhookIdUserParametersPost (string instanceWebhookId, UserDefinedWebhookParameterCreateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageWebhookInstanceWebhookIdUserParametersPostExample
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

            var apiInstance = new HelpMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiHelpMessageWebhookInstanceWebhookIdUserParametersPost(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageWebhookInstanceWebhookIdUserParametersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **body** | [**UserDefinedWebhookParameterCreateRequest**](UserDefinedWebhookParameterCreateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagewebhookinstancewebhookiduserparametersput"></a>
# **ApiHelpMessageWebhookInstanceWebhookIdUserParametersPut**
> bool? ApiHelpMessageWebhookInstanceWebhookIdUserParametersPut (string instanceWebhookId, UserDefinedWebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageWebhookInstanceWebhookIdUserParametersPutExample
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

            var apiInstance = new HelpMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiHelpMessageWebhookInstanceWebhookIdUserParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageWebhookInstanceWebhookIdUserParametersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **body** | [**UserDefinedWebhookParameterUpdateRequest**](UserDefinedWebhookParameterUpdateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apihelpmessagewebhookinstancewebhookidwebhookparametersput"></a>
# **ApiHelpMessageWebhookInstanceWebhookIdWebhookParametersPut**
> bool? ApiHelpMessageWebhookInstanceWebhookIdWebhookParametersPut (string instanceWebhookId, WebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiHelpMessageWebhookInstanceWebhookIdWebhookParametersPutExample
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

            var apiInstance = new HelpMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiHelpMessageWebhookInstanceWebhookIdWebhookParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HelpMessageApi.ApiHelpMessageWebhookInstanceWebhookIdWebhookParametersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **body** | [**WebhookParameterUpdateRequest**](WebhookParameterUpdateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
