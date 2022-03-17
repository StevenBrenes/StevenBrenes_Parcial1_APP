using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StevenBrenes_Parcial1_APP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivosPage : ContentPage
    {
        public ActivosPage()
        {
            InitializeComponent();
        }

        private async void CmdActivoGuardar(object sender, EventArgs e)
        {
            
        }

        private async void CmdActivoCancelar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}