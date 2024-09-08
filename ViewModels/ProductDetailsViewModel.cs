using System;
using test_maui_app.api;
using test_maui_app.Models;

namespace test_maui_app.ViewModels;

[QueryProperty("ProductId", "ProductId")]
public class ProductDetailsViewModel : BaseViewModel
{
    private int _productId;
    private Product? _product;
    public Command LoadProductDetailsAsync { get; }

    public int ProductId
    {
        get => _productId;
        set
        {
            if (_productId != value)
            {
                SetProperty(ref _productId, value);
                LoadProductDetailsAsync.Execute(null);
            }
        }
    }
    public Product Product
    {
        get => _product!;
        set => SetProperty(ref _product, value);
    }
    public ProductDetailsViewModel()
    {
        LoadProductDetailsAsync = new Command(async () =>
        {
            IsLoading = true;
            IsError = false;
            try
            {
                // var productId = (int)value;
                var product = await MainPageApi.GetProductByIdAsync(ProductId);
                if (product is not null)
                {
                    Product=product;
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
        });
    }
}
