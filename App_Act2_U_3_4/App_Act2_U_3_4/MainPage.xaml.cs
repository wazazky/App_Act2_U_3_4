using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Act2_U_3_4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void EventoAlta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageAlta());
        }
        private void EventoBaja(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageBaja());
        }
        private void EventoActu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageActu());
        }
        private void EventoConsu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageConsulta());
        }
    }
}
