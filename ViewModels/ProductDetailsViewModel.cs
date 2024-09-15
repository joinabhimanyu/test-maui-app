using System;
using test_maui_app.api;
using test_maui_app.Models;

namespace test_maui_app.ViewModels;

[QueryProperty("ProductId", "ProductId")]
public class ProductDetailsViewModel : BaseViewModel
{
    private int _productId;
    private Product? _product;
    private Command LoadProductDetailsAsync { get; }
    public Command AddProductToCartAsync { get; }

    public int ProductId
    {
        get => _productId;
        set
        {
            if (_productId == value) return;
            SetProperty(ref _productId, value);
            LoadProductDetailsAsync.Execute(null);
        }
    }
    public Product Product
    {
        get => _product!;
        private set => SetProperty(ref _product, value);
    }

    public ProductDetailsViewModel()
    {
        LoadProductDetailsAsync = new Command(ExecuteLoadProductDetailsAsync);
        AddProductToCartAsync = new Command(ExecuteAddProductToCart, CanExecute);
    }

    private bool CanExecute()
    {
        return Shell.Current is AppShell && ((Shell.Current as AppShell)!).CartItem.ViewModel.Items.All(x => x != _productId);
    }

    private void ExecuteAddProductToCart()
    {
        if (Shell.Current is AppShell appShell)
        {
            appShell.AddItemToCart(ProductId);
            AddProductToCartAsync.ChangeCanExecute();
        }
    }

    private async void ExecuteLoadProductDetailsAsync()
    {
        IsLoading = true;
        IsError = false;
        try
        {
            // var productId = (int)value;
            var product = await MainPageApi.GetProductByIdAsync(ProductId);
            if (product is not null)
            {
                Product = product;
            }
            else
            {
                IsError = true;
            }
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
}
