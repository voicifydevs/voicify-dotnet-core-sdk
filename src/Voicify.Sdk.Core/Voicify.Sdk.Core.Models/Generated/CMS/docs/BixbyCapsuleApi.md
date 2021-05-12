# Voicify.Sdk.Core.Models.Api.BixbyCapsuleApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiBixbyCapsuleBaseCapsuleTemplateGet**](BixbyCapsuleApi.md#apibixbycapsulebasecapsuletemplateget) | **GET** /api/BixbyCapsule/baseCapsuleTemplate | 
[**ApiBixbyCapsuleCapsulePropertiesApplicationIdGet**](BixbyCapsuleApi.md#apibixbycapsulecapsulepropertiesapplicationidget) | **GET** /api/BixbyCapsule/capsuleProperties/{applicationId} | 

<a name="apibixbycapsulebasecapsuletemplateget"></a>
# **ApiBixbyCapsuleBaseCapsuleTemplateGet**
> byte[] ApiBixbyCapsuleBaseCapsuleTemplateGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiBixbyCapsuleBaseCapsuleTemplateGetExample
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

            var apiInstance = new BixbyCapsuleApi();

            try
            {
                byte[] result = apiInstance.ApiBixbyCapsuleBaseCapsuleTemplateGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyCapsuleApi.ApiBixbyCapsuleBaseCapsuleTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**byte[]**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apibixbycapsulecapsulepropertiesapplicationidget"></a>
# **ApiBixbyCapsuleCapsulePropertiesApplicationIdGet**
> byte[] ApiBixbyCapsuleCapsulePropertiesApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiBixbyCapsuleCapsulePropertiesApplicationIdGetExample
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

            var apiInstance = new BixbyCapsuleApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                byte[] result = apiInstance.ApiBixbyCapsuleCapsulePropertiesApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyCapsuleApi.ApiBixbyCapsuleCapsulePropertiesApplicationIdGet: " + e.Message );
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

**byte[]**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
