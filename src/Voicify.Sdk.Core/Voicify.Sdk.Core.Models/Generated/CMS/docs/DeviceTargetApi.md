# Voicify.Sdk.Core.Models.Api.DeviceTargetApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiDeviceTargetDeviceTargetIdGet**](DeviceTargetApi.md#apidevicetargetdevicetargetidget) | **GET** /api/DeviceTarget/{deviceTargetId} | 
[**ApiDeviceTargetGet**](DeviceTargetApi.md#apidevicetargetget) | **GET** /api/DeviceTarget | 

<a name="apidevicetargetdevicetargetidget"></a>
# **ApiDeviceTargetDeviceTargetIdGet**
> DeviceTargetModel ApiDeviceTargetDeviceTargetIdGet (string deviceTargetId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiDeviceTargetDeviceTargetIdGetExample
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

            var apiInstance = new DeviceTargetApi();
            var deviceTargetId = deviceTargetId_example;  // string | 

            try
            {
                DeviceTargetModel result = apiInstance.ApiDeviceTargetDeviceTargetIdGet(deviceTargetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceTargetApi.ApiDeviceTargetDeviceTargetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceTargetId** | **string**|  | 

### Return type

[**DeviceTargetModel**](DeviceTargetModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apidevicetargetget"></a>
# **ApiDeviceTargetGet**
> List<DeviceTargetModel> ApiDeviceTargetGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiDeviceTargetGetExample
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

            var apiInstance = new DeviceTargetApi();

            try
            {
                List&lt;DeviceTargetModel&gt; result = apiInstance.ApiDeviceTargetGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeviceTargetApi.ApiDeviceTargetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DeviceTargetModel>**](DeviceTargetModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
