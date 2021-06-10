# Voicify.Sdk.Core.Models.Api.AppliedApplicationTemplateApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAppliedTemplateToApp**](AppliedApplicationTemplateApi.md#addappliedtemplatetoapp) | **POST** /api/AppliedApplicationTemplate/{applicationId}/add/{templateConfigurationId} | 
[**DeleteAppliedTemplate**](AppliedApplicationTemplateApi.md#deleteappliedtemplate) | **DELETE** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId} | 
[**FinalizeTemplateForm**](AppliedApplicationTemplateApi.md#finalizetemplateform) | **PUT** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId}/finalizeForm | 
[**FindAppliedTemplateById**](AppliedApplicationTemplateApi.md#findappliedtemplatebyid) | **GET** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId} | 
[**FinishTemplateFormSection**](AppliedApplicationTemplateApi.md#finishtemplateformsection) | **PUT** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId}/finishSection | 
[**GetAppliedTemplatesForApplication**](AppliedApplicationTemplateApi.md#getappliedtemplatesforapplication) | **GET** /api/AppliedApplicationTemplate/forApp/{applicationId} | 
[**UpdateAppliedTemplate**](AppliedApplicationTemplateApi.md#updateappliedtemplate) | **PUT** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId} | 

<a name="addappliedtemplatetoapp"></a>
# **AddAppliedTemplateToApp**
> AppliedApplicationTemplateFormModel AddAppliedTemplateToApp (string applicationId, string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddAppliedTemplateToAppExample
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
                AppliedApplicationTemplateFormModel result = apiInstance.AddAppliedTemplateToApp(applicationId, templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.AddAppliedTemplateToApp: " + e.Message );
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
<a name="deleteappliedtemplate"></a>
# **DeleteAppliedTemplate**
> AppliedApplicationTemplateFormModel DeleteAppliedTemplate (string appliedApplicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteAppliedTemplateExample
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
                AppliedApplicationTemplateFormModel result = apiInstance.DeleteAppliedTemplate(appliedApplicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.DeleteAppliedTemplate: " + e.Message );
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
<a name="finalizetemplateform"></a>
# **FinalizeTemplateForm**
> FinalizeTemplateFormResult FinalizeTemplateForm (string appliedApplicationTemplateFormId, FinalizeTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FinalizeTemplateFormExample
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
                FinalizeTemplateFormResult result = apiInstance.FinalizeTemplateForm(appliedApplicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.FinalizeTemplateForm: " + e.Message );
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
<a name="findappliedtemplatebyid"></a>
# **FindAppliedTemplateById**
> AppliedApplicationTemplateFormModel FindAppliedTemplateById (string appliedApplicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FindAppliedTemplateByIdExample
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
                AppliedApplicationTemplateFormModel result = apiInstance.FindAppliedTemplateById(appliedApplicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.FindAppliedTemplateById: " + e.Message );
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
<a name="finishtemplateformsection"></a>
# **FinishTemplateFormSection**
> DynamicFormResponse FinishTemplateFormSection (string appliedApplicationTemplateFormId, FinishTemplateFormSectionRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FinishTemplateFormSectionExample
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
                DynamicFormResponse result = apiInstance.FinishTemplateFormSection(appliedApplicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.FinishTemplateFormSection: " + e.Message );
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
<a name="getappliedtemplatesforapplication"></a>
# **GetAppliedTemplatesForApplication**
> List<AppliedApplicationTemplateFormModel> GetAppliedTemplatesForApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAppliedTemplatesForApplicationExample
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
                List&lt;AppliedApplicationTemplateFormModel&gt; result = apiInstance.GetAppliedTemplatesForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.GetAppliedTemplatesForApplication: " + e.Message );
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
<a name="updateappliedtemplate"></a>
# **UpdateAppliedTemplate**
> AppliedApplicationTemplateFormModel UpdateAppliedTemplate (string appliedApplicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateAppliedTemplateExample
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
                AppliedApplicationTemplateFormModel result = apiInstance.UpdateAppliedTemplate(appliedApplicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.UpdateAppliedTemplate: " + e.Message );
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
