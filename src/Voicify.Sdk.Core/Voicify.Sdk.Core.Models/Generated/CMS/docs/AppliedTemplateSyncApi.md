# Voicify.Sdk.Core.Models.Api.AppliedTemplateSyncApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormDynamicPost**](AppliedTemplateSyncApi.md#apiappliedtemplatesyncapplicationidaddappliedapplicationtemplateformdynamicpost) | **POST** /api/AppliedTemplateSync/{applicationId}/addAppliedApplicationTemplateForm/Dynamic | 
[**ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormPost**](AppliedTemplateSyncApi.md#apiappliedtemplatesyncapplicationidaddappliedapplicationtemplateformpost) | **POST** /api/AppliedTemplateSync/{applicationId}/addAppliedApplicationTemplateForm | 
[**ApiAppliedTemplateSyncApplicationIdGetAppliedTemplateSyncsGet**](AppliedTemplateSyncApi.md#apiappliedtemplatesyncapplicationidgetappliedtemplatesyncsget) | **GET** /api/AppliedTemplateSync/{applicationId}/getAppliedTemplateSyncs | 
[**ApiAppliedTemplateSyncApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete**](AppliedTemplateSyncApi.md#apiappliedtemplatesyncapplicationidremoveappliedapplicationtemplateformapplicationtemplateformiddelete) | **DELETE** /api/AppliedTemplateSync/{applicationId}/RemoveAppliedApplicationTemplateForm/{applicationTemplateFormId} | 
[**ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdDynamicPut**](AppliedTemplateSyncApi.md#apiappliedtemplatesyncapplicationidupdateappliedapplicationtemplateformapplicationtemplateformiddynamicput) | **PUT** /api/AppliedTemplateSync/{applicationId}/UpdateAppliedApplicationTemplateForm/{applicationTemplateFormId}/Dynamic | 
[**ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut**](AppliedTemplateSyncApi.md#apiappliedtemplatesyncapplicationidupdateappliedapplicationtemplateformapplicationtemplateformidput) | **PUT** /api/AppliedTemplateSync/{applicationId}/UpdateAppliedApplicationTemplateForm/{applicationTemplateFormId} | 
[**ApiAppliedTemplateSyncAppliedTemplateSyncIdGet**](AppliedTemplateSyncApi.md#apiappliedtemplatesyncappliedtemplatesyncidget) | **GET** /api/AppliedTemplateSync/{appliedTemplateSyncId} | 

<a name="apiappliedtemplatesyncapplicationidaddappliedapplicationtemplateformdynamicpost"></a>
# **ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormDynamicPost**
> AppliedTemplateSyncModel ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormDynamicPost (string applicationId, CompleteTemplateFormModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormDynamicPostExample
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

            var apiInstance = new AppliedTemplateSyncApi();
            var applicationId = applicationId_example;  // string | 
            var body = new CompleteTemplateFormModel(); // CompleteTemplateFormModel |  (optional) 

            try
            {
                AppliedTemplateSyncModel result = apiInstance.ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormDynamicPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormDynamicPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**CompleteTemplateFormModel**](CompleteTemplateFormModel.md)|  | [optional] 

### Return type

[**AppliedTemplateSyncModel**](AppliedTemplateSyncModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedtemplatesyncapplicationidaddappliedapplicationtemplateformpost"></a>
# **ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormPost**
> AppliedTemplateSyncModel ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormPost (string applicationId, CompleteTemplateFormModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormPostExample
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

            var apiInstance = new AppliedTemplateSyncApi();
            var applicationId = applicationId_example;  // string | 
            var body = new CompleteTemplateFormModel(); // CompleteTemplateFormModel |  (optional) 

            try
            {
                AppliedTemplateSyncModel result = apiInstance.ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.ApiAppliedTemplateSyncApplicationIdAddAppliedApplicationTemplateFormPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**CompleteTemplateFormModel**](CompleteTemplateFormModel.md)|  | [optional] 

### Return type

[**AppliedTemplateSyncModel**](AppliedTemplateSyncModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedtemplatesyncapplicationidgetappliedtemplatesyncsget"></a>
# **ApiAppliedTemplateSyncApplicationIdGetAppliedTemplateSyncsGet**
> List<AppliedTemplateSyncModel> ApiAppliedTemplateSyncApplicationIdGetAppliedTemplateSyncsGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedTemplateSyncApplicationIdGetAppliedTemplateSyncsGetExample
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

            var apiInstance = new AppliedTemplateSyncApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;AppliedTemplateSyncModel&gt; result = apiInstance.ApiAppliedTemplateSyncApplicationIdGetAppliedTemplateSyncsGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.ApiAppliedTemplateSyncApplicationIdGetAppliedTemplateSyncsGet: " + e.Message );
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

[**List<AppliedTemplateSyncModel>**](AppliedTemplateSyncModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedtemplatesyncapplicationidremoveappliedapplicationtemplateformapplicationtemplateformiddelete"></a>
# **ApiAppliedTemplateSyncApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete**
> AppliedTemplateSyncModel ApiAppliedTemplateSyncApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete (string applicationId, string applicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedTemplateSyncApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDeleteExample
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

            var apiInstance = new AppliedTemplateSyncApi();
            var applicationId = applicationId_example;  // string | 
            var applicationTemplateFormId = applicationTemplateFormId_example;  // string | 

            try
            {
                AppliedTemplateSyncModel result = apiInstance.ApiAppliedTemplateSyncApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete(applicationId, applicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.ApiAppliedTemplateSyncApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **applicationTemplateFormId** | **string**|  | 

### Return type

[**AppliedTemplateSyncModel**](AppliedTemplateSyncModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedtemplatesyncapplicationidupdateappliedapplicationtemplateformapplicationtemplateformiddynamicput"></a>
# **ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdDynamicPut**
> AppliedTemplateSyncModel ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdDynamicPut (string applicationId, string applicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdDynamicPutExample
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

            var apiInstance = new AppliedTemplateSyncApi();
            var applicationId = applicationId_example;  // string | 
            var applicationTemplateFormId = applicationTemplateFormId_example;  // string | 
            var body = new UpdateAppliedApplicationTemplateFormRequest(); // UpdateAppliedApplicationTemplateFormRequest |  (optional) 

            try
            {
                AppliedTemplateSyncModel result = apiInstance.ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdDynamicPut(applicationId, applicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdDynamicPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **applicationTemplateFormId** | **string**|  | 
 **body** | [**UpdateAppliedApplicationTemplateFormRequest**](UpdateAppliedApplicationTemplateFormRequest.md)|  | [optional] 

### Return type

[**AppliedTemplateSyncModel**](AppliedTemplateSyncModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedtemplatesyncapplicationidupdateappliedapplicationtemplateformapplicationtemplateformidput"></a>
# **ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut**
> AppliedTemplateSyncModel ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut (string applicationId, string applicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPutExample
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

            var apiInstance = new AppliedTemplateSyncApi();
            var applicationId = applicationId_example;  // string | 
            var applicationTemplateFormId = applicationTemplateFormId_example;  // string | 
            var body = new UpdateAppliedApplicationTemplateFormRequest(); // UpdateAppliedApplicationTemplateFormRequest |  (optional) 

            try
            {
                AppliedTemplateSyncModel result = apiInstance.ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut(applicationId, applicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.ApiAppliedTemplateSyncApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **applicationTemplateFormId** | **string**|  | 
 **body** | [**UpdateAppliedApplicationTemplateFormRequest**](UpdateAppliedApplicationTemplateFormRequest.md)|  | [optional] 

### Return type

[**AppliedTemplateSyncModel**](AppliedTemplateSyncModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedtemplatesyncappliedtemplatesyncidget"></a>
# **ApiAppliedTemplateSyncAppliedTemplateSyncIdGet**
> AppliedTemplateSyncModel ApiAppliedTemplateSyncAppliedTemplateSyncIdGet (string appliedTemplateSyncId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedTemplateSyncAppliedTemplateSyncIdGetExample
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

            var apiInstance = new AppliedTemplateSyncApi();
            var appliedTemplateSyncId = appliedTemplateSyncId_example;  // string | 

            try
            {
                AppliedTemplateSyncModel result = apiInstance.ApiAppliedTemplateSyncAppliedTemplateSyncIdGet(appliedTemplateSyncId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.ApiAppliedTemplateSyncAppliedTemplateSyncIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appliedTemplateSyncId** | **string**|  | 

### Return type

[**AppliedTemplateSyncModel**](AppliedTemplateSyncModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
