using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSuma1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contactos : ContentPage
    {
        public Contactos()
        {
            InitializeComponent();
        }

        private async void OpPanC_Clicked(object sender, EventArgs e)
        {
            var contacto = new Modelos.Personas
            {
                nombre = txtname.Text,
            apellido=txtAp.Text,
            edad=Convert.ToInt32(txtEdad.Text),
            correo=txtCor.Text
      
            };

            var PageCont = new ResultadoCont();
            PageCont.BindingContext = contacto;
            await Navigation.PushAsync(PageCont);
        }
    }
}