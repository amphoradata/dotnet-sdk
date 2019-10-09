# AmphoraData.Client.Api.AmphoraeApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAmphoraeIdDelete**](AmphoraeApi.md#apiamphoraeiddelete) | **DELETE** /api/amphorae/{id} | Deletes an Amphora
[**ApiAmphoraeIdFilesFileGet**](AmphoraeApi.md#apiamphoraeidfilesfileget) | **GET** /api/amphorae/{id}/files/{file} | Get&#39;s the contents of a file. Returns application/octet-stream
[**ApiAmphoraeIdFilesFilePut**](AmphoraeApi.md#apiamphoraeidfilesfileput) | **PUT** /api/amphorae/{id}/files/{file} | Set&#39;s the contents of a file. The request body becomes the content.
[**ApiAmphoraeIdFilesGet**](AmphoraeApi.md#apiamphoraeidfilesget) | **GET** /api/amphorae/{id}/files | Get&#39;s a list of an Amphora&#39;s files
[**ApiAmphoraeIdGet**](AmphoraeApi.md#apiamphoraeidget) | **GET** /api/amphorae/{id} | Get&#39;s details of an Amphora by Id
[**ApiAmphoraeIdPut**](AmphoraeApi.md#apiamphoraeidput) | **PUT** /api/amphorae/{id} | Updates the details of an Amphora by Id
[**ApiAmphoraeIdSignalsGet**](AmphoraeApi.md#apiamphoraeidsignalsget) | **GET** /api/amphorae/{id}/signals | Get&#39;s the signals associated with an Amphora.
[**ApiAmphoraeIdSignalsPost**](AmphoraeApi.md#apiamphoraeidsignalspost) | **POST** /api/amphorae/{id}/signals | Associates a signal with an Amphora. Signal is created if not existing.
[**ApiAmphoraeIdSignalsValuesPost**](AmphoraeApi.md#apiamphoraeidsignalsvaluespost) | **POST** /api/amphorae/{id}/signals/values | Get&#39;s the signals associated with an Amphora.
[**ApiAmphoraePost**](AmphoraeApi.md#apiamphoraepost) | **POST** /api/amphorae | Creates a new empty Amphora in the user&#39;s organisation


<a name="apiamphoraeiddelete"></a>
# **ApiAmphoraeIdDelete**
> void ApiAmphoraeIdDelete (string id)

Deletes an Amphora

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraeIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")

            try
            {
                // Deletes an Amphora
                apiInstance.ApiAmphoraeIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraeIdDelete: " + e.Message );
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

<a name="apiamphoraeidfilesfileget"></a>
# **ApiAmphoraeIdFilesFileGet**
> void ApiAmphoraeIdFilesFileGet (string id, string file)

Get's the contents of a file. Returns application/octet-stream

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraeIdFilesFileGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")
            var file = file_example;  // string | The name of the file (default to "")

            try
            {
                // Get's the contents of a file. Returns application/octet-stream
                apiInstance.ApiAmphoraeIdFilesFileGet(id, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraeIdFilesFileGet: " + e.Message );
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
 **file** | **string**| The name of the file | [default to &quot;&quot;]

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

<a name="apiamphoraeidfilesfileput"></a>
# **ApiAmphoraeIdFilesFilePut**
> void ApiAmphoraeIdFilesFilePut (string id, string file)

Set's the contents of a file. The request body becomes the content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraeIdFilesFilePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")
            var file = file_example;  // string | The name of the file (default to "")

            try
            {
                // Set's the contents of a file. The request body becomes the content.
                apiInstance.ApiAmphoraeIdFilesFilePut(id, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraeIdFilesFilePut: " + e.Message );
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
 **file** | **string**| The name of the file | [default to &quot;&quot;]

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

<a name="apiamphoraeidfilesget"></a>
# **ApiAmphoraeIdFilesGet**
> List&lt;string&gt; ApiAmphoraeIdFilesGet (string id)

Get's a list of an Amphora's files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraeIdFilesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")

            try
            {
                // Get's a list of an Amphora's files
                List<string> result = apiInstance.ApiAmphoraeIdFilesGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraeIdFilesGet: " + e.Message );
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

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiamphoraeidget"></a>
# **ApiAmphoraeIdGet**
> AmphoraExtendedDto ApiAmphoraeIdGet (string id)

Get's details of an Amphora by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraeIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")

            try
            {
                // Get's details of an Amphora by Id
                AmphoraExtendedDto result = apiInstance.ApiAmphoraeIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraeIdGet: " + e.Message );
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

[**AmphoraExtendedDto**](AmphoraExtendedDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiamphoraeidput"></a>
# **ApiAmphoraeIdPut**
> AmphoraExtendedDto ApiAmphoraeIdPut (string id, AmphoraExtendedDto amphoraExtendedDto = null)

Updates the details of an Amphora by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraeIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")
            var amphoraExtendedDto = new AmphoraExtendedDto(); // AmphoraExtendedDto |  (optional) 

            try
            {
                // Updates the details of an Amphora by Id
                AmphoraExtendedDto result = apiInstance.ApiAmphoraeIdPut(id, amphoraExtendedDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraeIdPut: " + e.Message );
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
 **amphoraExtendedDto** | [**AmphoraExtendedDto**](AmphoraExtendedDto.md)|  | [optional] 

### Return type

[**AmphoraExtendedDto**](AmphoraExtendedDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiamphoraeidsignalsget"></a>
# **ApiAmphoraeIdSignalsGet**
> List&lt;SignalDto&gt; ApiAmphoraeIdSignalsGet (string id)

Get's the signals associated with an Amphora.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraeIdSignalsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")

            try
            {
                // Get's the signals associated with an Amphora.
                List<SignalDto> result = apiInstance.ApiAmphoraeIdSignalsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraeIdSignalsGet: " + e.Message );
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

[**List&lt;SignalDto&gt;**](SignalDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiamphoraeidsignalspost"></a>
# **ApiAmphoraeIdSignalsPost**
> SignalDto ApiAmphoraeIdSignalsPost (string id, SignalDto signalDto = null)

Associates a signal with an Amphora. Signal is created if not existing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraeIdSignalsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")
            var signalDto = new SignalDto(); // SignalDto |  (optional) 

            try
            {
                // Associates a signal with an Amphora. Signal is created if not existing.
                SignalDto result = apiInstance.ApiAmphoraeIdSignalsPost(id, signalDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraeIdSignalsPost: " + e.Message );
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
 **signalDto** | [**SignalDto**](SignalDto.md)|  | [optional] 

### Return type

[**SignalDto**](SignalDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiamphoraeidsignalsvaluespost"></a>
# **ApiAmphoraeIdSignalsValuesPost**
> void ApiAmphoraeIdSignalsValuesPost (string id, Dictionary<string, Object> requestBody = null)

Get's the signals associated with an Amphora.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraeIdSignalsValuesPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var id = id_example;  // string | Amphora Id (default to "")
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> |  (optional) 

            try
            {
                // Get's the signals associated with an Amphora.
                apiInstance.ApiAmphoraeIdSignalsValuesPost(id, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraeIdSignalsValuesPost: " + e.Message );
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
 **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiamphoraepost"></a>
# **ApiAmphoraePost**
> AmphoraExtendedDto ApiAmphoraePost (CreateAmphoraDto createAmphoraDto = null)

Creates a new empty Amphora in the user's organisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AmphoraData.Client.Api;
using AmphoraData.Client.Client;
using AmphoraData.Client.Model;

namespace Example
{
    public class ApiAmphoraePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new AmphoraeApi(Configuration.Default);
            var createAmphoraDto = new CreateAmphoraDto(); // CreateAmphoraDto |  (optional) 

            try
            {
                // Creates a new empty Amphora in the user's organisation
                AmphoraExtendedDto result = apiInstance.ApiAmphoraePost(createAmphoraDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmphoraeApi.ApiAmphoraePost: " + e.Message );
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
 **createAmphoraDto** | [**CreateAmphoraDto**](CreateAmphoraDto.md)|  | [optional] 

### Return type

[**AmphoraExtendedDto**](AmphoraExtendedDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

