# Voicify.Sdk.Core.Models.Api.ApplicationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiApplicationApplicationIdAlexaFallbackSensitivitySensitivityLevelPut**](ApplicationApi.md#apiapplicationapplicationidalexafallbacksensitivitysensitivitylevelput) | **PUT** /api/Application/{applicationId}/alexaFallbackSensitivity/{sensitivityLevel} | 
[**ApiApplicationApplicationIdConversationCountGet**](ApplicationApi.md#apiapplicationapplicationidconversationcountget) | **GET** /api/Application/{applicationId}/conversationCount | 
[**ApiApplicationApplicationIdDefaultLanguageLanguageIdPut**](ApplicationApi.md#apiapplicationapplicationiddefaultlanguagelanguageidput) | **PUT** /api/Application/{applicationId}/defaultLanguage/{languageId} | 
[**ApiApplicationApplicationIdDefaultWebhookTimeoutPut**](ApplicationApi.md#apiapplicationapplicationiddefaultwebhooktimeoutput) | **PUT** /api/Application/{applicationId}/defaultWebhookTimeout | 
[**ApiApplicationApplicationIdDelete**](ApplicationApi.md#apiapplicationapplicationiddelete) | **DELETE** /api/Application/{applicationId} | 
[**ApiApplicationApplicationIdDisableDelete**](ApplicationApi.md#apiapplicationapplicationiddisabledelete) | **DELETE** /api/Application/{applicationId}/disable | 
[**ApiApplicationApplicationIdEnablePut**](ApplicationApi.md#apiapplicationapplicationidenableput) | **PUT** /api/Application/{applicationId}/enable | 
[**ApiApplicationApplicationIdFulfillmentEndpointsGet**](ApplicationApi.md#apiapplicationapplicationidfulfillmentendpointsget) | **GET** /api/Application/{applicationId}/fulfillmentEndpoints | 
[**ApiApplicationApplicationIdLanguagesPut**](ApplicationApi.md#apiapplicationapplicationidlanguagesput) | **PUT** /api/Application/{applicationId}/languages | 
[**ApiApplicationApplicationIdMembersBulkAddPost**](ApplicationApi.md#apiapplicationapplicationidmembersbulkaddpost) | **POST** /api/Application/{applicationId}/members/bulkAdd | 
[**ApiApplicationApplicationIdMembersGet**](ApplicationApi.md#apiapplicationapplicationidmembersget) | **GET** /api/Application/{applicationId}/members | 
[**ApiApplicationApplicationIdMembersPost**](ApplicationApi.md#apiapplicationapplicationidmemberspost) | **POST** /api/Application/{applicationId}/members | 
[**ApiApplicationApplicationIdPut**](ApplicationApi.md#apiapplicationapplicationidput) | **PUT** /api/Application/{applicationId} | 
[**ApiApplicationApplicationIdSetImageImageItemIdPut**](ApplicationApi.md#apiapplicationapplicationidsetimageimageitemidput) | **PUT** /api/Application/{applicationId}/setImage/{imageItemId} | 
[**ApiApplicationApplicationIdToggleAllowsTemplatePut**](ApplicationApi.md#apiapplicationapplicationidtoggleallowstemplateput) | **PUT** /api/Application/{applicationId}/toggleAllowsTemplate | 
[**ApiApplicationApplicationIdWebhooksBulkPut**](ApplicationApi.md#apiapplicationapplicationidwebhooksbulkput) | **PUT** /api/Application/{applicationId}/webhooks/bulk | 
[**ApiApplicationApplicationIdWebhooksGet**](ApplicationApi.md#apiapplicationapplicationidwebhooksget) | **GET** /api/Application/{applicationId}/webhooks | 
[**ApiApplicationApplicationIdWebhooksWebhookIdPost**](ApplicationApi.md#apiapplicationapplicationidwebhookswebhookidpost) | **POST** /api/Application/{applicationId}/webhooks/{webhookId} | 
[**ApiApplicationApplicationIdWebhooksWebhookInstanceIdPut**](ApplicationApi.md#apiapplicationapplicationidwebhookswebhookinstanceidput) | **PUT** /api/Application/{applicationId}/webhooks/{webhookInstanceId} | 
[**ApiApplicationFindApplicationIdGet**](ApplicationApi.md#apiapplicationfindapplicationidget) | **GET** /api/Application/find/{applicationId} | 
[**ApiApplicationFindApplicationIdWithFeaturesGet**](ApplicationApi.md#apiapplicationfindapplicationidwithfeaturesget) | **GET** /api/Application/find/{applicationId}/withFeatures | 
[**ApiApplicationMembersApplicationMemberIdDelete**](ApplicationApi.md#apiapplicationmembersapplicationmemberiddelete) | **DELETE** /api/Application/members/{applicationMemberId} | 
[**ApiApplicationMembersApplicationMemberIdPut**](ApplicationApi.md#apiapplicationmembersapplicationmemberidput) | **PUT** /api/Application/members/{applicationMemberId} | 
[**ApiApplicationOrganizationIdAppsConversationCountsGet**](ApplicationApi.md#apiapplicationorganizationidappsconversationcountsget) | **GET** /api/Application/{organizationId}/apps/conversationCounts | 
[**ApiApplicationOrganizationIdConversationAndFeatureCountsGet**](ApplicationApi.md#apiapplicationorganizationidconversationandfeaturecountsget) | **GET** /api/Application/{organizationId}/conversationAndFeatureCounts | 
[**ApiApplicationOrganizationIdGet**](ApplicationApi.md#apiapplicationorganizationidget) | **GET** /api/Application/{organizationId} | 
[**ApiApplicationOrganizationIdPost**](ApplicationApi.md#apiapplicationorganizationidpost) | **POST** /api/Application/{organizationId} | 
[**ApiApplicationOrganizationIdWithFeaturesGet**](ApplicationApi.md#apiapplicationorganizationidwithfeaturesget) | **GET** /api/Application/{organizationId}/withFeatures | 
[**ApiApplicationOrganizationIdWithMembersSearchGet**](ApplicationApi.md#apiapplicationorganizationidwithmemberssearchget) | **GET** /api/Application/{organizationId}/withMembers/search | 
[**ApiApplicationOrganizationIdWithSamplesPost**](ApplicationApi.md#apiapplicationorganizationidwithsamplespost) | **POST** /api/Application/{organizationId}/withSamples | 
[**ApiApplicationSetInitialPriorityPost**](ApplicationApi.md#apiapplicationsetinitialprioritypost) | **POST** /api/Application/setInitialPriority | 
[**ApiApplicationWebhookApplicationWebhookIdDelete**](ApplicationApi.md#apiapplicationwebhookapplicationwebhookiddelete) | **DELETE** /api/Application/webhook/{applicationWebhookId} | 
[**ApiApplicationWebhookInstanceWebhookIdUserParametersParameterNameDelete**](ApplicationApi.md#apiapplicationwebhookinstancewebhookiduserparametersparameternamedelete) | **DELETE** /api/Application/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**ApiApplicationWebhookInstanceWebhookIdUserParametersPost**](ApplicationApi.md#apiapplicationwebhookinstancewebhookiduserparameterspost) | **POST** /api/Application/webhook/{instanceWebhookId}/userParameters | 
[**ApiApplicationWebhookInstanceWebhookIdUserParametersPut**](ApplicationApi.md#apiapplicationwebhookinstancewebhookiduserparametersput) | **PUT** /api/Application/webhook/{instanceWebhookId}/userParameters | 
[**ApiApplicationWebhookInstanceWebhookIdWebhookParametersPut**](ApplicationApi.md#apiapplicationwebhookinstancewebhookidwebhookparametersput) | **PUT** /api/Application/webhook/{instanceWebhookId}/webhookParameters | 

<a name="apiapplicationapplicationidalexafallbacksensitivitysensitivitylevelput"></a>
# **ApiApplicationApplicationIdAlexaFallbackSensitivitySensitivityLevelPut**
> bool? ApiApplicationApplicationIdAlexaFallbackSensitivitySensitivityLevelPut (string applicationId, AlexaFallbackSensitivityLevel sensitivityLevel)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdAlexaFallbackSensitivitySensitivityLevelPutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var sensitivityLevel = new AlexaFallbackSensitivityLevel(); // AlexaFallbackSensitivityLevel | 

            try
            {
                bool? result = apiInstance.ApiApplicationApplicationIdAlexaFallbackSensitivitySensitivityLevelPut(applicationId, sensitivityLevel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdAlexaFallbackSensitivitySensitivityLevelPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **sensitivityLevel** | [**AlexaFallbackSensitivityLevel**](AlexaFallbackSensitivityLevel.md)|  | 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidconversationcountget"></a>
# **ApiApplicationApplicationIdConversationCountGet**
> ApplicationCountsModel ApiApplicationApplicationIdConversationCountGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdConversationCountGetExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationCountsModel result = apiInstance.ApiApplicationApplicationIdConversationCountGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdConversationCountGet: " + e.Message );
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

[**ApplicationCountsModel**](ApplicationCountsModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationiddefaultlanguagelanguageidput"></a>
# **ApiApplicationApplicationIdDefaultLanguageLanguageIdPut**
> ApplicationModel ApiApplicationApplicationIdDefaultLanguageLanguageIdPut (string applicationId, string languageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdDefaultLanguageLanguageIdPutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var languageId = languageId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationApplicationIdDefaultLanguageLanguageIdPut(applicationId, languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdDefaultLanguageLanguageIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **languageId** | **string**|  | 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationiddefaultwebhooktimeoutput"></a>
# **ApiApplicationApplicationIdDefaultWebhookTimeoutPut**
> bool? ApiApplicationApplicationIdDefaultWebhookTimeoutPut (string applicationId, UpdateApplicationDefaultTimeoutRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdDefaultWebhookTimeoutPutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var body = new UpdateApplicationDefaultTimeoutRequest(); // UpdateApplicationDefaultTimeoutRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiApplicationApplicationIdDefaultWebhookTimeoutPut(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdDefaultWebhookTimeoutPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**UpdateApplicationDefaultTimeoutRequest**](UpdateApplicationDefaultTimeoutRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationiddelete"></a>
# **ApiApplicationApplicationIdDelete**
> ApplicationModel ApiApplicationApplicationIdDelete (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdDeleteExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationApplicationIdDelete(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdDelete: " + e.Message );
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

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationiddisabledelete"></a>
# **ApiApplicationApplicationIdDisableDelete**
> ApplicationModel ApiApplicationApplicationIdDisableDelete (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdDisableDeleteExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationApplicationIdDisableDelete(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdDisableDelete: " + e.Message );
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

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidenableput"></a>
# **ApiApplicationApplicationIdEnablePut**
> ApplicationModel ApiApplicationApplicationIdEnablePut (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdEnablePutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationApplicationIdEnablePut(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdEnablePut: " + e.Message );
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

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidfulfillmentendpointsget"></a>
# **ApiApplicationApplicationIdFulfillmentEndpointsGet**
> ApplicationFulfillmentEndpoints ApiApplicationApplicationIdFulfillmentEndpointsGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdFulfillmentEndpointsGetExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationFulfillmentEndpoints result = apiInstance.ApiApplicationApplicationIdFulfillmentEndpointsGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdFulfillmentEndpointsGet: " + e.Message );
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

[**ApplicationFulfillmentEndpoints**](ApplicationFulfillmentEndpoints.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidlanguagesput"></a>
# **ApiApplicationApplicationIdLanguagesPut**
> ApplicationModel ApiApplicationApplicationIdLanguagesPut (string applicationId, List<string> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdLanguagesPutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var body = new List<string>(); // List<string> |  (optional) 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationApplicationIdLanguagesPut(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdLanguagesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidmembersbulkaddpost"></a>
# **ApiApplicationApplicationIdMembersBulkAddPost**
> List<ApplicationMemberModel> ApiApplicationApplicationIdMembersBulkAddPost (string applicationId, NewBulkApplicationMemberRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdMembersBulkAddPostExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewBulkApplicationMemberRequest(); // NewBulkApplicationMemberRequest |  (optional) 

            try
            {
                List&lt;ApplicationMemberModel&gt; result = apiInstance.ApiApplicationApplicationIdMembersBulkAddPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdMembersBulkAddPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewBulkApplicationMemberRequest**](NewBulkApplicationMemberRequest.md)|  | [optional] 

### Return type

[**List<ApplicationMemberModel>**](ApplicationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidmembersget"></a>
# **ApiApplicationApplicationIdMembersGet**
> List<ApplicationMemberModel> ApiApplicationApplicationIdMembersGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdMembersGetExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;ApplicationMemberModel&gt; result = apiInstance.ApiApplicationApplicationIdMembersGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdMembersGet: " + e.Message );
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

[**List<ApplicationMemberModel>**](ApplicationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidmemberspost"></a>
# **ApiApplicationApplicationIdMembersPost**
> ApplicationMemberModel ApiApplicationApplicationIdMembersPost (string applicationId, NewApplicationMemberRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdMembersPostExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var body = new NewApplicationMemberRequest(); // NewApplicationMemberRequest |  (optional) 

            try
            {
                ApplicationMemberModel result = apiInstance.ApiApplicationApplicationIdMembersPost(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**NewApplicationMemberRequest**](NewApplicationMemberRequest.md)|  | [optional] 

### Return type

[**ApplicationMemberModel**](ApplicationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidput"></a>
# **ApiApplicationApplicationIdPut**
> ApplicationModel ApiApplicationApplicationIdPut (string applicationId, UpdateApplicationRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdPutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var body = new UpdateApplicationRequest(); // UpdateApplicationRequest |  (optional) 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationApplicationIdPut(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**UpdateApplicationRequest**](UpdateApplicationRequest.md)|  | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidsetimageimageitemidput"></a>
# **ApiApplicationApplicationIdSetImageImageItemIdPut**
> ApplicationModel ApiApplicationApplicationIdSetImageImageItemIdPut (string applicationId, string imageItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdSetImageImageItemIdPutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var imageItemId = imageItemId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationApplicationIdSetImageImageItemIdPut(applicationId, imageItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdSetImageImageItemIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **imageItemId** | **string**|  | 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidtoggleallowstemplateput"></a>
# **ApiApplicationApplicationIdToggleAllowsTemplatePut**
> ApplicationModel ApiApplicationApplicationIdToggleAllowsTemplatePut (string applicationId, ToggleTemplateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdToggleAllowsTemplatePutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var body = new ToggleTemplateRequest(); // ToggleTemplateRequest |  (optional) 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationApplicationIdToggleAllowsTemplatePut(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdToggleAllowsTemplatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**ToggleTemplateRequest**](ToggleTemplateRequest.md)|  | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidwebhooksbulkput"></a>
# **ApiApplicationApplicationIdWebhooksBulkPut**
> List<ApplicationWebhookModel> ApiApplicationApplicationIdWebhooksBulkPut (string applicationId, BulkWebhookInstancesUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdWebhooksBulkPutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var body = new BulkWebhookInstancesUpdateRequest(); // BulkWebhookInstancesUpdateRequest |  (optional) 

            try
            {
                List&lt;ApplicationWebhookModel&gt; result = apiInstance.ApiApplicationApplicationIdWebhooksBulkPut(applicationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdWebhooksBulkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **body** | [**BulkWebhookInstancesUpdateRequest**](BulkWebhookInstancesUpdateRequest.md)|  | [optional] 

### Return type

[**List<ApplicationWebhookModel>**](ApplicationWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidwebhooksget"></a>
# **ApiApplicationApplicationIdWebhooksGet**
> List<ApplicationWebhookModel> ApiApplicationApplicationIdWebhooksGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdWebhooksGetExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;ApplicationWebhookModel&gt; result = apiInstance.ApiApplicationApplicationIdWebhooksGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdWebhooksGet: " + e.Message );
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

[**List<ApplicationWebhookModel>**](ApplicationWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidwebhookswebhookidpost"></a>
# **ApiApplicationApplicationIdWebhooksWebhookIdPost**
> ApplicationWebhookModel ApiApplicationApplicationIdWebhooksWebhookIdPost (string applicationId, string webhookId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdWebhooksWebhookIdPostExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                ApplicationWebhookModel result = apiInstance.ApiApplicationApplicationIdWebhooksWebhookIdPost(applicationId, webhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdWebhooksWebhookIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **webhookId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**ApplicationWebhookModel**](ApplicationWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationapplicationidwebhookswebhookinstanceidput"></a>
# **ApiApplicationApplicationIdWebhooksWebhookInstanceIdPut**
> ApplicationWebhookModel ApiApplicationApplicationIdWebhooksWebhookInstanceIdPut (string applicationId, string webhookInstanceId, WebhookParametersRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationApplicationIdWebhooksWebhookInstanceIdPutExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var body = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                ApplicationWebhookModel result = apiInstance.ApiApplicationApplicationIdWebhooksWebhookInstanceIdPut(applicationId, webhookInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationApplicationIdWebhooksWebhookInstanceIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **body** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**ApplicationWebhookModel**](ApplicationWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationfindapplicationidget"></a>
# **ApiApplicationFindApplicationIdGet**
> ApplicationModel ApiApplicationFindApplicationIdGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationFindApplicationIdGetExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationFindApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationFindApplicationIdGet: " + e.Message );
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

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationfindapplicationidwithfeaturesget"></a>
# **ApiApplicationFindApplicationIdWithFeaturesGet**
> ApplicationWithFeaturesModel ApiApplicationFindApplicationIdWithFeaturesGet (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationFindApplicationIdWithFeaturesGetExample
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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationWithFeaturesModel result = apiInstance.ApiApplicationFindApplicationIdWithFeaturesGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationFindApplicationIdWithFeaturesGet: " + e.Message );
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

[**ApplicationWithFeaturesModel**](ApplicationWithFeaturesModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationmembersapplicationmemberiddelete"></a>
# **ApiApplicationMembersApplicationMemberIdDelete**
> ApplicationMemberModel ApiApplicationMembersApplicationMemberIdDelete (string applicationMemberId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationMembersApplicationMemberIdDeleteExample
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

            var apiInstance = new ApplicationApi();
            var applicationMemberId = applicationMemberId_example;  // string | 

            try
            {
                ApplicationMemberModel result = apiInstance.ApiApplicationMembersApplicationMemberIdDelete(applicationMemberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationMembersApplicationMemberIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationMemberId** | **string**|  | 

### Return type

[**ApplicationMemberModel**](ApplicationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationmembersapplicationmemberidput"></a>
# **ApiApplicationMembersApplicationMemberIdPut**
> ApplicationMemberModel ApiApplicationMembersApplicationMemberIdPut (string applicationMemberId, MemberRoleUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationMembersApplicationMemberIdPutExample
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

            var apiInstance = new ApplicationApi();
            var applicationMemberId = applicationMemberId_example;  // string | 
            var body = new MemberRoleUpdateRequest(); // MemberRoleUpdateRequest |  (optional) 

            try
            {
                ApplicationMemberModel result = apiInstance.ApiApplicationMembersApplicationMemberIdPut(applicationMemberId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationMembersApplicationMemberIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationMemberId** | **string**|  | 
 **body** | [**MemberRoleUpdateRequest**](MemberRoleUpdateRequest.md)|  | [optional] 

### Return type

[**ApplicationMemberModel**](ApplicationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationorganizationidappsconversationcountsget"></a>
# **ApiApplicationOrganizationIdAppsConversationCountsGet**
> List<ApplicationCountsModel> ApiApplicationOrganizationIdAppsConversationCountsGet (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationOrganizationIdAppsConversationCountsGetExample
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

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;ApplicationCountsModel&gt; result = apiInstance.ApiApplicationOrganizationIdAppsConversationCountsGet(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationOrganizationIdAppsConversationCountsGet: " + e.Message );
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

[**List<ApplicationCountsModel>**](ApplicationCountsModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationorganizationidconversationandfeaturecountsget"></a>
# **ApiApplicationOrganizationIdConversationAndFeatureCountsGet**
> List<ApplicationCountsModel> ApiApplicationOrganizationIdConversationAndFeatureCountsGet (string organizationId, List<string> appIds = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationOrganizationIdConversationAndFeatureCountsGetExample
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

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | 
            var appIds = new List<string>(); // List<string> |  (optional) 

            try
            {
                List&lt;ApplicationCountsModel&gt; result = apiInstance.ApiApplicationOrganizationIdConversationAndFeatureCountsGet(organizationId, appIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationOrganizationIdConversationAndFeatureCountsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **appIds** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**List<ApplicationCountsModel>**](ApplicationCountsModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationorganizationidget"></a>
# **ApiApplicationOrganizationIdGet**
> List<ApplicationModel> ApiApplicationOrganizationIdGet (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationOrganizationIdGetExample
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

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;ApplicationModel&gt; result = apiInstance.ApiApplicationOrganizationIdGet(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationOrganizationIdGet: " + e.Message );
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

[**List<ApplicationModel>**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationorganizationidpost"></a>
# **ApiApplicationOrganizationIdPost**
> ApplicationModel ApiApplicationOrganizationIdPost (string organizationId, NewApplicationRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationOrganizationIdPostExample
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

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | 
            var body = new NewApplicationRequest(); // NewApplicationRequest |  (optional) 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationOrganizationIdPost(organizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationOrganizationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **body** | [**NewApplicationRequest**](NewApplicationRequest.md)|  | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationorganizationidwithfeaturesget"></a>
# **ApiApplicationOrganizationIdWithFeaturesGet**
> List<ApplicationWithFeaturesModel> ApiApplicationOrganizationIdWithFeaturesGet (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationOrganizationIdWithFeaturesGetExample
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

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;ApplicationWithFeaturesModel&gt; result = apiInstance.ApiApplicationOrganizationIdWithFeaturesGet(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationOrganizationIdWithFeaturesGet: " + e.Message );
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

[**List<ApplicationWithFeaturesModel>**](ApplicationWithFeaturesModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationorganizationidwithmemberssearchget"></a>
# **ApiApplicationOrganizationIdWithMembersSearchGet**
> ApplicationsSearchResult ApiApplicationOrganizationIdWithMembersSearchGet (string organizationId, int? skip = null, int? take = null, string search = null, string sortBy = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationOrganizationIdWithMembersSearchGetExample
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

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | 
            var skip = 56;  // int? |  (optional)  (default to 0)
            var take = 56;  // int? |  (optional)  (default to 10)
            var search = search_example;  // string |  (optional) 
            var sortBy = sortBy_example;  // string |  (optional) 

            try
            {
                ApplicationsSearchResult result = apiInstance.ApiApplicationOrganizationIdWithMembersSearchGet(organizationId, skip, take, search, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationOrganizationIdWithMembersSearchGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **skip** | **int?**|  | [optional] [default to 0]
 **take** | **int?**|  | [optional] [default to 10]
 **search** | **string**|  | [optional] 
 **sortBy** | **string**|  | [optional] 

### Return type

[**ApplicationsSearchResult**](ApplicationsSearchResult.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationorganizationidwithsamplespost"></a>
# **ApiApplicationOrganizationIdWithSamplesPost**
> ApplicationModel ApiApplicationOrganizationIdWithSamplesPost (string organizationId, NewApplicationRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationOrganizationIdWithSamplesPostExample
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

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | 
            var body = new NewApplicationRequest(); // NewApplicationRequest |  (optional) 

            try
            {
                ApplicationModel result = apiInstance.ApiApplicationOrganizationIdWithSamplesPost(organizationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationOrganizationIdWithSamplesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **body** | [**NewApplicationRequest**](NewApplicationRequest.md)|  | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationsetinitialprioritypost"></a>
# **ApiApplicationSetInitialPriorityPost**
> bool? ApiApplicationSetInitialPriorityPost ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationSetInitialPriorityPostExample
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

            var apiInstance = new ApplicationApi();

            try
            {
                bool? result = apiInstance.ApiApplicationSetInitialPriorityPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationSetInitialPriorityPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationwebhookapplicationwebhookiddelete"></a>
# **ApiApplicationWebhookApplicationWebhookIdDelete**
> ApplicationWebhookModel ApiApplicationWebhookApplicationWebhookIdDelete (string applicationWebhookId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationWebhookApplicationWebhookIdDeleteExample
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

            var apiInstance = new ApplicationApi();
            var applicationWebhookId = applicationWebhookId_example;  // string | 

            try
            {
                ApplicationWebhookModel result = apiInstance.ApiApplicationWebhookApplicationWebhookIdDelete(applicationWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationWebhookApplicationWebhookIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationWebhookId** | **string**|  | 

### Return type

[**ApplicationWebhookModel**](ApplicationWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationwebhookinstancewebhookiduserparametersparameternamedelete"></a>
# **ApiApplicationWebhookInstanceWebhookIdUserParametersParameterNameDelete**
> bool? ApiApplicationWebhookInstanceWebhookIdUserParametersParameterNameDelete (string instanceWebhookId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationWebhookInstanceWebhookIdUserParametersParameterNameDeleteExample
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

            var apiInstance = new ApplicationApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.ApiApplicationWebhookInstanceWebhookIdUserParametersParameterNameDelete(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationWebhookInstanceWebhookIdUserParametersParameterNameDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **parameterName** | **string**|  | 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationwebhookinstancewebhookiduserparameterspost"></a>
# **ApiApplicationWebhookInstanceWebhookIdUserParametersPost**
> bool? ApiApplicationWebhookInstanceWebhookIdUserParametersPost (string instanceWebhookId, UserDefinedWebhookParameterCreateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationWebhookInstanceWebhookIdUserParametersPostExample
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

            var apiInstance = new ApplicationApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiApplicationWebhookInstanceWebhookIdUserParametersPost(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationWebhookInstanceWebhookIdUserParametersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **body** | [**UserDefinedWebhookParameterCreateRequest**](UserDefinedWebhookParameterCreateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationwebhookinstancewebhookiduserparametersput"></a>
# **ApiApplicationWebhookInstanceWebhookIdUserParametersPut**
> bool? ApiApplicationWebhookInstanceWebhookIdUserParametersPut (string instanceWebhookId, UserDefinedWebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationWebhookInstanceWebhookIdUserParametersPutExample
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

            var apiInstance = new ApplicationApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiApplicationWebhookInstanceWebhookIdUserParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationWebhookInstanceWebhookIdUserParametersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **body** | [**UserDefinedWebhookParameterUpdateRequest**](UserDefinedWebhookParameterUpdateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiapplicationwebhookinstancewebhookidwebhookparametersput"></a>
# **ApiApplicationWebhookInstanceWebhookIdWebhookParametersPut**
> bool? ApiApplicationWebhookInstanceWebhookIdWebhookParametersPut (string instanceWebhookId, WebhookParameterUpdateRequest body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiApplicationWebhookInstanceWebhookIdWebhookParametersPutExample
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

            var apiInstance = new ApplicationApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var body = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ApiApplicationWebhookInstanceWebhookIdWebhookParametersPut(instanceWebhookId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApiApplicationWebhookInstanceWebhookIdWebhookParametersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **body** | [**WebhookParameterUpdateRequest**](WebhookParameterUpdateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
