# Voicify.Sdk.Core.Models.Api.ApiKeyApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiApiKeyApiKeyIdDelete**](ApiKeyApi.md#apiapikeyapikeyiddelete) | **DELETE** /api/ApiKey/{apiKeyId} | 
[**ApiApiKeyOrganizationOrganizationIdAdminPost**](ApiKeyApi.md#apiapikeyorganizationorganizationidadminpost) | **POST** /api/ApiKey/organization/{organizationId}/admin | 
[**ApiApiKeyOrganizationOrganizationIdGet**](ApiKeyApi.md#apiapikeyorganizationorganizationidget) | **GET** /api/ApiKey/organization/{organizationId} | 

<a name="apiapikeyapikeyiddelete"></a>
# **ApiApiKeyApiKeyIdDelete**
> List<ApiKeyModel> ApiApiKeyApiKeyIdDelete (string apiKeyId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApiKeyApiKeyIdDeleteExample
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

            var apiInstance = new ApiKeyApi();
            var apiKeyId = apiKeyId_example;  // string | 

            try
            {
                List&lt;ApiKeyModel&gt; result = apiInstance.ApiApiKeyApiKeyIdDelete(apiKeyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeyApi.ApiApiKeyApiKeyIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKeyId** | **string**|  | 

### Return type

[**List<ApiKeyModel>**](ApiKeyModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapikeyorganizationorganizationidadminpost"></a>
# **ApiApiKeyOrganizationOrganizationIdAdminPost**
> ApiKeyResult ApiApiKeyOrganizationOrganizationIdAdminPost (string organizationId, NewApiKeyRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApiKeyOrganizationOrganizationIdAdminPostExample
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

            var apiInstance = new ApiKeyApi();
            var organizationId = organizationId_example;  // string | 
            var body = new NewApiKeyRequest(); // NewApiKeyRequest |  (optional) 

            try
            {
                ApiKeyResult result = apiInstance.ApiApiKeyOrganizationOrganizationIdAdminPost(organizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeyApi.ApiApiKeyOrganizationOrganizationIdAdminPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **body** | [**NewApiKeyRequest**](NewApiKeyRequest.md)|  | [optional] 

### Return type

[**ApiKeyResult**](ApiKeyResult.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapikeyorganizationorganizationidget"></a>
# **ApiApiKeyOrganizationOrganizationIdGet**
> List<ApiKeyModel> ApiApiKeyOrganizationOrganizationIdGet (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApiKeyOrganizationOrganizationIdGetExample
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

            var apiInstance = new ApiKeyApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;ApiKeyModel&gt; result = apiInstance.ApiApiKeyOrganizationOrganizationIdGet(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeyApi.ApiApiKeyOrganizationOrganizationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 

### Return type

[**List<ApiKeyModel>**](ApiKeyModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
