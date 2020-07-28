# IO.Swagger.Api.UserProfileApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSessionAttributes**](UserProfileApi.md#getsessionattributes) | **GET** /api/UserProfile/session/{sessionId} | Gets the current session state data


<a name="getsessionattributes"></a>
# **GetSessionAttributes**
> ConversationSessionState GetSessionAttributes (string sessionId, string applicationId = null, string applicationSecret = null)

Gets the current session state data

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSessionAttributesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserProfileApi();
            var sessionId = sessionId_example;  // string | 
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 

            try
            {
                // Gets the current session state data
                ConversationSessionState result = apiInstance.GetSessionAttributes(sessionId, applicationId, applicationSecret);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserProfileApi.GetSessionAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **string**|  | 
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 

### Return type

[**ConversationSessionState**](ConversationSessionState.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

