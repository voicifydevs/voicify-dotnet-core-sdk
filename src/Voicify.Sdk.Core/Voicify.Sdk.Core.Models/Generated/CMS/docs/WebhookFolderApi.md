# Voicify.Sdk.Core.Models.Api.WebhookFolderApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiWebhookFolderApplicationIdReorderPut**](WebhookFolderApi.md#apiwebhookfolderapplicationidreorderput) | **PUT** /api/WebhookFolder/{applicationId}/reorder | 
[**ApiWebhookFolderBulkDeletePut**](WebhookFolderApi.md#apiwebhookfolderbulkdeleteput) | **PUT** /api/WebhookFolder/bulkDelete | 
[**ApiWebhookFolderCopyToFolderPut**](WebhookFolderApi.md#apiwebhookfoldercopytofolderput) | **PUT** /api/WebhookFolder/copyToFolder | 
[**ApiWebhookFolderForApplicationApplicationIdGet**](WebhookFolderApi.md#apiwebhookfolderforapplicationapplicationidget) | **GET** /api/WebhookFolder/forApplication/{applicationId} | 
[**ApiWebhookFolderForParentFolderParentFolderIdGet**](WebhookFolderApi.md#apiwebhookfolderforparentfolderparentfolderidget) | **GET** /api/WebhookFolder/forParentFolder/{parentFolderId} | 
[**ApiWebhookFolderMoveToFolderPut**](WebhookFolderApi.md#apiwebhookfoldermovetofolderput) | **PUT** /api/WebhookFolder/moveToFolder | 
[**ApiWebhookFolderPost**](WebhookFolderApi.md#apiwebhookfolderpost) | **POST** /api/WebhookFolder | 
[**ApiWebhookFolderWebhookFolderIdDelete**](WebhookFolderApi.md#apiwebhookfolderwebhookfolderiddelete) | **DELETE** /api/WebhookFolder/{webhookFolderId} | 
[**ApiWebhookFolderWebhookFolderIdGet**](WebhookFolderApi.md#apiwebhookfolderwebhookfolderidget) | **GET** /api/WebhookFolder/{webhookFolderId} | 
[**ApiWebhookFolderWebhookFolderIdPut**](WebhookFolderApi.md#apiwebhookfolderwebhookfolderidput) | **PUT** /api/WebhookFolder/{webhookFolderId} | 

<a name="apiwebhookfolderapplicationidreorderput"></a>
# **ApiWebhookFolderApplicationIdReorderPut**
> List<WebhookFolderModel> ApiWebhookFolderApplicationIdReorderPut (string applicationId, List<string> body = null, string parentFolderId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderApplicationIdReorderPutExample
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
                List&lt;WebhookFolderModel&gt; result = apiInstance.ApiWebhookFolderApplicationIdReorderPut(applicationId, body, parentFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderApplicationIdReorderPut: " + e.Message );
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
<a name="apiwebhookfolderbulkdeleteput"></a>
# **ApiWebhookFolderBulkDeletePut**
> string ApiWebhookFolderBulkDeletePut (BulkWebhookRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderBulkDeletePutExample
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
                string result = apiInstance.ApiWebhookFolderBulkDeletePut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderBulkDeletePut: " + e.Message );
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
<a name="apiwebhookfoldercopytofolderput"></a>
# **ApiWebhookFolderCopyToFolderPut**
> string ApiWebhookFolderCopyToFolderPut (BulkWebhookRequest body = null, string folderId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderCopyToFolderPutExample
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
                string result = apiInstance.ApiWebhookFolderCopyToFolderPut(body, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderCopyToFolderPut: " + e.Message );
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
<a name="apiwebhookfolderforapplicationapplicationidget"></a>
# **ApiWebhookFolderForApplicationApplicationIdGet**
> List<WebhookFolderModel> ApiWebhookFolderForApplicationApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderForApplicationApplicationIdGetExample
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
                List&lt;WebhookFolderModel&gt; result = apiInstance.ApiWebhookFolderForApplicationApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderForApplicationApplicationIdGet: " + e.Message );
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
<a name="apiwebhookfolderforparentfolderparentfolderidget"></a>
# **ApiWebhookFolderForParentFolderParentFolderIdGet**
> List<WebhookFolderModel> ApiWebhookFolderForParentFolderParentFolderIdGet (string parentFolderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderForParentFolderParentFolderIdGetExample
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
                List&lt;WebhookFolderModel&gt; result = apiInstance.ApiWebhookFolderForParentFolderParentFolderIdGet(parentFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderForParentFolderParentFolderIdGet: " + e.Message );
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
<a name="apiwebhookfoldermovetofolderput"></a>
# **ApiWebhookFolderMoveToFolderPut**
> string ApiWebhookFolderMoveToFolderPut (BulkWebhookRequest body = null, string folderId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderMoveToFolderPutExample
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
                string result = apiInstance.ApiWebhookFolderMoveToFolderPut(body, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderMoveToFolderPut: " + e.Message );
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
<a name="apiwebhookfolderpost"></a>
# **ApiWebhookFolderPost**
> WebhookFolderModel ApiWebhookFolderPost (WebhookFolderModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderPostExample
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
                WebhookFolderModel result = apiInstance.ApiWebhookFolderPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderPost: " + e.Message );
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
<a name="apiwebhookfolderwebhookfolderiddelete"></a>
# **ApiWebhookFolderWebhookFolderIdDelete**
> WebhookFolderModel ApiWebhookFolderWebhookFolderIdDelete (string webhookFolderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderWebhookFolderIdDeleteExample
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
                WebhookFolderModel result = apiInstance.ApiWebhookFolderWebhookFolderIdDelete(webhookFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderWebhookFolderIdDelete: " + e.Message );
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
<a name="apiwebhookfolderwebhookfolderidget"></a>
# **ApiWebhookFolderWebhookFolderIdGet**
> WebhookFolderModel ApiWebhookFolderWebhookFolderIdGet (string webhookFolderId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderWebhookFolderIdGetExample
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
                WebhookFolderModel result = apiInstance.ApiWebhookFolderWebhookFolderIdGet(webhookFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderWebhookFolderIdGet: " + e.Message );
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
<a name="apiwebhookfolderwebhookfolderidput"></a>
# **ApiWebhookFolderWebhookFolderIdPut**
> WebhookFolderModel ApiWebhookFolderWebhookFolderIdPut (string webhookFolderId, WebhookFolderModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiWebhookFolderWebhookFolderIdPutExample
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
                WebhookFolderModel result = apiInstance.ApiWebhookFolderWebhookFolderIdPut(webhookFolderId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhookFolderApi.ApiWebhookFolderWebhookFolderIdPut: " + e.Message );
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
