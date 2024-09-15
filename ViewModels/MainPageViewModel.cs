using System;
using System.Collections.ObjectModel;
using test_maui_app.api;
using test_maui_app.Models;

namespace test_maui_app.ViewModels;

public class MainPageViewModel : BaseViewModel
{
    public Command LoadProductsAsync { get; }
    public Command SearchProductsAsync { get; }
    
    private ObservableCollection<Product> _products = [];

    public MainPageViewModel()
    {
        LoadProductsAsync = new Command(ExecuteLoadProductsAsync);
        SearchProductsAsync = new Command(ExecuteSearchProductsAsync);
    }

    private async void ExecuteSearchProductsAsync(object value)
    {
        var searchText = value as string;
        if (!string.IsNullOrWhiteSpace(searchText))
        {
            IsLoading = true;
            IsError = false;
            Products.Clear();
            try
            {
                Products = await MainPageApi.SearchProductsAsync(searchText) ?? [];
                IsError = false;
            }
            catch (System.Exception)
            {
                IsError = true;
                throw;
            }
            finally
            {
                IsLoading = false;
            }
        }
        else
        {
            LoadProductsAsync.Execute(null);
        }
    }

    private async void ExecuteLoadProductsAsync()
    {
        IsLoading = true;
        IsError = false;
        Products.Clear();
        try
        {
            Products = await MainPageApi.GetProducts() ?? [];
            IsError = false;
        }
        catch (System.Exception)
        {
            IsError = true;
            throw;
        }
        finally
        {
            IsLoading = false;
        }
    }

    public ObservableCollection<Product> Products
    {
        get => _products;
        set => SetProperty(ref _products, value);
    }
    
}
