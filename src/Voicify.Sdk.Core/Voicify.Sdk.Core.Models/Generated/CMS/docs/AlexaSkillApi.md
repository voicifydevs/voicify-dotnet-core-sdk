# Voicify.Sdk.Core.Models.Api.AlexaSkillApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAlexaSkills**](AlexaSkillApi.md#listalexaskills) | **GET** /api/AlexaSkill/Skills/{vendorId}/{tokenId} | 

<a name="listalexaskills"></a>
# **ListAlexaSkills**
> List<SkillSummary> ListAlexaSkills (string tokenId, string vendorId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ListAlexaSkillsExample
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

            var apiInstance = new AlexaSkillApi();
            var tokenId = tokenId_example;  // string | 
            var vendorId = vendorId_example;  // string | 

            try
            {
                List&lt;SkillSummary&gt; result = apiInstance.ListAlexaSkills(tokenId, vendorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlexaSkillApi.ListAlexaSkills: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**|  | 
 **vendorId** | **string**|  | 

### Return type

[**List<SkillSummary>**](SkillSummary.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
