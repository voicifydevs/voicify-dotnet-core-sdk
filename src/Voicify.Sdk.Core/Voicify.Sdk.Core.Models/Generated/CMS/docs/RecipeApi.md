# Voicify.Sdk.Core.Models.Api.RecipeApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiRecipeByFeatureApplicationFeatureIdGet**](RecipeApi.md#apirecipebyfeatureapplicationfeatureidget) | **GET** /api/Recipe/byFeature/{applicationFeatureId} | 
[**ApiRecipeContentItemIdFullPut**](RecipeApi.md#apirecipecontentitemidfullput) | **PUT** /api/Recipe/{contentItemId}/full | 
[**ApiRecipeContentItemIdMoveToFeatureApplicationFeatureIdPut**](RecipeApi.md#apirecipecontentitemidmovetofeatureapplicationfeatureidput) | **PUT** /api/Recipe/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**ApiRecipeFullIdGet**](RecipeApi.md#apirecipefullidget) | **GET** /api/Recipe/full/{id} | 
[**ApiRecipeFullPost**](RecipeApi.md#apirecipefullpost) | **POST** /api/Recipe/full | 
[**ApiRecipePost**](RecipeApi.md#apirecipepost) | **POST** /api/Recipe | 
[**ApiRecipeRecipeIdBulkUpdatePut**](RecipeApi.md#apireciperecipeidbulkupdateput) | **PUT** /api/Recipe/{recipeId}/bulkUpdate | 
[**ApiRecipeRecipeIdBulkUpdateStubPut**](RecipeApi.md#apireciperecipeidbulkupdatestubput) | **PUT** /api/Recipe/{recipeId}/bulkUpdate/stub | 
[**ApiRecipeRecipeIdCopyPost**](RecipeApi.md#apireciperecipeidcopypost) | **POST** /api/Recipe/{recipeId}/copy | 
[**ApiRecipeRecipeIdDelete**](RecipeApi.md#apireciperecipeiddelete) | **DELETE** /api/Recipe/{recipeId} | 
[**ApiRecipeRecipeIdIsLivePut**](RecipeApi.md#apireciperecipeidisliveput) | **PUT** /api/Recipe/{recipeId}/isLive | 
[**ApiRecipeRecipeIdWebhooksBulkPut**](RecipeApi.md#apireciperecipeidwebhooksbulkput) | **PUT** /api/Recipe/{recipeId}/webhooks/bulk | 
[**ApiRecipeRecipeIdWebhooksGet**](RecipeApi.md#apireciperecipeidwebhooksget) | **GET** /api/Recipe/{recipeId}/webhooks | 
[**ApiRecipeRecipeIdWebhooksWebhookIdPost**](RecipeApi.md#apireciperecipeidwebhookswebhookidpost) | **POST** /api/Recipe/{recipeId}/webhooks/{webhookId} | 
[**ApiRecipeRecipeIdWebhooksWebhookInstanceIdPut**](RecipeApi.md#apireciperecipeidwebhookswebhookinstanceidput) | **PUT** /api/Recipe/{recipeId}/webhooks/{webhookInstanceId} | 
[**ApiRecipeStubPost**](RecipeApi.md#apirecipestubpost) | **POST** /api/Recipe/stub | 
[**ApiRecipeWebhookInstanceWebhookIdUserParametersParameterNameDelete**](RecipeApi.md#apirecipewebhookinstancewebhookiduserparametersparameternamedelete) | **DELETE** /api/Recipe/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**ApiRecipeWebhookInstanceWebhookIdUserParametersPost**](RecipeApi.md#apirecipewebhookinstancewebhookiduserparameterspost) | **POST** /api/Recipe/webhook/{instanceWebhookId}/userParameters | 
[**ApiRecipeWebhookInstanceWebhookIdUserParametersPut**](RecipeApi.md#apirecipewebhookinstancewebhookiduserparametersput) | **PUT** /api/Recipe/webhook/{instanceWebhookId}/userParameters | 
[**ApiRecipeWebhookInstanceWebhookIdWebhookParametersPut**](RecipeApi.md#apirecipewebhookinstancewebhookidwebhookparametersput) | **PUT** /api/Recipe/webhook/{instanceWebhookId}/webhookParameters | 
[**ApiRecipeWebhookRecipeWebhookIdDelete**](RecipeApi.md#apirecipewebhookrecipewebhookiddelete) | **DELETE** /api/Recipe/webhook/{recipeWebhookId} | 

<a name="apirecipebyfeatureapplicationfeatureidget"></a>
# **ApiRecipeByFeatureApplicationFeatureIdGet**
> List<RecipeModel> ApiRecipeByFeatureApplicationFeatureIdGet (string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeByFeatureApplicationFeatureIdGetExample
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

            var apiInstance = new RecipeApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                List&lt;RecipeModel&gt; result = apiInstance.ApiRecipeByFeatureApplicationFeatureIdGet(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeByFeatureApplicationFeatureIdGet: " + e.Message );
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

[**List<RecipeModel>**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apirecipecontentitemidfullput"></a>
# **ApiRecipeContentItemIdFullPut**
> RecipeModel ApiRecipeContentItemIdFullPut (string contentItemId, RecipeModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeContentItemIdFullPutExample
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

            var apiInstance = new RecipeApi();
            var contentItemId = contentItemId_example;  // string | 
            var body = new RecipeModel(); // RecipeModel |  (optional) 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeContentItemIdFullPut(contentItemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeContentItemIdFullPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **body** | [**RecipeModel**](RecipeModel.md)|  | [optional] 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apirecipecontentitemidmovetofeatureapplicationfeatureidput"></a>
# **ApiRecipeContentItemIdMoveToFeatureApplicationFeatureIdPut**
> RecipeModel ApiRecipeContentItemIdMoveToFeatureApplicationFeatureIdPut (string contentItemId, string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeContentItemIdMoveToFeatureApplicationFeatureIdPutExample
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

            var apiInstance = new RecipeApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeContentItemIdMoveToFeatureApplicationFeatureIdPut(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeContentItemIdMoveToFeatureApplicationFeatureIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **applicationFeatureId** | **string**|  | 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apirecipefullidget"></a>
# **ApiRecipeFullIdGet**
> RecipeModel ApiRecipeFullIdGet (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeFullIdGetExample
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

            var apiInstance = new RecipeApi();
            var id = id_example;  // string | 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeFullIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeFullIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apirecipefullpost"></a>
# **ApiRecipeFullPost**
> RecipeModel ApiRecipeFullPost (RecipeModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeFullPostExample
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

            var apiInstance = new RecipeApi();
            var body = new RecipeModel(); // RecipeModel |  (optional) 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeFullPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeFullPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecipeModel**](RecipeModel.md)|  | [optional] 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apirecipepost"></a>
# **ApiRecipePost**
> RecipeModel ApiRecipePost (CreateRecipeRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipePostExample
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

            var apiInstance = new RecipeApi();
            var body = new CreateRecipeRequest(); // CreateRecipeRequest |  (optional) 

            try
            {
                RecipeModel result = apiInstance.ApiRecipePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRecipeRequest**](CreateRecipeRequest.md)|  | [optional] 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apireciperecipeidbulkupdateput"></a>
# **ApiRecipeRecipeIdBulkUpdatePut**
> RecipeModel ApiRecipeRecipeIdBulkUpdatePut (string recipeId, BulkUpdateRecipeRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeRecipeIdBulkUpdatePutExample
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

            var apiInstance = new RecipeApi();
            var recipeId = recipeId_example;  // string | 
            var body = new BulkUpdateRecipeRequest(); // BulkUpdateRecipeRequest |  (optional) 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeRecipeIdBulkUpdatePut(recipeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeRecipeIdBulkUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **string**|  | 
 **body** | [**BulkUpdateRecipeRequest**](BulkUpdateRecipeRequest.md)|  | [optional] 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apireciperecipeidbulkupdatestubput"></a>
# **ApiRecipeRecipeIdBulkUpdateStubPut**
> RecipeModel ApiRecipeRecipeIdBulkUpdateStubPut (string recipeId, BulkUpdateRecipeStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeRecipeIdBulkUpdateStubPutExample
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

            var apiInstance = new RecipeApi();
            var recipeId = recipeId_example;  // string | 
            var body = new BulkUpdateRecipeStubRequest(); // BulkUpdateRecipeStubRequest |  (optional) 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeRecipeIdBulkUpdateStubPut(recipeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeRecipeIdBulkUpdateStubPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **string**|  | 
 **body** | [**BulkUpdateRecipeStubRequest**](BulkUpdateRecipeStubRequest.md)|  | [optional] 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apireciperecipeidcopypost"></a>
# **ApiRecipeRecipeIdCopyPost**
> RecipeModel ApiRecipeRecipeIdCopyPost (string recipeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeRecipeIdCopyPostExample
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

            var apiInstance = new RecipeApi();
            var recipeId = recipeId_example;  // string | 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeRecipeIdCopyPost(recipeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeRecipeIdCopyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **string**|  | 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apireciperecipeiddelete"></a>
# **ApiRecipeRecipeIdDelete**
> RecipeModel ApiRecipeRecipeIdDelete (string recipeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeRecipeIdDeleteExample
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

            var apiInstance = new RecipeApi();
            var recipeId = recipeId_example;  // string | 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeRecipeIdDelete(recipeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeRecipeIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **string**|  | 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apireciperecipeidisliveput"></a>
# **ApiRecipeRecipeIdIsLivePut**
> RecipeModel ApiRecipeRecipeIdIsLivePut (string recipeId, ToggleLiveRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeRecipeIdIsLivePutExample
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

            var apiInstance = new RecipeApi();
            var recipeId = recipeId_example;  // string | 
            var body = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeRecipeIdIsLivePut(recipeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeRecipeIdIsLivePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **string**|  | 
 **body** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apireciperecipeidwebhooksbulkput"></a>
# **ApiRecipeRecipeIdWebhooksBulkPut**
> List<RecipeWebhookModel> ApiRecipeRecipeIdWebhooksBulkPut (string recipeId, BulkWebhookInstancesUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeRecipeIdWebhooksBulkPutExample
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

            var apiInstance = new RecipeApi();
            var recipeId = recipeId_example;  // string | 
            var body = new BulkWebhookInstancesUpdateRequest(); // BulkWebhookInstancesUpdateRequest |  (optional) 

            try
            {
                List&lt;RecipeWebhookModel&gt; result = apiInstance.ApiRecipeRecipeIdWebhooksBulkPut(recipeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeRecipeIdWebhooksBulkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **string**|  | 
 **body** | [**BulkWebhookInstancesUpdateRequest**](BulkWebhookInstancesUpdateRequest.md)|  | [optional] 

### Return type

[**List<RecipeWebhookModel>**](RecipeWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apireciperecipeidwebhooksget"></a>
# **ApiRecipeRecipeIdWebhooksGet**
> RecipeWebhookModel ApiRecipeRecipeIdWebhooksGet (string recipeId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeRecipeIdWebhooksGetExample
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

            var apiInstance = new RecipeApi();
            var recipeId = recipeId_example;  // string | 

            try
            {
                RecipeWebhookModel result = apiInstance.ApiRecipeRecipeIdWebhooksGet(recipeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeRecipeIdWebhooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **string**|  | 

### Return type

[**RecipeWebhookModel**](RecipeWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apireciperecipeidwebhookswebhookidpost"></a>
# **ApiRecipeRecipeIdWebhooksWebhookIdPost**
> RecipeWebhookModel ApiRecipeRecipeIdWebhooksWebhookIdPost (string recipeId, string webhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeRecipeIdWebhooksWebhookIdPostExample
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

            var apiInstance = new RecipeApi();
            var recipeId = recipeId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                RecipeWebhookModel result = apiInstance.ApiRecipeRecipeIdWebhooksWebhookIdPost(recipeId, webhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeRecipeIdWebhooksWebhookIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **string**|  | 
 **webhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**RecipeWebhookModel**](RecipeWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apireciperecipeidwebhookswebhookinstanceidput"></a>
# **ApiRecipeRecipeIdWebhooksWebhookInstanceIdPut**
> RecipeWebhookModel ApiRecipeRecipeIdWebhooksWebhookInstanceIdPut (string recipeId, string webhookInstanceId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeRecipeIdWebhooksWebhookInstanceIdPutExample
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

            var apiInstance = new RecipeApi();
            var recipeId = recipeId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                RecipeWebhookModel result = apiInstance.ApiRecipeRecipeIdWebhooksWebhookInstanceIdPut(recipeId, webhookInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeRecipeIdWebhooksWebhookInstanceIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**RecipeWebhookModel**](RecipeWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apirecipestubpost"></a>
# **ApiRecipeStubPost**
> RecipeModel ApiRecipeStubPost (CreateRecipeStubRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeStubPostExample
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

            var apiInstance = new RecipeApi();
            var body = new CreateRecipeStubRequest(); // CreateRecipeStubRequest |  (optional) 

            try
            {
                RecipeModel result = apiInstance.ApiRecipeStubPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeStubPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRecipeStubRequest**](CreateRecipeStubRequest.md)|  | [optional] 

### Return type

[**RecipeModel**](RecipeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apirecipewebhookinstancewebhookiduserparametersparameternamedelete"></a>
# **ApiRecipeWebhookInstanceWebhookIdUserParametersParameterNameDelete**
> bool? ApiRecipeWebhookInstanceWebhookIdUserParametersParameterNameDelete (string instanceWebhookId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeWebhookInstanceWebhookIdUserParametersParameterNameDeleteExample
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

            var apiInstance = new RecipeApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.ApiRecipeWebhookInstanceWebhookIdUserParametersParameterNameDelete(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeWebhookInstanceWebhookIdUserParametersParameterNameDelete: " + e.Message );
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
<a name="apirecipewebhookinstancewebhookiduserparameterspost"></a>
# **ApiRecipeWebhookInstanceWebhookIdUserParametersPost**
> bool? ApiRecipeWebhookInstanceWebhookIdUserParametersPost (string instanceWebhookId, UserDefinedWebhookParameterCreateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeWebhookInstanceWebhookIdUserParametersPostExample
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

            var apiInstance = new RecipeApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiRecipeWebhookInstanceWebhookIdUserParametersPost(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeWebhookInstanceWebhookIdUserParametersPost: " + e.Message );
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
<a name="apirecipewebhookinstancewebhookiduserparametersput"></a>
# **ApiRecipeWebhookInstanceWebhookIdUserParametersPut**
> bool? ApiRecipeWebhookInstanceWebhookIdUserParametersPut (string instanceWebhookId, UserDefinedWebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeWebhookInstanceWebhookIdUserParametersPutExample
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

            var apiInstance = new RecipeApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiRecipeWebhookInstanceWebhookIdUserParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeWebhookInstanceWebhookIdUserParametersPut: " + e.Message );
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
<a name="apirecipewebhookinstancewebhookidwebhookparametersput"></a>
# **ApiRecipeWebhookInstanceWebhookIdWebhookParametersPut**
> bool? ApiRecipeWebhookInstanceWebhookIdWebhookParametersPut (string instanceWebhookId, WebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeWebhookInstanceWebhookIdWebhookParametersPutExample
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

            var apiInstance = new RecipeApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiRecipeWebhookInstanceWebhookIdWebhookParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeWebhookInstanceWebhookIdWebhookParametersPut: " + e.Message );
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
<a name="apirecipewebhookrecipewebhookiddelete"></a>
# **ApiRecipeWebhookRecipeWebhookIdDelete**
> RecipeWebhookModel ApiRecipeWebhookRecipeWebhookIdDelete (string recipeWebhookId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiRecipeWebhookRecipeWebhookIdDeleteExample
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

            var apiInstance = new RecipeApi();
            var recipeWebhookId = recipeWebhookId_example;  // string | 

            try
            {
                RecipeWebhookModel result = apiInstance.ApiRecipeWebhookRecipeWebhookIdDelete(recipeWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecipeApi.ApiRecipeWebhookRecipeWebhookIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipeWebhookId** | **string**|  | 

### Return type

[**RecipeWebhookModel**](RecipeWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
