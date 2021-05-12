# Voicify.Sdk.Core.Models.Api.AuthenticationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAuthenticationPost**](AuthenticationApi.md#apiauthenticationpost) | **POST** /api/Authentication | 
[**ApiAuthenticationTestAdminGet**](AuthenticationApi.md#apiauthenticationtestadminget) | **GET** /api/Authentication/test/admin | 
[**ApiAuthenticationTestGet**](AuthenticationApi.md#apiauthenticationtestget) | **GET** /api/Authentication/test | 

<a name="apiauthenticationpost"></a>
# **ApiAuthenticationPost**
> AuthenticationResponse ApiAuthenticationPost (string clientId, string clientSecret, string grantType, string username, string password = null, string refreshToken = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAuthenticationPostExample
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

            var apiInstance = new AuthenticationApi();
            var clientId = clientId_example;  // string | 
            var clientSecret = clientSecret_example;  // string | 
            var grantType = grantType_example;  // string | 
            var username = username_example;  // string | 
            var password = password_example;  // string |  (optional) 
            var refreshToken = refreshToken_example;  // string |  (optional) 

            try
            {
                AuthenticationResponse result = apiInstance.ApiAuthenticationPost(clientId, clientSecret, grantType, username, password, refreshToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.ApiAuthenticationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | 
 **clientSecret** | **string**|  | 
 **grantType** | **string**|  | 
 **username** | **string**|  | 
 **password** | **string**|  | [optional] 
 **refreshToken** | **string**|  | [optional] 

### Return type

[**AuthenticationResponse**](AuthenticationResponse.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiauthenticationtestadminget"></a>
# **ApiAuthenticationTestAdminGet**
> void ApiAuthenticationTestAdminGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAuthenticationTestAdminGetExample
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

            var apiInstance = new AuthenticationApi();

            try
            {
                apiInstance.ApiAuthenticationTestAdminGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.ApiAuthenticationTestAdminGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiauthenticationtestget"></a>
# **ApiAuthenticationTestGet**
> void ApiAuthenticationTestGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAuthenticationTestGetExample
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

            var apiInstance = new AuthenticationApi();

            try
            {
                apiInstance.ApiAuthenticationTestGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.ApiAuthenticationTestGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
