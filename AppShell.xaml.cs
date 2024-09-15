using test_maui_app.Pages;

namespace test_maui_app
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // register routes
            Routing.RegisterRoute(nameof(ProductDetails), typeof(ProductDetails));
        }

        public void AddItemToCart(int id)
        {
            if (CartItem.ViewModel.Items.All(item => item != id))
            {
                CartItem.ViewModel.Items.Add(id);
            }
            // CartItem._viewModel.Items=CartItem._viewModel.Items;
        }
    }
}
