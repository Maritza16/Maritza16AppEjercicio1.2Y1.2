using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSuma1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }
        private async void Pantala2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void OpPanC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vistas.Contactos());
        }
    }
}