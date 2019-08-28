# Org.OpenAPITools.Api.OpenApiApi

All URIs are relative to *http://192.168.99.100:5000/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OpenapiVersionOpenapiGet**](OpenApiApi.md#openapiversionopenapiget) | **GET** /openapi/{version}/_openapi | 


<a name="openapiversionopenapiget"></a>
# **OpenapiVersionOpenapiGet**
> Object OpenapiVersionOpenapiGet (string version)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OpenapiVersionOpenapiGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new OpenApiApi(Configuration.Default);
            var version = version_example;  // string | 

            try
            {
                Object result = apiInstance.OpenapiVersionOpenapiGet(version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OpenApiApi.OpenapiVersionOpenapiGet: " + e.Message );
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
 **version** | **string**|  | 

### Return type

**Object**

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item from Model |  -  |
| **404** | Not found |  -  |
| **500** | Fatal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

