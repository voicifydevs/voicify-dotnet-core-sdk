# Voicify.Sdk.Core.Models.Api.ModuleApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiModuleAddCustomModulesApplicationIdPut**](ModuleApi.md#apimoduleaddcustommodulesapplicationidput) | **PUT** /api/Module/addCustomModules/{applicationId} | 
[**ApiModuleAddFeatureApplicationModuleIdPut**](ModuleApi.md#apimoduleaddfeatureapplicationmoduleidput) | **PUT** /api/Module/addFeature/{applicationModuleId} | 
[**ApiModuleAddModuleApplicationIdPut**](ModuleApi.md#apimoduleaddmoduleapplicationidput) | **PUT** /api/Module/addModule/{applicationId} | 
[**ApiModuleAddUncategorizedFeatureApplicationIdPut**](ModuleApi.md#apimoduleadduncategorizedfeatureapplicationidput) | **PUT** /api/Module/addUncategorizedFeature/{applicationId} | 
[**ApiModuleApplicationIdGet**](ModuleApi.md#apimoduleapplicationidget) | **GET** /api/Module/{applicationId} | 
[**ApiModuleApplicationModuleIdDisableDelete**](ModuleApi.md#apimoduleapplicationmoduleiddisabledelete) | **DELETE** /api/Module/{applicationModuleId}/disable | 
[**ApiModuleApplicationModuleIdUpdatePut**](ModuleApi.md#apimoduleapplicationmoduleidupdateput) | **PUT** /api/Module/{applicationModuleId}/update | 
[**ApiModuleCustomApplicationIdPost**](ModuleApi.md#apimodulecustomapplicationidpost) | **POST** /api/Module/custom/{applicationId} | 
[**ApiModuleReorderModulesApplicationIdPut**](ModuleApi.md#apimodulereordermodulesapplicationidput) | **PUT** /api/Module/reorderModules/{applicationId} | 
[**ApiModuleSystemModulesGet**](ModuleApi.md#apimodulesystemmodulesget) | **GET** /api/Module/SystemModules | 

<a name="apimoduleaddcustommodulesapplicationidput"></a>
# **ApiModuleAddCustomModulesApplicationIdPut**
> void ApiModuleAddCustomModulesApplicationIdPut (string applicationId, List<NewModuleRequest> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleAddCustomModulesApplicationIdPutExample
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

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var body = new List<NewModuleRequest>(); // List<NewModuleRequest> |  (optional) 

            try
            {
                apiInstance.ApiModuleAddCustomModulesApplicationIdPut(applicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleAddCustomModulesApplicationIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**List&lt;NewModuleRequest&gt;**](NewModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimoduleaddfeatureapplicationmoduleidput"></a>
# **ApiModuleAddFeatureApplicationModuleIdPut**
> void ApiModuleAddFeatureApplicationModuleIdPut (string applicationModuleId, AddFeatureToModuleRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleAddFeatureApplicationModuleIdPutExample
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

            var apiInstance = new ModuleApi();
            var applicationModuleId = applicationModuleId_example;  // string | 
            var body = new AddFeatureToModuleRequest(); // AddFeatureToModuleRequest |  (optional) 

            try
            {
                apiInstance.ApiModuleAddFeatureApplicationModuleIdPut(applicationModuleId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleAddFeatureApplicationModuleIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationModuleId** | **string**|  | 
 **body** | [**AddFeatureToModuleRequest**](AddFeatureToModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimoduleaddmoduleapplicationidput"></a>
# **ApiModuleAddModuleApplicationIdPut**
> void ApiModuleAddModuleApplicationIdPut (string applicationId, AddModuleToApplicationRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleAddModuleApplicationIdPutExample
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

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var body = new AddModuleToApplicationRequest(); // AddModuleToApplicationRequest |  (optional) 

            try
            {
                apiInstance.ApiModuleAddModuleApplicationIdPut(applicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleAddModuleApplicationIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**AddModuleToApplicationRequest**](AddModuleToApplicationRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimoduleadduncategorizedfeatureapplicationidput"></a>
# **ApiModuleAddUncategorizedFeatureApplicationIdPut**
> void ApiModuleAddUncategorizedFeatureApplicationIdPut (string applicationId, AddFeatureToModuleRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleAddUncategorizedFeatureApplicationIdPutExample
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

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var body = new AddFeatureToModuleRequest(); // AddFeatureToModuleRequest |  (optional) 

            try
            {
                apiInstance.ApiModuleAddUncategorizedFeatureApplicationIdPut(applicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleAddUncategorizedFeatureApplicationIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**AddFeatureToModuleRequest**](AddFeatureToModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimoduleapplicationidget"></a>
# **ApiModuleApplicationIdGet**
> void ApiModuleApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleApplicationIdGetExample
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

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                apiInstance.ApiModuleApplicationIdGet(applicationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleApplicationIdGet: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimoduleapplicationmoduleiddisabledelete"></a>
# **ApiModuleApplicationModuleIdDisableDelete**
> void ApiModuleApplicationModuleIdDisableDelete (string applicationModuleId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleApplicationModuleIdDisableDeleteExample
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

            var apiInstance = new ModuleApi();
            var applicationModuleId = applicationModuleId_example;  // string | 

            try
            {
                apiInstance.ApiModuleApplicationModuleIdDisableDelete(applicationModuleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleApplicationModuleIdDisableDelete: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimoduleapplicationmoduleidupdateput"></a>
# **ApiModuleApplicationModuleIdUpdatePut**
> void ApiModuleApplicationModuleIdUpdatePut (string applicationModuleId, UpdateApplicationModuleRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleApplicationModuleIdUpdatePutExample
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

            var apiInstance = new ModuleApi();
            var applicationModuleId = applicationModuleId_example;  // string | 
            var body = new UpdateApplicationModuleRequest(); // UpdateApplicationModuleRequest |  (optional) 

            try
            {
                apiInstance.ApiModuleApplicationModuleIdUpdatePut(applicationModuleId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleApplicationModuleIdUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationModuleId** | **string**|  | 
 **body** | [**UpdateApplicationModuleRequest**](UpdateApplicationModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimodulecustomapplicationidpost"></a>
# **ApiModuleCustomApplicationIdPost**
> void ApiModuleCustomApplicationIdPost (string applicationId, NewModuleRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleCustomApplicationIdPostExample
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

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewModuleRequest(); // NewModuleRequest |  (optional) 

            try
            {
                apiInstance.ApiModuleCustomApplicationIdPost(applicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleCustomApplicationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewModuleRequest**](NewModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimodulereordermodulesapplicationidput"></a>
# **ApiModuleReorderModulesApplicationIdPut**
> void ApiModuleReorderModulesApplicationIdPut (string applicationId, List<string> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleReorderModulesApplicationIdPutExample
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

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var body = new List<string>(); // List<string> |  (optional) 

            try
            {
                apiInstance.ApiModuleReorderModulesApplicationIdPut(applicationId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleReorderModulesApplicationIdPut: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimodulesystemmodulesget"></a>
# **ApiModuleSystemModulesGet**
> void ApiModuleSystemModulesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiModuleSystemModulesGetExample
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

            var apiInstance = new ModuleApi();

            try
            {
                apiInstance.ApiModuleSystemModulesGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ApiModuleSystemModulesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
