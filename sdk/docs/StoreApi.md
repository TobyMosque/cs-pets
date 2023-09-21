# OpenApi.Pets.Sdk.Api.StoreApi

All URIs are relative to *https://petstore3.swagger.io/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteOrder**](StoreApi.md#deleteorder) | **DELETE** /store/order/{orderId} | Delete purchase order by ID |
| [**GetInventory**](StoreApi.md#getinventory) | **GET** /store/inventory | Returns pet inventories by status |
| [**GetOrderById**](StoreApi.md#getorderbyid) | **GET** /store/order/{orderId} | Find purchase order by ID |
| [**PlaceOrder**](StoreApi.md#placeorder) | **POST** /store/order | Place an order for a pet |

<a id="deleteorder"></a>
# **DeleteOrder**
> void DeleteOrder (long orderId)

Delete purchase order by ID

For valid response try integer IDs with value < 1000. Anything above 1000 or nonintegers will generate API errors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OpenApi.Pets.Sdk.Api;
using OpenApi.Pets.Sdk.Client;
using OpenApi.Pets.Sdk.Model;

namespace Example
{
    public class DeleteOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://petstore3.swagger.io/api/v3";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new StoreApi(httpClient, config, httpClientHandler);
            var orderId = 789L;  // long | ID of the order that needs to be deleted

            try
            {
                // Delete purchase order by ID
                apiInstance.DeleteOrder(orderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoreApi.DeleteOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete purchase order by ID
    apiInstance.DeleteOrderWithHttpInfo(orderId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StoreApi.DeleteOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **long** | ID of the order that needs to be deleted |  |

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
| **400** | Invalid ID supplied |  -  |
| **404** | Order not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinventory"></a>
# **GetInventory**
> Dictionary&lt;string, int&gt; GetInventory ()

Returns pet inventories by status

Returns a map of status codes to quantities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OpenApi.Pets.Sdk.Api;
using OpenApi.Pets.Sdk.Client;
using OpenApi.Pets.Sdk.Model;

namespace Example
{
    public class GetInventoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://petstore3.swagger.io/api/v3";
            // Configure API key authorization: api_key
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new StoreApi(httpClient, config, httpClientHandler);

            try
            {
                // Returns pet inventories by status
                Dictionary<string, int> result = apiInstance.GetInventory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoreApi.GetInventory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInventoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns pet inventories by status
    ApiResponse<Dictionary<string, int>> response = apiInstance.GetInventoryWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StoreApi.GetInventoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Dictionary<string, int>**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorderbyid"></a>
# **GetOrderById**
> Order GetOrderById (long orderId)

Find purchase order by ID

For valid response try integer IDs with value <= 5 or > 10. Other values will generate exceptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OpenApi.Pets.Sdk.Api;
using OpenApi.Pets.Sdk.Client;
using OpenApi.Pets.Sdk.Model;

namespace Example
{
    public class GetOrderByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://petstore3.swagger.io/api/v3";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new StoreApi(httpClient, config, httpClientHandler);
            var orderId = 789L;  // long | ID of order that needs to be fetched

            try
            {
                // Find purchase order by ID
                Order result = apiInstance.GetOrderById(orderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoreApi.GetOrderById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find purchase order by ID
    ApiResponse<Order> response = apiInstance.GetOrderByIdWithHttpInfo(orderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StoreApi.GetOrderByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **long** | ID of order that needs to be fetched |  |

### Return type

[**Order**](Order.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Invalid ID supplied |  -  |
| **404** | Order not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="placeorder"></a>
# **PlaceOrder**
> Order PlaceOrder (Order? order = null)

Place an order for a pet

Place a new order in the store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OpenApi.Pets.Sdk.Api;
using OpenApi.Pets.Sdk.Client;
using OpenApi.Pets.Sdk.Model;

namespace Example
{
    public class PlaceOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://petstore3.swagger.io/api/v3";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new StoreApi(httpClient, config, httpClientHandler);
            var order = new Order?(); // Order? |  (optional) 

            try
            {
                // Place an order for a pet
                Order result = apiInstance.PlaceOrder(order);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StoreApi.PlaceOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlaceOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Place an order for a pet
    ApiResponse<Order> response = apiInstance.PlaceOrderWithHttpInfo(order);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StoreApi.PlaceOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **order** | [**Order?**](Order?.md) |  | [optional]  |

### Return type

[**Order**](Order.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml, application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **405** | Invalid input |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
