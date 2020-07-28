# IO.Swagger.Api.AlexaApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandleLocalRequest**](AlexaApi.md#handlelocalrequest) | **POST** /api/Alexa/HandleRequest | Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates.
[**HandleSignedRequest**](AlexaApi.md#handlesignedrequest) | **POST** /api/Alexa/HandleSignedRequest | Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent.


<a name="handlelocalrequest"></a>
# **HandleLocalRequest**
> SkillResponse HandleLocalRequest (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)

Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleLocalRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AlexaApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var request = new APLSkillRequest(); // APLSkillRequest |  (optional) 

            try
            {
                // Handles an unsigned request from Alexa. This endpoint can be used from existing skills without validating Alexa certificates.
                SkillResponse result = apiInstance.HandleLocalRequest(applicationId, applicationSecret, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlexaApi.HandleLocalRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **request** | [**APLSkillRequest**](APLSkillRequest.md)|  | [optional] 

### Return type

[**SkillResponse**](SkillResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlesignedrequest"></a>
# **HandleSignedRequest**
> SkillResponse HandleSignedRequest (string applicationId = null, string applicationSecret = null, APLSkillRequest request = null)

Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleSignedRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AlexaApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var request = new APLSkillRequest(); // APLSkillRequest |  (optional) 

            try
            {
                // Handles a signed request from Alexa. This endpoint validates the certificates coming from amazon and the skill id sent.
                SkillResponse result = apiInstance.HandleSignedRequest(applicationId, applicationSecret, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlexaApi.HandleSignedRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **request** | [**APLSkillRequest**](APLSkillRequest.md)|  | [optional] 

### Return type

[**SkillResponse**](SkillResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

