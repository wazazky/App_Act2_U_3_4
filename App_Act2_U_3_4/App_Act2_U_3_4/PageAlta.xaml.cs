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
    public partial class PageAlta : ContentPage
    {
        public PageAlta()
        {
            InitializeComponent();
        }
        private void EventoMenu(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        } 
        private void EventoIngresar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void EventoNvoAlu(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
