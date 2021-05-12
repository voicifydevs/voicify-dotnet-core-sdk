# Voicify.Sdk.Core.Models.Api.SubscriptionApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiSubscriptionForOrganizationOrganizationIdGet**](SubscriptionApi.md#apisubscriptionfororganizationorganizationidget) | **GET** /api/Subscription/forOrganization/{organizationId} | 
[**ApiSubscriptionOrganizationIdDefaultGet**](SubscriptionApi.md#apisubscriptionorganizationiddefaultget) | **GET** /api/Subscription/{organizationId}/default | 
[**ApiSubscriptionTypesGet**](SubscriptionApi.md#apisubscriptiontypesget) | **GET** /api/Subscription/types | 

<a name="apisubscriptionfororganizationorganizationidget"></a>
# **ApiSubscriptionForOrganizationOrganizationIdGet**
> List<SubscriptionModel> ApiSubscriptionForOrganizationOrganizationIdGet (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiSubscriptionForOrganizationOrganizationIdGetExample
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

            var apiInstance = new SubscriptionApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;SubscriptionModel&gt; result = apiInstance.ApiSubscriptionForOrganizationOrganizationIdGet(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ApiSubscriptionForOrganizationOrganizationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 

### Return type

[**List<SubscriptionModel>**](SubscriptionModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apisubscriptionorganizationiddefaultget"></a>
# **ApiSubscriptionOrganizationIdDefaultGet**
> SubscriptionModel ApiSubscriptionOrganizationIdDefaultGet (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiSubscriptionOrganizationIdDefaultGetExample
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

            var apiInstance = new SubscriptionApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                SubscriptionModel result = apiInstance.ApiSubscriptionOrganizationIdDefaultGet(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ApiSubscriptionOrganizationIdDefaultGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 

### Return type

[**SubscriptionModel**](SubscriptionModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apisubscriptiontypesget"></a>
# **ApiSubscriptionTypesGet**
> List<SubscriptionTypeModel> ApiSubscriptionTypesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiSubscriptionTypesGetExample
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

            var apiInstance = new SubscriptionApi();

            try
            {
                List&lt;SubscriptionTypeModel&gt; result = apiInstance.ApiSubscriptionTypesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionApi.ApiSubscriptionTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SubscriptionTypeModel>**](SubscriptionTypeModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
