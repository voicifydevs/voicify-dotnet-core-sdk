# Voicify.Sdk.Core.Models.Api.ExitMessageApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiExitMessageApplicationIdGet**](ExitMessageApi.md#apiexitmessageapplicationidget) | **GET** /api/ExitMessage/{applicationId} | 
[**ApiExitMessageApplicationIdPost**](ExitMessageApi.md#apiexitmessageapplicationidpost) | **POST** /api/ExitMessage/{applicationId} | 
[**ApiExitMessageApplicationIdStubPost**](ExitMessageApi.md#apiexitmessageapplicationidstubpost) | **POST** /api/ExitMessage/{applicationId}/stub | 
[**ApiExitMessageByFeatureApplicationFeatureIdGet**](ExitMessageApi.md#apiexitmessagebyfeatureapplicationfeatureidget) | **GET** /api/ExitMessage/byFeature/{applicationFeatureId} | 
[**ApiExitMessageContentItemIdFullPut**](ExitMessageApi.md#apiexitmessagecontentitemidfullput) | **PUT** /api/ExitMessage/{contentItemId}/full | 
[**ApiExitMessageContentItemIdMoveToFeatureApplicationFeatureIdPut**](ExitMessageApi.md#apiexitmessagecontentitemidmovetofeatureapplicationfeatureidput) | **PUT** /api/ExitMessage/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**ApiExitMessageExitMessageIdAddAudioFileMediaItemIdPut**](ExitMessageApi.md#apiexitmessageexitmessageidaddaudiofilemediaitemidput) | **PUT** /api/ExitMessage/{exitMessageId}/addAudioFile/{mediaItemId} | 
[**ApiExitMessageExitMessageIdAddLargeImageMediaItemIdPut**](ExitMessageApi.md#apiexitmessageexitmessageidaddlargeimagemediaitemidput) | **PUT** /api/ExitMessage/{exitMessageId}/addLargeImage/{mediaItemId} | 
[**ApiExitMessageExitMessageIdAddSmallImageMediaItemIdPut**](ExitMessageApi.md#apiexitmessageexitmessageidaddsmallimagemediaitemidput) | **PUT** /api/ExitMessage/{exitMessageId}/addSmallImage/{mediaItemId} | 
[**ApiExitMessageExitMessageIdAddVideoFileMediaItemIdPut**](ExitMessageApi.md#apiexitmessageexitmessageidaddvideofilemediaitemidput) | **PUT** /api/ExitMessage/{exitMessageId}/addVideoFile/{mediaItemId} | 
[**ApiExitMessageExitMessageIdCopyPost**](ExitMessageApi.md#apiexitmessageexitmessageidcopypost) | **POST** /api/ExitMessage/{exitMessageId}/copy | 
[**ApiExitMessageExitMessageIdDelete**](ExitMessageApi.md#apiexitmessageexitmessageiddelete) | **DELETE** /api/ExitMessage/{exitMessageId} | 
[**ApiExitMessageExitMessageIdIsLivePut**](ExitMessageApi.md#apiexitmessageexitmessageidisliveput) | **PUT** /api/ExitMessage/{exitMessageId}/isLive | 
[**ApiExitMessageExitMessageIdShouldNotSyncPut**](ExitMessageApi.md#apiexitmessageexitmessageidshouldnotsyncput) | **PUT** /api/ExitMessage/{exitMessageId}/shouldNotSync | 
[**ApiExitMessageExitMessageIdUpdatePut**](ExitMessageApi.md#apiexitmessageexitmessageidupdateput) | **PUT** /api/ExitMessage/{exitMessageId}/update | 
[**ApiExitMessageExitMessageIdUpdateStubPut**](ExitMessageApi.md#apiexitmessageexitmessageidupdatestubput) | **PUT** /api/ExitMessage/{exitMessageId}/update/stub | 
[**ApiExitMessageExitMessageIdWebhooksBulkPut**](ExitMessageApi.md#apiexitmessageexitmessageidwebhooksbulkput) | **PUT** /api/ExitMessage/{exitMessageId}/webhooks/bulk | 
[**ApiExitMessageExitMessageIdWebhooksGet**](ExitMessageApi.md#apiexitmessageexitmessageidwebhooksget) | **GET** /api/ExitMessage/{exitMessageId}/webhooks | 
[**ApiExitMessageExitMessageIdWebhooksInstanceWebhookIdPut**](ExitMessageApi.md#apiexitmessageexitmessageidwebhooksinstancewebhookidput) | **PUT** /api/ExitMessage/{exitMessageId}/webhooks/{instanceWebhookId} | 
[**ApiExitMessageExitMessageIdWebhooksWebhookIdPost**](ExitMessageApi.md#apiexitmessageexitmessageidwebhookswebhookidpost) | **POST** /api/ExitMessage/{exitMessageId}/webhooks/{webhookId} | 
[**ApiExitMessageFullIdGet**](ExitMessageApi.md#apiexitmessagefullidget) | **GET** /api/ExitMessage/full/{id} | 
[**ApiExitMessageFullPost**](ExitMessageApi.md#apiexitmessagefullpost) | **POST** /api/ExitMessage/full | 
[**ApiExitMessageWebhookExitMessageWebhookIdDelete**](ExitMessageApi.md#apiexitmessagewebhookexitmessagewebhookiddelete) | **DELETE** /api/ExitMessage/webhook/{exitMessageWebhookId} | 
[**ApiExitMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete**](ExitMessageApi.md#apiexitmessagewebhookinstancewebhookiduserparametersparameternamedelete) | **DELETE** /api/ExitMessage/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**ApiExitMessageWebhookInstanceWebhookIdUserParametersPost**](ExitMessageApi.md#apiexitmessagewebhookinstancewebhookiduserparameterspost) | **POST** /api/ExitMessage/webhook/{instanceWebhookId}/userParameters | 
[**ApiExitMessageWebhookInstanceWebhookIdUserParametersPut**](ExitMessageApi.md#apiexitmessagewebhookinstancewebhookiduserparametersput) | **PUT** /api/ExitMessage/webhook/{instanceWebhookId}/userParameters | 
[**ApiExitMessageWebhookInstanceWebhookIdWebhookParametersPut**](ExitMessageApi.md#apiexitmessagewebhookinstancewebhookidwebhookparametersput) | **PUT** /api/ExitMessage/webhook/{instanceWebhookId}/webhookParameters | 

<a name="apiexitmessageapplicationidget"></a>
# **ApiExitMessageApplicationIdGet**
> List<ExitMessageModel> ApiExitMessageApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageApplicationIdGetExample
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

            var apiInstance = new ExitMessageApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;ExitMessageModel&gt; result = apiInstance.ApiExitMessageApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageApplicationIdGet: " + e.Message );
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

[**List<ExitMessageModel>**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageapplicationidpost"></a>
# **ApiExitMessageApplicationIdPost**
> ExitMessageModel ApiExitMessageApplicationIdPost (string applicationId, NewExitMessageRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageApplicationIdPostExample
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

            var apiInstance = new ExitMessageApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewExitMessageRequest(); // NewExitMessageRequest |  (optional) 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageApplicationIdPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageApplicationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewExitMessageRequest**](NewExitMessageRequest.md)|  | [optional] 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageapplicationidstubpost"></a>
# **ApiExitMessageApplicationIdStubPost**
> ExitMessageModel ApiExitMessageApplicationIdStubPost (string applicationId, NewExitMessageStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageApplicationIdStubPostExample
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

            var apiInstance = new ExitMessageApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewExitMessageStubRequest(); // NewExitMessageStubRequest |  (optional) 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageApplicationIdStubPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageApplicationIdStubPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewExitMessageStubRequest**](NewExitMessageStubRequest.md)|  | [optional] 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessagebyfeatureapplicationfeatureidget"></a>
# **ApiExitMessageByFeatureApplicationFeatureIdGet**
> List<ExitMessageModel> ApiExitMessageByFeatureApplicationFeatureIdGet (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageByFeatureApplicationFeatureIdGetExample
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

            var apiInstance = new ExitMessageApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                List&lt;ExitMessageModel&gt; result = apiInstance.ApiExitMessageByFeatureApplicationFeatureIdGet(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageByFeatureApplicationFeatureIdGet: " + e.Message );
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

[**List<ExitMessageModel>**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessagecontentitemidfullput"></a>
# **ApiExitMessageContentItemIdFullPut**
> ExitMessageModel ApiExitMessageContentItemIdFullPut (string contentItemId, ExitMessageModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageContentItemIdFullPutExample
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

            var apiInstance = new ExitMessageApi();
            var contentItemId = contentItemId_example;  // string | 
            var body = new ExitMessageModel(); // ExitMessageModel |  (optional) 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageContentItemIdFullPut(contentItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageContentItemIdFullPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **body** | [**ExitMessageModel**](ExitMessageModel.md)|  | [optional] 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessagecontentitemidmovetofeatureapplicationfeatureidput"></a>
# **ApiExitMessageContentItemIdMoveToFeatureApplicationFeatureIdPut**
> ExitMessageModel ApiExitMessageContentItemIdMoveToFeatureApplicationFeatureIdPut (string contentItemId, string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageContentItemIdMoveToFeatureApplicationFeatureIdPutExample
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

            var apiInstance = new ExitMessageApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageContentItemIdMoveToFeatureApplicationFeatureIdPut(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageContentItemIdMoveToFeatureApplicationFeatureIdPut: " + e.Message );
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

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidaddaudiofilemediaitemidput"></a>
# **ApiExitMessageExitMessageIdAddAudioFileMediaItemIdPut**
> ExitMessageModel ApiExitMessageExitMessageIdAddAudioFileMediaItemIdPut (string exitMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdAddAudioFileMediaItemIdPutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdAddAudioFileMediaItemIdPut(exitMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdAddAudioFileMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidaddlargeimagemediaitemidput"></a>
# **ApiExitMessageExitMessageIdAddLargeImageMediaItemIdPut**
> ExitMessageModel ApiExitMessageExitMessageIdAddLargeImageMediaItemIdPut (string exitMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdAddLargeImageMediaItemIdPutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdAddLargeImageMediaItemIdPut(exitMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdAddLargeImageMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidaddsmallimagemediaitemidput"></a>
# **ApiExitMessageExitMessageIdAddSmallImageMediaItemIdPut**
> ExitMessageModel ApiExitMessageExitMessageIdAddSmallImageMediaItemIdPut (string exitMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdAddSmallImageMediaItemIdPutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdAddSmallImageMediaItemIdPut(exitMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdAddSmallImageMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidaddvideofilemediaitemidput"></a>
# **ApiExitMessageExitMessageIdAddVideoFileMediaItemIdPut**
> ExitMessageModel ApiExitMessageExitMessageIdAddVideoFileMediaItemIdPut (string exitMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdAddVideoFileMediaItemIdPutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdAddVideoFileMediaItemIdPut(exitMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdAddVideoFileMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidcopypost"></a>
# **ApiExitMessageExitMessageIdCopyPost**
> ExitMessageModel ApiExitMessageExitMessageIdCopyPost (string exitMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdCopyPostExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdCopyPost(exitMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdCopyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageiddelete"></a>
# **ApiExitMessageExitMessageIdDelete**
> ExitMessageModel ApiExitMessageExitMessageIdDelete (string exitMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdDeleteExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdDelete(exitMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidisliveput"></a>
# **ApiExitMessageExitMessageIdIsLivePut**
> ExitMessageModel ApiExitMessageExitMessageIdIsLivePut (string exitMessageId, ToggleLiveRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdIsLivePutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var body = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdIsLivePut(exitMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdIsLivePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **body** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidshouldnotsyncput"></a>
# **ApiExitMessageExitMessageIdShouldNotSyncPut**
> ExitMessageModel ApiExitMessageExitMessageIdShouldNotSyncPut (string exitMessageId, ToggleSyncRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdShouldNotSyncPutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var body = new ToggleSyncRequest(); // ToggleSyncRequest |  (optional) 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdShouldNotSyncPut(exitMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdShouldNotSyncPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **body** | [**ToggleSyncRequest**](ToggleSyncRequest.md)|  | [optional] 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidupdateput"></a>
# **ApiExitMessageExitMessageIdUpdatePut**
> ExitMessageModel ApiExitMessageExitMessageIdUpdatePut (string exitMessageId, UpdateExitMessageRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdUpdatePutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var body = new UpdateExitMessageRequest(); // UpdateExitMessageRequest |  (optional) 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdUpdatePut(exitMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **body** | [**UpdateExitMessageRequest**](UpdateExitMessageRequest.md)|  | [optional] 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidupdatestubput"></a>
# **ApiExitMessageExitMessageIdUpdateStubPut**
> ExitMessageModel ApiExitMessageExitMessageIdUpdateStubPut (string exitMessageId, UpdateExitMessageStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdUpdateStubPutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var body = new UpdateExitMessageStubRequest(); // UpdateExitMessageStubRequest |  (optional) 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageExitMessageIdUpdateStubPut(exitMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdUpdateStubPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **body** | [**UpdateExitMessageStubRequest**](UpdateExitMessageStubRequest.md)|  | [optional] 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidwebhooksbulkput"></a>
# **ApiExitMessageExitMessageIdWebhooksBulkPut**
> List<ExitMessageWebhookModel> ApiExitMessageExitMessageIdWebhooksBulkPut (string exitMessageId, BulkWebhookInstancesUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdWebhooksBulkPutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var body = new BulkWebhookInstancesUpdateRequest(); // BulkWebhookInstancesUpdateRequest |  (optional) 

            try
            {
                List&lt;ExitMessageWebhookModel&gt; result = apiInstance.ApiExitMessageExitMessageIdWebhooksBulkPut(exitMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdWebhooksBulkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **body** | [**BulkWebhookInstancesUpdateRequest**](BulkWebhookInstancesUpdateRequest.md)|  | [optional] 

### Return type

[**List<ExitMessageWebhookModel>**](ExitMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidwebhooksget"></a>
# **ApiExitMessageExitMessageIdWebhooksGet**
> List<ExitMessageWebhookModel> ApiExitMessageExitMessageIdWebhooksGet (string exitMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdWebhooksGetExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 

            try
            {
                List&lt;ExitMessageWebhookModel&gt; result = apiInstance.ApiExitMessageExitMessageIdWebhooksGet(exitMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdWebhooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 

### Return type

[**List<ExitMessageWebhookModel>**](ExitMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidwebhooksinstancewebhookidput"></a>
# **ApiExitMessageExitMessageIdWebhooksInstanceWebhookIdPut**
> ExitMessageWebhookModel ApiExitMessageExitMessageIdWebhooksInstanceWebhookIdPut (string exitMessageId, string instanceWebhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdWebhooksInstanceWebhookIdPutExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                ExitMessageWebhookModel result = apiInstance.ApiExitMessageExitMessageIdWebhooksInstanceWebhookIdPut(exitMessageId, instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdWebhooksInstanceWebhookIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **instanceWebhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**ExitMessageWebhookModel**](ExitMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessageexitmessageidwebhookswebhookidpost"></a>
# **ApiExitMessageExitMessageIdWebhooksWebhookIdPost**
> ExitMessageWebhookModel ApiExitMessageExitMessageIdWebhooksWebhookIdPost (string exitMessageId, string webhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageExitMessageIdWebhooksWebhookIdPostExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageId = exitMessageId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                ExitMessageWebhookModel result = apiInstance.ApiExitMessageExitMessageIdWebhooksWebhookIdPost(exitMessageId, webhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageExitMessageIdWebhooksWebhookIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageId** | **string**|  | 
 **webhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**ExitMessageWebhookModel**](ExitMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessagefullidget"></a>
# **ApiExitMessageFullIdGet**
> ExitMessageModel ApiExitMessageFullIdGet (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageFullIdGetExample
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

            var apiInstance = new ExitMessageApi();
            var id = id_example;  // string | 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageFullIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageFullIdGet: " + e.Message );
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

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessagefullpost"></a>
# **ApiExitMessageFullPost**
> ExitMessageModel ApiExitMessageFullPost (ExitMessageModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageFullPostExample
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

            var apiInstance = new ExitMessageApi();
            var body = new ExitMessageModel(); // ExitMessageModel |  (optional) 

            try
            {
                ExitMessageModel result = apiInstance.ApiExitMessageFullPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageFullPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExitMessageModel**](ExitMessageModel.md)|  | [optional] 

### Return type

[**ExitMessageModel**](ExitMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessagewebhookexitmessagewebhookiddelete"></a>
# **ApiExitMessageWebhookExitMessageWebhookIdDelete**
> ExitMessageWebhookModel ApiExitMessageWebhookExitMessageWebhookIdDelete (string exitMessageWebhookId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageWebhookExitMessageWebhookIdDeleteExample
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

            var apiInstance = new ExitMessageApi();
            var exitMessageWebhookId = exitMessageWebhookId_example;  // string | 

            try
            {
                ExitMessageWebhookModel result = apiInstance.ApiExitMessageWebhookExitMessageWebhookIdDelete(exitMessageWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageWebhookExitMessageWebhookIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exitMessageWebhookId** | **string**|  | 

### Return type

[**ExitMessageWebhookModel**](ExitMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiexitmessagewebhookinstancewebhookiduserparametersparameternamedelete"></a>
# **ApiExitMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete**
> bool? ApiExitMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete (string instanceWebhookId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageWebhookInstanceWebhookIdUserParametersParameterNameDeleteExample
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

            var apiInstance = new ExitMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.ApiExitMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete: " + e.Message );
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
<a name="apiexitmessagewebhookinstancewebhookiduserparameterspost"></a>
# **ApiExitMessageWebhookInstanceWebhookIdUserParametersPost**
> bool? ApiExitMessageWebhookInstanceWebhookIdUserParametersPost (string instanceWebhookId, UserDefinedWebhookParameterCreateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageWebhookInstanceWebhookIdUserParametersPostExample
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

            var apiInstance = new ExitMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiExitMessageWebhookInstanceWebhookIdUserParametersPost(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageWebhookInstanceWebhookIdUserParametersPost: " + e.Message );
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
<a name="apiexitmessagewebhookinstancewebhookiduserparametersput"></a>
# **ApiExitMessageWebhookInstanceWebhookIdUserParametersPut**
> bool? ApiExitMessageWebhookInstanceWebhookIdUserParametersPut (string instanceWebhookId, UserDefinedWebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageWebhookInstanceWebhookIdUserParametersPutExample
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

            var apiInstance = new ExitMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiExitMessageWebhookInstanceWebhookIdUserParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageWebhookInstanceWebhookIdUserParametersPut: " + e.Message );
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
<a name="apiexitmessagewebhookinstancewebhookidwebhookparametersput"></a>
# **ApiExitMessageWebhookInstanceWebhookIdWebhookParametersPut**
> bool? ApiExitMessageWebhookInstanceWebhookIdWebhookParametersPut (string instanceWebhookId, WebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiExitMessageWebhookInstanceWebhookIdWebhookParametersPutExample
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

            var apiInstance = new ExitMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiExitMessageWebhookInstanceWebhookIdWebhookParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExitMessageApi.ApiExitMessageWebhookInstanceWebhookIdWebhookParametersPut: " + e.Message );
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
