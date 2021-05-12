# Voicify.Sdk.Core.Models.Api.MediaResponseApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiMediaResponseContainersBulkPost**](MediaResponseApi.md#apimediaresponsecontainersbulkpost) | **POST** /api/MediaResponse/containers/bulk | 
[**ApiMediaResponseContainersContainerIdBulkPut**](MediaResponseApi.md#apimediaresponsecontainerscontaineridbulkput) | **PUT** /api/MediaResponse/containers/{containerId}/bulk | 
[**ApiMediaResponseContainersContainerIdDelete**](MediaResponseApi.md#apimediaresponsecontainerscontaineriddelete) | **DELETE** /api/MediaResponse/containers/{containerId} | 
[**ApiMediaResponseContainersContainerIdGet**](MediaResponseApi.md#apimediaresponsecontainerscontaineridget) | **GET** /api/MediaResponse/containers/{containerId} | 
[**ApiMediaResponseContainersContainerIdPut**](MediaResponseApi.md#apimediaresponsecontainerscontaineridput) | **PUT** /api/MediaResponse/containers/{containerId} | 
[**ApiMediaResponseContainersForAppApplicationIdGet**](MediaResponseApi.md#apimediaresponsecontainersforappapplicationidget) | **GET** /api/MediaResponse/containers/forApp/{applicationId} | 
[**ApiMediaResponseContainersPost**](MediaResponseApi.md#apimediaresponsecontainerspost) | **POST** /api/MediaResponse/containers | 
[**ApiMediaResponseMediaResponseIdDelete**](MediaResponseApi.md#apimediaresponsemediaresponseiddelete) | **DELETE** /api/MediaResponse/{mediaResponseId} | 
[**ApiMediaResponsePost**](MediaResponseApi.md#apimediaresponsepost) | **POST** /api/MediaResponse | 
[**ApiMediaResponseResponseIdPut**](MediaResponseApi.md#apimediaresponseresponseidput) | **PUT** /api/MediaResponse/{responseId} | 
[**ApiMediaResponseTemplateTypeAssistantAssistantGet**](MediaResponseApi.md#apimediaresponsetemplatetypeassistantassistantget) | **GET** /api/MediaResponse/templateType/assistant/{assistant} | 
[**ApiMediaResponseTemplateTypeDeviceTargetDeviceTargetIdGet**](MediaResponseApi.md#apimediaresponsetemplatetypedevicetargetdevicetargetidget) | **GET** /api/MediaResponse/templateType/deviceTarget/{deviceTargetId} | 
[**ApiMediaResponseTemplateTypeEnabledGet**](MediaResponseApi.md#apimediaresponsetemplatetypeenabledget) | **GET** /api/MediaResponse/templateType/enabled | 
[**ApiMediaResponseTemplateTypeGet**](MediaResponseApi.md#apimediaresponsetemplatetypeget) | **GET** /api/MediaResponse/templateType | 
[**ApiMediaResponseTemplateTypePost**](MediaResponseApi.md#apimediaresponsetemplatetypepost) | **POST** /api/MediaResponse/templateType | 
[**ApiMediaResponseTemplateTypeResponseTemplateIdGet**](MediaResponseApi.md#apimediaresponsetemplatetyperesponsetemplateidget) | **GET** /api/MediaResponse/templateType/{responseTemplateId} | 
[**ApiMediaResponseTemplateTypeTemplateIdDelete**](MediaResponseApi.md#apimediaresponsetemplatetypetemplateiddelete) | **DELETE** /api/MediaResponse/templateType/{templateId} | 
[**ApiMediaResponseTemplateTypeTemplateIdPut**](MediaResponseApi.md#apimediaresponsetemplatetypetemplateidput) | **PUT** /api/MediaResponse/templateType/{templateId} | 

<a name="apimediaresponsecontainersbulkpost"></a>
# **ApiMediaResponseContainersBulkPost**
> MediaResponseContainerModel ApiMediaResponseContainersBulkPost (NewBulkMediaResponseContainerRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseContainersBulkPostExample
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

            var apiInstance = new MediaResponseApi();
            var body = new NewBulkMediaResponseContainerRequest(); // NewBulkMediaResponseContainerRequest |  (optional) 

            try
            {
                MediaResponseContainerModel result = apiInstance.ApiMediaResponseContainersBulkPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseContainersBulkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewBulkMediaResponseContainerRequest**](NewBulkMediaResponseContainerRequest.md)|  | [optional] 

### Return type

[**MediaResponseContainerModel**](MediaResponseContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsecontainerscontaineridbulkput"></a>
# **ApiMediaResponseContainersContainerIdBulkPut**
> MediaResponseContainerModel ApiMediaResponseContainersContainerIdBulkPut (string containerId, UpdateBulkMediaResponseContainerRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseContainersContainerIdBulkPutExample
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

            var apiInstance = new MediaResponseApi();
            var containerId = containerId_example;  // string | 
            var body = new UpdateBulkMediaResponseContainerRequest(); // UpdateBulkMediaResponseContainerRequest |  (optional) 

            try
            {
                MediaResponseContainerModel result = apiInstance.ApiMediaResponseContainersContainerIdBulkPut(containerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseContainersContainerIdBulkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 
 **body** | [**UpdateBulkMediaResponseContainerRequest**](UpdateBulkMediaResponseContainerRequest.md)|  | [optional] 

### Return type

[**MediaResponseContainerModel**](MediaResponseContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsecontainerscontaineriddelete"></a>
# **ApiMediaResponseContainersContainerIdDelete**
> MediaResponseContainerModel ApiMediaResponseContainersContainerIdDelete (string containerId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseContainersContainerIdDeleteExample
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

            var apiInstance = new MediaResponseApi();
            var containerId = containerId_example;  // string | 

            try
            {
                MediaResponseContainerModel result = apiInstance.ApiMediaResponseContainersContainerIdDelete(containerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseContainersContainerIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 

### Return type

[**MediaResponseContainerModel**](MediaResponseContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsecontainerscontaineridget"></a>
# **ApiMediaResponseContainersContainerIdGet**
> MediaResponseContainerModel ApiMediaResponseContainersContainerIdGet (string containerId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseContainersContainerIdGetExample
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

            var apiInstance = new MediaResponseApi();
            var containerId = containerId_example;  // string | 

            try
            {
                MediaResponseContainerModel result = apiInstance.ApiMediaResponseContainersContainerIdGet(containerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseContainersContainerIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 

### Return type

[**MediaResponseContainerModel**](MediaResponseContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsecontainerscontaineridput"></a>
# **ApiMediaResponseContainersContainerIdPut**
> MediaResponseContainerModel ApiMediaResponseContainersContainerIdPut (string containerId, UpdateMediaResponseContainerRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseContainersContainerIdPutExample
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

            var apiInstance = new MediaResponseApi();
            var containerId = containerId_example;  // string | 
            var body = new UpdateMediaResponseContainerRequest(); // UpdateMediaResponseContainerRequest |  (optional) 

            try
            {
                MediaResponseContainerModel result = apiInstance.ApiMediaResponseContainersContainerIdPut(containerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseContainersContainerIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 
 **body** | [**UpdateMediaResponseContainerRequest**](UpdateMediaResponseContainerRequest.md)|  | [optional] 

### Return type

[**MediaResponseContainerModel**](MediaResponseContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsecontainersforappapplicationidget"></a>
# **ApiMediaResponseContainersForAppApplicationIdGet**
> List<MediaResponseContainerModel> ApiMediaResponseContainersForAppApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseContainersForAppApplicationIdGetExample
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

            var apiInstance = new MediaResponseApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;MediaResponseContainerModel&gt; result = apiInstance.ApiMediaResponseContainersForAppApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseContainersForAppApplicationIdGet: " + e.Message );
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

[**List<MediaResponseContainerModel>**](MediaResponseContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsecontainerspost"></a>
# **ApiMediaResponseContainersPost**
> MediaResponseContainerModel ApiMediaResponseContainersPost (NewMediaResponseContainerRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseContainersPostExample
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

            var apiInstance = new MediaResponseApi();
            var body = new NewMediaResponseContainerRequest(); // NewMediaResponseContainerRequest |  (optional) 

            try
            {
                MediaResponseContainerModel result = apiInstance.ApiMediaResponseContainersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseContainersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewMediaResponseContainerRequest**](NewMediaResponseContainerRequest.md)|  | [optional] 

### Return type

[**MediaResponseContainerModel**](MediaResponseContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsemediaresponseiddelete"></a>
# **ApiMediaResponseMediaResponseIdDelete**
> MediaResponseModel ApiMediaResponseMediaResponseIdDelete (string mediaResponseId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseMediaResponseIdDeleteExample
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

            var apiInstance = new MediaResponseApi();
            var mediaResponseId = mediaResponseId_example;  // string | 

            try
            {
                MediaResponseModel result = apiInstance.ApiMediaResponseMediaResponseIdDelete(mediaResponseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseMediaResponseIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaResponseId** | **string**|  | 

### Return type

[**MediaResponseModel**](MediaResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsepost"></a>
# **ApiMediaResponsePost**
> MediaResponseModel ApiMediaResponsePost (NewMediaResponseRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponsePostExample
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

            var apiInstance = new MediaResponseApi();
            var body = new NewMediaResponseRequest(); // NewMediaResponseRequest |  (optional) 

            try
            {
                MediaResponseModel result = apiInstance.ApiMediaResponsePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponsePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewMediaResponseRequest**](NewMediaResponseRequest.md)|  | [optional] 

### Return type

[**MediaResponseModel**](MediaResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponseresponseidput"></a>
# **ApiMediaResponseResponseIdPut**
> MediaResponseModel ApiMediaResponseResponseIdPut (string responseId, UpdateMediaResponseRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseResponseIdPutExample
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

            var apiInstance = new MediaResponseApi();
            var responseId = responseId_example;  // string | 
            var body = new UpdateMediaResponseRequest(); // UpdateMediaResponseRequest |  (optional) 

            try
            {
                MediaResponseModel result = apiInstance.ApiMediaResponseResponseIdPut(responseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseResponseIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **responseId** | **string**|  | 
 **body** | [**UpdateMediaResponseRequest**](UpdateMediaResponseRequest.md)|  | [optional] 

### Return type

[**MediaResponseModel**](MediaResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsetemplatetypeassistantassistantget"></a>
# **ApiMediaResponseTemplateTypeAssistantAssistantGet**
> List<ResponseTemplateTypeModel> ApiMediaResponseTemplateTypeAssistantAssistantGet (string assistant)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseTemplateTypeAssistantAssistantGetExample
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

            var apiInstance = new MediaResponseApi();
            var assistant = assistant_example;  // string | 

            try
            {
                List&lt;ResponseTemplateTypeModel&gt; result = apiInstance.ApiMediaResponseTemplateTypeAssistantAssistantGet(assistant);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseTemplateTypeAssistantAssistantGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assistant** | **string**|  | 

### Return type

[**List<ResponseTemplateTypeModel>**](ResponseTemplateTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsetemplatetypedevicetargetdevicetargetidget"></a>
# **ApiMediaResponseTemplateTypeDeviceTargetDeviceTargetIdGet**
> List<ResponseTemplateTypeModel> ApiMediaResponseTemplateTypeDeviceTargetDeviceTargetIdGet (string deviceTargetId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseTemplateTypeDeviceTargetDeviceTargetIdGetExample
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

            var apiInstance = new MediaResponseApi();
            var deviceTargetId = deviceTargetId_example;  // string | 

            try
            {
                List&lt;ResponseTemplateTypeModel&gt; result = apiInstance.ApiMediaResponseTemplateTypeDeviceTargetDeviceTargetIdGet(deviceTargetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseTemplateTypeDeviceTargetDeviceTargetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceTargetId** | **string**|  | 

### Return type

[**List<ResponseTemplateTypeModel>**](ResponseTemplateTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsetemplatetypeenabledget"></a>
# **ApiMediaResponseTemplateTypeEnabledGet**
> List<ResponseTemplateTypeModel> ApiMediaResponseTemplateTypeEnabledGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseTemplateTypeEnabledGetExample
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

            var apiInstance = new MediaResponseApi();

            try
            {
                List&lt;ResponseTemplateTypeModel&gt; result = apiInstance.ApiMediaResponseTemplateTypeEnabledGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseTemplateTypeEnabledGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ResponseTemplateTypeModel>**](ResponseTemplateTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsetemplatetypeget"></a>
# **ApiMediaResponseTemplateTypeGet**
> List<ResponseTemplateTypeModel> ApiMediaResponseTemplateTypeGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseTemplateTypeGetExample
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

            var apiInstance = new MediaResponseApi();

            try
            {
                List&lt;ResponseTemplateTypeModel&gt; result = apiInstance.ApiMediaResponseTemplateTypeGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseTemplateTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ResponseTemplateTypeModel>**](ResponseTemplateTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsetemplatetypepost"></a>
# **ApiMediaResponseTemplateTypePost**
> ResponseTemplateTypeModel ApiMediaResponseTemplateTypePost (NewResponseTemplateTypeRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseTemplateTypePostExample
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

            var apiInstance = new MediaResponseApi();
            var body = new NewResponseTemplateTypeRequest(); // NewResponseTemplateTypeRequest |  (optional) 

            try
            {
                ResponseTemplateTypeModel result = apiInstance.ApiMediaResponseTemplateTypePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseTemplateTypePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewResponseTemplateTypeRequest**](NewResponseTemplateTypeRequest.md)|  | [optional] 

### Return type

[**ResponseTemplateTypeModel**](ResponseTemplateTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsetemplatetyperesponsetemplateidget"></a>
# **ApiMediaResponseTemplateTypeResponseTemplateIdGet**
> ResponseTemplateTypeModel ApiMediaResponseTemplateTypeResponseTemplateIdGet (string responseTemplateId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseTemplateTypeResponseTemplateIdGetExample
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

            var apiInstance = new MediaResponseApi();
            var responseTemplateId = responseTemplateId_example;  // string | 

            try
            {
                ResponseTemplateTypeModel result = apiInstance.ApiMediaResponseTemplateTypeResponseTemplateIdGet(responseTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseTemplateTypeResponseTemplateIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **responseTemplateId** | **string**|  | 

### Return type

[**ResponseTemplateTypeModel**](ResponseTemplateTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsetemplatetypetemplateiddelete"></a>
# **ApiMediaResponseTemplateTypeTemplateIdDelete**
> ResponseTemplateTypeModel ApiMediaResponseTemplateTypeTemplateIdDelete (string templateId, string responseTemplateId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseTemplateTypeTemplateIdDeleteExample
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

            var apiInstance = new MediaResponseApi();
            var templateId = templateId_example;  // string | 
            var responseTemplateId = responseTemplateId_example;  // string |  (optional) 

            try
            {
                ResponseTemplateTypeModel result = apiInstance.ApiMediaResponseTemplateTypeTemplateIdDelete(templateId, responseTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseTemplateTypeTemplateIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 
 **responseTemplateId** | **string**|  | [optional] 

### Return type

[**ResponseTemplateTypeModel**](ResponseTemplateTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apimediaresponsetemplatetypetemplateidput"></a>
# **ApiMediaResponseTemplateTypeTemplateIdPut**
> ResponseTemplateTypeModel ApiMediaResponseTemplateTypeTemplateIdPut (string templateId, UpdateResponseTemplateTypeRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiMediaResponseTemplateTypeTemplateIdPutExample
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

            var apiInstance = new MediaResponseApi();
            var templateId = templateId_example;  // string | 
            var body = new UpdateResponseTemplateTypeRequest(); // UpdateResponseTemplateTypeRequest |  (optional) 

            try
            {
                ResponseTemplateTypeModel result = apiInstance.ApiMediaResponseTemplateTypeTemplateIdPut(templateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.ApiMediaResponseTemplateTypeTemplateIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 
 **body** | [**UpdateResponseTemplateTypeRequest**](UpdateResponseTemplateTypeRequest.md)|  | [optional] 

### Return type

[**ResponseTemplateTypeModel**](ResponseTemplateTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
