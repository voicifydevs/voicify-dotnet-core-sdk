# Voicify.Sdk.Core.Models.Api.AppliedTemplateSyncApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAppliedApplicationTemplateForm**](AppliedTemplateSyncApi.md#addappliedapplicationtemplateform) | **POST** /api/AppliedTemplateSync/{applicationId}/addAppliedApplicationTemplateForm | 
[**AddAppliedApplicationTemplateFormDynamically**](AppliedTemplateSyncApi.md#addappliedapplicationtemplateformdynamically) | **POST** /api/AppliedTemplateSync/{applicationId}/addAppliedApplicationTemplateForm/Dynamic | 
[**GetAppliedTemplateSync**](AppliedTemplateSyncApi.md#getappliedtemplatesync) | **GET** /api/AppliedTemplateSync/{appliedTemplateSyncId} | 
[**GetAppliedTemplateSyncsForOrganization**](AppliedTemplateSyncApi.md#getappliedtemplatesyncsfororganization) | **GET** /api/AppliedTemplateSync/{applicationId}/getAppliedTemplateSyncs | 
[**RemoveAppliedApplicationTemplateForm**](AppliedTemplateSyncApi.md#removeappliedapplicationtemplateform) | **DELETE** /api/AppliedTemplateSync/{applicationId}/RemoveAppliedApplicationTemplateForm/{applicationTemplateFormId} | 
[**UpdateAppliedApplicationTemplateForm**](AppliedTemplateSyncApi.md#updateappliedapplicationtemplateform) | **PUT** /api/AppliedTemplateSync/{applicationId}/UpdateAppliedApplicationTemplateForm/{applicationTemplateFormId} | 
[**UpdateAppliedApplicationTemplateFormFromExportModel**](AppliedTemplateSyncApi.md#updateappliedapplicationtemplateformfromexportmodel) | **PUT** /api/AppliedTemplateSync/{applicationId}/UpdateAppliedApplicationTemplateForm/{applicationTemplateFormId}/Dynamic | 

<a name="addappliedapplicationtemplateform"></a>
# **AddAppliedApplicationTemplateForm**
> AppliedTemplateSyncModel AddAppliedApplicationTemplateForm (string applicationId, CompleteTemplateFormModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddAppliedApplicationTemplateFormExample
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
                AppliedTemplateSyncModel result = apiInstance.AddAppliedApplicationTemplateForm(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.AddAppliedApplicationTemplateForm: " + e.Message );
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
<a name="addappliedapplicationtemplateformdynamically"></a>
# **AddAppliedApplicationTemplateFormDynamically**
> AppliedTemplateSyncModel AddAppliedApplicationTemplateFormDynamically (string applicationId, CompleteTemplateFormModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddAppliedApplicationTemplateFormDynamicallyExample
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
                AppliedTemplateSyncModel result = apiInstance.AddAppliedApplicationTemplateFormDynamically(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.AddAppliedApplicationTemplateFormDynamically: " + e.Message );
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
<a name="getappliedtemplatesync"></a>
# **GetAppliedTemplateSync**
> AppliedTemplateSyncModel GetAppliedTemplateSync (string appliedTemplateSyncId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAppliedTemplateSyncExample
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
                AppliedTemplateSyncModel result = apiInstance.GetAppliedTemplateSync(appliedTemplateSyncId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.GetAppliedTemplateSync: " + e.Message );
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
<a name="getappliedtemplatesyncsfororganization"></a>
# **GetAppliedTemplateSyncsForOrganization**
> List<AppliedTemplateSyncModel> GetAppliedTemplateSyncsForOrganization (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAppliedTemplateSyncsForOrganizationExample
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
                List&lt;AppliedTemplateSyncModel&gt; result = apiInstance.GetAppliedTemplateSyncsForOrganization(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.GetAppliedTemplateSyncsForOrganization: " + e.Message );
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
<a name="removeappliedapplicationtemplateform"></a>
# **RemoveAppliedApplicationTemplateForm**
> AppliedTemplateSyncModel RemoveAppliedApplicationTemplateForm (string applicationId, string applicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveAppliedApplicationTemplateFormExample
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
                AppliedTemplateSyncModel result = apiInstance.RemoveAppliedApplicationTemplateForm(applicationId, applicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.RemoveAppliedApplicationTemplateForm: " + e.Message );
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
<a name="updateappliedapplicationtemplateform"></a>
# **UpdateAppliedApplicationTemplateForm**
> AppliedTemplateSyncModel UpdateAppliedApplicationTemplateForm (string applicationId, string applicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateAppliedApplicationTemplateFormExample
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
                AppliedTemplateSyncModel result = apiInstance.UpdateAppliedApplicationTemplateForm(applicationId, applicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.UpdateAppliedApplicationTemplateForm: " + e.Message );
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
<a name="updateappliedapplicationtemplateformfromexportmodel"></a>
# **UpdateAppliedApplicationTemplateFormFromExportModel**
> AppliedTemplateSyncModel UpdateAppliedApplicationTemplateFormFromExportModel (string applicationId, string applicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateAppliedApplicationTemplateFormFromExportModelExample
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
                AppliedTemplateSyncModel result = apiInstance.UpdateAppliedApplicationTemplateFormFromExportModel(applicationId, applicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedTemplateSyncApi.UpdateAppliedApplicationTemplateFormFromExportModel: " + e.Message );
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
