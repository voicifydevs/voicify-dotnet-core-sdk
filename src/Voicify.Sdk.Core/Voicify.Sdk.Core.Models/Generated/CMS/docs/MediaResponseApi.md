# Voicify.Sdk.Core.Models.Api.MediaResponseApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMediaResponse**](MediaResponseApi.md#createmediaresponse) | **POST** /api/MediaResponse | 
[**CreateMediaResponseContainer**](MediaResponseApi.md#createmediaresponsecontainer) | **POST** /api/MediaResponse/containers | 
[**CreateMediaResponseContainer_0**](MediaResponseApi.md#createmediaresponsecontainer_0) | **POST** /api/MediaResponse/containers/bulk | 
[**CreateResponseTemplateType**](MediaResponseApi.md#createresponsetemplatetype) | **POST** /api/MediaResponse/templateType | 
[**DeleteMediaResponse**](MediaResponseApi.md#deletemediaresponse) | **DELETE** /api/MediaResponse/{mediaResponseId} | 
[**DeleteMediaResponseContainer**](MediaResponseApi.md#deletemediaresponsecontainer) | **DELETE** /api/MediaResponse/containers/{containerId} | 
[**DeleteResponseTemplate**](MediaResponseApi.md#deleteresponsetemplate) | **DELETE** /api/MediaResponse/templateType/{templateId} | 
[**GetAllResponseTemplates**](MediaResponseApi.md#getallresponsetemplates) | **GET** /api/MediaResponse/templateType | 
[**GetEnabledResponseTemplates**](MediaResponseApi.md#getenabledresponsetemplates) | **GET** /api/MediaResponse/templateType/enabled | 
[**GetResponseContainerById**](MediaResponseApi.md#getresponsecontainerbyid) | **GET** /api/MediaResponse/containers/{containerId} | 
[**GetResponseContainersForApp**](MediaResponseApi.md#getresponsecontainersforapp) | **GET** /api/MediaResponse/containers/forApp/{applicationId} | 
[**GetResponseTemplateById**](MediaResponseApi.md#getresponsetemplatebyid) | **GET** /api/MediaResponse/templateType/{responseTemplateId} | 
[**GetResponseTemplatesByAssistant**](MediaResponseApi.md#getresponsetemplatesbyassistant) | **GET** /api/MediaResponse/templateType/assistant/{assistant} | 
[**GetResponseTemplatesByDeviceTarget**](MediaResponseApi.md#getresponsetemplatesbydevicetarget) | **GET** /api/MediaResponse/templateType/deviceTarget/{deviceTargetId} | 
[**UpdateMediaResponse**](MediaResponseApi.md#updatemediaresponse) | **PUT** /api/MediaResponse/{responseId} | 
[**UpdateMediaResponseContainer**](MediaResponseApi.md#updatemediaresponsecontainer) | **PUT** /api/MediaResponse/containers/{containerId} | 
[**UpdateMediaResponseContainer_0**](MediaResponseApi.md#updatemediaresponsecontainer_0) | **PUT** /api/MediaResponse/containers/{containerId}/bulk | 
[**UpdateResponseTemplateType**](MediaResponseApi.md#updateresponsetemplatetype) | **PUT** /api/MediaResponse/templateType/{templateId} | 

<a name="createmediaresponse"></a>
# **CreateMediaResponse**
> MediaResponseModel CreateMediaResponse (NewMediaResponseRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateMediaResponseExample
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
                MediaResponseModel result = apiInstance.CreateMediaResponse(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.CreateMediaResponse: " + e.Message );
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
<a name="createmediaresponsecontainer"></a>
# **CreateMediaResponseContainer**
> MediaResponseContainerModel CreateMediaResponseContainer (NewMediaResponseContainerRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateMediaResponseContainerExample
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
                MediaResponseContainerModel result = apiInstance.CreateMediaResponseContainer(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.CreateMediaResponseContainer: " + e.Message );
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
<a name="createmediaresponsecontainer_0"></a>
# **CreateMediaResponseContainer_0**
> MediaResponseContainerModel CreateMediaResponseContainer_0 (NewBulkMediaResponseContainerRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateMediaResponseContainer_0Example
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
                MediaResponseContainerModel result = apiInstance.CreateMediaResponseContainer_0(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.CreateMediaResponseContainer_0: " + e.Message );
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
<a name="createresponsetemplatetype"></a>
# **CreateResponseTemplateType**
> ResponseTemplateTypeModel CreateResponseTemplateType (NewResponseTemplateTypeRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateResponseTemplateTypeExample
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
                ResponseTemplateTypeModel result = apiInstance.CreateResponseTemplateType(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.CreateResponseTemplateType: " + e.Message );
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
<a name="deletemediaresponse"></a>
# **DeleteMediaResponse**
> MediaResponseModel DeleteMediaResponse (string mediaResponseId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteMediaResponseExample
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
                MediaResponseModel result = apiInstance.DeleteMediaResponse(mediaResponseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.DeleteMediaResponse: " + e.Message );
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
<a name="deletemediaresponsecontainer"></a>
# **DeleteMediaResponseContainer**
> MediaResponseContainerModel DeleteMediaResponseContainer (string containerId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteMediaResponseContainerExample
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
                MediaResponseContainerModel result = apiInstance.DeleteMediaResponseContainer(containerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.DeleteMediaResponseContainer: " + e.Message );
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
<a name="deleteresponsetemplate"></a>
# **DeleteResponseTemplate**
> ResponseTemplateTypeModel DeleteResponseTemplate (string templateId, string responseTemplateId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteResponseTemplateExample
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
                ResponseTemplateTypeModel result = apiInstance.DeleteResponseTemplate(templateId, responseTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.DeleteResponseTemplate: " + e.Message );
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
<a name="getallresponsetemplates"></a>
# **GetAllResponseTemplates**
> List<ResponseTemplateTypeModel> GetAllResponseTemplates ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAllResponseTemplatesExample
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
                List&lt;ResponseTemplateTypeModel&gt; result = apiInstance.GetAllResponseTemplates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.GetAllResponseTemplates: " + e.Message );
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
<a name="getenabledresponsetemplates"></a>
# **GetEnabledResponseTemplates**
> List<ResponseTemplateTypeModel> GetEnabledResponseTemplates ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetEnabledResponseTemplatesExample
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
                List&lt;ResponseTemplateTypeModel&gt; result = apiInstance.GetEnabledResponseTemplates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.GetEnabledResponseTemplates: " + e.Message );
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
<a name="getresponsecontainerbyid"></a>
# **GetResponseContainerById**
> MediaResponseContainerModel GetResponseContainerById (string containerId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetResponseContainerByIdExample
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
                MediaResponseContainerModel result = apiInstance.GetResponseContainerById(containerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.GetResponseContainerById: " + e.Message );
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
<a name="getresponsecontainersforapp"></a>
# **GetResponseContainersForApp**
> List<MediaResponseContainerModel> GetResponseContainersForApp (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetResponseContainersForAppExample
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
                List&lt;MediaResponseContainerModel&gt; result = apiInstance.GetResponseContainersForApp(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.GetResponseContainersForApp: " + e.Message );
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
<a name="getresponsetemplatebyid"></a>
# **GetResponseTemplateById**
> ResponseTemplateTypeModel GetResponseTemplateById (string responseTemplateId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetResponseTemplateByIdExample
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
                ResponseTemplateTypeModel result = apiInstance.GetResponseTemplateById(responseTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.GetResponseTemplateById: " + e.Message );
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
<a name="getresponsetemplatesbyassistant"></a>
# **GetResponseTemplatesByAssistant**
> List<ResponseTemplateTypeModel> GetResponseTemplatesByAssistant (string assistant)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetResponseTemplatesByAssistantExample
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
                List&lt;ResponseTemplateTypeModel&gt; result = apiInstance.GetResponseTemplatesByAssistant(assistant);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.GetResponseTemplatesByAssistant: " + e.Message );
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
<a name="getresponsetemplatesbydevicetarget"></a>
# **GetResponseTemplatesByDeviceTarget**
> List<ResponseTemplateTypeModel> GetResponseTemplatesByDeviceTarget (string deviceTargetId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetResponseTemplatesByDeviceTargetExample
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
                List&lt;ResponseTemplateTypeModel&gt; result = apiInstance.GetResponseTemplatesByDeviceTarget(deviceTargetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.GetResponseTemplatesByDeviceTarget: " + e.Message );
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
<a name="updatemediaresponse"></a>
# **UpdateMediaResponse**
> MediaResponseModel UpdateMediaResponse (string responseId, UpdateMediaResponseRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateMediaResponseExample
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
                MediaResponseModel result = apiInstance.UpdateMediaResponse(responseId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.UpdateMediaResponse: " + e.Message );
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
<a name="updatemediaresponsecontainer"></a>
# **UpdateMediaResponseContainer**
> MediaResponseContainerModel UpdateMediaResponseContainer (string containerId, UpdateMediaResponseContainerRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateMediaResponseContainerExample
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
                MediaResponseContainerModel result = apiInstance.UpdateMediaResponseContainer(containerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.UpdateMediaResponseContainer: " + e.Message );
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
<a name="updatemediaresponsecontainer_0"></a>
# **UpdateMediaResponseContainer_0**
> MediaResponseContainerModel UpdateMediaResponseContainer_0 (string containerId, UpdateBulkMediaResponseContainerRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateMediaResponseContainer_0Example
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
                MediaResponseContainerModel result = apiInstance.UpdateMediaResponseContainer_0(containerId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.UpdateMediaResponseContainer_0: " + e.Message );
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
<a name="updateresponsetemplatetype"></a>
# **UpdateResponseTemplateType**
> ResponseTemplateTypeModel UpdateResponseTemplateType (string templateId, UpdateResponseTemplateTypeRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateResponseTemplateTypeExample
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
                ResponseTemplateTypeModel result = apiInstance.UpdateResponseTemplateType(templateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaResponseApi.UpdateResponseTemplateType: " + e.Message );
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
