# AmphoraData.Client.Api.MarketApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiLocationFuzzyGet**](MarketApi.md#apilocationfuzzyget) | **GET** /api/location/fuzzy | Executes a fuzzy location search.
[**ApiMarketGet**](MarketApi.md#apimarketget) | **GET** /api/market | Finds Amphora using a fuzzy search
[**ApiMarketPurchasePost**](MarketApi.md#apimarketpurchasepost) | **POST** /api/market/purchase | Purchases an Amphora as the logged in user.


<a name="apilocationfuzzyget"></a>
# **ApiLocationFuzzyGet**
> FuzzySearchResponse ApiLocationFuzzyGet (string query = null)

Executes a fuzzy location search.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiLocationFuzzyGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new MarketApi(Configuration.Default);
            var query = query_example;  // string | Search Text (optional)  (default to "")

            try
            {
                // Executes a fuzzy location search.
                FuzzySearchResponse result = apiInstance.ApiLocationFuzzyGet(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketApi.ApiLocationFuzzyGet: " + e.Message );
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
 **query** | **string**| Search Text | [optional] [default to &quot;&quot;]

### Return type

[**FuzzySearchResponse**](FuzzySearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apimarketget"></a>
# **ApiMarketGet**
> List&lt;AmphoraDto&gt; ApiMarketGet (string query = null)

Finds Amphora using a fuzzy search

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiMarketGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new MarketApi(Configuration.Default);
            var query = query_example;  // string | Amphora Id (optional)  (default to "")

            try
            {
                // Finds Amphora using a fuzzy search
                List<AmphoraDto> result = apiInstance.ApiMarketGet(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketApi.ApiMarketGet: " + e.Message );
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
 **query** | **string**| Amphora Id | [optional] [default to &quot;&quot;]

### Return type

[**List&lt;AmphoraDto&gt;**](AmphoraDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apimarketpurchasepost"></a>
# **ApiMarketPurchasePost**
> void ApiMarketPurchasePost (string id = null)

Purchases an Amphora as the logged in user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiMarketPurchasePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new MarketApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (optional)  (default to "")

            try
            {
                // Purchases an Amphora as the logged in user.
                apiInstance.ApiMarketPurchasePost(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketApi.ApiMarketPurchasePost: " + e.Message );
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
 **id** | **string**| Amphora Id | [optional] [default to &quot;&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

