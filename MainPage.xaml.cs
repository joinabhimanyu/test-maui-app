using test_maui_app.ViewModels;

namespace test_maui_app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
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
            _viewModel!.LoadProducts.Execute(null);
        }

        // private void OnCounterClicked(object sender, EventArgs e)
        // {
        //     count++;

        //     if (count == 1)
        //         CounterBtn.Text = $"Clicked {count} time";
        //     else
        //         CounterBtn.Text = $"Clicked {count} times";

        //     SemanticScreenReader.Announce(CounterBtn.Text);
        // }
    }

}
