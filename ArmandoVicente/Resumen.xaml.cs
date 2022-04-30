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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, double total)
        {
           
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblNombre.Text = nombre;
            lbTotalPAgar.Text = total.ToString();
        }
    }
}