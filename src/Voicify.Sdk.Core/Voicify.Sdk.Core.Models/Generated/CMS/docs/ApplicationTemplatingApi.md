# Voicify.Sdk.Core.Models.Api.ApplicationTemplatingApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiApplicationTemplatingApplicationIdAddAppliedApplicationTemplateFormPost**](ApplicationTemplatingApi.md#apiapplicationtemplatingapplicationidaddappliedapplicationtemplateformpost) | **POST** /api/ApplicationTemplating/{applicationId}/addAppliedApplicationTemplateForm | 
[**ApiApplicationTemplatingApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete**](ApplicationTemplatingApi.md#apiapplicationtemplatingapplicationidremoveappliedapplicationtemplateformapplicationtemplateformiddelete) | **DELETE** /api/ApplicationTemplating/{applicationId}/RemoveAppliedApplicationTemplateForm/{applicationTemplateFormId} | 
[**ApiApplicationTemplatingApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut**](ApplicationTemplatingApi.md#apiapplicationtemplatingapplicationidupdateappliedapplicationtemplateformapplicationtemplateformidput) | **PUT** /api/ApplicationTemplating/{applicationId}/UpdateAppliedApplicationTemplateForm/{applicationTemplateFormId} | 
[**ApiApplicationTemplatingCreateFromFormPost**](ApplicationTemplatingApi.md#apiapplicationtemplatingcreatefromformpost) | **POST** /api/ApplicationTemplating/CreateFromForm | 

<a name="apiapplicationtemplatingapplicationidaddappliedapplicationtemplateformpost"></a>
# **ApiApplicationTemplatingApplicationIdAddAppliedApplicationTemplateFormPost**
> AppliedApplicationTemplateFormModel ApiApplicationTemplatingApplicationIdAddAppliedApplicationTemplateFormPost (string applicationId, CompleteTemplateFormModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationTemplatingApplicationIdAddAppliedApplicationTemplateFormPostExample
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

            var apiInstance = new ApplicationTemplatingApi();
            var applicationId = applicationId_example;  // string | 
            var body = new CompleteTemplateFormModel(); // CompleteTemplateFormModel |  (optional) 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.ApiApplicationTemplatingApplicationIdAddAppliedApplicationTemplateFormPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.ApiApplicationTemplatingApplicationIdAddAppliedApplicationTemplateFormPost: " + e.Message );
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

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationtemplatingapplicationidremoveappliedapplicationtemplateformapplicationtemplateformiddelete"></a>
# **ApiApplicationTemplatingApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete**
> AppliedApplicationTemplateFormModel ApiApplicationTemplatingApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete (string applicationId, string applicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationTemplatingApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDeleteExample
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

            var apiInstance = new ApplicationTemplatingApi();
            var applicationId = applicationId_example;  // string | 
            var applicationTemplateFormId = applicationTemplateFormId_example;  // string | 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.ApiApplicationTemplatingApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete(applicationId, applicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.ApiApplicationTemplatingApplicationIdRemoveAppliedApplicationTemplateFormApplicationTemplateFormIdDelete: " + e.Message );
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

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationtemplatingapplicationidupdateappliedapplicationtemplateformapplicationtemplateformidput"></a>
# **ApiApplicationTemplatingApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut**
> AppliedApplicationTemplateFormModel ApiApplicationTemplatingApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut (string applicationId, string applicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationTemplatingApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPutExample
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

            var apiInstance = new ApplicationTemplatingApi();
            var applicationId = applicationId_example;  // string | 
            var applicationTemplateFormId = applicationTemplateFormId_example;  // string | 
            var body = new UpdateAppliedApplicationTemplateFormRequest(); // UpdateAppliedApplicationTemplateFormRequest |  (optional) 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.ApiApplicationTemplatingApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut(applicationId, applicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.ApiApplicationTemplatingApplicationIdUpdateAppliedApplicationTemplateFormApplicationTemplateFormIdPut: " + e.Message );
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

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationtemplatingcreatefromformpost"></a>
# **ApiApplicationTemplatingCreateFromFormPost**
> ApplicationModel ApiApplicationTemplatingCreateFromFormPost (CreateApplicationFromCompletedFormsRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationTemplatingCreateFromFormPostExample
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

            var apiInstance = new ApplicationTemplatingApi();
            var body = new CreateApplicationFromCompletedFormsRequest(); // CreateApplicationFromCompletedFormsRequest |  (optional) 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationTemplatingCreateFromFormPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.ApiApplicationTemplatingCreateFromFormPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateApplicationFromCompletedFormsRequest**](CreateApplicationFromCompletedFormsRequest.md)|  | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
