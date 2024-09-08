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
    }
}
