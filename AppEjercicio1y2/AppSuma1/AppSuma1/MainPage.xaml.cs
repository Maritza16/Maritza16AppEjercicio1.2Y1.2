using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSuma1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            Modelos.Operaciones OP = new Modelos.Operaciones();
            OP.n1 = Convert.ToInt32(txtnum1.Text);
            OP.n2 = Convert.ToInt32(txtnum2.Text);
            await Navigation.PushAsync(new ResultadoPage(Convert.ToInt32(OP.n1 + OP.n2)));

           // await DisplayAlert("Suma Es: ", Convert.ToString(nume1+nume2), "Ok"); 
        }

        private async void Multiplicacion(object sender, EventArgs e)
        {
            Modelos.Operaciones OP = new Modelos.Operaciones();
            OP.n1 = Convert.ToInt32(txtnum1.Text);
            OP.n2 = Convert.ToInt32(txtnum2.Text);
            await Navigation.PushAsync(new ResultadoPage(Convert.ToInt32(OP.n1 * OP.n2)));
            //await DisplayAlert("Multiplicacion  Es: ", Convert.ToString(nume1 * nume2), "Ok");
        }

        private async void Resta(object sender, EventArgs e)
        {
            Modelos.Operaciones OP = new Modelos.Operaciones();
            OP.n1 = Convert.ToInt32(txtnum1.Text);
            OP.n2 = Convert.ToInt32(txtnum2.Text);
            await Navigation.PushAsync(new ResultadoPage(Convert.ToInt32(OP.n1 - OP.n2)));
          //  await DisplayAlert("Resta Es: ", Convert.ToString(nume1 - nume2), "Ok");
        }

        private async void Divisiones(object sender, EventArgs e)
        {
            Modelos.Operaciones OP = new Modelos.Operaciones();
            OP.n1= Convert.ToInt32(txtnum1.Text);
            OP.n2 = Convert.ToInt32(txtnum2.Text);
            await Navigation.PushAsync(new ResultadoPage(Convert.ToInt32(OP.n1 / OP.n2)));
          //  await DisplayAlert("Division Es: ", Convert.ToString(OP.n1 / OP.n2), "Ok");
        }
        
       
    }
}
