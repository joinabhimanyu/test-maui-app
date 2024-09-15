using test_maui_app.Models;
using test_maui_app.ViewModels;

namespace test_maui_app.Pages
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel? _viewModel = null;

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

        private void searchBtn_Pressed(object? sender, EventArgs e)
        {
            if (sender is not null)
            {
                _viewModel!.SearchProductsAsync.Execute(TxtSearch.Text);
                TxtSearch.Unfocus();
            }
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not CollectionView collectionView ||
                collectionView.SelectedItem is not Product selectedProduct) return;
            // handle selected item
            // ...
            var route = $"{nameof(ProductDetails)}?{nameof(ProductDetailsViewModel.ProductId)}={selectedProduct.Id}";
            await Shell.Current.GoToAsync(route);
            collectionView.SelectedItem = null;
        }
    }

}
