# AmphoraData.Client.Api.SearchApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiSearchAmphoraeByCreatorGet**](SearchApi.md#apisearchamphoraebycreatorget) | **GET** /api/search/amphorae/byCreator | Searches for Amphorae by creator.
[**ApiSearchAmphoraeByLocationGet**](SearchApi.md#apisearchamphoraebylocationget) | **GET** /api/search/amphorae/byLocation | Searches for Amphorae by loction.
[**ApiSearchAmphoraeByOrganisationGet**](SearchApi.md#apisearchamphoraebyorganisationget) | **GET** /api/search/amphorae/byOrganisation | Searches for Amphorae in an Organisation.
[**ApiSearchAmphoraePost**](SearchApi.md#apisearchamphoraepost) | **POST** /api/search/amphorae | Searches for Amphorae.


<a name="apisearchamphoraebycreatorget"></a>
# **ApiSearchAmphoraeByCreatorGet**
> List&lt;AmphoraDto&gt; ApiSearchAmphoraeByCreatorGet (string userName = null)

Searches for Amphorae by creator.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiSearchAmphoraeByCreatorGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchApi(Configuration.Default);
            var userName = userName_example;  // string | User Name of the creator (optional)  (default to "")

            try
            {
                // Searches for Amphorae by creator.
                List<AmphoraDto> result = apiInstance.ApiSearchAmphoraeByCreatorGet(userName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.ApiSearchAmphoraeByCreatorGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userName** | **string**| User Name of the creator | [optional] [default to &quot;&quot;]

### Return type

[**List&lt;AmphoraDto&gt;**](AmphoraDto.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisearchamphoraebylocationget"></a>
# **ApiSearchAmphoraeByLocationGet**
> List&lt;AmphoraDto&gt; ApiSearchAmphoraeByLocationGet (double? lat = null, double? lon = null, double? dist = null)

Searches for Amphorae by loction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiSearchAmphoraeByLocationGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchApi(Configuration.Default);
            var lat = 1.2D;  // double? | Latitude (optional) 
            var lon = 1.2D;  // double? | Longitude (optional) 
            var dist = 1.2D;  // double? | Distance from Latitude and Longitude in which to search (optional)  (default to 10D)

            try
            {
                // Searches for Amphorae by loction.
                List<AmphoraDto> result = apiInstance.ApiSearchAmphoraeByLocationGet(lat, lon, dist);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.ApiSearchAmphoraeByLocationGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lat** | **double?**| Latitude | [optional] 
 **lon** | **double?**| Longitude | [optional] 
 **dist** | **double?**| Distance from Latitude and Longitude in which to search | [optional] [default to 10D]

### Return type

[**List&lt;AmphoraDto&gt;**](AmphoraDto.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisearchamphoraebyorganisationget"></a>
# **ApiSearchAmphoraeByOrganisationGet**
> List&lt;AmphoraDto&gt; ApiSearchAmphoraeByOrganisationGet (string orgId = null)

Searches for Amphorae in an Organisation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiSearchAmphoraeByOrganisationGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchApi(Configuration.Default);
            var orgId = orgId_example;  // string | Organisation Id (optional)  (default to "")

            try
            {
                // Searches for Amphorae in an Organisation.
                List<AmphoraDto> result = apiInstance.ApiSearchAmphoraeByOrganisationGet(orgId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.ApiSearchAmphoraeByOrganisationGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgId** | **string**| Organisation Id | [optional] [default to &quot;&quot;]

### Return type

[**List&lt;AmphoraDto&gt;**](AmphoraDto.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apisearchamphoraepost"></a>
# **ApiSearchAmphoraePost**
> List&lt;AmphoraDto&gt; ApiSearchAmphoraePost (SearchParameters searchParameters = null)

Searches for Amphorae.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiSearchAmphoraePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SearchApi(Configuration.Default);
            var searchParameters = new SearchParameters(); // SearchParameters |  (optional) 

            try
            {
                // Searches for Amphorae.
                List<AmphoraDto> result = apiInstance.ApiSearchAmphoraePost(searchParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.ApiSearchAmphoraePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchParameters** | [**SearchParameters**](SearchParameters.md)|  | [optional] 

### Return type

[**List&lt;AmphoraDto&gt;**](AmphoraDto.md)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

