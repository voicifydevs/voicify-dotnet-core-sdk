# Voicify.Sdk.Core.Models.Api.ApplicationTemplatingApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAppliedApplicationTemplateFormSynchronously**](ApplicationTemplatingApi.md#addappliedapplicationtemplateformsynchronously) | **POST** /api/ApplicationTemplating/{applicationId}/addAppliedApplicationTemplateForm | 
[**CreateApplicationFromFormsSynchronously**](ApplicationTemplatingApi.md#createapplicationfromformssynchronously) | **POST** /api/ApplicationTemplating/CreateFromForm | 
[**RemoveAppliedApplicationTemplateFormSynchronously**](ApplicationTemplatingApi.md#removeappliedapplicationtemplateformsynchronously) | **DELETE** /api/ApplicationTemplating/{applicationId}/RemoveAppliedApplicationTemplateForm/{applicationTemplateFormId} | 
[**UpdateAppliedApplicationTemplateFormSynchronously**](ApplicationTemplatingApi.md#updateappliedapplicationtemplateformsynchronously) | **PUT** /api/ApplicationTemplating/{applicationId}/UpdateAppliedApplicationTemplateForm/{applicationTemplateFormId} | 

<a name="addappliedapplicationtemplateformsynchronously"></a>
# **AddAppliedApplicationTemplateFormSynchronously**
> AppliedApplicationTemplateFormModel AddAppliedApplicationTemplateFormSynchronously (string applicationId, CompleteTemplateFormModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddAppliedApplicationTemplateFormSynchronouslyExample
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
                AppliedApplicationTemplateFormModel result = apiInstance.AddAppliedApplicationTemplateFormSynchronously(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.AddAppliedApplicationTemplateFormSynchronously: " + e.Message );
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
<a name="createapplicationfromformssynchronously"></a>
# **CreateApplicationFromFormsSynchronously**
> ApplicationModel CreateApplicationFromFormsSynchronously (CreateApplicationFromCompletedFormsRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateApplicationFromFormsSynchronouslyExample
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
                ApplicationModel result = apiInstance.CreateApplicationFromFormsSynchronously(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.CreateApplicationFromFormsSynchronously: " + e.Message );
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
<a name="removeappliedapplicationtemplateformsynchronously"></a>
# **RemoveAppliedApplicationTemplateFormSynchronously**
> AppliedApplicationTemplateFormModel RemoveAppliedApplicationTemplateFormSynchronously (string applicationId, string applicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveAppliedApplicationTemplateFormSynchronouslyExample
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
                AppliedApplicationTemplateFormModel result = apiInstance.RemoveAppliedApplicationTemplateFormSynchronously(applicationId, applicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.RemoveAppliedApplicationTemplateFormSynchronously: " + e.Message );
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
<a name="updateappliedapplicationtemplateformsynchronously"></a>
# **UpdateAppliedApplicationTemplateFormSynchronously**
> AppliedApplicationTemplateFormModel UpdateAppliedApplicationTemplateFormSynchronously (string applicationId, string applicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateAppliedApplicationTemplateFormSynchronouslyExample
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
                AppliedApplicationTemplateFormModel result = apiInstance.UpdateAppliedApplicationTemplateFormSynchronously(applicationId, applicationTemplateFormId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.UpdateAppliedApplicationTemplateFormSynchronously: " + e.Message );
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
