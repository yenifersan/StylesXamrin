using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ejercicio09
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var buttonStyle = new Style(typeof(Button))
            {
                Setters = { new Setter { Property = Button.TextColorProperty,    Value = Color.Teal }
            }
            };
            //Resources = new ResourceDictionary();
            Resources.Add("buttonStyleCode", buttonStyle);

            MainPage = new NavigationPage(new ClassDemo());
     
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

