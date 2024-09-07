using System;
using test_maui_app.api;

namespace test_maui_app.ViewModels;

public class MainPageViewModel : BaseViewModel
{
    private int _counter = 0;
    public Command IncrementCounter { get; }
    public Command DecrementCounter { get; }
    public Command LoadProducts { get; }

    private List<Product> _products = new List<Product>();

    public MainPageViewModel()
    {
        IncrementCounter = new Command(() => Counter++, () => Counter < 10);
        DecrementCounter = new Command(() => Counter--, () => Counter > 0);
        LoadProducts=new Command(async ()=>{
            Products.Clear();
            Products=await MainPageApi.GetProducts()??new List<Product>();
        });
    }

    public int Counter
    {
        get => _counter;
        set
        {
            SetProperty(ref _counter, value);
            IncrementCounter.ChangeCanExecute();
            DecrementCounter.ChangeCanExecute();
        }
    }
    
    public List<Product> Products
    {
        get => _products;
        set => SetProperty(ref _products, value);
    }
}
