using DalluiApp.Views;

namespace DalluiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GenerationOptionsView();
        }
    }
}