# Voicify.Sdk.Core.Models.Api.BulkContentApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkCopyContentToApplicationFeature**](BulkContentApi.md#bulkcopycontenttoapplicationfeature) | **PUT** /api/BulkContent/CopyToFeature/{applicationFeatureId} | 
[**BulkMoveContentToApplicationFeature**](BulkContentApi.md#bulkmovecontenttoapplicationfeature) | **PUT** /api/BulkContent/MoveToFeature/{applicationFeatureId} | 
[**DeleteContentInBulk**](BulkContentApi.md#deletecontentinbulk) | **PUT** /api/BulkContent/Delete | 
[**LoadContentDetails**](BulkContentApi.md#loadcontentdetails) | **POST** /api/BulkContent/LoadDetails | 

<a name="bulkcopycontenttoapplicationfeature"></a>
# **BulkCopyContentToApplicationFeature**
> string BulkCopyContentToApplicationFeature (string applicationFeatureId, BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkCopyContentToApplicationFeatureExample
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
                string result = apiInstance.BulkCopyContentToApplicationFeature(applicationFeatureId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.BulkCopyContentToApplicationFeature: " + e.Message );
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
<a name="bulkmovecontenttoapplicationfeature"></a>
# **BulkMoveContentToApplicationFeature**
> string BulkMoveContentToApplicationFeature (string applicationFeatureId, BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkMoveContentToApplicationFeatureExample
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
                string result = apiInstance.BulkMoveContentToApplicationFeature(applicationFeatureId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.BulkMoveContentToApplicationFeature: " + e.Message );
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
<a name="deletecontentinbulk"></a>
# **DeleteContentInBulk**
> string DeleteContentInBulk (BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteContentInBulkExample
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
                string result = apiInstance.DeleteContentInBulk(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.DeleteContentInBulk: " + e.Message );
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
<a name="loadcontentdetails"></a>
# **LoadContentDetails**
> List<SlimGenericContentModel> LoadContentDetails (BulkContentRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class LoadContentDetailsExample
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
                List&lt;SlimGenericContentModel&gt; result = apiInstance.LoadContentDetails(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.LoadContentDetails: " + e.Message );
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
