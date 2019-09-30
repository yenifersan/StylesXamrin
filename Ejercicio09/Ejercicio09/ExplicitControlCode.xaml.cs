using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio09
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExplicitControlCode : ContentPage
    {
        public ExplicitControlCode()
        {
            var labelRedStyle = new Style(typeof(Label))
            {
                Setters = {new Setter { Property = Label.TextColorProperty, Value = Color.Red    }
                }
            };
            var labelGreenStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Green }
                }
            };
            var labelBlueStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Blue    }
                }
            };
            Content = new StackLayout
            {
                Children = {
                new Label { Text = "These labels", Style = labelRedStyle },
                new Label { Text = "are demonstrating", Style = labelGreenStyle },
                new Label { Text = "explicit styles,", Style = labelBlueStyle },
                new Label { Text = "and an explicit style override", Style = labelBlueStyle,
                            TextColor = Color.Teal }
            }
            };
        }
    }
}
