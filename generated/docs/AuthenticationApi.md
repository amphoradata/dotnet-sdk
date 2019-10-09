# AmphoraData.Client.Api.AuthenticationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAuthenticationRequestPost**](AuthenticationApi.md#apiauthenticationrequestpost) | **POST** /api/authentication/request | Returns a JWT (JSON Web Token).


<a name="apiauthenticationrequestpost"></a>
# **ApiAuthenticationRequestPost**
> string ApiAuthenticationRequestPost (TokenRequest tokenRequest = null)

Returns a JWT (JSON Web Token).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAuthenticationRequestPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AuthenticationApi(Configuration.Default);
            var tokenRequest = new TokenRequest(); // TokenRequest |  (optional) 

            try
            {
                // Returns a JWT (JSON Web Token).
                string result = apiInstance.ApiAuthenticationRequestPost(tokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.ApiAuthenticationRequestPost: " + e.Message );
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
 **tokenRequest** | [**TokenRequest**](TokenRequest.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

