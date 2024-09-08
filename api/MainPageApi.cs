using System;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using test_maui_app.Models;
using test_maui_app.ViewModels;

namespace test_maui_app.api;

public static class MainPageApi
{
    public static async Task<ObservableCollection<Product>?> GetProducts()
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://dummyjson.com/");
            var response = await client.GetAsync("products");
            if (response.IsSuccessStatusCode)
            {
                // var result = await response.Content.ReadAsStringAsync();
                var result = await response.Content.ReadFromJsonAsync<ProductResponse>();
                if (result != null && result!.products != null)
                {
                    return new ObservableCollection<Product>(result.products!);
                }
            }
        }
        return new ObservableCollection<Product>();
    }

    public static async Task<Product?> GetProductByIdAsync(int productId)
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

    public static async Task<ObservableCollection<Product>> SearchProductsAsync(string value)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://dummyjson.com/");
            var response = await client.GetAsync($"products/search?q={Uri.EscapeDataString(value)}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<ProductResponse>();
                if (result != null && result!.products != null)
                {
                    return new ObservableCollection<Product>(result.products!);
                }
            }
        }
        return new ObservableCollection<Product>();
    }
}
