# Voicify.Sdk.Core.Models.Api.ImportExportApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiImportExportExportApplicationApplicationIdGet**](ImportExportApi.md#apiimportexportexportapplicationapplicationidget) | **GET** /api/ImportExport/export/application/{applicationId} | 
[**ApiImportExportExportApplicationIdGet**](ImportExportApi.md#apiimportexportexportapplicationidget) | **GET** /api/ImportExport/export/{applicationId} | 
[**ApiImportExportExportContentPost**](ImportExportApi.md#apiimportexportexportcontentpost) | **POST** /api/ImportExport/export/content | 
[**ApiImportExportExportContentToFilePost**](ImportExportApi.md#apiimportexportexportcontenttofilepost) | **POST** /api/ImportExport/export/contentToFile | 
[**ApiImportExportExportInteractionModelApplicationIdFileGet**](ImportExportApi.md#apiimportexportexportinteractionmodelapplicationidfileget) | **GET** /api/ImportExport/export/interactionModel/{applicationId}/file | 
[**ApiImportExportExportInteractionModelApplicationIdGet**](ImportExportApi.md#apiimportexportexportinteractionmodelapplicationidget) | **GET** /api/ImportExport/export/interactionModel/{applicationId} | 
[**ApiImportExportExportWebhooksPost**](ImportExportApi.md#apiimportexportexportwebhookspost) | **POST** /api/ImportExport/export/webhooks | 
[**ApiImportExportExportWebhooksToFilePost**](ImportExportApi.md#apiimportexportexportwebhookstofilepost) | **POST** /api/ImportExport/export/webhooksToFile | 
[**ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderFromFilePost**](ImportExportApi.md#apiimportexportimportintoapplicationapplicationidintowebhookfolderfromfilepost) | **POST** /api/ImportExport/import/intoApplication/{applicationId}/intoWebhookFolderFromFile | 
[**ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderPost**](ImportExportApi.md#apiimportexportimportintoapplicationapplicationidintowebhookfolderpost) | **POST** /api/ImportExport/import/intoApplication/{applicationId}/intoWebhookFolder | 
[**ApiImportExportImportIntoApplicationApplicationIdPost**](ImportExportApi.md#apiimportexportimportintoapplicationapplicationidpost) | **POST** /api/ImportExport/import/intoApplication/{applicationId} | 
[**ApiImportExportImportIntoApplicationFeatureApplicationFeatureIdPost**](ImportExportApi.md#apiimportexportimportintoapplicationfeatureapplicationfeatureidpost) | **POST** /api/ImportExport/import/intoApplicationFeature/{applicationFeatureId} | 
[**ApiImportExportImportIntoApplicationFeatureFromFileApplicationFeatureIdPost**](ImportExportApi.md#apiimportexportimportintoapplicationfeaturefromfileapplicationfeatureidpost) | **POST** /api/ImportExport/import/intoApplicationFeatureFromFile/{applicationFeatureId} | 
[**ApiImportExportImportIntoApplicationFromFileApplicationIdPost**](ImportExportApi.md#apiimportexportimportintoapplicationfromfileapplicationidpost) | **POST** /api/ImportExport/import/intoApplicationFromFile/{applicationId} | 

<a name="apiimportexportexportapplicationapplicationidget"></a>
# **ApiImportExportExportApplicationApplicationIdGet**
> ExportModel ApiImportExportExportApplicationApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportExportApplicationApplicationIdGetExample
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

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ExportModel result = apiInstance.ApiImportExportExportApplicationApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportExportApplicationApplicationIdGet: " + e.Message );
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

[**ExportModel**](ExportModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportexportapplicationidget"></a>
# **ApiImportExportExportApplicationIdGet**
> byte[] ApiImportExportExportApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportExportApplicationIdGetExample
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

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                byte[] result = apiInstance.ApiImportExportExportApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportExportApplicationIdGet: " + e.Message );
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

**byte[]**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportexportcontentpost"></a>
# **ApiImportExportExportContentPost**
> ExportModel ApiImportExportExportContentPost (BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportExportContentPostExample
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

            var apiInstance = new ImportExportApi();
            var body = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                ExportModel result = apiInstance.ApiImportExportExportContentPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportExportContentPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

[**ExportModel**](ExportModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportexportcontenttofilepost"></a>
# **ApiImportExportExportContentToFilePost**
> byte[] ApiImportExportExportContentToFilePost (BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportExportContentToFilePostExample
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

            var apiInstance = new ImportExportApi();
            var body = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                byte[] result = apiInstance.ApiImportExportExportContentToFilePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportExportContentToFilePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

**byte[]**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportexportinteractionmodelapplicationidfileget"></a>
# **ApiImportExportExportInteractionModelApplicationIdFileGet**
> byte[] ApiImportExportExportInteractionModelApplicationIdFileGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportExportInteractionModelApplicationIdFileGetExample
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

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                byte[] result = apiInstance.ApiImportExportExportInteractionModelApplicationIdFileGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportExportInteractionModelApplicationIdFileGet: " + e.Message );
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

**byte[]**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportexportinteractionmodelapplicationidget"></a>
# **ApiImportExportExportInteractionModelApplicationIdGet**
> ExportModel ApiImportExportExportInteractionModelApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportExportInteractionModelApplicationIdGetExample
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

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ExportModel result = apiInstance.ApiImportExportExportInteractionModelApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportExportInteractionModelApplicationIdGet: " + e.Message );
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

[**ExportModel**](ExportModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportexportwebhookspost"></a>
# **ApiImportExportExportWebhooksPost**
> ExportModel ApiImportExportExportWebhooksPost (BulkWebhookRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportExportWebhooksPostExample
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

            var apiInstance = new ImportExportApi();
            var body = new BulkWebhookRequest(); // BulkWebhookRequest |  (optional) 

            try
            {
                ExportModel result = apiInstance.ApiImportExportExportWebhooksPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportExportWebhooksPost: " + e.Message );
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

[**ExportModel**](ExportModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportexportwebhookstofilepost"></a>
# **ApiImportExportExportWebhooksToFilePost**
> byte[] ApiImportExportExportWebhooksToFilePost (BulkWebhookRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportExportWebhooksToFilePostExample
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

            var apiInstance = new ImportExportApi();
            var body = new BulkWebhookRequest(); // BulkWebhookRequest |  (optional) 

            try
            {
                byte[] result = apiInstance.ApiImportExportExportWebhooksToFilePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportExportWebhooksToFilePost: " + e.Message );
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

**byte[]**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportimportintoapplicationapplicationidintowebhookfolderfromfilepost"></a>
# **ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderFromFilePost**
> string ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderFromFilePost (string applicationId, string folderId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderFromFilePostExample
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

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 
            var folderId = folderId_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderFromFilePost(applicationId, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderFromFilePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **folderId** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportimportintoapplicationapplicationidintowebhookfolderpost"></a>
# **ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderPost**
> string ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderPost (string applicationId, ExportModel body = null, string folderId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderPostExample
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

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 
            var body = new ExportModel(); // ExportModel |  (optional) 
            var folderId = folderId_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderPost(applicationId, body, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportImportIntoApplicationApplicationIdIntoWebhookFolderPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**ExportModel**](ExportModel.md)|  | [optional] 
 **folderId** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportimportintoapplicationapplicationidpost"></a>
# **ApiImportExportImportIntoApplicationApplicationIdPost**
> string ApiImportExportImportIntoApplicationApplicationIdPost (string applicationId, ExportModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportImportIntoApplicationApplicationIdPostExample
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

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 
            var body = new ExportModel(); // ExportModel |  (optional) 

            try
            {
                string result = apiInstance.ApiImportExportImportIntoApplicationApplicationIdPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportImportIntoApplicationApplicationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**ExportModel**](ExportModel.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportimportintoapplicationfeatureapplicationfeatureidpost"></a>
# **ApiImportExportImportIntoApplicationFeatureApplicationFeatureIdPost**
> string ApiImportExportImportIntoApplicationFeatureApplicationFeatureIdPost (string applicationFeatureId, ExportModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportImportIntoApplicationFeatureApplicationFeatureIdPostExample
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

            var apiInstance = new ImportExportApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var body = new ExportModel(); // ExportModel |  (optional) 

            try
            {
                string result = apiInstance.ApiImportExportImportIntoApplicationFeatureApplicationFeatureIdPost(applicationFeatureId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportImportIntoApplicationFeatureApplicationFeatureIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **body** | [**ExportModel**](ExportModel.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportimportintoapplicationfeaturefromfileapplicationfeatureidpost"></a>
# **ApiImportExportImportIntoApplicationFeatureFromFileApplicationFeatureIdPost**
> string ApiImportExportImportIntoApplicationFeatureFromFileApplicationFeatureIdPost (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportImportIntoApplicationFeatureFromFileApplicationFeatureIdPostExample
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

            var apiInstance = new ImportExportApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                string result = apiInstance.ApiImportExportImportIntoApplicationFeatureFromFileApplicationFeatureIdPost(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportImportIntoApplicationFeatureFromFileApplicationFeatureIdPost: " + e.Message );
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

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiimportexportimportintoapplicationfromfileapplicationidpost"></a>
# **ApiImportExportImportIntoApplicationFromFileApplicationIdPost**
> string ApiImportExportImportIntoApplicationFromFileApplicationIdPost (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiImportExportImportIntoApplicationFromFileApplicationIdPostExample
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

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                string result = apiInstance.ApiImportExportImportIntoApplicationFromFileApplicationIdPost(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiImportExportImportIntoApplicationFromFileApplicationIdPost: " + e.Message );
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

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
