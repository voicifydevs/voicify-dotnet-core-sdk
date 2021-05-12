# Voicify.Sdk.Core.Models.Api.SingleSignOnRedirectApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SingleSignOnRedirectOauth2Get**](SingleSignOnRedirectApi.md#singlesignonredirectoauth2get) | **GET** /SingleSignOnRedirect/oauth2 | 
[**SingleSignOnRedirectSamlPost**](SingleSignOnRedirectApi.md#singlesignonredirectsamlpost) | **POST** /SingleSignOnRedirect/saml | 

<a name="singlesignonredirectoauth2get"></a>
# **SingleSignOnRedirectOauth2Get**
> void SingleSignOnRedirectOauth2Get (string code = null, string state = null, string error = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SingleSignOnRedirectOauth2GetExample
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
                apiInstance.SingleSignOnRedirectOauth2Get(code, state, error);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SingleSignOnRedirectApi.SingleSignOnRedirectOauth2Get: " + e.Message );
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
<a name="singlesignonredirectsamlpost"></a>
# **SingleSignOnRedirectSamlPost**
> void SingleSignOnRedirectSamlPost (string redirectUrl = null, string email = null, string clientId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SingleSignOnRedirectSamlPostExample
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
                apiInstance.SingleSignOnRedirectSamlPost(redirectUrl, email, clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SingleSignOnRedirectApi.SingleSignOnRedirectSamlPost: " + e.Message );
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
