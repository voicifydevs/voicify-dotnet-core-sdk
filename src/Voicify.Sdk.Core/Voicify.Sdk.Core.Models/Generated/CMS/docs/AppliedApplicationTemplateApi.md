# Voicify.Sdk.Core.Models.Api.AppliedApplicationTemplateApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAppliedApplicationTemplateApplicationIdAddTemplateConfigurationIdPost**](AppliedApplicationTemplateApi.md#apiappliedapplicationtemplateapplicationidaddtemplateconfigurationidpost) | **POST** /api/AppliedApplicationTemplate/{applicationId}/add/{templateConfigurationId} | 
[**ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdDelete**](AppliedApplicationTemplateApi.md#apiappliedapplicationtemplateappliedapplicationtemplateformiddelete) | **DELETE** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId} | 
[**ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinalizeFormPut**](AppliedApplicationTemplateApi.md#apiappliedapplicationtemplateappliedapplicationtemplateformidfinalizeformput) | **PUT** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId}/finalizeForm | 
[**ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinishSectionPut**](AppliedApplicationTemplateApi.md#apiappliedapplicationtemplateappliedapplicationtemplateformidfinishsectionput) | **PUT** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId}/finishSection | 
[**ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdGet**](AppliedApplicationTemplateApi.md#apiappliedapplicationtemplateappliedapplicationtemplateformidget) | **GET** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId} | 
[**ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdPut**](AppliedApplicationTemplateApi.md#apiappliedapplicationtemplateappliedapplicationtemplateformidput) | **PUT** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId} | 
[**ApiAppliedApplicationTemplateForAppApplicationIdGet**](AppliedApplicationTemplateApi.md#apiappliedapplicationtemplateforappapplicationidget) | **GET** /api/AppliedApplicationTemplate/forApp/{applicationId} | 

<a name="apiappliedapplicationtemplateapplicationidaddtemplateconfigurationidpost"></a>
# **ApiAppliedApplicationTemplateApplicationIdAddTemplateConfigurationIdPost**
> AppliedApplicationTemplateFormModel ApiAppliedApplicationTemplateApplicationIdAddTemplateConfigurationIdPost (string applicationId, string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedApplicationTemplateApplicationIdAddTemplateConfigurationIdPostExample
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

            var apiInstance = new AppliedApplicationTemplateApi();
            var applicationId = applicationId_example;  // string | 
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.ApiAppliedApplicationTemplateApplicationIdAddTemplateConfigurationIdPost(applicationId, templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.ApiAppliedApplicationTemplateApplicationIdAddTemplateConfigurationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **templateConfigurationId** | **string**|  | 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedapplicationtemplateappliedapplicationtemplateformiddelete"></a>
# **ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdDelete**
> AppliedApplicationTemplateFormModel ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdDelete (string appliedApplicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdDeleteExample
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

            var apiInstance = new AppliedApplicationTemplateApi();
            var appliedApplicationTemplateFormId = appliedApplicationTemplateFormId_example;  // string | 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdDelete(appliedApplicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appliedApplicationTemplateFormId** | **string**|  | 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedapplicationtemplateappliedapplicationtemplateformidfinalizeformput"></a>
# **ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinalizeFormPut**
> FinalizeTemplateFormResult ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinalizeFormPut (string appliedApplicationTemplateFormId, FinalizeTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinalizeFormPutExample
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

            var apiInstance = new AppliedApplicationTemplateApi();
            var appliedApplicationTemplateFormId = appliedApplicationTemplateFormId_example;  // string | 
            var body = new FinalizeTemplateFormRequest(); // FinalizeTemplateFormRequest |  (optional) 

            try
            {
                FinalizeTemplateFormResult result = apiInstance.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinalizeFormPut(appliedApplicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinalizeFormPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appliedApplicationTemplateFormId** | **string**|  | 
 **body** | [**FinalizeTemplateFormRequest**](FinalizeTemplateFormRequest.md)|  | [optional] 

### Return type

[**FinalizeTemplateFormResult**](FinalizeTemplateFormResult.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedapplicationtemplateappliedapplicationtemplateformidfinishsectionput"></a>
# **ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinishSectionPut**
> DynamicFormResponse ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinishSectionPut (string appliedApplicationTemplateFormId, FinishTemplateFormSectionRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinishSectionPutExample
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

            var apiInstance = new AppliedApplicationTemplateApi();
            var appliedApplicationTemplateFormId = appliedApplicationTemplateFormId_example;  // string | 
            var body = new FinishTemplateFormSectionRequest(); // FinishTemplateFormSectionRequest |  (optional) 

            try
            {
                DynamicFormResponse result = apiInstance.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinishSectionPut(appliedApplicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdFinishSectionPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appliedApplicationTemplateFormId** | **string**|  | 
 **body** | [**FinishTemplateFormSectionRequest**](FinishTemplateFormSectionRequest.md)|  | [optional] 

### Return type

[**DynamicFormResponse**](DynamicFormResponse.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedapplicationtemplateappliedapplicationtemplateformidget"></a>
# **ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdGet**
> AppliedApplicationTemplateFormModel ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdGet (string appliedApplicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdGetExample
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

            var apiInstance = new AppliedApplicationTemplateApi();
            var appliedApplicationTemplateFormId = appliedApplicationTemplateFormId_example;  // string | 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdGet(appliedApplicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appliedApplicationTemplateFormId** | **string**|  | 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedapplicationtemplateappliedapplicationtemplateformidput"></a>
# **ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdPut**
> AppliedApplicationTemplateFormModel ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdPut (string appliedApplicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdPutExample
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

            var apiInstance = new AppliedApplicationTemplateApi();
            var appliedApplicationTemplateFormId = appliedApplicationTemplateFormId_example;  // string | 
            var body = new UpdateAppliedApplicationTemplateFormRequest(); // UpdateAppliedApplicationTemplateFormRequest |  (optional) 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdPut(appliedApplicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.ApiAppliedApplicationTemplateAppliedApplicationTemplateFormIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appliedApplicationTemplateFormId** | **string**|  | 
 **body** | [**UpdateAppliedApplicationTemplateFormRequest**](UpdateAppliedApplicationTemplateFormRequest.md)|  | [optional] 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiappliedapplicationtemplateforappapplicationidget"></a>
# **ApiAppliedApplicationTemplateForAppApplicationIdGet**
> List<AppliedApplicationTemplateFormModel> ApiAppliedApplicationTemplateForAppApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAppliedApplicationTemplateForAppApplicationIdGetExample
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

            var apiInstance = new AppliedApplicationTemplateApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;AppliedApplicationTemplateFormModel&gt; result = apiInstance.ApiAppliedApplicationTemplateForAppApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.ApiAppliedApplicationTemplateForAppApplicationIdGet: " + e.Message );
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

[**List<AppliedApplicationTemplateFormModel>**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
