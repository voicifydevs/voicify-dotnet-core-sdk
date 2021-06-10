# Voicify.Sdk.Core.Models.Api.MediaItemApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertToSsml**](MediaItemApi.md#converttossml) | **POST** /api/MediaItem/convert/ssml/{mediaItemId} | 
[**CreateMediaItem**](MediaItemApi.md#createmediaitem) | **POST** /api/MediaItem/{applicationId}/upload | 
[**CreateMediaItem_0**](MediaItemApi.md#createmediaitem_0) | **POST** /api/MediaItem/{applicationId} | 
[**DeleteMediaItem**](MediaItemApi.md#deletemediaitem) | **DELETE** /api/MediaItem/{mediaItemId} | 
[**DisableMediaItem**](MediaItemApi.md#disablemediaitem) | **DELETE** /api/MediaItem/{mediaItemId}/disable | 
[**GetDisabledMediaItemsForApplication**](MediaItemApi.md#getdisabledmediaitemsforapplication) | **GET** /api/MediaItem/{applicationId}/disabled | 
[**GetMediaItemsForApplication**](MediaItemApi.md#getmediaitemsforapplication) | **GET** /api/MediaItem/{applicationId} | 
[**GetOrganizationUploadUrl**](MediaItemApi.md#getorganizationuploadurl) | **GET** /api/MediaItem/{organizationId}/orgUploadUrl | 
[**GetUploadUrl**](MediaItemApi.md#getuploadurl) | **GET** /api/MediaItem/{applicationId}/uploadUrl | 
[**ToggleSync**](MediaItemApi.md#togglesync) | **PUT** /api/MediaItem/{mediaItemId}/shouldnotsync | 
[**UpdateMediaItem**](MediaItemApi.md#updatemediaitem) | **PUT** /api/MediaItem/{mediaItemId} | 

<a name="converttossml"></a>
# **ConvertToSsml**
> MediaItemModel ConvertToSsml (string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ConvertToSsmlExample
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
                MediaItemModel result = apiInstance.ConvertToSsml(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ConvertToSsml: " + e.Message );
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
<a name="createmediaitem"></a>
# **CreateMediaItem**
> MediaItemModel CreateMediaItem (string applicationId, string name = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateMediaItemExample
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
                MediaItemModel result = apiInstance.CreateMediaItem(applicationId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.CreateMediaItem: " + e.Message );
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
<a name="createmediaitem_0"></a>
# **CreateMediaItem_0**
> MediaItemModel CreateMediaItem_0 (string applicationId, NewMediaItemRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateMediaItem_0Example
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
                MediaItemModel result = apiInstance.CreateMediaItem_0(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.CreateMediaItem_0: " + e.Message );
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
<a name="deletemediaitem"></a>
# **DeleteMediaItem**
> MediaItemModel DeleteMediaItem (string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteMediaItemExample
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
                MediaItemModel result = apiInstance.DeleteMediaItem(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.DeleteMediaItem: " + e.Message );
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
<a name="disablemediaitem"></a>
# **DisableMediaItem**
> MediaItemModel DisableMediaItem (string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DisableMediaItemExample
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
                MediaItemModel result = apiInstance.DisableMediaItem(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.DisableMediaItem: " + e.Message );
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
<a name="getdisabledmediaitemsforapplication"></a>
# **GetDisabledMediaItemsForApplication**
> List<MediaItemModel> GetDisabledMediaItemsForApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetDisabledMediaItemsForApplicationExample
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
                List&lt;MediaItemModel&gt; result = apiInstance.GetDisabledMediaItemsForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.GetDisabledMediaItemsForApplication: " + e.Message );
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
<a name="getmediaitemsforapplication"></a>
# **GetMediaItemsForApplication**
> List<MediaItemModel> GetMediaItemsForApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetMediaItemsForApplicationExample
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
                List&lt;MediaItemModel&gt; result = apiInstance.GetMediaItemsForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.GetMediaItemsForApplication: " + e.Message );
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
<a name="getorganizationuploadurl"></a>
# **GetOrganizationUploadUrl**
> string GetOrganizationUploadUrl (string organizationId, string name = null, string fileName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetOrganizationUploadUrlExample
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
                string result = apiInstance.GetOrganizationUploadUrl(organizationId, name, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.GetOrganizationUploadUrl: " + e.Message );
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
<a name="getuploadurl"></a>
# **GetUploadUrl**
> string GetUploadUrl (string applicationId, string name = null, string fileName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetUploadUrlExample
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
                string result = apiInstance.GetUploadUrl(applicationId, name, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.GetUploadUrl: " + e.Message );
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
<a name="togglesync"></a>
# **ToggleSync**
> MediaItemModel ToggleSync (string mediaItemId, ToggleSyncRequest body = null)



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

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 
            var body = new ToggleSyncRequest(); // ToggleSyncRequest |  (optional) 

            try
            {
                MediaItemModel result = apiInstance.ToggleSync(mediaItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ToggleSync: " + e.Message );
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
<a name="updatemediaitem"></a>
# **UpdateMediaItem**
> MediaItemModel UpdateMediaItem (string mediaItemId, UpdateMediaItemRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateMediaItemExample
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
                MediaItemModel result = apiInstance.UpdateMediaItem(mediaItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.UpdateMediaItem: " + e.Message );
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
