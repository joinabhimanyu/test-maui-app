using test_maui_app.ViewModels;

namespace test_maui_app;

public partial class ProductDetails : ContentPage
{
	private ProductDetailsViewModel _viewModel;
	public ProductDetails()
	{
		_viewModel = new ProductDetailsViewModel();
		BindingContext = _viewModel;
		InitializeComponent();
	}

    // protected override void OnAppearing()
    // {
    //     base.OnAppearing();
	// 	_viewModel.LoadProductDetailsAsync.Execute(null);
    // }
}