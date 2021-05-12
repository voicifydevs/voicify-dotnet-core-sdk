# Voicify.Sdk.Core.Models.Api.FeatureApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiFeatureApplicationFeatureIdChangeModuleApplicationModuleIdPut**](FeatureApi.md#apifeatureapplicationfeatureidchangemoduleapplicationmoduleidput) | **PUT** /api/Feature/{applicationFeatureId}/changeModule/{applicationModuleId} | 
[**ApiFeatureApplicationFeatureIdContentGet**](FeatureApi.md#apifeatureapplicationfeatureidcontentget) | **GET** /api/Feature/{applicationFeatureId}/content | 
[**ApiFeatureApplicationFeatureIdDelete**](FeatureApi.md#apifeatureapplicationfeatureiddelete) | **DELETE** /api/Feature/{applicationFeatureId} | 
[**ApiFeatureApplicationFeatureIdDisableDelete**](FeatureApi.md#apifeatureapplicationfeatureiddisabledelete) | **DELETE** /api/Feature/{applicationFeatureId}/disable | 
[**ApiFeatureApplicationFeatureIdEnablePut**](FeatureApi.md#apifeatureapplicationfeatureidenableput) | **PUT** /api/Feature/{applicationFeatureId}/enable | 
[**ApiFeatureApplicationFeatureIdUpdateParentParentApplicationFeatureIdPut**](FeatureApi.md#apifeatureapplicationfeatureidupdateparentparentapplicationfeatureidput) | **PUT** /api/Feature/{applicationFeatureId}/updateParent/{parentApplicationFeatureId} | 
[**ApiFeatureApplicationFeatureIdUpdatePut**](FeatureApi.md#apifeatureapplicationfeatureidupdateput) | **PUT** /api/Feature/{applicationFeatureId}/update | 
[**ApiFeatureApplicationFeatureIdWebhooksBulkPut**](FeatureApi.md#apifeatureapplicationfeatureidwebhooksbulkput) | **PUT** /api/Feature/{applicationFeatureId}/webhooks/bulk | 
[**ApiFeatureApplicationFeatureIdWebhooksGet**](FeatureApi.md#apifeatureapplicationfeatureidwebhooksget) | **GET** /api/Feature/{applicationFeatureId}/webhooks | 
[**ApiFeatureApplicationFeatureIdWebhooksWebhookIdPost**](FeatureApi.md#apifeatureapplicationfeatureidwebhookswebhookidpost) | **POST** /api/Feature/{applicationFeatureId}/webhooks/{webhookId} | 
[**ApiFeatureApplicationFeatureIdWebhooksWebhookInstanceIdPut**](FeatureApi.md#apifeatureapplicationfeatureidwebhookswebhookinstanceidput) | **PUT** /api/Feature/{applicationFeatureId}/webhooks/{webhookInstanceId} | 
[**ApiFeatureApplicationIdAddFeaturePost**](FeatureApi.md#apifeatureapplicationidaddfeaturepost) | **POST** /api/Feature/{applicationId}/AddFeature | 
[**ApiFeatureApplicationIdAvailableGet**](FeatureApi.md#apifeatureapplicationidavailableget) | **GET** /api/Feature/{applicationId}/Available | 
[**ApiFeatureApplicationIdFeaturesConversationCountsGet**](FeatureApi.md#apifeatureapplicationidfeaturesconversationcountsget) | **GET** /api/Feature/{applicationId}/features/conversationCounts | 
[**ApiFeatureApplicationIdFeaturesGet**](FeatureApi.md#apifeatureapplicationidfeaturesget) | **GET** /api/Feature/{applicationId}/features | 
[**ApiFeatureApplicationIdReorderFeaturesPut**](FeatureApi.md#apifeatureapplicationidreorderfeaturesput) | **PUT** /api/Feature/{applicationId}/reorderFeatures | 
[**ApiFeatureBuiltInGet**](FeatureApi.md#apifeaturebuiltinget) | **GET** /api/Feature/BuiltIn | 
[**ApiFeatureTypesGet**](FeatureApi.md#apifeaturetypesget) | **GET** /api/Feature/Types | 
[**ApiFeatureWebhookApplicationFeatureWebhookIdDelete**](FeatureApi.md#apifeaturewebhookapplicationfeaturewebhookiddelete) | **DELETE** /api/Feature/webhook/{applicationFeatureWebhookId} | 
[**ApiFeatureWebhookInstanceWebhookIdUserParametersParameterNameDelete**](FeatureApi.md#apifeaturewebhookinstancewebhookiduserparametersparameternamedelete) | **DELETE** /api/Feature/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**ApiFeatureWebhookInstanceWebhookIdUserParametersPost**](FeatureApi.md#apifeaturewebhookinstancewebhookiduserparameterspost) | **POST** /api/Feature/webhook/{instanceWebhookId}/userParameters | 
[**ApiFeatureWebhookInstanceWebhookIdUserParametersPut**](FeatureApi.md#apifeaturewebhookinstancewebhookiduserparametersput) | **PUT** /api/Feature/webhook/{instanceWebhookId}/userParameters | 
[**ApiFeatureWebhookInstanceWebhookIdWebhookParametersPut**](FeatureApi.md#apifeaturewebhookinstancewebhookidwebhookparametersput) | **PUT** /api/Feature/webhook/{instanceWebhookId}/webhookParameters | 

<a name="apifeatureapplicationfeatureidchangemoduleapplicationmoduleidput"></a>
# **ApiFeatureApplicationFeatureIdChangeModuleApplicationModuleIdPut**
> ApplicationFeatureModel ApiFeatureApplicationFeatureIdChangeModuleApplicationModuleIdPut (string applicationFeatureId, string applicationModuleId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdChangeModuleApplicationModuleIdPutExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var applicationModuleId = applicationModuleId_example;  // string | 

            try
            {
                ApplicationFeatureModel result = apiInstance.ApiFeatureApplicationFeatureIdChangeModuleApplicationModuleIdPut(applicationFeatureId, applicationModuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdChangeModuleApplicationModuleIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **applicationModuleId** | **string**|  | 

### Return type

[**ApplicationFeatureModel**](ApplicationFeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureidcontentget"></a>
# **ApiFeatureApplicationFeatureIdContentGet**
> List<GenericContentModel> ApiFeatureApplicationFeatureIdContentGet (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdContentGetExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                List&lt;GenericContentModel&gt; result = apiInstance.ApiFeatureApplicationFeatureIdContentGet(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdContentGet: " + e.Message );
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

[**List<GenericContentModel>**](GenericContentModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureiddelete"></a>
# **ApiFeatureApplicationFeatureIdDelete**
> ApplicationFeatureModel ApiFeatureApplicationFeatureIdDelete (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdDeleteExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                ApplicationFeatureModel result = apiInstance.ApiFeatureApplicationFeatureIdDelete(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdDelete: " + e.Message );
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

[**ApplicationFeatureModel**](ApplicationFeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureiddisabledelete"></a>
# **ApiFeatureApplicationFeatureIdDisableDelete**
> ApplicationFeatureModel ApiFeatureApplicationFeatureIdDisableDelete (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdDisableDeleteExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                ApplicationFeatureModel result = apiInstance.ApiFeatureApplicationFeatureIdDisableDelete(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdDisableDelete: " + e.Message );
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

[**ApplicationFeatureModel**](ApplicationFeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureidenableput"></a>
# **ApiFeatureApplicationFeatureIdEnablePut**
> ApplicationFeatureModel ApiFeatureApplicationFeatureIdEnablePut (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdEnablePutExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                ApplicationFeatureModel result = apiInstance.ApiFeatureApplicationFeatureIdEnablePut(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdEnablePut: " + e.Message );
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

[**ApplicationFeatureModel**](ApplicationFeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureidupdateparentparentapplicationfeatureidput"></a>
# **ApiFeatureApplicationFeatureIdUpdateParentParentApplicationFeatureIdPut**
> ApplicationFeatureModel ApiFeatureApplicationFeatureIdUpdateParentParentApplicationFeatureIdPut (string applicationFeatureId, string parentApplicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdUpdateParentParentApplicationFeatureIdPutExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var parentApplicationFeatureId = parentApplicationFeatureId_example;  // string | 

            try
            {
                ApplicationFeatureModel result = apiInstance.ApiFeatureApplicationFeatureIdUpdateParentParentApplicationFeatureIdPut(applicationFeatureId, parentApplicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdUpdateParentParentApplicationFeatureIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **parentApplicationFeatureId** | **string**|  | 

### Return type

[**ApplicationFeatureModel**](ApplicationFeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureidupdateput"></a>
# **ApiFeatureApplicationFeatureIdUpdatePut**
> ApplicationFeatureModel ApiFeatureApplicationFeatureIdUpdatePut (string applicationFeatureId, UpdateApplicationFeatureRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdUpdatePutExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var body = new UpdateApplicationFeatureRequest(); // UpdateApplicationFeatureRequest |  (optional) 

            try
            {
                ApplicationFeatureModel result = apiInstance.ApiFeatureApplicationFeatureIdUpdatePut(applicationFeatureId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **body** | [**UpdateApplicationFeatureRequest**](UpdateApplicationFeatureRequest.md)|  | [optional] 

### Return type

[**ApplicationFeatureModel**](ApplicationFeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureidwebhooksbulkput"></a>
# **ApiFeatureApplicationFeatureIdWebhooksBulkPut**
> List<ApplicationFeatureWebhookModel> ApiFeatureApplicationFeatureIdWebhooksBulkPut (string applicationFeatureId, BulkWebhookInstancesUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdWebhooksBulkPutExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var body = new BulkWebhookInstancesUpdateRequest(); // BulkWebhookInstancesUpdateRequest |  (optional) 

            try
            {
                List&lt;ApplicationFeatureWebhookModel&gt; result = apiInstance.ApiFeatureApplicationFeatureIdWebhooksBulkPut(applicationFeatureId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdWebhooksBulkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **body** | [**BulkWebhookInstancesUpdateRequest**](BulkWebhookInstancesUpdateRequest.md)|  | [optional] 

### Return type

[**List<ApplicationFeatureWebhookModel>**](ApplicationFeatureWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureidwebhooksget"></a>
# **ApiFeatureApplicationFeatureIdWebhooksGet**
> List<ApplicationFeatureWebhookModel> ApiFeatureApplicationFeatureIdWebhooksGet (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdWebhooksGetExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                List&lt;ApplicationFeatureWebhookModel&gt; result = apiInstance.ApiFeatureApplicationFeatureIdWebhooksGet(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdWebhooksGet: " + e.Message );
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

[**List<ApplicationFeatureWebhookModel>**](ApplicationFeatureWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureidwebhookswebhookidpost"></a>
# **ApiFeatureApplicationFeatureIdWebhooksWebhookIdPost**
> ApplicationFeatureWebhookModel ApiFeatureApplicationFeatureIdWebhooksWebhookIdPost (string applicationFeatureId, string webhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdWebhooksWebhookIdPostExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                ApplicationFeatureWebhookModel result = apiInstance.ApiFeatureApplicationFeatureIdWebhooksWebhookIdPost(applicationFeatureId, webhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdWebhooksWebhookIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **webhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**ApplicationFeatureWebhookModel**](ApplicationFeatureWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationfeatureidwebhookswebhookinstanceidput"></a>
# **ApiFeatureApplicationFeatureIdWebhooksWebhookInstanceIdPut**
> ApplicationFeatureWebhookModel ApiFeatureApplicationFeatureIdWebhooksWebhookInstanceIdPut (string applicationFeatureId, string webhookInstanceId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationFeatureIdWebhooksWebhookInstanceIdPutExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                ApplicationFeatureWebhookModel result = apiInstance.ApiFeatureApplicationFeatureIdWebhooksWebhookInstanceIdPut(applicationFeatureId, webhookInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationFeatureIdWebhooksWebhookInstanceIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**ApplicationFeatureWebhookModel**](ApplicationFeatureWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationidaddfeaturepost"></a>
# **ApiFeatureApplicationIdAddFeaturePost**
> ApplicationFeatureModel ApiFeatureApplicationIdAddFeaturePost (string applicationId, CreateApplicationFeatureRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationIdAddFeaturePostExample
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

            var apiInstance = new FeatureApi();
            var applicationId = applicationId_example;  // string | 
            var body = new CreateApplicationFeatureRequest(); // CreateApplicationFeatureRequest |  (optional) 

            try
            {
                ApplicationFeatureModel result = apiInstance.ApiFeatureApplicationIdAddFeaturePost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationIdAddFeaturePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**CreateApplicationFeatureRequest**](CreateApplicationFeatureRequest.md)|  | [optional] 

### Return type

[**ApplicationFeatureModel**](ApplicationFeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationidavailableget"></a>
# **ApiFeatureApplicationIdAvailableGet**
> List<FeatureModel> ApiFeatureApplicationIdAvailableGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationIdAvailableGetExample
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

            var apiInstance = new FeatureApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;FeatureModel&gt; result = apiInstance.ApiFeatureApplicationIdAvailableGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationIdAvailableGet: " + e.Message );
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

[**List<FeatureModel>**](FeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationidfeaturesconversationcountsget"></a>
# **ApiFeatureApplicationIdFeaturesConversationCountsGet**
> List<ConversationCountModel> ApiFeatureApplicationIdFeaturesConversationCountsGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationIdFeaturesConversationCountsGetExample
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

            var apiInstance = new FeatureApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;ConversationCountModel&gt; result = apiInstance.ApiFeatureApplicationIdFeaturesConversationCountsGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationIdFeaturesConversationCountsGet: " + e.Message );
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

[**List<ConversationCountModel>**](ConversationCountModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationidfeaturesget"></a>
# **ApiFeatureApplicationIdFeaturesGet**
> List<ApplicationFeatureModel> ApiFeatureApplicationIdFeaturesGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationIdFeaturesGetExample
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

            var apiInstance = new FeatureApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;ApplicationFeatureModel&gt; result = apiInstance.ApiFeatureApplicationIdFeaturesGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationIdFeaturesGet: " + e.Message );
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

[**List<ApplicationFeatureModel>**](ApplicationFeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeatureapplicationidreorderfeaturesput"></a>
# **ApiFeatureApplicationIdReorderFeaturesPut**
> List<ApplicationFeatureModel> ApiFeatureApplicationIdReorderFeaturesPut (string applicationId, List<string> body = null, string parentApplicationFeatureId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureApplicationIdReorderFeaturesPutExample
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

            var apiInstance = new FeatureApi();
            var applicationId = applicationId_example;  // string | 
            var body = new List<string>(); // List<string> |  (optional) 
            var parentApplicationFeatureId = parentApplicationFeatureId_example;  // string |  (optional) 

            try
            {
                List&lt;ApplicationFeatureModel&gt; result = apiInstance.ApiFeatureApplicationIdReorderFeaturesPut(applicationId, body, parentApplicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureApplicationIdReorderFeaturesPut: " + e.Message );
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
 **parentApplicationFeatureId** | **string**|  | [optional] 

### Return type

[**List<ApplicationFeatureModel>**](ApplicationFeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeaturebuiltinget"></a>
# **ApiFeatureBuiltInGet**
> List<FeatureModel> ApiFeatureBuiltInGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureBuiltInGetExample
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

            var apiInstance = new FeatureApi();

            try
            {
                List&lt;FeatureModel&gt; result = apiInstance.ApiFeatureBuiltInGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureBuiltInGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FeatureModel>**](FeatureModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeaturetypesget"></a>
# **ApiFeatureTypesGet**
> List<FeatureTypeModel> ApiFeatureTypesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureTypesGetExample
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

            var apiInstance = new FeatureApi();

            try
            {
                List&lt;FeatureTypeModel&gt; result = apiInstance.ApiFeatureTypesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FeatureTypeModel>**](FeatureTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeaturewebhookapplicationfeaturewebhookiddelete"></a>
# **ApiFeatureWebhookApplicationFeatureWebhookIdDelete**
> ApplicationFeatureWebhookModel ApiFeatureWebhookApplicationFeatureWebhookIdDelete (string applicationFeatureWebhookId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureWebhookApplicationFeatureWebhookIdDeleteExample
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

            var apiInstance = new FeatureApi();
            var applicationFeatureWebhookId = applicationFeatureWebhookId_example;  // string | 

            try
            {
                ApplicationFeatureWebhookModel result = apiInstance.ApiFeatureWebhookApplicationFeatureWebhookIdDelete(applicationFeatureWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureWebhookApplicationFeatureWebhookIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureWebhookId** | **string**|  | 

### Return type

[**ApplicationFeatureWebhookModel**](ApplicationFeatureWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeaturewebhookinstancewebhookiduserparametersparameternamedelete"></a>
# **ApiFeatureWebhookInstanceWebhookIdUserParametersParameterNameDelete**
> bool? ApiFeatureWebhookInstanceWebhookIdUserParametersParameterNameDelete (string instanceWebhookId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureWebhookInstanceWebhookIdUserParametersParameterNameDeleteExample
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

            var apiInstance = new FeatureApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.ApiFeatureWebhookInstanceWebhookIdUserParametersParameterNameDelete(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureWebhookInstanceWebhookIdUserParametersParameterNameDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **parameterName** | **string**|  | 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeaturewebhookinstancewebhookiduserparameterspost"></a>
# **ApiFeatureWebhookInstanceWebhookIdUserParametersPost**
> bool? ApiFeatureWebhookInstanceWebhookIdUserParametersPost (string instanceWebhookId, UserDefinedWebhookParameterCreateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureWebhookInstanceWebhookIdUserParametersPostExample
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

            var apiInstance = new FeatureApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiFeatureWebhookInstanceWebhookIdUserParametersPost(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureWebhookInstanceWebhookIdUserParametersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **body** | [**UserDefinedWebhookParameterCreateRequest**](UserDefinedWebhookParameterCreateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeaturewebhookinstancewebhookiduserparametersput"></a>
# **ApiFeatureWebhookInstanceWebhookIdUserParametersPut**
> bool? ApiFeatureWebhookInstanceWebhookIdUserParametersPut (string instanceWebhookId, UserDefinedWebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureWebhookInstanceWebhookIdUserParametersPutExample
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

            var apiInstance = new FeatureApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiFeatureWebhookInstanceWebhookIdUserParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureWebhookInstanceWebhookIdUserParametersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **body** | [**UserDefinedWebhookParameterUpdateRequest**](UserDefinedWebhookParameterUpdateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifeaturewebhookinstancewebhookidwebhookparametersput"></a>
# **ApiFeatureWebhookInstanceWebhookIdWebhookParametersPut**
> bool? ApiFeatureWebhookInstanceWebhookIdWebhookParametersPut (string instanceWebhookId, WebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFeatureWebhookInstanceWebhookIdWebhookParametersPutExample
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

            var apiInstance = new FeatureApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiFeatureWebhookInstanceWebhookIdWebhookParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeatureApi.ApiFeatureWebhookInstanceWebhookIdWebhookParametersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **body** | [**WebhookParameterUpdateRequest**](WebhookParameterUpdateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
