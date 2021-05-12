# Voicify.Sdk.Core.Models.Api.ContentLanguageApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiContentLanguageAllGet**](ContentLanguageApi.md#apicontentlanguageallget) | **GET** /api/ContentLanguage/All | 

<a name="apicontentlanguageallget"></a>
# **ApiContentLanguageAllGet**
> List<LanguageModel> ApiContentLanguageAllGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiContentLanguageAllGetExample
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

            var apiInstance = new ContentLanguageApi();

            try
            {
                List&lt;LanguageModel&gt; result = apiInstance.ApiContentLanguageAllGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentLanguageApi.ApiContentLanguageAllGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<LanguageModel>**](LanguageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
