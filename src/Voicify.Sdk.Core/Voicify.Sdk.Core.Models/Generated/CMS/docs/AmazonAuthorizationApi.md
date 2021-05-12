# Voicify.Sdk.Core.Models.Api.AmazonAuthorizationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAmazonAuthorizationAuthorizationUrlGet**](AmazonAuthorizationApi.md#apiamazonauthorizationauthorizationurlget) | **GET** /api/AmazonAuthorization/AuthorizationUrl | 
[**ApiAmazonAuthorizationCallbackGet**](AmazonAuthorizationApi.md#apiamazonauthorizationcallbackget) | **GET** /api/AmazonAuthorization/Callback | 
[**ApiAmazonAuthorizationCredentialsOrganizationIdGet**](AmazonAuthorizationApi.md#apiamazonauthorizationcredentialsorganizationidget) | **GET** /api/AmazonAuthorization/Credentials/{organizationId} | 
[**ApiAmazonAuthorizationCredentialsTokenIdDelete**](AmazonAuthorizationApi.md#apiamazonauthorizationcredentialstokeniddelete) | **DELETE** /api/AmazonAuthorization/Credentials/{tokenId} | 

<a name="apiamazonauthorizationauthorizationurlget"></a>
# **ApiAmazonAuthorizationAuthorizationUrlGet**
> string ApiAmazonAuthorizationAuthorizationUrlGet (string organizationId = null, string applicationId = null, string salt = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAmazonAuthorizationAuthorizationUrlGetExample
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

            var apiInstance = new AmazonAuthorizationApi();
            var organizationId = organizationId_example;  // string |  (optional) 
            var applicationId = applicationId_example;  // string |  (optional) 
            var salt = salt_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ApiAmazonAuthorizationAuthorizationUrlGet(organizationId, applicationId, salt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonAuthorizationApi.ApiAmazonAuthorizationAuthorizationUrlGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | [optional] 
 **applicationId** | **string**|  | [optional] 
 **salt** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiamazonauthorizationcallbackget"></a>
# **ApiAmazonAuthorizationCallbackGet**
> bool? ApiAmazonAuthorizationCallbackGet (string code = null, string state = null, string error = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAmazonAuthorizationCallbackGetExample
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

            var apiInstance = new AmazonAuthorizationApi();
            var code = code_example;  // string |  (optional) 
            var state = state_example;  // string |  (optional) 
            var error = error_example;  // string |  (optional) 

            try
            {
                bool? result = apiInstance.ApiAmazonAuthorizationCallbackGet(code, state, error);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonAuthorizationApi.ApiAmazonAuthorizationCallbackGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**|  | [optional] 
 **state** | **string**|  | [optional] 
 **error** | **string**|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiamazonauthorizationcredentialsorganizationidget"></a>
# **ApiAmazonAuthorizationCredentialsOrganizationIdGet**
> List<TokenResponse> ApiAmazonAuthorizationCredentialsOrganizationIdGet (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAmazonAuthorizationCredentialsOrganizationIdGetExample
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

            var apiInstance = new AmazonAuthorizationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;TokenResponse&gt; result = apiInstance.ApiAmazonAuthorizationCredentialsOrganizationIdGet(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonAuthorizationApi.ApiAmazonAuthorizationCredentialsOrganizationIdGet: " + e.Message );
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

[**List<TokenResponse>**](TokenResponse.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiamazonauthorizationcredentialstokeniddelete"></a>
# **ApiAmazonAuthorizationCredentialsTokenIdDelete**
> bool? ApiAmazonAuthorizationCredentialsTokenIdDelete (string tokenId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAmazonAuthorizationCredentialsTokenIdDeleteExample
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

            var apiInstance = new AmazonAuthorizationApi();
            var tokenId = tokenId_example;  // string | 

            try
            {
                bool? result = apiInstance.ApiAmazonAuthorizationCredentialsTokenIdDelete(tokenId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonAuthorizationApi.ApiAmazonAuthorizationCredentialsTokenIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**|  | 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
