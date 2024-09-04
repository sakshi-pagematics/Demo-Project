using System.Diagnostics;

namespace demo_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new HomePage();
        }
    }
}