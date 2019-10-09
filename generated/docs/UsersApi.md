# AmphoraData.Client.Api.UsersApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiUsersPost**](UsersApi.md#apiuserspost) | **POST** /api/users | Creates a new User. Returns the password.
[**ApiUsersSelfGet**](UsersApi.md#apiusersselfget) | **GET** /api/users/self | Get&#39;s logged in users information.
[**ApiUsersUsernameDelete**](UsersApi.md#apiusersusernamedelete) | **DELETE** /api/users/{username} | Deletes a user


<a name="apiuserspost"></a>
# **ApiUsersPost**
> string ApiUsersPost (UserDto userDto = null)

Creates a new User. Returns the password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiUsersPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new UsersApi(Configuration.Default);
            var userDto = new UserDto(); // UserDto |  (optional) 

            try
            {
                // Creates a new User. Returns the password.
                string result = apiInstance.ApiUsersPost(userDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersPost: " + e.Message );
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
 **userDto** | [**UserDto**](UserDto.md)|  | [optional] 

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

<a name="apiusersselfget"></a>
# **ApiUsersSelfGet**
> UserDto ApiUsersSelfGet ()

Get's logged in users information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiUsersSelfGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);

            try
            {
                // Get's logged in users information.
                UserDto result = apiInstance.ApiUsersSelfGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersSelfGet: " + e.Message );
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

[**UserDto**](UserDto.md)

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

<a name="apiusersusernamedelete"></a>
# **ApiUsersUsernameDelete**
> void ApiUsersUsernameDelete (string userName)

Deletes a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiUsersUsernameDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var userName = userName_example;  // string | UserName of user to delete. (default to "")

            try
            {
                // Deletes a user
                apiInstance.ApiUsersUsernameDelete(userName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersUsernameDelete: " + e.Message );
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
 **userName** | **string**| UserName of user to delete. | [default to &quot;&quot;]

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

