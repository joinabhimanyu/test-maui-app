using System;
using System.Collections.ObjectModel;
using test_maui_app.api;
using test_maui_app.Models;

namespace test_maui_app.ViewModels;

public class MainPageViewModel : BaseViewModel
{
    public Command LoadProductsAsync { get; }
    public Command SearchProductsAsync { get; }
    private ObservableCollection<Product> _products = new ObservableCollection<Product>();

    public MainPageViewModel()
    {
        LoadProductsAsync = new Command(async () =>
        {
            IsLoading = true;
            IsError = false;
            Products.Clear();
            try
            {
                Products = await MainPageApi.GetProducts() ?? new ObservableCollection<Product>();
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
        });

        SearchProductsAsync = new Command(async (object value) =>
        {
            var searchText = value as string;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                IsLoading = true;
                IsError = false;
                Products.Clear();
                try
                {
                    Products = await MainPageApi.SearchProductsAsync(searchText)?? new ObservableCollection<Product>();
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
        });
    }

    public ObservableCollection<Product> Products
    {
        get => _products;
        set => SetProperty(ref _products, value);
    }
}
