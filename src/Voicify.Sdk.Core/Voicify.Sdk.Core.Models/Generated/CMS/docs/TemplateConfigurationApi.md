# Voicify.Sdk.Core.Models.Api.TemplateConfigurationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptTemplateInvite**](TemplateConfigurationApi.md#accepttemplateinvite) | **POST** /api/TemplateConfiguration/invite/accept | 
[**CreateTemplateConfigurationFromModel**](TemplateConfigurationApi.md#createtemplateconfigurationfrommodel) | **POST** /api/TemplateConfiguration | 
[**CreateTemplateInvite**](TemplateConfigurationApi.md#createtemplateinvite) | **POST** /api/TemplateConfiguration/{templateConfigurationId}/invite | 
[**DeleteTemplateConfiguration**](TemplateConfigurationApi.md#deletetemplateconfiguration) | **DELETE** /api/TemplateConfiguration/{templateConfigurationId} | 
[**DeleteTemplateInvite**](TemplateConfigurationApi.md#deletetemplateinvite) | **DELETE** /api/TemplateConfiguration/invite/{templateInviteId} | 
[**DisableTemplateConfiguration**](TemplateConfigurationApi.md#disabletemplateconfiguration) | **PUT** /api/TemplateConfiguration/{templateConfigurationId}/disable | 
[**EnableTemplateConfiguration**](TemplateConfigurationApi.md#enabletemplateconfiguration) | **PUT** /api/TemplateConfiguration/{templateConfigurationId}/enable | 
[**GetActiveInvitesToTemplate**](TemplateConfigurationApi.md#getactiveinvitestotemplate) | **GET** /api/TemplateConfiguration/{templateConfigurationId}/invites | 
[**GetAvailableTemplateCategories**](TemplateConfigurationApi.md#getavailabletemplatecategories) | **GET** /api/TemplateConfiguration/categories | 
[**GetAvailableTemplateConfigurations**](TemplateConfigurationApi.md#getavailabletemplateconfigurations) | **GET** /api/TemplateConfiguration/{organizationId}/available | 
[**GetAvailableTemplateIndustries**](TemplateConfigurationApi.md#getavailabletemplateindustries) | **GET** /api/TemplateConfiguration/industries | 
[**GetOrganizationTemplateConfigurations**](TemplateConfigurationApi.md#getorganizationtemplateconfigurations) | **GET** /api/TemplateConfiguration/{organizationId} | 
[**GetOrganizationsWithAccessToTemplate**](TemplateConfigurationApi.md#getorganizationswithaccesstotemplate) | **GET** /api/TemplateConfiguration/{templateConfigurationId}/organizationAccess | 
[**GetPrivateTemplateConfigurations**](TemplateConfigurationApi.md#getprivatetemplateconfigurations) | **GET** /api/TemplateConfiguration/{organizationId}/private | 
[**RevokeTemplateAccess**](TemplateConfigurationApi.md#revoketemplateaccess) | **DELETE** /api/TemplateConfiguration/{templateConfigurationId}/organizationAccess/{organizationId} | 
[**UpdateTemplateConfiguration**](TemplateConfigurationApi.md#updatetemplateconfiguration) | **PUT** /api/TemplateConfiguration/{templateConfigurationId} | 

<a name="accepttemplateinvite"></a>
# **AcceptTemplateInvite**
> TemplateConfigurationModel AcceptTemplateInvite (string organizationId = null, string accessCode = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AcceptTemplateInviteExample
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

            var apiInstance = new TemplateConfigurationApi();
            var organizationId = organizationId_example;  // string |  (optional) 
            var accessCode = accessCode_example;  // string |  (optional) 

            try
            {
                TemplateConfigurationModel result = apiInstance.AcceptTemplateInvite(organizationId, accessCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.AcceptTemplateInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | [optional] 
 **accessCode** | **string**|  | [optional] 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createtemplateconfigurationfrommodel"></a>
# **CreateTemplateConfigurationFromModel**
> TemplateConfigurationModel CreateTemplateConfigurationFromModel (TemplateConfigurationModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateTemplateConfigurationFromModelExample
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

            var apiInstance = new TemplateConfigurationApi();
            var body = new TemplateConfigurationModel(); // TemplateConfigurationModel |  (optional) 

            try
            {
                TemplateConfigurationModel result = apiInstance.CreateTemplateConfigurationFromModel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.CreateTemplateConfigurationFromModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TemplateConfigurationModel**](TemplateConfigurationModel.md)|  | [optional] 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createtemplateinvite"></a>
# **CreateTemplateInvite**
> TemplateInviteModel CreateTemplateInvite (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateTemplateInviteExample
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

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                TemplateInviteModel result = apiInstance.CreateTemplateInvite(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.CreateTemplateInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 

### Return type

[**TemplateInviteModel**](TemplateInviteModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetemplateconfiguration"></a>
# **DeleteTemplateConfiguration**
> TemplateConfigurationModel DeleteTemplateConfiguration (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteTemplateConfigurationExample
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

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                TemplateConfigurationModel result = apiInstance.DeleteTemplateConfiguration(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.DeleteTemplateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletetemplateinvite"></a>
# **DeleteTemplateInvite**
> TemplateInviteModel DeleteTemplateInvite (string templateInviteId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteTemplateInviteExample
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

            var apiInstance = new TemplateConfigurationApi();
            var templateInviteId = templateInviteId_example;  // string | 

            try
            {
                TemplateInviteModel result = apiInstance.DeleteTemplateInvite(templateInviteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.DeleteTemplateInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateInviteId** | **string**|  | 

### Return type

[**TemplateInviteModel**](TemplateInviteModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="disabletemplateconfiguration"></a>
# **DisableTemplateConfiguration**
> TemplateConfigurationModel DisableTemplateConfiguration (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DisableTemplateConfigurationExample
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

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                TemplateConfigurationModel result = apiInstance.DisableTemplateConfiguration(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.DisableTemplateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="enabletemplateconfiguration"></a>
# **EnableTemplateConfiguration**
> TemplateConfigurationModel EnableTemplateConfiguration (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class EnableTemplateConfigurationExample
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

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                TemplateConfigurationModel result = apiInstance.EnableTemplateConfiguration(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.EnableTemplateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getactiveinvitestotemplate"></a>
# **GetActiveInvitesToTemplate**
> List<TemplateInviteModel> GetActiveInvitesToTemplate (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetActiveInvitesToTemplateExample
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

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                List&lt;TemplateInviteModel&gt; result = apiInstance.GetActiveInvitesToTemplate(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.GetActiveInvitesToTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 

### Return type

[**List<TemplateInviteModel>**](TemplateInviteModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getavailabletemplatecategories"></a>
# **GetAvailableTemplateCategories**
> List<TemplateCategoryModel> GetAvailableTemplateCategories ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAvailableTemplateCategoriesExample
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

            var apiInstance = new TemplateConfigurationApi();

            try
            {
                List&lt;TemplateCategoryModel&gt; result = apiInstance.GetAvailableTemplateCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.GetAvailableTemplateCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TemplateCategoryModel>**](TemplateCategoryModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getavailabletemplateconfigurations"></a>
# **GetAvailableTemplateConfigurations**
> List<TemplateConfigurationModel> GetAvailableTemplateConfigurations (string organizationId, int? skip = null, int? take = null, TemplateType templateType = null, string templateCategoryId = null, string templateIndustryId = null, string searchQuery = null, string sortBy = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAvailableTemplateConfigurationsExample
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

            var apiInstance = new TemplateConfigurationApi();
            var organizationId = organizationId_example;  // string | 
            var skip = 56;  // int? |  (optional) 
            var take = 56;  // int? |  (optional) 
            var templateType = new TemplateType(); // TemplateType |  (optional) 
            var templateCategoryId = templateCategoryId_example;  // string |  (optional) 
            var templateIndustryId = templateIndustryId_example;  // string |  (optional) 
            var searchQuery = searchQuery_example;  // string |  (optional) 
            var sortBy = sortBy_example;  // string |  (optional) 

            try
            {
                List&lt;TemplateConfigurationModel&gt; result = apiInstance.GetAvailableTemplateConfigurations(organizationId, skip, take, templateType, templateCategoryId, templateIndustryId, searchQuery, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.GetAvailableTemplateConfigurations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **skip** | **int?**|  | [optional] 
 **take** | **int?**|  | [optional] 
 **templateType** | [**TemplateType**](TemplateType.md)|  | [optional] 
 **templateCategoryId** | **string**|  | [optional] 
 **templateIndustryId** | **string**|  | [optional] 
 **searchQuery** | **string**|  | [optional] 
 **sortBy** | **string**|  | [optional] 

### Return type

[**List<TemplateConfigurationModel>**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getavailabletemplateindustries"></a>
# **GetAvailableTemplateIndustries**
> List<TemplateIndustryModel> GetAvailableTemplateIndustries ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAvailableTemplateIndustriesExample
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

            var apiInstance = new TemplateConfigurationApi();

            try
            {
                List&lt;TemplateIndustryModel&gt; result = apiInstance.GetAvailableTemplateIndustries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.GetAvailableTemplateIndustries: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TemplateIndustryModel>**](TemplateIndustryModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorganizationtemplateconfigurations"></a>
# **GetOrganizationTemplateConfigurations**
> List<TemplateConfigurationModel> GetOrganizationTemplateConfigurations (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetOrganizationTemplateConfigurationsExample
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

            var apiInstance = new TemplateConfigurationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;TemplateConfigurationModel&gt; result = apiInstance.GetOrganizationTemplateConfigurations(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.GetOrganizationTemplateConfigurations: " + e.Message );
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

[**List<TemplateConfigurationModel>**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorganizationswithaccesstotemplate"></a>
# **GetOrganizationsWithAccessToTemplate**
> List<TemplateOrganizationAccessModel> GetOrganizationsWithAccessToTemplate (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetOrganizationsWithAccessToTemplateExample
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

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                List&lt;TemplateOrganizationAccessModel&gt; result = apiInstance.GetOrganizationsWithAccessToTemplate(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.GetOrganizationsWithAccessToTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 

### Return type

[**List<TemplateOrganizationAccessModel>**](TemplateOrganizationAccessModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getprivatetemplateconfigurations"></a>
# **GetPrivateTemplateConfigurations**
> List<TemplateConfigurationModel> GetPrivateTemplateConfigurations (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetPrivateTemplateConfigurationsExample
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

            var apiInstance = new TemplateConfigurationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;TemplateConfigurationModel&gt; result = apiInstance.GetPrivateTemplateConfigurations(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.GetPrivateTemplateConfigurations: " + e.Message );
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

[**List<TemplateConfigurationModel>**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="revoketemplateaccess"></a>
# **RevokeTemplateAccess**
> TemplateOrganizationAccessModel RevokeTemplateAccess (string templateConfigurationId, string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RevokeTemplateAccessExample
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

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 
            var organizationId = organizationId_example;  // string | 

            try
            {
                TemplateOrganizationAccessModel result = apiInstance.RevokeTemplateAccess(templateConfigurationId, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.RevokeTemplateAccess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 
 **organizationId** | **string**|  | 

### Return type

[**TemplateOrganizationAccessModel**](TemplateOrganizationAccessModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetemplateconfiguration"></a>
# **UpdateTemplateConfiguration**
> TemplateConfigurationModel UpdateTemplateConfiguration (string templateConfigurationId, TemplateConfigurationModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateTemplateConfigurationExample
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

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 
            var body = new TemplateConfigurationModel(); // TemplateConfigurationModel |  (optional) 

            try
            {
                TemplateConfigurationModel result = apiInstance.UpdateTemplateConfiguration(templateConfigurationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.UpdateTemplateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 
 **body** | [**TemplateConfigurationModel**](TemplateConfigurationModel.md)|  | [optional] 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer), [X-Api-Key](../README.md#X-Api-Key)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
