using System.Collections.ObjectModel;
using test_maui_app.ViewModels;

namespace test_maui_app.Views;

public partial class CartWidget : ToolbarItem
{
	public readonly CartViewModel ViewModel;
	public CartWidget()
	{
		ViewModel = new CartViewModel();
		BindingContext = ViewModel;
		InitializeComponent();
	}
}