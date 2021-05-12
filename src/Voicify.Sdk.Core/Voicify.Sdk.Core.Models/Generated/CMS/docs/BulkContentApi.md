# Voicify.Sdk.Core.Models.Api.BulkContentApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiBulkContentCopyToFeatureApplicationFeatureIdPut**](BulkContentApi.md#apibulkcontentcopytofeatureapplicationfeatureidput) | **PUT** /api/BulkContent/CopyToFeature/{applicationFeatureId} | 
[**ApiBulkContentDeletePut**](BulkContentApi.md#apibulkcontentdeleteput) | **PUT** /api/BulkContent/Delete | 
[**ApiBulkContentLoadDetailsPost**](BulkContentApi.md#apibulkcontentloaddetailspost) | **POST** /api/BulkContent/LoadDetails | 
[**ApiBulkContentMoveToFeatureApplicationFeatureIdPut**](BulkContentApi.md#apibulkcontentmovetofeatureapplicationfeatureidput) | **PUT** /api/BulkContent/MoveToFeature/{applicationFeatureId} | 

<a name="apibulkcontentcopytofeatureapplicationfeatureidput"></a>
# **ApiBulkContentCopyToFeatureApplicationFeatureIdPut**
> string ApiBulkContentCopyToFeatureApplicationFeatureIdPut (string applicationFeatureId, BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiBulkContentCopyToFeatureApplicationFeatureIdPutExample
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

            var apiInstance = new BulkContentApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var body = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                string result = apiInstance.ApiBulkContentCopyToFeatureApplicationFeatureIdPut(applicationFeatureId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.ApiBulkContentCopyToFeatureApplicationFeatureIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **body** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apibulkcontentdeleteput"></a>
# **ApiBulkContentDeletePut**
> string ApiBulkContentDeletePut (BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiBulkContentDeletePutExample
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

            var apiInstance = new BulkContentApi();
            var body = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                string result = apiInstance.ApiBulkContentDeletePut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.ApiBulkContentDeletePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apibulkcontentloaddetailspost"></a>
# **ApiBulkContentLoadDetailsPost**
> List<SlimGenericContentModel> ApiBulkContentLoadDetailsPost (BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiBulkContentLoadDetailsPostExample
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

            var apiInstance = new BulkContentApi();
            var body = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                List&lt;SlimGenericContentModel&gt; result = apiInstance.ApiBulkContentLoadDetailsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.ApiBulkContentLoadDetailsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

[**List<SlimGenericContentModel>**](SlimGenericContentModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apibulkcontentmovetofeatureapplicationfeatureidput"></a>
# **ApiBulkContentMoveToFeatureApplicationFeatureIdPut**
> string ApiBulkContentMoveToFeatureApplicationFeatureIdPut (string applicationFeatureId, BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiBulkContentMoveToFeatureApplicationFeatureIdPutExample
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

            var apiInstance = new BulkContentApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var body = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                string result = apiInstance.ApiBulkContentMoveToFeatureApplicationFeatureIdPut(applicationFeatureId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.ApiBulkContentMoveToFeatureApplicationFeatureIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **body** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
