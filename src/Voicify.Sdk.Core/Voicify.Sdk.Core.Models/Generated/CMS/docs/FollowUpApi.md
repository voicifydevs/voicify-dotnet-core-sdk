# Voicify.Sdk.Core.Models.Api.FollowUpApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiFollowUpApplicationIdGet**](FollowUpApi.md#apifollowupapplicationidget) | **GET** /api/FollowUp/{applicationId} | 
[**ApiFollowUpApplicationIdPost**](FollowUpApi.md#apifollowupapplicationidpost) | **POST** /api/FollowUp/{applicationId} | 
[**ApiFollowUpFindFollowUpIdChildrenGet**](FollowUpApi.md#apifollowupfindfollowupidchildrenget) | **GET** /api/FollowUp/find/{followUpId}/children | 
[**ApiFollowUpFindFollowUpIdGet**](FollowUpApi.md#apifollowupfindfollowupidget) | **GET** /api/FollowUp/find/{followUpId} | 
[**ApiFollowUpFollowUpIdDelete**](FollowUpApi.md#apifollowupfollowupiddelete) | **DELETE** /api/FollowUp/{followUpId} | 
[**ApiFollowUpFollowUpIdShouldNotSyncPut**](FollowUpApi.md#apifollowupfollowupidshouldnotsyncput) | **PUT** /api/FollowUp/{followUpId}/shouldNotSync | 
[**ApiFollowUpParentsFeatureTypeIdContentIdContentGet**](FollowUpApi.md#apifollowupparentsfeaturetypeidcontentidcontentget) | **GET** /api/FollowUp/parents/{featureTypeId}/{contentId}/content | 
[**ApiFollowUpParentsFeatureTypeIdContentIdGet**](FollowUpApi.md#apifollowupparentsfeaturetypeidcontentidget) | **GET** /api/FollowUp/parents/{featureTypeId}/{contentId} | 
[**ApiFollowUpPut**](FollowUpApi.md#apifollowupput) | **PUT** /api/FollowUp | 

<a name="apifollowupapplicationidget"></a>
# **ApiFollowUpApplicationIdGet**
> List<FollowUpModel> ApiFollowUpApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFollowUpApplicationIdGetExample
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

            var apiInstance = new FollowUpApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;FollowUpModel&gt; result = apiInstance.ApiFollowUpApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.ApiFollowUpApplicationIdGet: " + e.Message );
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

[**List<FollowUpModel>**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifollowupapplicationidpost"></a>
# **ApiFollowUpApplicationIdPost**
> FollowUpModel ApiFollowUpApplicationIdPost (string applicationId, CreateFollowUpRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFollowUpApplicationIdPostExample
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

            var apiInstance = new FollowUpApi();
            var applicationId = applicationId_example;  // string | 
            var body = new CreateFollowUpRequest(); // CreateFollowUpRequest |  (optional) 

            try
            {
                FollowUpModel result = apiInstance.ApiFollowUpApplicationIdPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.ApiFollowUpApplicationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**CreateFollowUpRequest**](CreateFollowUpRequest.md)|  | [optional] 

### Return type

[**FollowUpModel**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifollowupfindfollowupidchildrenget"></a>
# **ApiFollowUpFindFollowUpIdChildrenGet**
> ChildContentContainerModel ApiFollowUpFindFollowUpIdChildrenGet (string followUpId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFollowUpFindFollowUpIdChildrenGetExample
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

            var apiInstance = new FollowUpApi();
            var followUpId = followUpId_example;  // string | 

            try
            {
                ChildContentContainerModel result = apiInstance.ApiFollowUpFindFollowUpIdChildrenGet(followUpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.ApiFollowUpFindFollowUpIdChildrenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **followUpId** | **string**|  | 

### Return type

[**ChildContentContainerModel**](ChildContentContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifollowupfindfollowupidget"></a>
# **ApiFollowUpFindFollowUpIdGet**
> FollowUpModel ApiFollowUpFindFollowUpIdGet (string followUpId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFollowUpFindFollowUpIdGetExample
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

            var apiInstance = new FollowUpApi();
            var followUpId = followUpId_example;  // string | 

            try
            {
                FollowUpModel result = apiInstance.ApiFollowUpFindFollowUpIdGet(followUpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.ApiFollowUpFindFollowUpIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **followUpId** | **string**|  | 

### Return type

[**FollowUpModel**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifollowupfollowupiddelete"></a>
# **ApiFollowUpFollowUpIdDelete**
> FollowUpModel ApiFollowUpFollowUpIdDelete (string followUpId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFollowUpFollowUpIdDeleteExample
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

            var apiInstance = new FollowUpApi();
            var followUpId = followUpId_example;  // string | 

            try
            {
                FollowUpModel result = apiInstance.ApiFollowUpFollowUpIdDelete(followUpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.ApiFollowUpFollowUpIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **followUpId** | **string**|  | 

### Return type

[**FollowUpModel**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifollowupfollowupidshouldnotsyncput"></a>
# **ApiFollowUpFollowUpIdShouldNotSyncPut**
> FollowUpModel ApiFollowUpFollowUpIdShouldNotSyncPut (string followUpId, ToggleSyncRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFollowUpFollowUpIdShouldNotSyncPutExample
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

            var apiInstance = new FollowUpApi();
            var followUpId = followUpId_example;  // string | 
            var body = new ToggleSyncRequest(); // ToggleSyncRequest |  (optional) 

            try
            {
                FollowUpModel result = apiInstance.ApiFollowUpFollowUpIdShouldNotSyncPut(followUpId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.ApiFollowUpFollowUpIdShouldNotSyncPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **followUpId** | **string**|  | 
 **body** | [**ToggleSyncRequest**](ToggleSyncRequest.md)|  | [optional] 

### Return type

[**FollowUpModel**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifollowupparentsfeaturetypeidcontentidcontentget"></a>
# **ApiFollowUpParentsFeatureTypeIdContentIdContentGet**
> ParentContentContainerModel ApiFollowUpParentsFeatureTypeIdContentIdContentGet (string featureTypeId, string contentId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFollowUpParentsFeatureTypeIdContentIdContentGetExample
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

            var apiInstance = new FollowUpApi();
            var featureTypeId = featureTypeId_example;  // string | 
            var contentId = contentId_example;  // string | 

            try
            {
                ParentContentContainerModel result = apiInstance.ApiFollowUpParentsFeatureTypeIdContentIdContentGet(featureTypeId, contentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.ApiFollowUpParentsFeatureTypeIdContentIdContentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **featureTypeId** | **string**|  | 
 **contentId** | **string**|  | 

### Return type

[**ParentContentContainerModel**](ParentContentContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifollowupparentsfeaturetypeidcontentidget"></a>
# **ApiFollowUpParentsFeatureTypeIdContentIdGet**
> List<FollowUpModel> ApiFollowUpParentsFeatureTypeIdContentIdGet (string featureTypeId, string contentId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFollowUpParentsFeatureTypeIdContentIdGetExample
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

            var apiInstance = new FollowUpApi();
            var featureTypeId = featureTypeId_example;  // string | 
            var contentId = contentId_example;  // string | 

            try
            {
                List&lt;FollowUpModel&gt; result = apiInstance.ApiFollowUpParentsFeatureTypeIdContentIdGet(featureTypeId, contentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.ApiFollowUpParentsFeatureTypeIdContentIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **featureTypeId** | **string**|  | 
 **contentId** | **string**|  | 

### Return type

[**List<FollowUpModel>**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apifollowupput"></a>
# **ApiFollowUpPut**
> FollowUpModel ApiFollowUpPut (UpdateFollowUpRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiFollowUpPutExample
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

            var apiInstance = new FollowUpApi();
            var body = new UpdateFollowUpRequest(); // UpdateFollowUpRequest |  (optional) 

            try
            {
                FollowUpModel result = apiInstance.ApiFollowUpPut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.ApiFollowUpPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateFollowUpRequest**](UpdateFollowUpRequest.md)|  | [optional] 

### Return type

[**FollowUpModel**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
