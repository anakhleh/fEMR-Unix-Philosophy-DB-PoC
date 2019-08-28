# Org.OpenAPITools.Api.SubjectModelApiApi

All URIs are relative to *http://192.168.99.100:5000/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubjectGet**](SubjectModelApiApi.md#subjectget) | **GET** /subject/ | 
[**SubjectInfoGet**](SubjectModelApiApi.md#subjectinfoget) | **GET** /subject/_info | 
[**SubjectPkDelete**](SubjectModelApiApi.md#subjectpkdelete) | **DELETE** /subject/{pk} | 
[**SubjectPkGet**](SubjectModelApiApi.md#subjectpkget) | **GET** /subject/{pk} | 
[**SubjectPkPut**](SubjectModelApiApi.md#subjectpkput) | **PUT** /subject/{pk} | 
[**SubjectPost**](SubjectModelApiApi.md#subjectpost) | **POST** /subject/ | 


<a name="subjectget"></a>
# **SubjectGet**
> InlineResponse2002 SubjectGet (GetListSchema q = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectModelApiApi(Configuration.Default);
            var q = new GetListSchema(); // GetListSchema |  (optional) 

            try
            {
                InlineResponse2002 result = apiInstance.SubjectGet(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectModelApiApi.SubjectGet: " + e.Message );
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
 **q** | [**GetListSchema**](GetListSchema.md)|  | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Items from Model |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **422** | Could not process entity |  -  |
| **500** | Fatal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subjectinfoget"></a>
# **SubjectInfoGet**
> InlineResponse2003 SubjectInfoGet (GetInfoSchema q = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectInfoGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectModelApiApi(Configuration.Default);
            var q = new GetInfoSchema(); // GetInfoSchema |  (optional) 

            try
            {
                InlineResponse2003 result = apiInstance.SubjectInfoGet(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectModelApiApi.SubjectInfoGet: " + e.Message );
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
 **q** | [**GetInfoSchema**](GetInfoSchema.md)|  | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item from Model |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **422** | Could not process entity |  -  |
| **500** | Fatal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subjectpkdelete"></a>
# **SubjectPkDelete**
> InlineResponse404 SubjectPkDelete (int pk)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectPkDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectModelApiApi(Configuration.Default);
            var pk = 56;  // int | 

            try
            {
                InlineResponse404 result = apiInstance.SubjectPkDelete(pk);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectModelApiApi.SubjectPkDelete: " + e.Message );
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
 **pk** | **int**|  | 

### Return type

[**InlineResponse404**](InlineResponse404.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item deleted |  -  |
| **404** | Not found |  -  |
| **422** | Could not process entity |  -  |
| **500** | Fatal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subjectpkget"></a>
# **SubjectPkGet**
> InlineResponse2004 SubjectPkGet (int pk, GetItemSchema q = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectPkGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectModelApiApi(Configuration.Default);
            var pk = 56;  // int | 
            var q = new GetItemSchema(); // GetItemSchema |  (optional) 

            try
            {
                InlineResponse2004 result = apiInstance.SubjectPkGet(pk, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectModelApiApi.SubjectPkGet: " + e.Message );
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
 **pk** | **int**|  | 
 **q** | [**GetItemSchema**](GetItemSchema.md)|  | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item from Model |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |
| **422** | Could not process entity |  -  |
| **500** | Fatal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subjectpkput"></a>
# **SubjectPkPut**
> InlineResponse2005 SubjectPkPut (int pk, SubjectModelApiPut subjectModelApiPut)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectPkPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectModelApiApi(Configuration.Default);
            var pk = 56;  // int | 
            var subjectModelApiPut = new SubjectModelApiPut(); // SubjectModelApiPut | Model schema

            try
            {
                InlineResponse2005 result = apiInstance.SubjectPkPut(pk, subjectModelApiPut);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectModelApiApi.SubjectPkPut: " + e.Message );
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
 **pk** | **int**|  | 
 **subjectModelApiPut** | [**SubjectModelApiPut**](SubjectModelApiPut.md)| Model schema | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Item changed |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not found |  -  |
| **422** | Could not process entity |  -  |
| **500** | Fatal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subjectpost"></a>
# **SubjectPost**
> InlineResponse201 SubjectPost (SubjectModelApiPost subjectModelApiPost)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectModelApiApi(Configuration.Default);
            var subjectModelApiPost = new SubjectModelApiPost(); // SubjectModelApiPost | Model schema

            try
            {
                InlineResponse201 result = apiInstance.SubjectPost(subjectModelApiPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectModelApiApi.SubjectPost: " + e.Message );
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
 **subjectModelApiPost** | [**SubjectModelApiPost**](SubjectModelApiPost.md)| Model schema | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Item inserted |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **422** | Could not process entity |  -  |
| **500** | Fatal error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

