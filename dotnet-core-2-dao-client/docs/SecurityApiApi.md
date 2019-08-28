# Org.OpenAPITools.Api.SecurityApiApi

All URIs are relative to *http://192.168.99.100:5000/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SecurityLoginPost**](SecurityApiApi.md#securityloginpost) | **POST** /security/login | 
[**SecurityRefreshPost**](SecurityApiApi.md#securityrefreshpost) | **POST** /security/refresh | 


<a name="securityloginpost"></a>
# **SecurityLoginPost**
> InlineResponse200 SecurityLoginPost (InlineObject inlineObject)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityLoginPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            var apiInstance = new SecurityApiApi(Configuration.Default);
            var inlineObject = new InlineObject(); // InlineObject | 

            try
            {
                InlineResponse200 result = apiInstance.SecurityLoginPost(inlineObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApiApi.SecurityLoginPost: " + e.Message );
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
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Authentication Successful |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Fatal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityrefreshpost"></a>
# **SecurityRefreshPost**
> InlineResponse2001 SecurityRefreshPost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityRefreshPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt_refresh
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SecurityApiApi(Configuration.Default);

            try
            {
                InlineResponse2001 result = apiInstance.SecurityRefreshPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApiApi.SecurityRefreshPost: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[jwt_refresh](../README.md#jwt_refresh)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refresh Successful |  -  |
| **401** | Unauthorized |  -  |
| **500** | Fatal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

