# Voicify.Sdk.Core.Models.Api.AzureApplicationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAzureApplicationApplicationIdAzureSubscriptionsGet**](AzureApplicationApi.md#apiazureapplicationapplicationidazuresubscriptionsget) | **GET** /api/AzureApplication/{applicationId}/azureSubscriptions | 
[**ApiAzureApplicationApplicationIdBotServiceAppsGet**](AzureApplicationApi.md#apiazureapplicationapplicationidbotserviceappsget) | **GET** /api/AzureApplication/{applicationId}/botServiceApps | 
[**ApiAzureApplicationApplicationIdLuisAppsGet**](AzureApplicationApi.md#apiazureapplicationapplicationidluisappsget) | **GET** /api/AzureApplication/{applicationId}/luisApps | 

<a name="apiazureapplicationapplicationidazuresubscriptionsget"></a>
# **ApiAzureApplicationApplicationIdAzureSubscriptionsGet**
> List<AzureSubscriptionInformation> ApiAzureApplicationApplicationIdAzureSubscriptionsGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAzureApplicationApplicationIdAzureSubscriptionsGetExample
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

            var apiInstance = new AzureApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;AzureSubscriptionInformation&gt; result = apiInstance.ApiAzureApplicationApplicationIdAzureSubscriptionsGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AzureApplicationApi.ApiAzureApplicationApplicationIdAzureSubscriptionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 

### Return type

[**List<AzureSubscriptionInformation>**](AzureSubscriptionInformation.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiazureapplicationapplicationidbotserviceappsget"></a>
# **ApiAzureApplicationApplicationIdBotServiceAppsGet**
> List<AzureBotServiceInformation> ApiAzureApplicationApplicationIdBotServiceAppsGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAzureApplicationApplicationIdBotServiceAppsGetExample
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

            var apiInstance = new AzureApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;AzureBotServiceInformation&gt; result = apiInstance.ApiAzureApplicationApplicationIdBotServiceAppsGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AzureApplicationApi.ApiAzureApplicationApplicationIdBotServiceAppsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 

### Return type

[**List<AzureBotServiceInformation>**](AzureBotServiceInformation.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiazureapplicationapplicationidluisappsget"></a>
# **ApiAzureApplicationApplicationIdLuisAppsGet**
> List<LuisApplicationInformation> ApiAzureApplicationApplicationIdLuisAppsGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiAzureApplicationApplicationIdLuisAppsGetExample
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

            var apiInstance = new AzureApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;LuisApplicationInformation&gt; result = apiInstance.ApiAzureApplicationApplicationIdLuisAppsGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AzureApplicationApi.ApiAzureApplicationApplicationIdLuisAppsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 

### Return type

[**List<LuisApplicationInformation>**](LuisApplicationInformation.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
