# Voicify.Sdk.Core.Models.Api.FallbackMessageApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiFallbackMessageApplicationIdGet**](FallbackMessageApi.md#apifallbackmessageapplicationidget) | **GET** /api/FallbackMessage/{applicationId} | 
[**ApiFallbackMessageApplicationIdPost**](FallbackMessageApi.md#apifallbackmessageapplicationidpost) | **POST** /api/FallbackMessage/{applicationId} | 
[**ApiFallbackMessageApplicationIdStubPost**](FallbackMessageApi.md#apifallbackmessageapplicationidstubpost) | **POST** /api/FallbackMessage/{applicationId}/stub | 
[**ApiFallbackMessageByFeatureApplicationFeatureIdGet**](FallbackMessageApi.md#apifallbackmessagebyfeatureapplicationfeatureidget) | **GET** /api/FallbackMessage/byFeature/{applicationFeatureId} | 
[**ApiFallbackMessageCategoriesGet**](FallbackMessageApi.md#apifallbackmessagecategoriesget) | **GET** /api/FallbackMessage/categories | 
[**ApiFallbackMessageContentItemIdFullPut**](FallbackMessageApi.md#apifallbackmessagecontentitemidfullput) | **PUT** /api/FallbackMessage/{contentItemId}/full | 
[**ApiFallbackMessageContentItemIdMoveToFeatureApplicationFeatureIdPut**](FallbackMessageApi.md#apifallbackmessagecontentitemidmovetofeatureapplicationfeatureidput) | **PUT** /api/FallbackMessage/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**ApiFallbackMessageFallbackMessageIdAddAudioFileMediaItemIdPut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidaddaudiofilemediaitemidput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/addAudioFile/{mediaItemId} | 
[**ApiFallbackMessageFallbackMessageIdAddLargeImageMediaItemIdPut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidaddlargeimagemediaitemidput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/addLargeImage/{mediaItemId} | 
[**ApiFallbackMessageFallbackMessageIdAddSmallImageMediaItemIdPut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidaddsmallimagemediaitemidput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/addSmallImage/{mediaItemId} | 
[**ApiFallbackMessageFallbackMessageIdAddVideoFileMediaItemIdPut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidaddvideofilemediaitemidput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/addVideoFile/{mediaItemId} | 
[**ApiFallbackMessageFallbackMessageIdCopyPost**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidcopypost) | **POST** /api/FallbackMessage/{fallbackMessageId}/copy | 
[**ApiFallbackMessageFallbackMessageIdDelete**](FallbackMessageApi.md#apifallbackmessagefallbackmessageiddelete) | **DELETE** /api/FallbackMessage/{fallbackMessageId} | 
[**ApiFallbackMessageFallbackMessageIdIsLivePut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidisliveput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/isLive | 
[**ApiFallbackMessageFallbackMessageIdShouldNotSyncPut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidshouldnotsyncput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/shouldNotSync | 
[**ApiFallbackMessageFallbackMessageIdUpdatePut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidupdateput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/update | 
[**ApiFallbackMessageFallbackMessageIdUpdateStubPut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidupdatestubput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/update/stub | 
[**ApiFallbackMessageFallbackMessageIdWebhooksBulkPut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidwebhooksbulkput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/webhooks/bulk | 
[**ApiFallbackMessageFallbackMessageIdWebhooksGet**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidwebhooksget) | **GET** /api/FallbackMessage/{fallbackMessageId}/webhooks | 
[**ApiFallbackMessageFallbackMessageIdWebhooksInstanceWebhookIdPut**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidwebhooksinstancewebhookidput) | **PUT** /api/FallbackMessage/{fallbackMessageId}/webhooks/{instanceWebhookId} | 
[**ApiFallbackMessageFallbackMessageIdWebhooksWebhookIdPost**](FallbackMessageApi.md#apifallbackmessagefallbackmessageidwebhookswebhookidpost) | **POST** /api/FallbackMessage/{fallbackMessageId}/webhooks/{webhookId} | 
[**ApiFallbackMessageFullIdGet**](FallbackMessageApi.md#apifallbackmessagefullidget) | **GET** /api/FallbackMessage/full/{id} | 
[**ApiFallbackMessageFullPost**](FallbackMessageApi.md#apifallbackmessagefullpost) | **POST** /api/FallbackMessage/full | 
[**ApiFallbackMessageWebhookFallbackMessageWebhookIdDelete**](FallbackMessageApi.md#apifallbackmessagewebhookfallbackmessagewebhookiddelete) | **DELETE** /api/FallbackMessage/webhook/{fallbackMessageWebhookId} | 
[**ApiFallbackMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete**](FallbackMessageApi.md#apifallbackmessagewebhookinstancewebhookiduserparametersparameternamedelete) | **DELETE** /api/FallbackMessage/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPost**](FallbackMessageApi.md#apifallbackmessagewebhookinstancewebhookiduserparameterspost) | **POST** /api/FallbackMessage/webhook/{instanceWebhookId}/userParameters | 
[**ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPut**](FallbackMessageApi.md#apifallbackmessagewebhookinstancewebhookiduserparametersput) | **PUT** /api/FallbackMessage/webhook/{instanceWebhookId}/userParameters | 
[**ApiFallbackMessageWebhookInstanceWebhookIdWebhookParametersPut**](FallbackMessageApi.md#apifallbackmessagewebhookinstancewebhookidwebhookparametersput) | **PUT** /api/FallbackMessage/webhook/{instanceWebhookId}/webhookParameters | 

<a name="apifallbackmessageapplicationidget"></a>
# **ApiFallbackMessageApplicationIdGet**
> List<FallbackMessageModel> ApiFallbackMessageApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageApplicationIdGetExample
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

            var apiInstance = new FallbackMessageApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;FallbackMessageModel&gt; result = apiInstance.ApiFallbackMessageApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageApplicationIdGet: " + e.Message );
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

[**List<FallbackMessageModel>**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessageapplicationidpost"></a>
# **ApiFallbackMessageApplicationIdPost**
> FallbackMessageModel ApiFallbackMessageApplicationIdPost (string applicationId, NewFallbackMessageRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageApplicationIdPostExample
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

            var apiInstance = new FallbackMessageApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewFallbackMessageRequest(); // NewFallbackMessageRequest |  (optional) 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageApplicationIdPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageApplicationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewFallbackMessageRequest**](NewFallbackMessageRequest.md)|  | [optional] 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessageapplicationidstubpost"></a>
# **ApiFallbackMessageApplicationIdStubPost**
> FallbackMessageModel ApiFallbackMessageApplicationIdStubPost (string applicationId, NewFallbackMessageStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageApplicationIdStubPostExample
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

            var apiInstance = new FallbackMessageApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewFallbackMessageStubRequest(); // NewFallbackMessageStubRequest |  (optional) 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageApplicationIdStubPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageApplicationIdStubPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewFallbackMessageStubRequest**](NewFallbackMessageStubRequest.md)|  | [optional] 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagebyfeatureapplicationfeatureidget"></a>
# **ApiFallbackMessageByFeatureApplicationFeatureIdGet**
> List<FallbackMessageModel> ApiFallbackMessageByFeatureApplicationFeatureIdGet (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageByFeatureApplicationFeatureIdGetExample
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

            var apiInstance = new FallbackMessageApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                List&lt;FallbackMessageModel&gt; result = apiInstance.ApiFallbackMessageByFeatureApplicationFeatureIdGet(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageByFeatureApplicationFeatureIdGet: " + e.Message );
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

[**List<FallbackMessageModel>**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagecategoriesget"></a>
# **ApiFallbackMessageCategoriesGet**
> List<FallbackMessageCategoryModel> ApiFallbackMessageCategoriesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageCategoriesGetExample
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

            var apiInstance = new FallbackMessageApi();

            try
            {
                List&lt;FallbackMessageCategoryModel&gt; result = apiInstance.ApiFallbackMessageCategoriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageCategoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FallbackMessageCategoryModel>**](FallbackMessageCategoryModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagecontentitemidfullput"></a>
# **ApiFallbackMessageContentItemIdFullPut**
> FallbackMessageModel ApiFallbackMessageContentItemIdFullPut (string contentItemId, FallbackMessageModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageContentItemIdFullPutExample
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

            var apiInstance = new FallbackMessageApi();
            var contentItemId = contentItemId_example;  // string | 
            var body = new FallbackMessageModel(); // FallbackMessageModel |  (optional) 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageContentItemIdFullPut(contentItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageContentItemIdFullPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **body** | [**FallbackMessageModel**](FallbackMessageModel.md)|  | [optional] 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagecontentitemidmovetofeatureapplicationfeatureidput"></a>
# **ApiFallbackMessageContentItemIdMoveToFeatureApplicationFeatureIdPut**
> FallbackMessageModel ApiFallbackMessageContentItemIdMoveToFeatureApplicationFeatureIdPut (string contentItemId, string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageContentItemIdMoveToFeatureApplicationFeatureIdPutExample
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

            var apiInstance = new FallbackMessageApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageContentItemIdMoveToFeatureApplicationFeatureIdPut(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageContentItemIdMoveToFeatureApplicationFeatureIdPut: " + e.Message );
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

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidaddaudiofilemediaitemidput"></a>
# **ApiFallbackMessageFallbackMessageIdAddAudioFileMediaItemIdPut**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdAddAudioFileMediaItemIdPut (string fallbackMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdAddAudioFileMediaItemIdPutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdAddAudioFileMediaItemIdPut(fallbackMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdAddAudioFileMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidaddlargeimagemediaitemidput"></a>
# **ApiFallbackMessageFallbackMessageIdAddLargeImageMediaItemIdPut**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdAddLargeImageMediaItemIdPut (string fallbackMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdAddLargeImageMediaItemIdPutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdAddLargeImageMediaItemIdPut(fallbackMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdAddLargeImageMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidaddsmallimagemediaitemidput"></a>
# **ApiFallbackMessageFallbackMessageIdAddSmallImageMediaItemIdPut**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdAddSmallImageMediaItemIdPut (string fallbackMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdAddSmallImageMediaItemIdPutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdAddSmallImageMediaItemIdPut(fallbackMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdAddSmallImageMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidaddvideofilemediaitemidput"></a>
# **ApiFallbackMessageFallbackMessageIdAddVideoFileMediaItemIdPut**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdAddVideoFileMediaItemIdPut (string fallbackMessageId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdAddVideoFileMediaItemIdPutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdAddVideoFileMediaItemIdPut(fallbackMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdAddVideoFileMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidcopypost"></a>
# **ApiFallbackMessageFallbackMessageIdCopyPost**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdCopyPost (string fallbackMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdCopyPostExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdCopyPost(fallbackMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdCopyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageiddelete"></a>
# **ApiFallbackMessageFallbackMessageIdDelete**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdDelete (string fallbackMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdDeleteExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdDelete(fallbackMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidisliveput"></a>
# **ApiFallbackMessageFallbackMessageIdIsLivePut**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdIsLivePut (string fallbackMessageId, ToggleLiveRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdIsLivePutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var body = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdIsLivePut(fallbackMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdIsLivePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **body** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidshouldnotsyncput"></a>
# **ApiFallbackMessageFallbackMessageIdShouldNotSyncPut**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdShouldNotSyncPut (string fallbackMessageId, ToggleSyncRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdShouldNotSyncPutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var body = new ToggleSyncRequest(); // ToggleSyncRequest |  (optional) 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdShouldNotSyncPut(fallbackMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdShouldNotSyncPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **body** | [**ToggleSyncRequest**](ToggleSyncRequest.md)|  | [optional] 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidupdateput"></a>
# **ApiFallbackMessageFallbackMessageIdUpdatePut**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdUpdatePut (string fallbackMessageId, UpdateFallbackMessageRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdUpdatePutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var body = new UpdateFallbackMessageRequest(); // UpdateFallbackMessageRequest |  (optional) 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdUpdatePut(fallbackMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **body** | [**UpdateFallbackMessageRequest**](UpdateFallbackMessageRequest.md)|  | [optional] 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidupdatestubput"></a>
# **ApiFallbackMessageFallbackMessageIdUpdateStubPut**
> FallbackMessageModel ApiFallbackMessageFallbackMessageIdUpdateStubPut (string fallbackMessageId, UpdateFallbackMessageStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdUpdateStubPutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var body = new UpdateFallbackMessageStubRequest(); // UpdateFallbackMessageStubRequest |  (optional) 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFallbackMessageIdUpdateStubPut(fallbackMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdUpdateStubPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **body** | [**UpdateFallbackMessageStubRequest**](UpdateFallbackMessageStubRequest.md)|  | [optional] 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidwebhooksbulkput"></a>
# **ApiFallbackMessageFallbackMessageIdWebhooksBulkPut**
> List<FallbackMessageWebhookModel> ApiFallbackMessageFallbackMessageIdWebhooksBulkPut (string fallbackMessageId, BulkWebhookInstancesUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdWebhooksBulkPutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var body = new BulkWebhookInstancesUpdateRequest(); // BulkWebhookInstancesUpdateRequest |  (optional) 

            try
            {
                List&lt;FallbackMessageWebhookModel&gt; result = apiInstance.ApiFallbackMessageFallbackMessageIdWebhooksBulkPut(fallbackMessageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdWebhooksBulkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **body** | [**BulkWebhookInstancesUpdateRequest**](BulkWebhookInstancesUpdateRequest.md)|  | [optional] 

### Return type

[**List<FallbackMessageWebhookModel>**](FallbackMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidwebhooksget"></a>
# **ApiFallbackMessageFallbackMessageIdWebhooksGet**
> List<FallbackMessageWebhookModel> ApiFallbackMessageFallbackMessageIdWebhooksGet (string fallbackMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdWebhooksGetExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 

            try
            {
                List&lt;FallbackMessageWebhookModel&gt; result = apiInstance.ApiFallbackMessageFallbackMessageIdWebhooksGet(fallbackMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdWebhooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 

### Return type

[**List<FallbackMessageWebhookModel>**](FallbackMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidwebhooksinstancewebhookidput"></a>
# **ApiFallbackMessageFallbackMessageIdWebhooksInstanceWebhookIdPut**
> FallbackMessageWebhookModel ApiFallbackMessageFallbackMessageIdWebhooksInstanceWebhookIdPut (string fallbackMessageId, string instanceWebhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdWebhooksInstanceWebhookIdPutExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                FallbackMessageWebhookModel result = apiInstance.ApiFallbackMessageFallbackMessageIdWebhooksInstanceWebhookIdPut(fallbackMessageId, instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdWebhooksInstanceWebhookIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **instanceWebhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**FallbackMessageWebhookModel**](FallbackMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefallbackmessageidwebhookswebhookidpost"></a>
# **ApiFallbackMessageFallbackMessageIdWebhooksWebhookIdPost**
> FallbackMessageWebhookModel ApiFallbackMessageFallbackMessageIdWebhooksWebhookIdPost (string fallbackMessageId, string webhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFallbackMessageIdWebhooksWebhookIdPostExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageId = fallbackMessageId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                FallbackMessageWebhookModel result = apiInstance.ApiFallbackMessageFallbackMessageIdWebhooksWebhookIdPost(fallbackMessageId, webhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFallbackMessageIdWebhooksWebhookIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageId** | **string**|  | 
 **webhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**FallbackMessageWebhookModel**](FallbackMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefullidget"></a>
# **ApiFallbackMessageFullIdGet**
> FallbackMessageModel ApiFallbackMessageFullIdGet (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFullIdGetExample
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

            var apiInstance = new FallbackMessageApi();
            var id = id_example;  // string | 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFullIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFullIdGet: " + e.Message );
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

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagefullpost"></a>
# **ApiFallbackMessageFullPost**
> FallbackMessageModel ApiFallbackMessageFullPost (FallbackMessageModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageFullPostExample
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

            var apiInstance = new FallbackMessageApi();
            var body = new FallbackMessageModel(); // FallbackMessageModel |  (optional) 

            try
            {
                FallbackMessageModel result = apiInstance.ApiFallbackMessageFullPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageFullPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FallbackMessageModel**](FallbackMessageModel.md)|  | [optional] 

### Return type

[**FallbackMessageModel**](FallbackMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagewebhookfallbackmessagewebhookiddelete"></a>
# **ApiFallbackMessageWebhookFallbackMessageWebhookIdDelete**
> FallbackMessageWebhookModel ApiFallbackMessageWebhookFallbackMessageWebhookIdDelete (string fallbackMessageWebhookId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageWebhookFallbackMessageWebhookIdDeleteExample
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

            var apiInstance = new FallbackMessageApi();
            var fallbackMessageWebhookId = fallbackMessageWebhookId_example;  // string | 

            try
            {
                FallbackMessageWebhookModel result = apiInstance.ApiFallbackMessageWebhookFallbackMessageWebhookIdDelete(fallbackMessageWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageWebhookFallbackMessageWebhookIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fallbackMessageWebhookId** | **string**|  | 

### Return type

[**FallbackMessageWebhookModel**](FallbackMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifallbackmessagewebhookinstancewebhookiduserparametersparameternamedelete"></a>
# **ApiFallbackMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete**
> bool? ApiFallbackMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete (string instanceWebhookId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageWebhookInstanceWebhookIdUserParametersParameterNameDeleteExample
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

            var apiInstance = new FallbackMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.ApiFallbackMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageWebhookInstanceWebhookIdUserParametersParameterNameDelete: " + e.Message );
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
<a name="apifallbackmessagewebhookinstancewebhookiduserparameterspost"></a>
# **ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPost**
> bool? ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPost (string instanceWebhookId, UserDefinedWebhookParameterCreateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPostExample
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

            var apiInstance = new FallbackMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPost(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPost: " + e.Message );
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
<a name="apifallbackmessagewebhookinstancewebhookiduserparametersput"></a>
# **ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPut**
> bool? ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPut (string instanceWebhookId, UserDefinedWebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPutExample
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

            var apiInstance = new FallbackMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageWebhookInstanceWebhookIdUserParametersPut: " + e.Message );
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
<a name="apifallbackmessagewebhookinstancewebhookidwebhookparametersput"></a>
# **ApiFallbackMessageWebhookInstanceWebhookIdWebhookParametersPut**
> bool? ApiFallbackMessageWebhookInstanceWebhookIdWebhookParametersPut (string instanceWebhookId, WebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFallbackMessageWebhookInstanceWebhookIdWebhookParametersPutExample
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

            var apiInstance = new FallbackMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiFallbackMessageWebhookInstanceWebhookIdWebhookParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FallbackMessageApi.ApiFallbackMessageWebhookInstanceWebhookIdWebhookParametersPut: " + e.Message );
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
