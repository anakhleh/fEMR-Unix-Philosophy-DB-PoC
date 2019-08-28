# Org.OpenAPITools.Api.SubjectInfoModelApiApi

All URIs are relative to *http://192.168.99.100:5000/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SubjectinfoGet**](SubjectInfoModelApiApi.md#subjectinfoget) | **GET** /subjectinfo/ | 
[**SubjectinfoInfoGet**](SubjectInfoModelApiApi.md#subjectinfoinfoget) | **GET** /subjectinfo/_info | 
[**SubjectinfoPkDelete**](SubjectInfoModelApiApi.md#subjectinfopkdelete) | **DELETE** /subjectinfo/{pk} | 
[**SubjectinfoPkGet**](SubjectInfoModelApiApi.md#subjectinfopkget) | **GET** /subjectinfo/{pk} | 
[**SubjectinfoPkPut**](SubjectInfoModelApiApi.md#subjectinfopkput) | **PUT** /subjectinfo/{pk} | 
[**SubjectinfoPost**](SubjectInfoModelApiApi.md#subjectinfopost) | **POST** /subjectinfo/ | 


<a name="subjectinfoget"></a>
# **SubjectinfoGet**
> InlineResponse2006 SubjectinfoGet (GetListSchema q = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectinfoGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectInfoModelApiApi(Configuration.Default);
            var q = new GetListSchema(); // GetListSchema |  (optional) 

            try
            {
                InlineResponse2006 result = apiInstance.SubjectinfoGet(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectInfoModelApiApi.SubjectinfoGet: " + e.Message );
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

[**InlineResponse2006**](InlineResponse2006.md)

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

<a name="subjectinfoinfoget"></a>
# **SubjectinfoInfoGet**
> InlineResponse2003 SubjectinfoInfoGet (GetInfoSchema q = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectinfoInfoGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectInfoModelApiApi(Configuration.Default);
            var q = new GetInfoSchema(); // GetInfoSchema |  (optional) 

            try
            {
                InlineResponse2003 result = apiInstance.SubjectinfoInfoGet(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectInfoModelApiApi.SubjectinfoInfoGet: " + e.Message );
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

<a name="subjectinfopkdelete"></a>
# **SubjectinfoPkDelete**
> InlineResponse404 SubjectinfoPkDelete (int pk)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectinfoPkDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectInfoModelApiApi(Configuration.Default);
            var pk = 56;  // int | 

            try
            {
                InlineResponse404 result = apiInstance.SubjectinfoPkDelete(pk);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectInfoModelApiApi.SubjectinfoPkDelete: " + e.Message );
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

<a name="subjectinfopkget"></a>
# **SubjectinfoPkGet**
> InlineResponse2007 SubjectinfoPkGet (int pk, GetItemSchema q = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectinfoPkGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectInfoModelApiApi(Configuration.Default);
            var pk = 56;  // int | 
            var q = new GetItemSchema(); // GetItemSchema |  (optional) 

            try
            {
                InlineResponse2007 result = apiInstance.SubjectinfoPkGet(pk, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectInfoModelApiApi.SubjectinfoPkGet: " + e.Message );
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

[**InlineResponse2007**](InlineResponse2007.md)

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

<a name="subjectinfopkput"></a>
# **SubjectinfoPkPut**
> InlineResponse2008 SubjectinfoPkPut (int pk, SubjectInfoModelApiPut subjectInfoModelApiPut)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectinfoPkPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectInfoModelApiApi(Configuration.Default);
            var pk = 56;  // int | 
            var subjectInfoModelApiPut = new SubjectInfoModelApiPut(); // SubjectInfoModelApiPut | Model schema

            try
            {
                InlineResponse2008 result = apiInstance.SubjectinfoPkPut(pk, subjectInfoModelApiPut);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectInfoModelApiApi.SubjectinfoPkPut: " + e.Message );
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
 **subjectInfoModelApiPut** | [**SubjectInfoModelApiPut**](SubjectInfoModelApiPut.md)| Model schema | 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

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

<a name="subjectinfopost"></a>
# **SubjectinfoPost**
> InlineResponse2011 SubjectinfoPost (SubjectInfoModelApiPost subjectInfoModelApiPost)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SubjectinfoPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://192.168.99.100:5000/api/v1";
            // Configure HTTP basic authorization: jwt
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new SubjectInfoModelApiApi(Configuration.Default);
            var subjectInfoModelApiPost = new SubjectInfoModelApiPost(); // SubjectInfoModelApiPost | Model schema

            try
            {
                InlineResponse2011 result = apiInstance.SubjectinfoPost(subjectInfoModelApiPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubjectInfoModelApiApi.SubjectinfoPost: " + e.Message );
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
 **subjectInfoModelApiPost** | [**SubjectInfoModelApiPost**](SubjectInfoModelApiPost.md)| Model schema | 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

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

