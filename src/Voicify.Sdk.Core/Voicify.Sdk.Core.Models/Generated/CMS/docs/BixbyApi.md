# IO.Swagger.Api.BixbyApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HandleCustomRequest**](BixbyApi.md#handlecustomrequest) | **POST** /api/Bixby/HandleRequest/Custom/{actionName} | 
[**HandleDynamicRequest**](BixbyApi.md#handledynamicrequest) | **POST** /api/Bixby/HandleRequest/Dynamic | 
[**HandleEventGeneralSearchRequest**](BixbyApi.md#handleeventgeneralsearchrequest) | **POST** /api/Bixby/HandleRequest/EventGeneralSearch | 
[**HandleEventLocationSearchRequest**](BixbyApi.md#handleeventlocationsearchrequest) | **POST** /api/Bixby/HandleRequest/EventLocationSearch | 
[**HandleEventStartTimeSearchRequest**](BixbyApi.md#handleeventstarttimesearchrequest) | **POST** /api/Bixby/HandleRequest/EventStartTimeSearch | 
[**HandleEventStatusSearchRequest**](BixbyApi.md#handleeventstatussearchrequest) | **POST** /api/Bixby/HandleRequest/EventStatusSearch | 
[**HandleGeneralQuestionRequest**](BixbyApi.md#handlegeneralquestionrequest) | **POST** /api/Bixby/HandleRequest/GeneralQuestion | 
[**HandleGoToStepRequest**](BixbyApi.md#handlegotosteprequest) | **POST** /api/Bixby/HandleRequest/GoToStep | 
[**HandleHelpRequest**](BixbyApi.md#handlehelprequest) | **POST** /api/Bixby/HandleRequest/Help | 
[**HandleLatestMessageRequest**](BixbyApi.md#handlelatestmessagerequest) | **POST** /api/Bixby/HandleRequest/LatestMessage | 
[**HandleListItemSelectRequest**](BixbyApi.md#handlelistitemselectrequest) | **POST** /api/Bixby/HandleRequest/ListItemSelect | 
[**HandleMoreRequest**](BixbyApi.md#handlemorerequest) | **POST** /api/Bixby/HandleRequest/More | 
[**HandleNextRequest**](BixbyApi.md#handlenextrequest) | **POST** /api/Bixby/HandleRequest/Next | 
[**HandleNoRequest**](BixbyApi.md#handlenorequest) | **POST** /api/Bixby/HandleRequest/No | 
[**HandleNumberRequest**](BixbyApi.md#handlenumberrequest) | **POST** /api/Bixby/HandleRequest/Number | 
[**HandlePrevisousRequest**](BixbyApi.md#handleprevisousrequest) | **POST** /api/Bixby/HandleRequest/Previous | 
[**HandleRecipeDetailsRequest**](BixbyApi.md#handlerecipedetailsrequest) | **POST** /api/Bixby/HandleRequest/RecipeDetails | 
[**HandleRecipeSearchRequest**](BixbyApi.md#handlerecipesearchrequest) | **POST** /api/Bixby/HandleRequest/RecipeSearch | 
[**HandleStartOverRequest**](BixbyApi.md#handlestartoverrequest) | **POST** /api/Bixby/HandleRequest/StartOver | 
[**HandleStartRequest**](BixbyApi.md#handlestartrequest) | **POST** /api/Bixby/HandleRequest/Start | 
[**HandleStopRequest**](BixbyApi.md#handlestoprequest) | **POST** /api/Bixby/HandleRequest/Stop | 
[**HandleWelcomeRequest**](BixbyApi.md#handlewelcomerequest) | **POST** /api/Bixby/HandleRequest/Welcome | 
[**HandleYesRequest**](BixbyApi.md#handleyesrequest) | **POST** /api/Bixby/HandleRequest/Yes | 


<a name="handlecustomrequest"></a>
# **HandleCustomRequest**
> BixbyResponse HandleCustomRequest (string actionName, string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleCustomRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var actionName = actionName_example;  // string | 
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleCustomRequest(actionName, applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleCustomRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionName** | **string**|  | 
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handledynamicrequest"></a>
# **HandleDynamicRequest**
> BixbyResponse HandleDynamicRequest (string applicationId = null, string applicationSecret = null, BixbyGeneralQuestionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleDynamicRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyGeneralQuestionRequest(); // BixbyGeneralQuestionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleDynamicRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleDynamicRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyGeneralQuestionRequest**](BixbyGeneralQuestionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleeventgeneralsearchrequest"></a>
# **HandleEventGeneralSearchRequest**
> BixbyResponse HandleEventGeneralSearchRequest (string applicationId = null, string applicationSecret = null, BixbyEventSearchRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleEventGeneralSearchRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyEventSearchRequest(); // BixbyEventSearchRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleEventGeneralSearchRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleEventGeneralSearchRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyEventSearchRequest**](BixbyEventSearchRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleeventlocationsearchrequest"></a>
# **HandleEventLocationSearchRequest**
> BixbyResponse HandleEventLocationSearchRequest (string applicationId = null, string applicationSecret = null, BixbyEventSearchRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleEventLocationSearchRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyEventSearchRequest(); // BixbyEventSearchRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleEventLocationSearchRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleEventLocationSearchRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyEventSearchRequest**](BixbyEventSearchRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleeventstarttimesearchrequest"></a>
# **HandleEventStartTimeSearchRequest**
> BixbyResponse HandleEventStartTimeSearchRequest (string applicationId = null, string applicationSecret = null, BixbyEventSearchRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleEventStartTimeSearchRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyEventSearchRequest(); // BixbyEventSearchRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleEventStartTimeSearchRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleEventStartTimeSearchRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyEventSearchRequest**](BixbyEventSearchRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleeventstatussearchrequest"></a>
# **HandleEventStatusSearchRequest**
> BixbyResponse HandleEventStatusSearchRequest (string applicationId = null, string applicationSecret = null, BixbyEventSearchRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleEventStatusSearchRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyEventSearchRequest(); // BixbyEventSearchRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleEventStatusSearchRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleEventStatusSearchRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyEventSearchRequest**](BixbyEventSearchRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlegeneralquestionrequest"></a>
# **HandleGeneralQuestionRequest**
> BixbyResponse HandleGeneralQuestionRequest (string applicationId = null, string applicationSecret = null, BixbyGeneralQuestionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleGeneralQuestionRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyGeneralQuestionRequest(); // BixbyGeneralQuestionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleGeneralQuestionRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleGeneralQuestionRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyGeneralQuestionRequest**](BixbyGeneralQuestionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlegotosteprequest"></a>
# **HandleGoToStepRequest**
> BixbyResponse HandleGoToStepRequest (string applicationId = null, string applicationSecret = null, BixbyGoToStepRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleGoToStepRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyGoToStepRequest(); // BixbyGoToStepRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleGoToStepRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleGoToStepRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyGoToStepRequest**](BixbyGoToStepRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlehelprequest"></a>
# **HandleHelpRequest**
> BixbyResponse HandleHelpRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleHelpRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleHelpRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleHelpRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlelatestmessagerequest"></a>
# **HandleLatestMessageRequest**
> BixbyResponse HandleLatestMessageRequest (string applicationId = null, string applicationSecret = null, BixbyLatestMessageRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleLatestMessageRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyLatestMessageRequest(); // BixbyLatestMessageRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleLatestMessageRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleLatestMessageRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyLatestMessageRequest**](BixbyLatestMessageRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlelistitemselectrequest"></a>
# **HandleListItemSelectRequest**
> BixbyResponse HandleListItemSelectRequest (string applicationId = null, string applicationSecret = null, BixbyItemSelectedRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleListItemSelectRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyItemSelectedRequest(); // BixbyItemSelectedRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleListItemSelectRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleListItemSelectRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyItemSelectedRequest**](BixbyItemSelectedRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlemorerequest"></a>
# **HandleMoreRequest**
> BixbyResponse HandleMoreRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleMoreRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleMoreRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleMoreRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlenextrequest"></a>
# **HandleNextRequest**
> BixbyResponse HandleNextRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleNextRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleNextRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleNextRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlenorequest"></a>
# **HandleNoRequest**
> BixbyResponse HandleNoRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleNoRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleNoRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleNoRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlenumberrequest"></a>
# **HandleNumberRequest**
> BixbyResponse HandleNumberRequest (string applicationId = null, string applicationSecret = null, BixbyNumberRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleNumberRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyNumberRequest(); // BixbyNumberRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleNumberRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleNumberRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyNumberRequest**](BixbyNumberRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleprevisousrequest"></a>
# **HandlePrevisousRequest**
> BixbyResponse HandlePrevisousRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandlePrevisousRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandlePrevisousRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandlePrevisousRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlerecipedetailsrequest"></a>
# **HandleRecipeDetailsRequest**
> BixbyResponse HandleRecipeDetailsRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleRecipeDetailsRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleRecipeDetailsRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleRecipeDetailsRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlerecipesearchrequest"></a>
# **HandleRecipeSearchRequest**
> BixbyResponse HandleRecipeSearchRequest (string applicationId = null, string applicationSecret = null, BixbyRecipeSearchRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleRecipeSearchRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyRecipeSearchRequest(); // BixbyRecipeSearchRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleRecipeSearchRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleRecipeSearchRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyRecipeSearchRequest**](BixbyRecipeSearchRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlestartoverrequest"></a>
# **HandleStartOverRequest**
> BixbyResponse HandleStartOverRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleStartOverRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleStartOverRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleStartOverRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlestartrequest"></a>
# **HandleStartRequest**
> BixbyResponse HandleStartRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleStartRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleStartRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleStartRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlestoprequest"></a>
# **HandleStopRequest**
> BixbyResponse HandleStopRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleStopRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleStopRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleStopRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handlewelcomerequest"></a>
# **HandleWelcomeRequest**
> BixbyResponse HandleWelcomeRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleWelcomeRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleWelcomeRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleWelcomeRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="handleyesrequest"></a>
# **HandleYesRequest**
> BixbyResponse HandleYesRequest (string applicationId = null, string applicationSecret = null, BixbyActionRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HandleYesRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyApi();
            var applicationId = applicationId_example;  // string |  (optional) 
            var applicationSecret = applicationSecret_example;  // string |  (optional) 
            var model = new BixbyActionRequest(); // BixbyActionRequest |  (optional) 

            try
            {
                BixbyResponse result = apiInstance.HandleYesRequest(applicationId, applicationSecret, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyApi.HandleYesRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | [optional] 
 **applicationSecret** | **string**|  | [optional] 
 **model** | [**BixbyActionRequest**](BixbyActionRequest.md)|  | [optional] 

### Return type

[**BixbyResponse**](BixbyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

