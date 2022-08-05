using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConvertidorDeDivisas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        public Convertir()
        {
            InitializeComponent();
        }

        
        private void Button_Back(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MainPage());
        }

        private void Pesos_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(Valor.Text);
            double n = n1 * 20.38;
            Result.Text =  n + " pesos mexicanos";
        } 

        private void Euros_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(Valor.Text);
            double n = n1 * 0.98;
            Result.Text =  n + " euros";
        }

        private void Libras_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(Valor.Text);
            double n = n1 * 0.82;
            Result.Text =  n + " libras esterlinas";
        }

        private void Soles_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(Valor.Text);
            double n = n1 * 3.93;
            
            Result.Text =  n + " soles";
        }

        private void Yenes_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(Valor.Text);
            double n = n1 * 133.33;
            Result.Text =  n + " yenes";
        }
    }
}