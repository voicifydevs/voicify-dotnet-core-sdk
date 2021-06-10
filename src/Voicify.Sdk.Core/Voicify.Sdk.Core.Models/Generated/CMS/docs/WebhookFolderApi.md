# Voicify.Sdk.Core.Models.Api.WebhookFolderApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkCopyContentToWebhookFolder**](WebhookFolderApi.md#bulkcopycontenttowebhookfolder) | **PUT** /api/WebhookFolder/copyToFolder | 
[**BulkDelteWebhookAndFolders**](WebhookFolderApi.md#bulkdeltewebhookandfolders) | **PUT** /api/WebhookFolder/bulkDelete | 
[**BulkMoveContentToWebhookFolder**](WebhookFolderApi.md#bulkmovecontenttowebhookfolder) | **PUT** /api/WebhookFolder/moveToFolder | 
[**CreateWebhookFolder**](WebhookFolderApi.md#createwebhookfolder) | **POST** /api/WebhookFolder | 
[**DeleteWebhookFolder**](WebhookFolderApi.md#deletewebhookfolder) | **DELETE** /api/WebhookFolder/{webhookFolderId} | 
[**GetWebhookFolder**](WebhookFolderApi.md#getwebhookfolder) | **GET** /api/WebhookFolder/{webhookFolderId} | 
[**GetWebhookFoldersForApplication**](WebhookFolderApi.md#getwebhookfoldersforapplication) | **GET** /api/WebhookFolder/forApplication/{applicationId} | 
[**GetWebhookFoldersForParentFolder**](WebhookFolderApi.md#getwebhookfoldersforparentfolder) | **GET** /api/WebhookFolder/forParentFolder/{parentFolderId} | 
[**SetWebhookFolderOrder**](WebhookFolderApi.md#setwebhookfolderorder) | **PUT** /api/WebhookFolder/{applicationId}/reorder | 
[**UpdateWebhookFolder**](WebhookFolderApi.md#updatewebhookfolder) | **PUT** /api/WebhookFolder/{webhookFolderId} | 

<a name="bulkcopycontenttowebhookfolder"></a>
# **BulkCopyContentToWebhookFolder**
> string BulkCopyContentToWebhookFolder (BulkWebhookRequest body = null, string folderId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkCopyContentToWebhookFolderExample
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

            var apiInstance = new WebhookFolderApi();
            var body = new BulkWebhookRequest(); // BulkWebhookRequest |  (optional) 
            var folderId = folderId_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.BulkCopyContentToWebhookFolder(body, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.BulkCopyContentToWebhookFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkWebhookRequest**](BulkWebhookRequest.md)|  | [optional] 
 **folderId** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="bulkdeltewebhookandfolders"></a>
# **BulkDelteWebhookAndFolders**
> string BulkDelteWebhookAndFolders (BulkWebhookRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkDelteWebhookAndFoldersExample
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

            var apiInstance = new WebhookFolderApi();
            var body = new BulkWebhookRequest(); // BulkWebhookRequest |  (optional) 

            try
            {
                string result = apiInstance.BulkDelteWebhookAndFolders(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.BulkDelteWebhookAndFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkWebhookRequest**](BulkWebhookRequest.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="bulkmovecontenttowebhookfolder"></a>
# **BulkMoveContentToWebhookFolder**
> string BulkMoveContentToWebhookFolder (BulkWebhookRequest body = null, string folderId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkMoveContentToWebhookFolderExample
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

            var apiInstance = new WebhookFolderApi();
            var body = new BulkWebhookRequest(); // BulkWebhookRequest |  (optional) 
            var folderId = folderId_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.BulkMoveContentToWebhookFolder(body, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.BulkMoveContentToWebhookFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkWebhookRequest**](BulkWebhookRequest.md)|  | [optional] 
 **folderId** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createwebhookfolder"></a>
# **CreateWebhookFolder**
> WebhookFolderModel CreateWebhookFolder (WebhookFolderModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateWebhookFolderExample
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

            var apiInstance = new WebhookFolderApi();
            var body = new WebhookFolderModel(); // WebhookFolderModel |  (optional) 

            try
            {
                WebhookFolderModel result = apiInstance.CreateWebhookFolder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.CreateWebhookFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebhookFolderModel**](WebhookFolderModel.md)|  | [optional] 

### Return type

[**WebhookFolderModel**](WebhookFolderModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletewebhookfolder"></a>
# **DeleteWebhookFolder**
> WebhookFolderModel DeleteWebhookFolder (string webhookFolderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteWebhookFolderExample
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

            var apiInstance = new WebhookFolderApi();
            var webhookFolderId = webhookFolderId_example;  // string | 

            try
            {
                WebhookFolderModel result = apiInstance.DeleteWebhookFolder(webhookFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.DeleteWebhookFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookFolderId** | **string**|  | 

### Return type

[**WebhookFolderModel**](WebhookFolderModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhookfolder"></a>
# **GetWebhookFolder**
> WebhookFolderModel GetWebhookFolder (string webhookFolderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetWebhookFolderExample
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

            var apiInstance = new WebhookFolderApi();
            var webhookFolderId = webhookFolderId_example;  // string | 

            try
            {
                WebhookFolderModel result = apiInstance.GetWebhookFolder(webhookFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.GetWebhookFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookFolderId** | **string**|  | 

### Return type

[**WebhookFolderModel**](WebhookFolderModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhookfoldersforapplication"></a>
# **GetWebhookFoldersForApplication**
> List<WebhookFolderModel> GetWebhookFoldersForApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetWebhookFoldersForApplicationExample
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

            var apiInstance = new WebhookFolderApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;WebhookFolderModel&gt; result = apiInstance.GetWebhookFoldersForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.GetWebhookFoldersForApplication: " + e.Message );
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

[**List<WebhookFolderModel>**](WebhookFolderModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhookfoldersforparentfolder"></a>
# **GetWebhookFoldersForParentFolder**
> List<WebhookFolderModel> GetWebhookFoldersForParentFolder (string parentFolderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetWebhookFoldersForParentFolderExample
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

            var apiInstance = new WebhookFolderApi();
            var parentFolderId = parentFolderId_example;  // string | 

            try
            {
                List&lt;WebhookFolderModel&gt; result = apiInstance.GetWebhookFoldersForParentFolder(parentFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.GetWebhookFoldersForParentFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentFolderId** | **string**|  | 

### Return type

[**List<WebhookFolderModel>**](WebhookFolderModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setwebhookfolderorder"></a>
# **SetWebhookFolderOrder**
> List<WebhookFolderModel> SetWebhookFolderOrder (string applicationId, List<string> body = null, string parentFolderId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SetWebhookFolderOrderExample
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

            var apiInstance = new WebhookFolderApi();
            var applicationId = applicationId_example;  // string | 
            var body = new List<string>(); // List<string> |  (optional) 
            var parentFolderId = parentFolderId_example;  // string |  (optional) 

            try
            {
                List&lt;WebhookFolderModel&gt; result = apiInstance.SetWebhookFolderOrder(applicationId, body, parentFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.SetWebhookFolderOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **parentFolderId** | **string**|  | [optional] 

### Return type

[**List<WebhookFolderModel>**](WebhookFolderModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatewebhookfolder"></a>
# **UpdateWebhookFolder**
> WebhookFolderModel UpdateWebhookFolder (string webhookFolderId, WebhookFolderModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateWebhookFolderExample
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

            var apiInstance = new WebhookFolderApi();
            var webhookFolderId = webhookFolderId_example;  // string | 
            var body = new WebhookFolderModel(); // WebhookFolderModel |  (optional) 

            try
            {
                WebhookFolderModel result = apiInstance.UpdateWebhookFolder(webhookFolderId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.UpdateWebhookFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookFolderId** | **string**|  | 
 **body** | [**WebhookFolderModel**](WebhookFolderModel.md)|  | [optional] 

### Return type

[**WebhookFolderModel**](WebhookFolderModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
