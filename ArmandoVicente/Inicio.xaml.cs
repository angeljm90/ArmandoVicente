using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArmandoVicente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private async void IniciarSesion_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Info", "Bienvenido al examen, Parcial 1", "CANCELAR");
            await Navigation.PushAsync(new Login());
        }
    }
}