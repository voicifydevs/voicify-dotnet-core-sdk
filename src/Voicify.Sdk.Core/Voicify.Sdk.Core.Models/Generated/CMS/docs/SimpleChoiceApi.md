# Voicify.Sdk.Core.Models.Api.SimpleChoiceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAudioFile**](SimpleChoiceApi.md#addaudiofile) | **PUT** /api/SimpleChoice/{simpleChoiceResponseId}/addAudioFile/{mediaItemId} | 
[**AddLargeImage**](SimpleChoiceApi.md#addlargeimage) | **PUT** /api/SimpleChoice/{simpleChoiceResponseId}/addLargeImage/{mediaItemId} | 
[**AddSmallImage**](SimpleChoiceApi.md#addsmallimage) | **PUT** /api/SimpleChoice/{simpleChoiceResponseId}/addSmallImage/{mediaItemId} | 
[**AddVideoFile**](SimpleChoiceApi.md#addvideofile) | **PUT** /api/SimpleChoice/{simpleChoiceResponseId}/addVideoFile/{mediaItemId} | 
[**AddWebhook**](SimpleChoiceApi.md#addwebhook) | **POST** /api/SimpleChoice/{simpleChoiceId}/webhooks/{webhookId} | 
[**BulkUpdateAttachedWebhooks**](SimpleChoiceApi.md#bulkupdateattachedwebhooks) | **PUT** /api/SimpleChoice/{simpleChoiceId}/webhooks/bulk | 
[**BulkUpdateSimpleChoice**](SimpleChoiceApi.md#bulkupdatesimplechoice) | **PUT** /api/SimpleChoice/{simpleChoiceId}/bulkUpdate | 
[**BulkUpdateSimpleChoiceStub**](SimpleChoiceApi.md#bulkupdatesimplechoicestub) | **PUT** /api/SimpleChoice/{simpleChoiceId}/bulkUpdate/stub | 
[**CopyContentItem**](SimpleChoiceApi.md#copycontentitem) | **POST** /api/SimpleChoice/{simpleChoiceId}/copy | 
[**CreateFullContentItem**](SimpleChoiceApi.md#createfullcontentitem) | **POST** /api/SimpleChoice/full | 
[**CreateResponse**](SimpleChoiceApi.md#createresponse) | **POST** /api/SimpleChoice/{simpleChoiceId}/response | 
[**CreateSimpleChoice**](SimpleChoiceApi.md#createsimplechoice) | **POST** /api/SimpleChoice | 
[**CreateSimpleChoiceStub**](SimpleChoiceApi.md#createsimplechoicestub) | **POST** /api/SimpleChoice/stub | 
[**CreateUserDefinedParameter**](SimpleChoiceApi.md#createuserdefinedparameter) | **POST** /api/SimpleChoice/webhook/{instanceWebhookId}/userParameters | 
[**DeleteResponse**](SimpleChoiceApi.md#deleteresponse) | **DELETE** /api/SimpleChoice/response/{simpleChoiceResponseId} | 
[**DeleteSimpleChoice**](SimpleChoiceApi.md#deletesimplechoice) | **DELETE** /api/SimpleChoice/{simpleChoiceId} | 
[**FindFullById**](SimpleChoiceApi.md#findfullbyid) | **GET** /api/SimpleChoice/full/{id} | 
[**GetByApplicationFeature**](SimpleChoiceApi.md#getbyapplicationfeature) | **GET** /api/SimpleChoice/byFeature/{applicationFeatureId} | 
[**GetMessagesForApplication**](SimpleChoiceApi.md#getmessagesforapplication) | **GET** /api/SimpleChoice/{applicationId} | 
[**GetMessagesForModule**](SimpleChoiceApi.md#getmessagesformodule) | **GET** /api/SimpleChoice/module/{applicationModuleId} | 
[**GetWebhooks**](SimpleChoiceApi.md#getwebhooks) | **GET** /api/SimpleChoice/{simpleChoiceId}/webhooks | 
[**MoveContentItemToApplicationFeature**](SimpleChoiceApi.md#movecontentitemtoapplicationfeature) | **PUT** /api/SimpleChoice/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**RemoveUserDefinedParameter**](SimpleChoiceApi.md#removeuserdefinedparameter) | **DELETE** /api/SimpleChoice/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**RemoveWebhook**](SimpleChoiceApi.md#removewebhook) | **DELETE** /api/SimpleChoice/webhook/{simpleChoiceWebhookId} | 
[**ToggleLive**](SimpleChoiceApi.md#togglelive) | **PUT** /api/SimpleChoice/{simpleChoiceId}/isLive | 
[**ToggleSync**](SimpleChoiceApi.md#togglesync) | **PUT** /api/SimpleChoice/{simpleChoiceId}/shouldNotSync | 
[**UpdateAttachedWebhook**](SimpleChoiceApi.md#updateattachedwebhook) | **PUT** /api/SimpleChoice/{simpleChoiceId}/webhooks/{webhookInstanceId} | 
[**UpdateFullContentItem**](SimpleChoiceApi.md#updatefullcontentitem) | **PUT** /api/SimpleChoice/{contentItemId}/full | 
[**UpdateMessage**](SimpleChoiceApi.md#updatemessage) | **PUT** /api/SimpleChoice/{simpleChoiceId} | 
[**UpdateResponse**](SimpleChoiceApi.md#updateresponse) | **PUT** /api/SimpleChoice/response/{simpleChoiceResponseId} | 
[**UpdateUserDefinedParameter**](SimpleChoiceApi.md#updateuserdefinedparameter) | **PUT** /api/SimpleChoice/webhook/{instanceWebhookId}/userParameters | 
[**UpdateWebhookParameter**](SimpleChoiceApi.md#updatewebhookparameter) | **PUT** /api/SimpleChoice/webhook/{instanceWebhookId}/webhookParameters | 

<a name="addaudiofile"></a>
# **AddAudioFile**
> SimpleChoiceResponseModel AddAudioFile (string simpleChoiceResponseId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddAudioFileExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                SimpleChoiceResponseModel result = apiInstance.AddAudioFile(simpleChoiceResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddAudioFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addlargeimage"></a>
# **AddLargeImage**
> SimpleChoiceResponseModel AddLargeImage (string simpleChoiceResponseId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddLargeImageExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                SimpleChoiceResponseModel result = apiInstance.AddLargeImage(simpleChoiceResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddLargeImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addsmallimage"></a>
# **AddSmallImage**
> SimpleChoiceResponseModel AddSmallImage (string simpleChoiceResponseId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddSmallImageExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                SimpleChoiceResponseModel result = apiInstance.AddSmallImage(simpleChoiceResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddSmallImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addvideofile"></a>
# **AddVideoFile**
> SimpleChoiceResponseModel AddVideoFile (string simpleChoiceResponseId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddVideoFileExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                SimpleChoiceResponseModel result = apiInstance.AddVideoFile(simpleChoiceResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddVideoFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addwebhook"></a>
# **AddWebhook**
> SimpleChoiceWebhookModel AddWebhook (string simpleChoiceId, string webhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddWebhookExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                SimpleChoiceWebhookModel result = apiInstance.AddWebhook(simpleChoiceId, webhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **webhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceWebhookModel**](SimpleChoiceWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="bulkupdateattachedwebhooks"></a>
# **BulkUpdateAttachedWebhooks**
> List<SimpleChoiceWebhookModel> BulkUpdateAttachedWebhooks (string simpleChoiceId, BulkWebhookInstancesUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateAttachedWebhooksExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var body = new BulkWebhookInstancesUpdateRequest(); // BulkWebhookInstancesUpdateRequest |  (optional) 

            try
            {
                List&lt;SimpleChoiceWebhookModel&gt; result = apiInstance.BulkUpdateAttachedWebhooks(simpleChoiceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.BulkUpdateAttachedWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **body** | [**BulkWebhookInstancesUpdateRequest**](BulkWebhookInstancesUpdateRequest.md)|  | [optional] 

### Return type

[**List<SimpleChoiceWebhookModel>**](SimpleChoiceWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="bulkupdatesimplechoice"></a>
# **BulkUpdateSimpleChoice**
> SimpleChoiceModel BulkUpdateSimpleChoice (string simpleChoiceId, BulkUpdateSimpleChoiceRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateSimpleChoiceExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var body = new BulkUpdateSimpleChoiceRequest(); // BulkUpdateSimpleChoiceRequest |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.BulkUpdateSimpleChoice(simpleChoiceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.BulkUpdateSimpleChoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **body** | [**BulkUpdateSimpleChoiceRequest**](BulkUpdateSimpleChoiceRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="bulkupdatesimplechoicestub"></a>
# **BulkUpdateSimpleChoiceStub**
> SimpleChoiceModel BulkUpdateSimpleChoiceStub (string simpleChoiceId, BulkUpdateSimpleChoiceStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateSimpleChoiceStubExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var body = new BulkUpdateSimpleChoiceStubRequest(); // BulkUpdateSimpleChoiceStubRequest |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.BulkUpdateSimpleChoiceStub(simpleChoiceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.BulkUpdateSimpleChoiceStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **body** | [**BulkUpdateSimpleChoiceStubRequest**](BulkUpdateSimpleChoiceStubRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="copycontentitem"></a>
# **CopyContentItem**
> SimpleChoiceModel CopyContentItem (string simpleChoiceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CopyContentItemExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 

            try
            {
                SimpleChoiceModel result = apiInstance.CopyContentItem(simpleChoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CopyContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createfullcontentitem"></a>
# **CreateFullContentItem**
> SimpleChoiceModel CreateFullContentItem (SimpleChoiceModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateFullContentItemExample
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

            var apiInstance = new SimpleChoiceApi();
            var body = new SimpleChoiceModel(); // SimpleChoiceModel |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.CreateFullContentItem(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SimpleChoiceModel**](SimpleChoiceModel.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createresponse"></a>
# **CreateResponse**
> SimpleChoiceResponseModel CreateResponse (string simpleChoiceId, NewSimpleChoiceResponseRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateResponseExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var body = new NewSimpleChoiceResponseRequest(); // NewSimpleChoiceResponseRequest |  (optional) 

            try
            {
                SimpleChoiceResponseModel result = apiInstance.CreateResponse(simpleChoiceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **body** | [**NewSimpleChoiceResponseRequest**](NewSimpleChoiceResponseRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createsimplechoice"></a>
# **CreateSimpleChoice**
> SimpleChoiceModel CreateSimpleChoice (NewSimpleChoiceRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateSimpleChoiceExample
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

            var apiInstance = new SimpleChoiceApi();
            var body = new NewSimpleChoiceRequest(); // NewSimpleChoiceRequest |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.CreateSimpleChoice(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateSimpleChoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewSimpleChoiceRequest**](NewSimpleChoiceRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createsimplechoicestub"></a>
# **CreateSimpleChoiceStub**
> SimpleChoiceModel CreateSimpleChoiceStub (NewSimpleChoiceStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateSimpleChoiceStubExample
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

            var apiInstance = new SimpleChoiceApi();
            var body = new NewSimpleChoiceStubRequest(); // NewSimpleChoiceStubRequest |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.CreateSimpleChoiceStub(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateSimpleChoiceStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewSimpleChoiceStubRequest**](NewSimpleChoiceStubRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createuserdefinedparameter"></a>
# **CreateUserDefinedParameter**
> bool? CreateUserDefinedParameter (string instanceWebhookId, UserDefinedWebhookParameterCreateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateUserDefinedParameterExample
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

            var apiInstance = new SimpleChoiceApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.CreateUserDefinedParameter(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateUserDefinedParameter: " + e.Message );
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
<a name="deleteresponse"></a>
# **DeleteResponse**
> SimpleChoiceResponseModel DeleteResponse (string simpleChoiceResponseId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteResponseExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 

            try
            {
                SimpleChoiceResponseModel result = apiInstance.DeleteResponse(simpleChoiceResponseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.DeleteResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesimplechoice"></a>
# **DeleteSimpleChoice**
> SimpleChoiceModel DeleteSimpleChoice (string simpleChoiceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteSimpleChoiceExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 

            try
            {
                SimpleChoiceModel result = apiInstance.DeleteSimpleChoice(simpleChoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.DeleteSimpleChoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="findfullbyid"></a>
# **FindFullById**
> SimpleChoiceModel FindFullById (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FindFullByIdExample
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

            var apiInstance = new SimpleChoiceApi();
            var id = id_example;  // string | 

            try
            {
                SimpleChoiceModel result = apiInstance.FindFullById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.FindFullById: " + e.Message );
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

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbyapplicationfeature"></a>
# **GetByApplicationFeature**
> List<SimpleChoiceModel> GetByApplicationFeature (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetByApplicationFeatureExample
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

            var apiInstance = new SimpleChoiceApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                List&lt;SimpleChoiceModel&gt; result = apiInstance.GetByApplicationFeature(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.GetByApplicationFeature: " + e.Message );
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

[**List<SimpleChoiceModel>**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmessagesforapplication"></a>
# **GetMessagesForApplication**
> List<SimpleChoiceModel> GetMessagesForApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetMessagesForApplicationExample
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

            var apiInstance = new SimpleChoiceApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;SimpleChoiceModel&gt; result = apiInstance.GetMessagesForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.GetMessagesForApplication: " + e.Message );
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

[**List<SimpleChoiceModel>**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmessagesformodule"></a>
# **GetMessagesForModule**
> List<SimpleChoiceModel> GetMessagesForModule (string applicationModuleId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetMessagesForModuleExample
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

            var apiInstance = new SimpleChoiceApi();
            var applicationModuleId = applicationModuleId_example;  // string | 

            try
            {
                List&lt;SimpleChoiceModel&gt; result = apiInstance.GetMessagesForModule(applicationModuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.GetMessagesForModule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationModuleId** | **string**|  | 

### Return type

[**List<SimpleChoiceModel>**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhooks"></a>
# **GetWebhooks**
> List<SimpleChoiceWebhookModel> GetWebhooks (string simpleChoiceId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetWebhooksExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 

            try
            {
                List&lt;SimpleChoiceWebhookModel&gt; result = apiInstance.GetWebhooks(simpleChoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 

### Return type

[**List<SimpleChoiceWebhookModel>**](SimpleChoiceWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="movecontentitemtoapplicationfeature"></a>
# **MoveContentItemToApplicationFeature**
> SimpleChoiceModel MoveContentItemToApplicationFeature (string contentItemId, string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class MoveContentItemToApplicationFeatureExample
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

            var apiInstance = new SimpleChoiceApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                SimpleChoiceModel result = apiInstance.MoveContentItemToApplicationFeature(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.MoveContentItemToApplicationFeature: " + e.Message );
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

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removeuserdefinedparameter"></a>
# **RemoveUserDefinedParameter**
> bool? RemoveUserDefinedParameter (string instanceWebhookId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveUserDefinedParameterExample
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

            var apiInstance = new SimpleChoiceApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.RemoveUserDefinedParameter(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.RemoveUserDefinedParameter: " + e.Message );
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
<a name="removewebhook"></a>
# **RemoveWebhook**
> SimpleChoiceWebhookModel RemoveWebhook (string simpleChoiceWebhookId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveWebhookExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceWebhookId = simpleChoiceWebhookId_example;  // string | 

            try
            {
                SimpleChoiceWebhookModel result = apiInstance.RemoveWebhook(simpleChoiceWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.RemoveWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceWebhookId** | **string**|  | 

### Return type

[**SimpleChoiceWebhookModel**](SimpleChoiceWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="togglelive"></a>
# **ToggleLive**
> SimpleChoiceModel ToggleLive (string simpleChoiceId, ToggleLiveRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ToggleLiveExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var body = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.ToggleLive(simpleChoiceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.ToggleLive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **body** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="togglesync"></a>
# **ToggleSync**
> SimpleChoiceModel ToggleSync (string simpleChoiceId, ToggleSyncRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ToggleSyncExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var body = new ToggleSyncRequest(); // ToggleSyncRequest |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.ToggleSync(simpleChoiceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.ToggleSync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **body** | [**ToggleSyncRequest**](ToggleSyncRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateattachedwebhook"></a>
# **UpdateAttachedWebhook**
> SimpleChoiceWebhookModel UpdateAttachedWebhook (string simpleChoiceId, string webhookInstanceId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateAttachedWebhookExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                SimpleChoiceWebhookModel result = apiInstance.UpdateAttachedWebhook(simpleChoiceId, webhookInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateAttachedWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceWebhookModel**](SimpleChoiceWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatefullcontentitem"></a>
# **UpdateFullContentItem**
> SimpleChoiceModel UpdateFullContentItem (string contentItemId, SimpleChoiceModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateFullContentItemExample
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

            var apiInstance = new SimpleChoiceApi();
            var contentItemId = contentItemId_example;  // string | 
            var body = new SimpleChoiceModel(); // SimpleChoiceModel |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.UpdateFullContentItem(contentItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **body** | [**SimpleChoiceModel**](SimpleChoiceModel.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatemessage"></a>
# **UpdateMessage**
> SimpleChoiceModel UpdateMessage (string simpleChoiceId, UpdateSimpleChoiceRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateMessageExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var body = new UpdateSimpleChoiceRequest(); // UpdateSimpleChoiceRequest |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.UpdateMessage(simpleChoiceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **body** | [**UpdateSimpleChoiceRequest**](UpdateSimpleChoiceRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateresponse"></a>
# **UpdateResponse**
> SimpleChoiceResponseModel UpdateResponse (string simpleChoiceResponseId, UpdateSimpleChoiceResponseRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateResponseExample
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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var body = new UpdateSimpleChoiceResponseRequest(); // UpdateSimpleChoiceResponseRequest |  (optional) 

            try
            {
                SimpleChoiceResponseModel result = apiInstance.UpdateResponse(simpleChoiceResponseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **body** | [**UpdateSimpleChoiceResponseRequest**](UpdateSimpleChoiceResponseRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateuserdefinedparameter"></a>
# **UpdateUserDefinedParameter**
> bool? UpdateUserDefinedParameter (string instanceWebhookId, UserDefinedWebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateUserDefinedParameterExample
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

            var apiInstance = new SimpleChoiceApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateUserDefinedParameter(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateUserDefinedParameter: " + e.Message );
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
<a name="updatewebhookparameter"></a>
# **UpdateWebhookParameter**
> bool? UpdateWebhookParameter (string instanceWebhookId, WebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateWebhookParameterExample
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

            var apiInstance = new SimpleChoiceApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateWebhookParameter(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateWebhookParameter: " + e.Message );
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
