using test_maui_app.Models;
using test_maui_app.ViewModels;

namespace test_maui_app
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel? _viewModel = null;

        public MainPage()
        {
            _viewModel = new MainPageViewModel();
            BindingContext = _viewModel;
            InitializeComponent();
        }

        // handle on load event
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // update UI
            _viewModel!.LoadProductsAsync.Execute(null);
        }

        private void searchBtn_Pressed(object sender, EventArgs e)
        {
            if (sender is not null)
            {
                _viewModel!.SearchProductsAsync.Execute(txtSearch.Text);
                txtSearch.Unfocus();
            }
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is CollectionView collectionView && collectionView.SelectedItem is Product selectedProduct)
            {
                // handle selected item
                // ...
                var route = $"{nameof(ProductDetails)}?{nameof(ProductDetailsViewModel.ProductId)}={selectedProduct.id}";
                await Shell.Current.GoToAsync(route);
                collectionView.SelectedItem = null;
            }
        }
    }

}
