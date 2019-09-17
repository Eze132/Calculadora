using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonSoma_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonMultiplicar_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonSubtrair_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonApagar_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonIgual_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonDividir_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonUm_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(1);
        }

        private void ButtonDois_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(2);
        }

        private void ButtonTres_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(3);
        }

        private void ButtonQuatro_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(4);
        }

        private void ButtonCinco_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(5);
        }

        private void ButtonSeis_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(6);
        }

        private void ButtonSete_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(7);
        }

        private void ButtonOito_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(8);
        }

        private void ButtonNove_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(9);
        }

        private void ButtonZero_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = Convert.ToString(0);
        }
    }
}
