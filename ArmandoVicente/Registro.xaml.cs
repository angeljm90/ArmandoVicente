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
    public partial class Registro : ContentPage
    {
        string usua = "", pass = "";
        double costo = 3000, cuota = 0, valorPendiente = 0, valorPendienteResultado= 0;
        public Registro(string usuario, string password)
        {
            InitializeComponent();
            usua = usuario;
            password = pass;
            lblUsuario.Text = usua;
        }

       

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                cuota =  Convert.ToDouble( txtCuota.Text);
            if (cuota> costo)
            {
                DisplayAlert("Info, ","El pago debe ser menor o igual a "+costo.ToString(), "Cancelar");
                return;
            }

            valorPendiente = costo - cuota;
            if (valorPendiente>0)
            {
                valorPendienteResultado =(valorPendiente / 5) + (costo*5/100);
                    txtMensual.Text = Math.Round(valorPendienteResultado).ToString();
            }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
          await  DisplayAlert("Info", "Elemento guardado con exito", "Cancelar");
            double suma = Convert.ToDouble(txtMensual.Text) + valorPendiente;
            await Navigation.PushAsync(new Resumen(usua, txtNombre.Text, suma));

        }

    }
}