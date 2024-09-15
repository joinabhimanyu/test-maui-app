using test_maui_app.ViewModels;

namespace test_maui_app.Pages;

public partial class ProductDetails : ContentPage
{
	private readonly ProductDetailsViewModel _viewModel;
	public ProductDetails()
	{
		_viewModel = new ProductDetailsViewModel();
		BindingContext = _viewModel;
		InitializeComponent();
	}

    private void btnPurchase_Clicked(object sender, EventArgs e)
    {
		if (Shell.Current is AppShell appShell)
		{
			appShell.AddItemToCart(_viewModel.Product.Id);
		}
    }
}