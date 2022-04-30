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
    public partial class Login : ContentPage
    {
        string usuario = "nombreEstudiante2022", pass = "uisrael2022";

        public Login()
        {
            InitializeComponent();
        }

        private async void registro_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text == usuario && txtContrasena.Text == pass)
            {
                await Navigation.PushAsync(new Registro(txtUsuario.Text, txtContrasena.Text));
            }
            else
            {
                await DisplayAlert("INFO", "Usuario o clave incorrecto", "OK");
            }
        }

       
    }
}