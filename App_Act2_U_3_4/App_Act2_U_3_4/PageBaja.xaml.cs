using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace App_Act2_U_3_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageBaja : ContentPage
    {
        public PageBaja()
        {
            InitializeComponent();
        }
        private void EventoConsul(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        } 
        private void EventoBaja(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void EventoMenu(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}