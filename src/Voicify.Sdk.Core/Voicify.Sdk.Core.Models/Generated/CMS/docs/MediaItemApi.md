# Voicify.Sdk.Core.Models.Api.MediaItemApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiMediaItemApplicationIdDisabledGet**](MediaItemApi.md#apimediaitemapplicationiddisabledget) | **GET** /api/MediaItem/{applicationId}/disabled | 
[**ApiMediaItemApplicationIdGet**](MediaItemApi.md#apimediaitemapplicationidget) | **GET** /api/MediaItem/{applicationId} | 
[**ApiMediaItemApplicationIdPost**](MediaItemApi.md#apimediaitemapplicationidpost) | **POST** /api/MediaItem/{applicationId} | 
[**ApiMediaItemApplicationIdUploadPost**](MediaItemApi.md#apimediaitemapplicationiduploadpost) | **POST** /api/MediaItem/{applicationId}/upload | 
[**ApiMediaItemApplicationIdUploadUrlGet**](MediaItemApi.md#apimediaitemapplicationiduploadurlget) | **GET** /api/MediaItem/{applicationId}/uploadUrl | 
[**ApiMediaItemConvertSsmlMediaItemIdPost**](MediaItemApi.md#apimediaitemconvertssmlmediaitemidpost) | **POST** /api/MediaItem/convert/ssml/{mediaItemId} | 
[**ApiMediaItemMediaItemIdDelete**](MediaItemApi.md#apimediaitemmediaitemiddelete) | **DELETE** /api/MediaItem/{mediaItemId} | 
[**ApiMediaItemMediaItemIdDisableDelete**](MediaItemApi.md#apimediaitemmediaitemiddisabledelete) | **DELETE** /api/MediaItem/{mediaItemId}/disable | 
[**ApiMediaItemMediaItemIdPut**](MediaItemApi.md#apimediaitemmediaitemidput) | **PUT** /api/MediaItem/{mediaItemId} | 
[**ApiMediaItemMediaItemIdShouldnotsyncPut**](MediaItemApi.md#apimediaitemmediaitemidshouldnotsyncput) | **PUT** /api/MediaItem/{mediaItemId}/shouldnotsync | 
[**ApiMediaItemOrganizationIdOrgUploadUrlGet**](MediaItemApi.md#apimediaitemorganizationidorguploadurlget) | **GET** /api/MediaItem/{organizationId}/orgUploadUrl | 

<a name="apimediaitemapplicationiddisabledget"></a>
# **ApiMediaItemApplicationIdDisabledGet**
> List<MediaItemModel> ApiMediaItemApplicationIdDisabledGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemApplicationIdDisabledGetExample
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

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;MediaItemModel&gt; result = apiInstance.ApiMediaItemApplicationIdDisabledGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemApplicationIdDisabledGet: " + e.Message );
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

[**List<MediaItemModel>**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemapplicationidget"></a>
# **ApiMediaItemApplicationIdGet**
> List<MediaItemModel> ApiMediaItemApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemApplicationIdGetExample
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

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;MediaItemModel&gt; result = apiInstance.ApiMediaItemApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemApplicationIdGet: " + e.Message );
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

[**List<MediaItemModel>**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemapplicationidpost"></a>
# **ApiMediaItemApplicationIdPost**
> MediaItemModel ApiMediaItemApplicationIdPost (string applicationId, NewMediaItemRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemApplicationIdPostExample
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

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewMediaItemRequest(); // NewMediaItemRequest |  (optional) 

            try
            {
                MediaItemModel result = apiInstance.ApiMediaItemApplicationIdPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemApplicationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewMediaItemRequest**](NewMediaItemRequest.md)|  | [optional] 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemapplicationiduploadpost"></a>
# **ApiMediaItemApplicationIdUploadPost**
> MediaItemModel ApiMediaItemApplicationIdUploadPost (string applicationId, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemApplicationIdUploadPostExample
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

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 
            var name = name_example;  // string |  (optional) 

            try
            {
                MediaItemModel result = apiInstance.ApiMediaItemApplicationIdUploadPost(applicationId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemApplicationIdUploadPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **name** | **string**|  | [optional] 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemapplicationiduploadurlget"></a>
# **ApiMediaItemApplicationIdUploadUrlGet**
> string ApiMediaItemApplicationIdUploadUrlGet (string applicationId, string name = null, string fileName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemApplicationIdUploadUrlGetExample
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

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 
            var name = name_example;  // string |  (optional) 
            var fileName = fileName_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ApiMediaItemApplicationIdUploadUrlGet(applicationId, name, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemApplicationIdUploadUrlGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **name** | **string**|  | [optional] 
 **fileName** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemconvertssmlmediaitemidpost"></a>
# **ApiMediaItemConvertSsmlMediaItemIdPost**
> MediaItemModel ApiMediaItemConvertSsmlMediaItemIdPost (string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemConvertSsmlMediaItemIdPostExample
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

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                MediaItemModel result = apiInstance.ApiMediaItemConvertSsmlMediaItemIdPost(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemConvertSsmlMediaItemIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemmediaitemiddelete"></a>
# **ApiMediaItemMediaItemIdDelete**
> MediaItemModel ApiMediaItemMediaItemIdDelete (string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemMediaItemIdDeleteExample
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

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                MediaItemModel result = apiInstance.ApiMediaItemMediaItemIdDelete(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemMediaItemIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemmediaitemiddisabledelete"></a>
# **ApiMediaItemMediaItemIdDisableDelete**
> MediaItemModel ApiMediaItemMediaItemIdDisableDelete (string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemMediaItemIdDisableDeleteExample
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

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                MediaItemModel result = apiInstance.ApiMediaItemMediaItemIdDisableDelete(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemMediaItemIdDisableDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemmediaitemidput"></a>
# **ApiMediaItemMediaItemIdPut**
> MediaItemModel ApiMediaItemMediaItemIdPut (string mediaItemId, UpdateMediaItemRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemMediaItemIdPutExample
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

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 
            var body = new UpdateMediaItemRequest(); // UpdateMediaItemRequest |  (optional) 

            try
            {
                MediaItemModel result = apiInstance.ApiMediaItemMediaItemIdPut(mediaItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemMediaItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 
 **body** | [**UpdateMediaItemRequest**](UpdateMediaItemRequest.md)|  | [optional] 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemmediaitemidshouldnotsyncput"></a>
# **ApiMediaItemMediaItemIdShouldnotsyncPut**
> MediaItemModel ApiMediaItemMediaItemIdShouldnotsyncPut (string mediaItemId, ToggleSyncRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemMediaItemIdShouldnotsyncPutExample
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

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 
            var body = new ToggleSyncRequest(); // ToggleSyncRequest |  (optional) 

            try
            {
                MediaItemModel result = apiInstance.ApiMediaItemMediaItemIdShouldnotsyncPut(mediaItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemMediaItemIdShouldnotsyncPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 
 **body** | [**ToggleSyncRequest**](ToggleSyncRequest.md)|  | [optional] 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaitemorganizationidorguploadurlget"></a>
# **ApiMediaItemOrganizationIdOrgUploadUrlGet**
> string ApiMediaItemOrganizationIdOrgUploadUrlGet (string organizationId, string name = null, string fileName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaItemOrganizationIdOrgUploadUrlGetExample
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

            var apiInstance = new MediaItemApi();
            var organizationId = organizationId_example;  // string | 
            var name = name_example;  // string |  (optional) 
            var fileName = fileName_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ApiMediaItemOrganizationIdOrgUploadUrlGet(organizationId, name, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ApiMediaItemOrganizationIdOrgUploadUrlGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **name** | **string**|  | [optional] 
 **fileName** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
