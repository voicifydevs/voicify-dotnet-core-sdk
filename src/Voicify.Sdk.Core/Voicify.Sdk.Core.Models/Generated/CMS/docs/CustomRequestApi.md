# Voicify.Sdk.Core.Models.Api.CustomRequestApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiCustomRequestApplicationIdGet**](CustomRequestApi.md#apicustomrequestapplicationidget) | **GET** /api/CustomRequest/{applicationId} | 
[**ApiCustomRequestByFeatureApplicationFeatureIdGet**](CustomRequestApi.md#apicustomrequestbyfeatureapplicationfeatureidget) | **GET** /api/CustomRequest/byFeature/{applicationFeatureId} | 
[**ApiCustomRequestContentItemIdFullPut**](CustomRequestApi.md#apicustomrequestcontentitemidfullput) | **PUT** /api/CustomRequest/{contentItemId}/full | 
[**ApiCustomRequestContentItemIdMoveToFeatureApplicationFeatureIdPut**](CustomRequestApi.md#apicustomrequestcontentitemidmovetofeatureapplicationfeatureidput) | **PUT** /api/CustomRequest/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**ApiCustomRequestCustomRequestIdBulkUpdatePut**](CustomRequestApi.md#apicustomrequestcustomrequestidbulkupdateput) | **PUT** /api/CustomRequest/{customRequestId}/bulkUpdate | 
[**ApiCustomRequestCustomRequestIdBulkUpdateStubPut**](CustomRequestApi.md#apicustomrequestcustomrequestidbulkupdatestubput) | **PUT** /api/CustomRequest/{customRequestId}/bulkUpdate/stub | 
[**ApiCustomRequestCustomRequestIdCopyPost**](CustomRequestApi.md#apicustomrequestcustomrequestidcopypost) | **POST** /api/CustomRequest/{customRequestId}/copy | 
[**ApiCustomRequestCustomRequestIdDelete**](CustomRequestApi.md#apicustomrequestcustomrequestiddelete) | **DELETE** /api/CustomRequest/{customRequestId} | 
[**ApiCustomRequestCustomRequestIdIsLivePut**](CustomRequestApi.md#apicustomrequestcustomrequestidisliveput) | **PUT** /api/CustomRequest/{customRequestId}/isLive | 
[**ApiCustomRequestCustomRequestIdPut**](CustomRequestApi.md#apicustomrequestcustomrequestidput) | **PUT** /api/CustomRequest/{customRequestId} | 
[**ApiCustomRequestCustomRequestIdResponsePost**](CustomRequestApi.md#apicustomrequestcustomrequestidresponsepost) | **POST** /api/CustomRequest/{customRequestId}/response | 
[**ApiCustomRequestCustomRequestIdShouldNotSyncPut**](CustomRequestApi.md#apicustomrequestcustomrequestidshouldnotsyncput) | **PUT** /api/CustomRequest/{customRequestId}/shouldNotSync | 
[**ApiCustomRequestCustomRequestIdWebhooksBulkPut**](CustomRequestApi.md#apicustomrequestcustomrequestidwebhooksbulkput) | **PUT** /api/CustomRequest/{customRequestId}/webhooks/bulk | 
[**ApiCustomRequestCustomRequestIdWebhooksGet**](CustomRequestApi.md#apicustomrequestcustomrequestidwebhooksget) | **GET** /api/CustomRequest/{customRequestId}/webhooks | 
[**ApiCustomRequestCustomRequestIdWebhooksWebhookIdPost**](CustomRequestApi.md#apicustomrequestcustomrequestidwebhookswebhookidpost) | **POST** /api/CustomRequest/{customRequestId}/webhooks/{webhookId} | 
[**ApiCustomRequestCustomRequestIdWebhooksWebhookInstanceIdPut**](CustomRequestApi.md#apicustomrequestcustomrequestidwebhookswebhookinstanceidput) | **PUT** /api/CustomRequest/{customRequestId}/webhooks/{webhookInstanceId} | 
[**ApiCustomRequestCustomRequestResponseIdAddAudioFileMediaItemIdPut**](CustomRequestApi.md#apicustomrequestcustomrequestresponseidaddaudiofilemediaitemidput) | **PUT** /api/CustomRequest/{customRequestResponseId}/addAudioFile/{mediaItemId} | 
[**ApiCustomRequestCustomRequestResponseIdAddLargeImageMediaItemIdPut**](CustomRequestApi.md#apicustomrequestcustomrequestresponseidaddlargeimagemediaitemidput) | **PUT** /api/CustomRequest/{customRequestResponseId}/addLargeImage/{mediaItemId} | 
[**ApiCustomRequestCustomRequestResponseIdAddSmallImageMediaItemIdPut**](CustomRequestApi.md#apicustomrequestcustomrequestresponseidaddsmallimagemediaitemidput) | **PUT** /api/CustomRequest/{customRequestResponseId}/addSmallImage/{mediaItemId} | 
[**ApiCustomRequestCustomRequestResponseIdAddVideoFileMediaItemIdPut**](CustomRequestApi.md#apicustomrequestcustomrequestresponseidaddvideofilemediaitemidput) | **PUT** /api/CustomRequest/{customRequestResponseId}/addVideoFile/{mediaItemId} | 
[**ApiCustomRequestFullIdGet**](CustomRequestApi.md#apicustomrequestfullidget) | **GET** /api/CustomRequest/full/{id} | 
[**ApiCustomRequestFullPost**](CustomRequestApi.md#apicustomrequestfullpost) | **POST** /api/CustomRequest/full | 
[**ApiCustomRequestModuleApplicationModuleIdGet**](CustomRequestApi.md#apicustomrequestmoduleapplicationmoduleidget) | **GET** /api/CustomRequest/module/{applicationModuleId} | 
[**ApiCustomRequestPost**](CustomRequestApi.md#apicustomrequestpost) | **POST** /api/CustomRequest | 
[**ApiCustomRequestResponseCustomRequestResponseIdDelete**](CustomRequestApi.md#apicustomrequestresponsecustomrequestresponseiddelete) | **DELETE** /api/CustomRequest/response/{customRequestResponseId} | 
[**ApiCustomRequestResponseCustomRequestResponseIdMediaGet**](CustomRequestApi.md#apicustomrequestresponsecustomrequestresponseidmediaget) | **GET** /api/CustomRequest/response/{customRequestResponseId}/media | 
[**ApiCustomRequestResponseCustomRequestResponseIdPut**](CustomRequestApi.md#apicustomrequestresponsecustomrequestresponseidput) | **PUT** /api/CustomRequest/response/{customRequestResponseId} | 
[**ApiCustomRequestStubPost**](CustomRequestApi.md#apicustomrequeststubpost) | **POST** /api/CustomRequest/stub | 
[**ApiCustomRequestWebhookCustomRequestWebhookIdDelete**](CustomRequestApi.md#apicustomrequestwebhookcustomrequestwebhookiddelete) | **DELETE** /api/CustomRequest/webhook/{customRequestWebhookId} | 

<a name="apicustomrequestapplicationidget"></a>
# **ApiCustomRequestApplicationIdGet**
> List<CustomRequestModel> ApiCustomRequestApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestApplicationIdGetExample
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

            var apiInstance = new CustomRequestApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;CustomRequestModel&gt; result = apiInstance.ApiCustomRequestApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestApplicationIdGet: " + e.Message );
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

[**List<CustomRequestModel>**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestbyfeatureapplicationfeatureidget"></a>
# **ApiCustomRequestByFeatureApplicationFeatureIdGet**
> List<CustomRequestModel> ApiCustomRequestByFeatureApplicationFeatureIdGet (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestByFeatureApplicationFeatureIdGetExample
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

            var apiInstance = new CustomRequestApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                List&lt;CustomRequestModel&gt; result = apiInstance.ApiCustomRequestByFeatureApplicationFeatureIdGet(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestByFeatureApplicationFeatureIdGet: " + e.Message );
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

[**List<CustomRequestModel>**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcontentitemidfullput"></a>
# **ApiCustomRequestContentItemIdFullPut**
> CustomRequestModel ApiCustomRequestContentItemIdFullPut (string contentItemId, CustomRequestModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestContentItemIdFullPutExample
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

            var apiInstance = new CustomRequestApi();
            var contentItemId = contentItemId_example;  // string | 
            var body = new CustomRequestModel(); // CustomRequestModel |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestContentItemIdFullPut(contentItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestContentItemIdFullPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **body** | [**CustomRequestModel**](CustomRequestModel.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcontentitemidmovetofeatureapplicationfeatureidput"></a>
# **ApiCustomRequestContentItemIdMoveToFeatureApplicationFeatureIdPut**
> CustomRequestModel ApiCustomRequestContentItemIdMoveToFeatureApplicationFeatureIdPut (string contentItemId, string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestContentItemIdMoveToFeatureApplicationFeatureIdPutExample
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

            var apiInstance = new CustomRequestApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestContentItemIdMoveToFeatureApplicationFeatureIdPut(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestContentItemIdMoveToFeatureApplicationFeatureIdPut: " + e.Message );
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

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidbulkupdateput"></a>
# **ApiCustomRequestCustomRequestIdBulkUpdatePut**
> CustomRequestModel ApiCustomRequestCustomRequestIdBulkUpdatePut (string customRequestId, BulkUpdateCustomRequestRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdBulkUpdatePutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var body = new BulkUpdateCustomRequestRequest(); // BulkUpdateCustomRequestRequest |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestCustomRequestIdBulkUpdatePut(customRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdBulkUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **body** | [**BulkUpdateCustomRequestRequest**](BulkUpdateCustomRequestRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidbulkupdatestubput"></a>
# **ApiCustomRequestCustomRequestIdBulkUpdateStubPut**
> CustomRequestModel ApiCustomRequestCustomRequestIdBulkUpdateStubPut (string customRequestId, BulkUpdateCustomRequestStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdBulkUpdateStubPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var body = new BulkUpdateCustomRequestStubRequest(); // BulkUpdateCustomRequestStubRequest |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestCustomRequestIdBulkUpdateStubPut(customRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdBulkUpdateStubPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **body** | [**BulkUpdateCustomRequestStubRequest**](BulkUpdateCustomRequestStubRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidcopypost"></a>
# **ApiCustomRequestCustomRequestIdCopyPost**
> CustomRequestModel ApiCustomRequestCustomRequestIdCopyPost (string customRequestId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdCopyPostExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestCustomRequestIdCopyPost(customRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdCopyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestiddelete"></a>
# **ApiCustomRequestCustomRequestIdDelete**
> CustomRequestModel ApiCustomRequestCustomRequestIdDelete (string customRequestId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdDeleteExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestCustomRequestIdDelete(customRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidisliveput"></a>
# **ApiCustomRequestCustomRequestIdIsLivePut**
> CustomRequestModel ApiCustomRequestCustomRequestIdIsLivePut (string customRequestId, ToggleLiveRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdIsLivePutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var body = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestCustomRequestIdIsLivePut(customRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdIsLivePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **body** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidput"></a>
# **ApiCustomRequestCustomRequestIdPut**
> CustomRequestModel ApiCustomRequestCustomRequestIdPut (string customRequestId, UpdateCustomRequestRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var body = new UpdateCustomRequestRequest(); // UpdateCustomRequestRequest |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestCustomRequestIdPut(customRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **body** | [**UpdateCustomRequestRequest**](UpdateCustomRequestRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidresponsepost"></a>
# **ApiCustomRequestCustomRequestIdResponsePost**
> CustomRequestResponseModel ApiCustomRequestCustomRequestIdResponsePost (string customRequestId, NewCustomRequestResponseRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdResponsePostExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var body = new NewCustomRequestResponseRequest(); // NewCustomRequestResponseRequest |  (optional) 

            try
            {
                CustomRequestResponseModel result = apiInstance.ApiCustomRequestCustomRequestIdResponsePost(customRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdResponsePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **body** | [**NewCustomRequestResponseRequest**](NewCustomRequestResponseRequest.md)|  | [optional] 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidshouldnotsyncput"></a>
# **ApiCustomRequestCustomRequestIdShouldNotSyncPut**
> CustomRequestModel ApiCustomRequestCustomRequestIdShouldNotSyncPut (string customRequestId, ToggleSyncRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdShouldNotSyncPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var body = new ToggleSyncRequest(); // ToggleSyncRequest |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestCustomRequestIdShouldNotSyncPut(customRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdShouldNotSyncPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **body** | [**ToggleSyncRequest**](ToggleSyncRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidwebhooksbulkput"></a>
# **ApiCustomRequestCustomRequestIdWebhooksBulkPut**
> List<CustomRequestWebhookModel> ApiCustomRequestCustomRequestIdWebhooksBulkPut (string customRequestId, BulkWebhookInstancesUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdWebhooksBulkPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var body = new BulkWebhookInstancesUpdateRequest(); // BulkWebhookInstancesUpdateRequest |  (optional) 

            try
            {
                List&lt;CustomRequestWebhookModel&gt; result = apiInstance.ApiCustomRequestCustomRequestIdWebhooksBulkPut(customRequestId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdWebhooksBulkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **body** | [**BulkWebhookInstancesUpdateRequest**](BulkWebhookInstancesUpdateRequest.md)|  | [optional] 

### Return type

[**List<CustomRequestWebhookModel>**](CustomRequestWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidwebhooksget"></a>
# **ApiCustomRequestCustomRequestIdWebhooksGet**
> List<CustomRequestWebhookModel> ApiCustomRequestCustomRequestIdWebhooksGet (string customRequestId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdWebhooksGetExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 

            try
            {
                List&lt;CustomRequestWebhookModel&gt; result = apiInstance.ApiCustomRequestCustomRequestIdWebhooksGet(customRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdWebhooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 

### Return type

[**List<CustomRequestWebhookModel>**](CustomRequestWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidwebhookswebhookidpost"></a>
# **ApiCustomRequestCustomRequestIdWebhooksWebhookIdPost**
> CustomRequestWebhookModel ApiCustomRequestCustomRequestIdWebhooksWebhookIdPost (string customRequestId, string webhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdWebhooksWebhookIdPostExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                CustomRequestWebhookModel result = apiInstance.ApiCustomRequestCustomRequestIdWebhooksWebhookIdPost(customRequestId, webhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdWebhooksWebhookIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **webhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**CustomRequestWebhookModel**](CustomRequestWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestidwebhookswebhookinstanceidput"></a>
# **ApiCustomRequestCustomRequestIdWebhooksWebhookInstanceIdPut**
> CustomRequestWebhookModel ApiCustomRequestCustomRequestIdWebhooksWebhookInstanceIdPut (string customRequestId, string webhookInstanceId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestIdWebhooksWebhookInstanceIdPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                CustomRequestWebhookModel result = apiInstance.ApiCustomRequestCustomRequestIdWebhooksWebhookInstanceIdPut(customRequestId, webhookInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestIdWebhooksWebhookInstanceIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**CustomRequestWebhookModel**](CustomRequestWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestresponseidaddaudiofilemediaitemidput"></a>
# **ApiCustomRequestCustomRequestResponseIdAddAudioFileMediaItemIdPut**
> CustomRequestResponseModel ApiCustomRequestCustomRequestResponseIdAddAudioFileMediaItemIdPut (string customRequestResponseId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestResponseIdAddAudioFileMediaItemIdPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                CustomRequestResponseModel result = apiInstance.ApiCustomRequestCustomRequestResponseIdAddAudioFileMediaItemIdPut(customRequestResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestResponseIdAddAudioFileMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestresponseidaddlargeimagemediaitemidput"></a>
# **ApiCustomRequestCustomRequestResponseIdAddLargeImageMediaItemIdPut**
> CustomRequestResponseModel ApiCustomRequestCustomRequestResponseIdAddLargeImageMediaItemIdPut (string customRequestResponseId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestResponseIdAddLargeImageMediaItemIdPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                CustomRequestResponseModel result = apiInstance.ApiCustomRequestCustomRequestResponseIdAddLargeImageMediaItemIdPut(customRequestResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestResponseIdAddLargeImageMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestresponseidaddsmallimagemediaitemidput"></a>
# **ApiCustomRequestCustomRequestResponseIdAddSmallImageMediaItemIdPut**
> CustomRequestResponseModel ApiCustomRequestCustomRequestResponseIdAddSmallImageMediaItemIdPut (string customRequestResponseId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestResponseIdAddSmallImageMediaItemIdPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                CustomRequestResponseModel result = apiInstance.ApiCustomRequestCustomRequestResponseIdAddSmallImageMediaItemIdPut(customRequestResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestResponseIdAddSmallImageMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestcustomrequestresponseidaddvideofilemediaitemidput"></a>
# **ApiCustomRequestCustomRequestResponseIdAddVideoFileMediaItemIdPut**
> CustomRequestResponseModel ApiCustomRequestCustomRequestResponseIdAddVideoFileMediaItemIdPut (string customRequestResponseId, string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestCustomRequestResponseIdAddVideoFileMediaItemIdPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                CustomRequestResponseModel result = apiInstance.ApiCustomRequestCustomRequestResponseIdAddVideoFileMediaItemIdPut(customRequestResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestCustomRequestResponseIdAddVideoFileMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestfullidget"></a>
# **ApiCustomRequestFullIdGet**
> CustomRequestModel ApiCustomRequestFullIdGet (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestFullIdGetExample
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

            var apiInstance = new CustomRequestApi();
            var id = id_example;  // string | 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestFullIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestFullIdGet: " + e.Message );
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

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestfullpost"></a>
# **ApiCustomRequestFullPost**
> CustomRequestModel ApiCustomRequestFullPost (CustomRequestModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestFullPostExample
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

            var apiInstance = new CustomRequestApi();
            var body = new CustomRequestModel(); // CustomRequestModel |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestFullPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestFullPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomRequestModel**](CustomRequestModel.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestmoduleapplicationmoduleidget"></a>
# **ApiCustomRequestModuleApplicationModuleIdGet**
> List<CustomRequestModel> ApiCustomRequestModuleApplicationModuleIdGet (string applicationModuleId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestModuleApplicationModuleIdGetExample
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

            var apiInstance = new CustomRequestApi();
            var applicationModuleId = applicationModuleId_example;  // string | 

            try
            {
                List&lt;CustomRequestModel&gt; result = apiInstance.ApiCustomRequestModuleApplicationModuleIdGet(applicationModuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestModuleApplicationModuleIdGet: " + e.Message );
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

[**List<CustomRequestModel>**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestpost"></a>
# **ApiCustomRequestPost**
> CustomRequestModel ApiCustomRequestPost (NewCustomRequestRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestPostExample
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

            var apiInstance = new CustomRequestApi();
            var body = new NewCustomRequestRequest(); // NewCustomRequestRequest |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewCustomRequestRequest**](NewCustomRequestRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestresponsecustomrequestresponseiddelete"></a>
# **ApiCustomRequestResponseCustomRequestResponseIdDelete**
> CustomRequestResponseModel ApiCustomRequestResponseCustomRequestResponseIdDelete (string customRequestResponseId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestResponseCustomRequestResponseIdDeleteExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 

            try
            {
                CustomRequestResponseModel result = apiInstance.ApiCustomRequestResponseCustomRequestResponseIdDelete(customRequestResponseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestResponseCustomRequestResponseIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestresponsecustomrequestresponseidmediaget"></a>
# **ApiCustomRequestResponseCustomRequestResponseIdMediaGet**
> List<MediaItemModel> ApiCustomRequestResponseCustomRequestResponseIdMediaGet (string customRequestResponseId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestResponseCustomRequestResponseIdMediaGetExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 

            try
            {
                List&lt;MediaItemModel&gt; result = apiInstance.ApiCustomRequestResponseCustomRequestResponseIdMediaGet(customRequestResponseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestResponseCustomRequestResponseIdMediaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 

### Return type

[**List<MediaItemModel>**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestresponsecustomrequestresponseidput"></a>
# **ApiCustomRequestResponseCustomRequestResponseIdPut**
> CustomRequestResponseModel ApiCustomRequestResponseCustomRequestResponseIdPut (string customRequestResponseId, UpdateCustomRequestResponseRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestResponseCustomRequestResponseIdPutExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var body = new UpdateCustomRequestResponseRequest(); // UpdateCustomRequestResponseRequest |  (optional) 

            try
            {
                CustomRequestResponseModel result = apiInstance.ApiCustomRequestResponseCustomRequestResponseIdPut(customRequestResponseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestResponseCustomRequestResponseIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **body** | [**UpdateCustomRequestResponseRequest**](UpdateCustomRequestResponseRequest.md)|  | [optional] 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequeststubpost"></a>
# **ApiCustomRequestStubPost**
> CustomRequestModel ApiCustomRequestStubPost (NewCustomRequestStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestStubPostExample
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

            var apiInstance = new CustomRequestApi();
            var body = new NewCustomRequestStubRequest(); // NewCustomRequestStubRequest |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.ApiCustomRequestStubPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestStubPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewCustomRequestStubRequest**](NewCustomRequestStubRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apicustomrequestwebhookcustomrequestwebhookiddelete"></a>
# **ApiCustomRequestWebhookCustomRequestWebhookIdDelete**
> CustomRequestWebhookModel ApiCustomRequestWebhookCustomRequestWebhookIdDelete (string customRequestWebhookId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiCustomRequestWebhookCustomRequestWebhookIdDeleteExample
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

            var apiInstance = new CustomRequestApi();
            var customRequestWebhookId = customRequestWebhookId_example;  // string | 

            try
            {
                CustomRequestWebhookModel result = apiInstance.ApiCustomRequestWebhookCustomRequestWebhookIdDelete(customRequestWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ApiCustomRequestWebhookCustomRequestWebhookIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestWebhookId** | **string**|  | 

### Return type

[**CustomRequestWebhookModel**](CustomRequestWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
