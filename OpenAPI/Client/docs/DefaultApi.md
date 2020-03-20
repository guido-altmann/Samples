# OpenApiClient.Api.DefaultApi

All URIs are relative to *http://api.example.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductsGet**](DefaultApi.md#productsget) | **GET** /products | Returns a list of products.
[**ProductsPost**](DefaultApi.md#productspost) | **POST** /products | Creates a new product.
[**ProductsProductIdGet**](DefaultApi.md#productsproductidget) | **GET** /products/{productId} | Returns a product by ID.
[**UsersGet**](DefaultApi.md#usersget) | **GET** /users | Returns a list of users.
[**UsersPost**](DefaultApi.md#userspost) | **POST** /users | Creates a new user.
[**UsersUserIdGet**](DefaultApi.md#usersuseridget) | **GET** /users/{userId} | Returns a user by ID.


<a name="productsget"></a>
# **ProductsGet**
> List&lt;Product&gt; ProductsGet ()

Returns a list of products.

Optional extended description in CommonMark or HTML.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenApiClient.Api;
using OpenApiClient.Client;
using OpenApiClient.Model;

namespace Example
{
    public class ProductsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.example.com/v1";
            var apiInstance = new DefaultApi(config);

            try
            {
                // Returns a list of products.
                List<Product> result = apiInstance.ProductsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsGet: " + e.Message );
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

[**List&lt;Product&gt;**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON array of products |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productspost"></a>
# **ProductsPost**
> void ProductsPost (Product product)

Creates a new product.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenApiClient.Api;
using OpenApiClient.Client;
using OpenApiClient.Model;

namespace Example
{
    public class ProductsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.example.com/v1";
            var apiInstance = new DefaultApi(config);
            var product = new Product(); // Product | 

            try
            {
                // Creates a new product.
                apiInstance.ProductsPost(product);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsPost: " + e.Message );
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
 **product** | [**Product**](Product.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsproductidget"></a>
# **ProductsProductIdGet**
> Product ProductsProductIdGet (int productId)

Returns a product by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenApiClient.Api;
using OpenApiClient.Client;
using OpenApiClient.Model;

namespace Example
{
    public class ProductsProductIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.example.com/v1";
            var apiInstance = new DefaultApi(config);
            var productId = 56;  // int | 

            try
            {
                // Returns a product by ID.
                Product result = apiInstance.ProductsProductIdGet(productId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ProductsProductIdGet: " + e.Message );
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
 **productId** | **int**|  | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersget"></a>
# **UsersGet**
> List&lt;User&gt; UsersGet ()

Returns a list of users.

Optional extended description in CommonMark or HTML.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenApiClient.Api;
using OpenApiClient.Client;
using OpenApiClient.Model;

namespace Example
{
    public class UsersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.example.com/v1";
            var apiInstance = new DefaultApi(config);

            try
            {
                // Returns a list of users.
                List<User> result = apiInstance.UsersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UsersGet: " + e.Message );
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

[**List&lt;User&gt;**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON array of user names |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userspost"></a>
# **UsersPost**
> void UsersPost (User user)

Creates a new user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenApiClient.Api;
using OpenApiClient.Client;
using OpenApiClient.Model;

namespace Example
{
    public class UsersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.example.com/v1";
            var apiInstance = new DefaultApi(config);
            var user = new User(); // User | 

            try
            {
                // Creates a new user.
                apiInstance.UsersPost(user);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UsersPost: " + e.Message );
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
 **user** | [**User**](User.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridget"></a>
# **UsersUserIdGet**
> User UsersUserIdGet (int userId)

Returns a user by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenApiClient.Api;
using OpenApiClient.Client;
using OpenApiClient.Model;

namespace Example
{
    public class UsersUserIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.example.com/v1";
            var apiInstance = new DefaultApi(config);
            var userId = 56;  // int | 

            try
            {
                // Returns a user by ID.
                User result = apiInstance.UsersUserIdGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UsersUserIdGet: " + e.Message );
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
 **userId** | **int**|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The specified user ID is invalid (not a number). |  -  |
| **404** | A user with the specified ID was not found. |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

