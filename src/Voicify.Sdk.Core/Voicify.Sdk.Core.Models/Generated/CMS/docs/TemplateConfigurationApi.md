# Voicify.Sdk.Core.Models.Api.TemplateConfigurationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiTemplateConfigurationCategoriesGet**](TemplateConfigurationApi.md#apitemplateconfigurationcategoriesget) | **GET** /api/TemplateConfiguration/categories | 
[**ApiTemplateConfigurationIndustriesGet**](TemplateConfigurationApi.md#apitemplateconfigurationindustriesget) | **GET** /api/TemplateConfiguration/industries | 
[**ApiTemplateConfigurationInviteAcceptPost**](TemplateConfigurationApi.md#apitemplateconfigurationinviteacceptpost) | **POST** /api/TemplateConfiguration/invite/accept | 
[**ApiTemplateConfigurationInviteTemplateInviteIdDelete**](TemplateConfigurationApi.md#apitemplateconfigurationinvitetemplateinviteiddelete) | **DELETE** /api/TemplateConfiguration/invite/{templateInviteId} | 
[**ApiTemplateConfigurationOrganizationIdAvailableGet**](TemplateConfigurationApi.md#apitemplateconfigurationorganizationidavailableget) | **GET** /api/TemplateConfiguration/{organizationId}/available | 
[**ApiTemplateConfigurationOrganizationIdGet**](TemplateConfigurationApi.md#apitemplateconfigurationorganizationidget) | **GET** /api/TemplateConfiguration/{organizationId} | 
[**ApiTemplateConfigurationOrganizationIdPrivateGet**](TemplateConfigurationApi.md#apitemplateconfigurationorganizationidprivateget) | **GET** /api/TemplateConfiguration/{organizationId}/private | 
[**ApiTemplateConfigurationPost**](TemplateConfigurationApi.md#apitemplateconfigurationpost) | **POST** /api/TemplateConfiguration | 
[**ApiTemplateConfigurationTemplateConfigurationIdDelete**](TemplateConfigurationApi.md#apitemplateconfigurationtemplateconfigurationiddelete) | **DELETE** /api/TemplateConfiguration/{templateConfigurationId} | 
[**ApiTemplateConfigurationTemplateConfigurationIdDisablePut**](TemplateConfigurationApi.md#apitemplateconfigurationtemplateconfigurationiddisableput) | **PUT** /api/TemplateConfiguration/{templateConfigurationId}/disable | 
[**ApiTemplateConfigurationTemplateConfigurationIdEnablePut**](TemplateConfigurationApi.md#apitemplateconfigurationtemplateconfigurationidenableput) | **PUT** /api/TemplateConfiguration/{templateConfigurationId}/enable | 
[**ApiTemplateConfigurationTemplateConfigurationIdInvitePost**](TemplateConfigurationApi.md#apitemplateconfigurationtemplateconfigurationidinvitepost) | **POST** /api/TemplateConfiguration/{templateConfigurationId}/invite | 
[**ApiTemplateConfigurationTemplateConfigurationIdInvitesGet**](TemplateConfigurationApi.md#apitemplateconfigurationtemplateconfigurationidinvitesget) | **GET** /api/TemplateConfiguration/{templateConfigurationId}/invites | 
[**ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessGet**](TemplateConfigurationApi.md#apitemplateconfigurationtemplateconfigurationidorganizationaccessget) | **GET** /api/TemplateConfiguration/{templateConfigurationId}/organizationAccess | 
[**ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessOrganizationIdDelete**](TemplateConfigurationApi.md#apitemplateconfigurationtemplateconfigurationidorganizationaccessorganizationiddelete) | **DELETE** /api/TemplateConfiguration/{templateConfigurationId}/organizationAccess/{organizationId} | 
[**ApiTemplateConfigurationTemplateConfigurationIdPut**](TemplateConfigurationApi.md#apitemplateconfigurationtemplateconfigurationidput) | **PUT** /api/TemplateConfiguration/{templateConfigurationId} | 

<a name="apitemplateconfigurationcategoriesget"></a>
# **ApiTemplateConfigurationCategoriesGet**
> List<TemplateCategoryModel> ApiTemplateConfigurationCategoriesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationCategoriesGetExample
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
                List&lt;TemplateCategoryModel&gt; result = apiInstance.ApiTemplateConfigurationCategoriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationCategoriesGet: " + e.Message );
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
<a name="apitemplateconfigurationindustriesget"></a>
# **ApiTemplateConfigurationIndustriesGet**
> List<TemplateIndustryModel> ApiTemplateConfigurationIndustriesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationIndustriesGetExample
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
                List&lt;TemplateIndustryModel&gt; result = apiInstance.ApiTemplateConfigurationIndustriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationIndustriesGet: " + e.Message );
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
<a name="apitemplateconfigurationinviteacceptpost"></a>
# **ApiTemplateConfigurationInviteAcceptPost**
> TemplateConfigurationModel ApiTemplateConfigurationInviteAcceptPost (string organizationId = null, string accessCode = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationInviteAcceptPostExample
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
                TemplateConfigurationModel result = apiInstance.ApiTemplateConfigurationInviteAcceptPost(organizationId, accessCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationInviteAcceptPost: " + e.Message );
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
<a name="apitemplateconfigurationinvitetemplateinviteiddelete"></a>
# **ApiTemplateConfigurationInviteTemplateInviteIdDelete**
> TemplateInviteModel ApiTemplateConfigurationInviteTemplateInviteIdDelete (string templateInviteId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationInviteTemplateInviteIdDeleteExample
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
                TemplateInviteModel result = apiInstance.ApiTemplateConfigurationInviteTemplateInviteIdDelete(templateInviteId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationInviteTemplateInviteIdDelete: " + e.Message );
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
<a name="apitemplateconfigurationorganizationidavailableget"></a>
# **ApiTemplateConfigurationOrganizationIdAvailableGet**
> List<TemplateConfigurationModel> ApiTemplateConfigurationOrganizationIdAvailableGet (string organizationId, int? skip = null, int? take = null, TemplateType templateType = null, string templateCategoryId = null, string templateIndustryId = null, string searchQuery = null, string sortBy = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationOrganizationIdAvailableGetExample
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
                List&lt;TemplateConfigurationModel&gt; result = apiInstance.ApiTemplateConfigurationOrganizationIdAvailableGet(organizationId, skip, take, templateType, templateCategoryId, templateIndustryId, searchQuery, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationOrganizationIdAvailableGet: " + e.Message );
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
<a name="apitemplateconfigurationorganizationidget"></a>
# **ApiTemplateConfigurationOrganizationIdGet**
> List<TemplateConfigurationModel> ApiTemplateConfigurationOrganizationIdGet (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationOrganizationIdGetExample
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
                List&lt;TemplateConfigurationModel&gt; result = apiInstance.ApiTemplateConfigurationOrganizationIdGet(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationOrganizationIdGet: " + e.Message );
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
<a name="apitemplateconfigurationorganizationidprivateget"></a>
# **ApiTemplateConfigurationOrganizationIdPrivateGet**
> List<TemplateConfigurationModel> ApiTemplateConfigurationOrganizationIdPrivateGet (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationOrganizationIdPrivateGetExample
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
                List&lt;TemplateConfigurationModel&gt; result = apiInstance.ApiTemplateConfigurationOrganizationIdPrivateGet(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationOrganizationIdPrivateGet: " + e.Message );
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
<a name="apitemplateconfigurationpost"></a>
# **ApiTemplateConfigurationPost**
> TemplateConfigurationModel ApiTemplateConfigurationPost (TemplateConfigurationModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationPostExample
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
                TemplateConfigurationModel result = apiInstance.ApiTemplateConfigurationPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationPost: " + e.Message );
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
<a name="apitemplateconfigurationtemplateconfigurationiddelete"></a>
# **ApiTemplateConfigurationTemplateConfigurationIdDelete**
> TemplateConfigurationModel ApiTemplateConfigurationTemplateConfigurationIdDelete (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationTemplateConfigurationIdDeleteExample
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
                TemplateConfigurationModel result = apiInstance.ApiTemplateConfigurationTemplateConfigurationIdDelete(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationTemplateConfigurationIdDelete: " + e.Message );
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
<a name="apitemplateconfigurationtemplateconfigurationiddisableput"></a>
# **ApiTemplateConfigurationTemplateConfigurationIdDisablePut**
> TemplateConfigurationModel ApiTemplateConfigurationTemplateConfigurationIdDisablePut (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationTemplateConfigurationIdDisablePutExample
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
                TemplateConfigurationModel result = apiInstance.ApiTemplateConfigurationTemplateConfigurationIdDisablePut(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationTemplateConfigurationIdDisablePut: " + e.Message );
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
<a name="apitemplateconfigurationtemplateconfigurationidenableput"></a>
# **ApiTemplateConfigurationTemplateConfigurationIdEnablePut**
> TemplateConfigurationModel ApiTemplateConfigurationTemplateConfigurationIdEnablePut (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationTemplateConfigurationIdEnablePutExample
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
                TemplateConfigurationModel result = apiInstance.ApiTemplateConfigurationTemplateConfigurationIdEnablePut(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationTemplateConfigurationIdEnablePut: " + e.Message );
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
<a name="apitemplateconfigurationtemplateconfigurationidinvitepost"></a>
# **ApiTemplateConfigurationTemplateConfigurationIdInvitePost**
> TemplateInviteModel ApiTemplateConfigurationTemplateConfigurationIdInvitePost (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationTemplateConfigurationIdInvitePostExample
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
                TemplateInviteModel result = apiInstance.ApiTemplateConfigurationTemplateConfigurationIdInvitePost(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationTemplateConfigurationIdInvitePost: " + e.Message );
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
<a name="apitemplateconfigurationtemplateconfigurationidinvitesget"></a>
# **ApiTemplateConfigurationTemplateConfigurationIdInvitesGet**
> List<TemplateInviteModel> ApiTemplateConfigurationTemplateConfigurationIdInvitesGet (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationTemplateConfigurationIdInvitesGetExample
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
                List&lt;TemplateInviteModel&gt; result = apiInstance.ApiTemplateConfigurationTemplateConfigurationIdInvitesGet(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationTemplateConfigurationIdInvitesGet: " + e.Message );
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
<a name="apitemplateconfigurationtemplateconfigurationidorganizationaccessget"></a>
# **ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessGet**
> List<TemplateOrganizationAccessModel> ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessGet (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessGetExample
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
                List&lt;TemplateOrganizationAccessModel&gt; result = apiInstance.ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessGet(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessGet: " + e.Message );
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
<a name="apitemplateconfigurationtemplateconfigurationidorganizationaccessorganizationiddelete"></a>
# **ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessOrganizationIdDelete**
> TemplateOrganizationAccessModel ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessOrganizationIdDelete (string templateConfigurationId, string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessOrganizationIdDeleteExample
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
                TemplateOrganizationAccessModel result = apiInstance.ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessOrganizationIdDelete(templateConfigurationId, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationTemplateConfigurationIdOrganizationAccessOrganizationIdDelete: " + e.Message );
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
<a name="apitemplateconfigurationtemplateconfigurationidput"></a>
# **ApiTemplateConfigurationTemplateConfigurationIdPut**
> TemplateConfigurationModel ApiTemplateConfigurationTemplateConfigurationIdPut (string templateConfigurationId, TemplateConfigurationModel body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Core.Models.Api;
using Voicify.Sdk.Core.Models.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ApiTemplateConfigurationTemplateConfigurationIdPutExample
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
                TemplateConfigurationModel result = apiInstance.ApiTemplateConfigurationTemplateConfigurationIdPut(templateConfigurationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.ApiTemplateConfigurationTemplateConfigurationIdPut: " + e.Message );
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
