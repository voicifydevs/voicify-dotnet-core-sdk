# Voicify.Sdk.Core.Models.Api.LanguageValidationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiLanguageValidationApplicationIdBestMatchPost**](LanguageValidationApi.md#apilanguagevalidationapplicationidbestmatchpost) | **POST** /api/LanguageValidation/{applicationId}/BestMatch | 
[**ApiLanguageValidationApplicationIdMatchesPost**](LanguageValidationApi.md#apilanguagevalidationapplicationidmatchespost) | **POST** /api/LanguageValidation/{applicationId}/Matches | 

<a name="apilanguagevalidationapplicationidbestmatchpost"></a>
# **ApiLanguageValidationApplicationIdBestMatchPost**
> ProcessedLanguage ApiLanguageValidationApplicationIdBestMatchPost (string applicationId, string body = null, string locale = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiLanguageValidationApplicationIdBestMatchPostExample
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

            var apiInstance = new LanguageValidationApi();
            var applicationId = applicationId_example;  // string | 
            var body = new string(); // string |  (optional) 
            var locale = locale_example;  // string |  (optional) 

            try
            {
                ProcessedLanguage result = apiInstance.ApiLanguageValidationApplicationIdBestMatchPost(applicationId, body, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageValidationApi.ApiLanguageValidationApplicationIdBestMatchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**string**](string.md)|  | [optional] 
 **locale** | **string**|  | [optional] 

### Return type

[**ProcessedLanguage**](ProcessedLanguage.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apilanguagevalidationapplicationidmatchespost"></a>
# **ApiLanguageValidationApplicationIdMatchesPost**
> List<ProcessedLanguage> ApiLanguageValidationApplicationIdMatchesPost (string applicationId, string body = null, string locale = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiLanguageValidationApplicationIdMatchesPostExample
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

            var apiInstance = new LanguageValidationApi();
            var applicationId = applicationId_example;  // string | 
            var body = new string(); // string |  (optional) 
            var locale = locale_example;  // string |  (optional) 

            try
            {
                List&lt;ProcessedLanguage&gt; result = apiInstance.ApiLanguageValidationApplicationIdMatchesPost(applicationId, body, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LanguageValidationApi.ApiLanguageValidationApplicationIdMatchesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**string**](string.md)|  | [optional] 
 **locale** | **string**|  | [optional] 

### Return type

[**List<ProcessedLanguage>**](ProcessedLanguage.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
