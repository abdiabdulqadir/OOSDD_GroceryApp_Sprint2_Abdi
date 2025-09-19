using Grocery.App.Views;

namespace Grocery.App
{
    public partial class App : Application
    {
        public App(LoginView view)
        {
            InitializeComponent();
            MainPage = view; // Start met login
        }
    }
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ContentPage
            {
                Content = new Label
                {
                    Text = "Hallo wereld 👋",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                }
            };
        }
    }
}
