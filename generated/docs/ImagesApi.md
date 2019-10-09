# AmphoraData.Client.Api.ImagesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiOrganisationsIdProfileJpgGet**](ImagesApi.md#apiorganisationsidprofilejpgget) | **GET** /api/organisations/{id}/profile.jpg | Gets an organisations profile picture


<a name="apiorganisationsidprofilejpgget"></a>
# **ApiOrganisationsIdProfileJpgGet**
> void ApiOrganisationsIdProfileJpgGet (string id)

Gets an organisations profile picture

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiOrganisationsIdProfileJpgGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new ImagesApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")

            try
            {
                // Gets an organisations profile picture
                apiInstance.ApiOrganisationsIdProfileJpgGet(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImagesApi.ApiOrganisationsIdProfileJpgGet: " + e.Message );
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
 **id** | **string**| Amphora Id | [default to &quot;&quot;]

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

