# Voicify.Sdk.Core.Models.Api.MicrosoftAuthorizationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAvailableCredentials**](MicrosoftAuthorizationApi.md#getavailablecredentials) | **GET** /api/MicrosoftAuthorization/Credentials/{organizationId} | 
[**MicrosoftAuthCallbackAsync**](MicrosoftAuthorizationApi.md#microsoftauthcallbackasync) | **GET** /api/MicrosoftAuthorization/Callback | 
[**RemoveCredential**](MicrosoftAuthorizationApi.md#removecredential) | **DELETE** /api/MicrosoftAuthorization/Credentials/{tokenId} | 
[**RequestAuthenticationUrl**](MicrosoftAuthorizationApi.md#requestauthenticationurl) | **GET** /api/MicrosoftAuthorization/AuthorizationUrl | 

<a name="getavailablecredentials"></a>
# **GetAvailableCredentials**
> List<TokenResponse> GetAvailableCredentials (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAvailableCredentialsExample
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

            var apiInstance = new MicrosoftAuthorizationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;TokenResponse&gt; result = apiInstance.GetAvailableCredentials(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MicrosoftAuthorizationApi.GetAvailableCredentials: " + e.Message );
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
<a name="microsoftauthcallbackasync"></a>
# **MicrosoftAuthCallbackAsync**
> bool? MicrosoftAuthCallbackAsync (string code = null, string state = null, string error = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class MicrosoftAuthCallbackAsyncExample
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

            var apiInstance = new MicrosoftAuthorizationApi();
            var code = code_example;  // string |  (optional) 
            var state = state_example;  // string |  (optional) 
            var error = error_example;  // string |  (optional) 

            try
            {
                bool? result = apiInstance.MicrosoftAuthCallbackAsync(code, state, error);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MicrosoftAuthorizationApi.MicrosoftAuthCallbackAsync: " + e.Message );
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
<a name="removecredential"></a>
# **RemoveCredential**
> bool? RemoveCredential (string tokenId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveCredentialExample
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

            var apiInstance = new MicrosoftAuthorizationApi();
            var tokenId = tokenId_example;  // string | 

            try
            {
                bool? result = apiInstance.RemoveCredential(tokenId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MicrosoftAuthorizationApi.RemoveCredential: " + e.Message );
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
<a name="requestauthenticationurl"></a>
# **RequestAuthenticationUrl**
> string RequestAuthenticationUrl (string organizationId = null, string applicationId = null, string salt = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RequestAuthenticationUrlExample
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

            var apiInstance = new MicrosoftAuthorizationApi();
            var organizationId = organizationId_example;  // string |  (optional) 
            var applicationId = applicationId_example;  // string |  (optional) 
            var salt = salt_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.RequestAuthenticationUrl(organizationId, applicationId, salt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MicrosoftAuthorizationApi.RequestAuthenticationUrl: " + e.Message );
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
