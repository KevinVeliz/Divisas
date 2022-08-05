using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConvertidorDeDivisas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Navigate(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Convertir());
        }
    }
}
