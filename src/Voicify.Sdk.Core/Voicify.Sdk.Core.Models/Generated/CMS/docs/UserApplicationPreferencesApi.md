# Voicify.Sdk.Core.Models.Api.UserApplicationPreferencesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiUserApplicationPreferencesApplicationApplicationIdSimulatorPinnedMessagePinnedMessageIdDelete**](UserApplicationPreferencesApi.md#apiuserapplicationpreferencesapplicationapplicationidsimulatorpinnedmessagepinnedmessageiddelete) | **DELETE** /api/UserApplicationPreferences/application/{applicationId}/simulatorPinnedMessage/{pinnedMessageId} | 
[**ApiUserApplicationPreferencesApplicationIdGet**](UserApplicationPreferencesApi.md#apiuserapplicationpreferencesapplicationidget) | **GET** /api/UserApplicationPreferences/{applicationId} | 
[**ApiUserApplicationPreferencesSimulatorPinnedMessagePost**](UserApplicationPreferencesApi.md#apiuserapplicationpreferencessimulatorpinnedmessagepost) | **POST** /api/UserApplicationPreferences/simulatorPinnedMessage | 

<a name="apiuserapplicationpreferencesapplicationapplicationidsimulatorpinnedmessagepinnedmessageiddelete"></a>
# **ApiUserApplicationPreferencesApplicationApplicationIdSimulatorPinnedMessagePinnedMessageIdDelete**
> SimulatorPinnedMessageModel ApiUserApplicationPreferencesApplicationApplicationIdSimulatorPinnedMessagePinnedMessageIdDelete (string applicationId, string pinnedMessageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiUserApplicationPreferencesApplicationApplicationIdSimulatorPinnedMessagePinnedMessageIdDeleteExample
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

            var apiInstance = new UserApplicationPreferencesApi();
            var applicationId = applicationId_example;  // string | 
            var pinnedMessageId = pinnedMessageId_example;  // string | 

            try
            {
                SimulatorPinnedMessageModel result = apiInstance.ApiUserApplicationPreferencesApplicationApplicationIdSimulatorPinnedMessagePinnedMessageIdDelete(applicationId, pinnedMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApplicationPreferencesApi.ApiUserApplicationPreferencesApplicationApplicationIdSimulatorPinnedMessagePinnedMessageIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **pinnedMessageId** | **string**|  | 

### Return type

[**SimulatorPinnedMessageModel**](SimulatorPinnedMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiuserapplicationpreferencesapplicationidget"></a>
# **ApiUserApplicationPreferencesApplicationIdGet**
> UserApplicationPreferencesModel ApiUserApplicationPreferencesApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiUserApplicationPreferencesApplicationIdGetExample
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

            var apiInstance = new UserApplicationPreferencesApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                UserApplicationPreferencesModel result = apiInstance.ApiUserApplicationPreferencesApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApplicationPreferencesApi.ApiUserApplicationPreferencesApplicationIdGet: " + e.Message );
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

[**UserApplicationPreferencesModel**](UserApplicationPreferencesModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiuserapplicationpreferencessimulatorpinnedmessagepost"></a>
# **ApiUserApplicationPreferencesSimulatorPinnedMessagePost**
> SimulatorPinnedMessageModel ApiUserApplicationPreferencesSimulatorPinnedMessagePost (NewSimulatorPinnedMessageRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiUserApplicationPreferencesSimulatorPinnedMessagePostExample
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

            var apiInstance = new UserApplicationPreferencesApi();
            var body = new NewSimulatorPinnedMessageRequest(); // NewSimulatorPinnedMessageRequest |  (optional) 

            try
            {
                SimulatorPinnedMessageModel result = apiInstance.ApiUserApplicationPreferencesSimulatorPinnedMessagePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApplicationPreferencesApi.ApiUserApplicationPreferencesSimulatorPinnedMessagePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewSimulatorPinnedMessageRequest**](NewSimulatorPinnedMessageRequest.md)|  | [optional] 

### Return type

[**SimulatorPinnedMessageModel**](SimulatorPinnedMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
