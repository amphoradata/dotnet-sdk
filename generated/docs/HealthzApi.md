# AmphoraData.Client.Api.HealthzApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HealthzGet**](HealthzApi.md#healthzget) | **GET** /healthz | Health endpoint.


<a name="healthzget"></a>
# **HealthzGet**
> void HealthzGet ()

Health endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class HealthzGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new HealthzApi(Configuration.Default);

            try
            {
                // Health endpoint.
                apiInstance.HealthzGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthzApi.HealthzGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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

