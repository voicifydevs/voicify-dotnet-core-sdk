# Voicify.Sdk.Core.Models.Api.SingleSignOnApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiSingleSignOnSignInPost**](SingleSignOnApi.md#apisinglesignonsigninpost) | **POST** /api/SingleSignOn/signIn | 
[**ApiSingleSignOnSignUpPost**](SingleSignOnApi.md#apisinglesignonsignuppost) | **POST** /api/SingleSignOn/signUp | 

<a name="apisinglesignonsigninpost"></a>
# **ApiSingleSignOnSignInPost**
> SingleSignOnResponse ApiSingleSignOnSignInPost (SingleSignOnRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiSingleSignOnSignInPostExample
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

            var apiInstance = new SingleSignOnApi();
            var body = new SingleSignOnRequest(); // SingleSignOnRequest |  (optional) 

            try
            {
                SingleSignOnResponse result = apiInstance.ApiSingleSignOnSignInPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SingleSignOnApi.ApiSingleSignOnSignInPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SingleSignOnRequest**](SingleSignOnRequest.md)|  | [optional] 

### Return type

[**SingleSignOnResponse**](SingleSignOnResponse.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apisinglesignonsignuppost"></a>
# **ApiSingleSignOnSignUpPost**
> SingleSignOnResponse ApiSingleSignOnSignUpPost (SingleSignOnRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiSingleSignOnSignUpPostExample
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

            var apiInstance = new SingleSignOnApi();
            var body = new SingleSignOnRequest(); // SingleSignOnRequest |  (optional) 

            try
            {
                SingleSignOnResponse result = apiInstance.ApiSingleSignOnSignUpPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SingleSignOnApi.ApiSingleSignOnSignUpPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SingleSignOnRequest**](SingleSignOnRequest.md)|  | [optional] 

### Return type

[**SingleSignOnResponse**](SingleSignOnResponse.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
