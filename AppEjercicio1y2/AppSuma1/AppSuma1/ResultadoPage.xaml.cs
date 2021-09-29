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
    public partial class ResultadoPage : ContentPage
    {
        public ResultadoPage(int Resulutado)
        {
            InitializeComponent();
            Resultado.Text = Resulutado.ToString();
        }
    }
}