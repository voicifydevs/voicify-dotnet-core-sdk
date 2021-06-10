# Voicify.Sdk.Core.Models.Api.SingleSignOnRedirectApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OAuth2CallbackGet**](SingleSignOnRedirectApi.md#oauth2callbackget) | **GET** /SingleSignOnRedirect/oauth2 | 
[**SAMLCallback**](SingleSignOnRedirectApi.md#samlcallback) | **POST** /SingleSignOnRedirect/saml | 

<a name="oauth2callbackget"></a>
# **OAuth2CallbackGet**
> void OAuth2CallbackGet (string code = null, string state = null, string error = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class OAuth2CallbackGetExample
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

            var apiInstance = new SingleSignOnRedirectApi();
            var code = code_example;  // string |  (optional) 
            var state = state_example;  // string |  (optional) 
            var error = error_example;  // string |  (optional) 

            try
            {
                apiInstance.OAuth2CallbackGet(code, state, error);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SingleSignOnRedirectApi.OAuth2CallbackGet: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="samlcallback"></a>
# **SAMLCallback**
> void SAMLCallback (string redirectUrl = null, string email = null, string clientId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SAMLCallbackExample
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

            var apiInstance = new SingleSignOnRedirectApi();
            var redirectUrl = redirectUrl_example;  // string |  (optional) 
            var email = email_example;  // string |  (optional) 
            var clientId = clientId_example;  // string |  (optional) 

            try
            {
                apiInstance.SAMLCallback(redirectUrl, email, clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SingleSignOnRedirectApi.SAMLCallback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **redirectUrl** | **string**|  | [optional] 
 **email** | **string**|  | [optional] 
 **clientId** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
