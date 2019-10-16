# AmphoraData.Client.Api.OrganisationsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiOrganisationsIdDelete**](OrganisationsApi.md#apiorganisationsiddelete) | **DELETE** /api/organisations/{id} | Deletes an organisation.
[**ApiOrganisationsIdGet**](OrganisationsApi.md#apiorganisationsidget) | **GET** /api/organisations/{id} | Gets an organisation&#39;s details.
[**ApiOrganisationsIdInvitationsGet**](OrganisationsApi.md#apiorganisationsidinvitationsget) | **GET** /api/organisations/{id}/invitations | Accept an invitation to an organisation.
[**ApiOrganisationsIdInvitationsPost**](OrganisationsApi.md#apiorganisationsidinvitationspost) | **POST** /api/organisations/{id}/invitations | Invite a user/ email address to your organisation.
[**ApiOrganisationsIdPut**](OrganisationsApi.md#apiorganisationsidput) | **PUT** /api/organisations/{id} | Updates an organisation.
[**ApiOrganisationsPost**](OrganisationsApi.md#apiorganisationspost) | **POST** /api/organisations | Creates a new Organisation. This will assign the logged in user to the organisation.


<a name="apiorganisationsiddelete"></a>
# **ApiOrganisationsIdDelete**
> OrganisationDto ApiOrganisationsIdDelete (string id)

Deletes an organisation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiOrganisationsIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganisationsApi(Configuration.Default);
            var id = id_example;  // string | Organisation Id (default to "")

            try
            {
                // Deletes an organisation.
                OrganisationDto result = apiInstance.ApiOrganisationsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganisationsApi.ApiOrganisationsIdDelete: " + e.Message );
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
 **id** | **string**| Organisation Id | [default to &quot;&quot;]

### Return type

[**OrganisationDto**](OrganisationDto.md)

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

<a name="apiorganisationsidget"></a>
# **ApiOrganisationsIdGet**
> OrganisationDto ApiOrganisationsIdGet (string id)

Gets an organisation's details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiOrganisationsIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganisationsApi(Configuration.Default);
            var id = id_example;  // string | Organisation Id (default to "")

            try
            {
                // Gets an organisation's details.
                OrganisationDto result = apiInstance.ApiOrganisationsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganisationsApi.ApiOrganisationsIdGet: " + e.Message );
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
 **id** | **string**| Organisation Id | [default to &quot;&quot;]

### Return type

[**OrganisationDto**](OrganisationDto.md)

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

<a name="apiorganisationsidinvitationsget"></a>
# **ApiOrganisationsIdInvitationsGet**
> OrganisationDto ApiOrganisationsIdInvitationsGet (string id)

Accept an invitation to an organisation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiOrganisationsIdInvitationsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganisationsApi(Configuration.Default);
            var id = id_example;  // string | Organisation Id (default to "")

            try
            {
                // Accept an invitation to an organisation.
                OrganisationDto result = apiInstance.ApiOrganisationsIdInvitationsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganisationsApi.ApiOrganisationsIdInvitationsGet: " + e.Message );
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
 **id** | **string**| Organisation Id | [default to &quot;&quot;]

### Return type

[**OrganisationDto**](OrganisationDto.md)

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

<a name="apiorganisationsidinvitationspost"></a>
# **ApiOrganisationsIdInvitationsPost**
> void ApiOrganisationsIdInvitationsPost (string id, Invitation invitation = null)

Invite a user/ email address to your organisation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiOrganisationsIdInvitationsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganisationsApi(Configuration.Default);
            var id = id_example;  // string | Organisation Id (default to "")
            var invitation = new Invitation(); // Invitation |  (optional) 

            try
            {
                // Invite a user/ email address to your organisation.
                apiInstance.ApiOrganisationsIdInvitationsPost(id, invitation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganisationsApi.ApiOrganisationsIdInvitationsPost: " + e.Message );
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
 **id** | **string**| Organisation Id | [default to &quot;&quot;]
 **invitation** | [**Invitation**](Invitation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorganisationsidput"></a>
# **ApiOrganisationsIdPut**
> void ApiOrganisationsIdPut (string id, OrganisationDto organisationDto = null)

Updates an organisation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiOrganisationsIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganisationsApi(Configuration.Default);
            var id = id_example;  // string | Organisation Id (default to "")
            var organisationDto = new OrganisationDto(); // OrganisationDto |  (optional) 

            try
            {
                // Updates an organisation.
                apiInstance.ApiOrganisationsIdPut(id, organisationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganisationsApi.ApiOrganisationsIdPut: " + e.Message );
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
 **id** | **string**| Organisation Id | [default to &quot;&quot;]
 **organisationDto** | [**OrganisationDto**](OrganisationDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[token](../README.md#token)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiorganisationspost"></a>
# **ApiOrganisationsPost**
> OrganisationDto ApiOrganisationsPost (OrganisationDto organisationDto = null)

Creates a new Organisation. This will assign the logged in user to the organisation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiOrganisationsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganisationsApi(Configuration.Default);
            var organisationDto = new OrganisationDto(); // OrganisationDto |  (optional) 

            try
            {
                // Creates a new Organisation. This will assign the logged in user to the organisation.
                OrganisationDto result = apiInstance.ApiOrganisationsPost(organisationDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganisationsApi.ApiOrganisationsPost: " + e.Message );
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
 **organisationDto** | [**OrganisationDto**](OrganisationDto.md)|  | [optional] 

### Return type

[**OrganisationDto**](OrganisationDto.md)

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

