using System;
using System.Net.Http.Json;
using System.Text.Json;
using test_maui_app.ViewModels;

namespace test_maui_app.api;

public static class MainPageApi
{
    public static async Task<List<Product>?> GetProducts()
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://dummyjson.com/");
            var response = await client.GetAsync("products");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                // convert the result into a dictionary
                var productResponse = JsonSerializer.Deserialize<ProductResponse>(result);
                if (productResponse != null && productResponse!.products != null)
                {
                    return productResponse!.products!.ToList();
                }
                // or convert the result into a list of Product objects directly
                // var products = await response.Content.ReadFromJsonAsync<List<Product>>();
            }
        }
        return null;
    }

    public static async Task<Product?> GetProductById(int productId)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://dummyjson.com/");
            var response = await client.GetAsync($"products/{productId}");
            if (response.IsSuccessStatusCode)
            {
                var product = await response.Content.ReadFromJsonAsync<Product>();
                return product;
            }
        }
        return null;
    }
}
