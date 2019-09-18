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

        private double n1 = 0;
        private double n2 = 0;
        private double resultado;
        private string operacao;

        private void ButtonSoma_Clicked(object sender, EventArgs e)
        {
            
           n1 = Convert.ToDouble(entryNumero.Text);
           operacao = "Soma";
           entryNumero.Text = "";

        }

        private void ButtonMultiplicar_Clicked(object sender, EventArgs e)
        {

            n1 = Convert.ToDouble(entryNumero.Text);
            operacao = "Multiplicar";
            entryNumero.Text = "";
        }

        private void ButtonSubtrair_Clicked(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(entryNumero.Text);
            operacao = "Subtrair";
            entryNumero.Text = "";
        }

        private void ButtonApagar_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = "";
            n1 = 0;
            n2 = 0;
            operacao = "";
        }

        private void ButtonIgual_Clicked(object sender, EventArgs e)
        {
            Contas c = new Contas();
            n2 = Convert.ToDouble(entryNumero.Text);
            switch (operacao)
            {
                case "Soma":
                    resultado = c.Soma(n1,n2);
                    entryNumero.Text = resultado.ToString();
                    break;


                case "Subtrair":
                    resultado = c.Subtrair(n1,n2);
                    entryNumero.Text = Convert.ToString(resultado);
                    break;


                case "Multiplicar":
                    resultado = c.Multiplicar(n1,n2);
                    entryNumero.Text = Convert.ToString(resultado);
                    break;


                case "Dividir":
                    resultado = c.Dividir(n1,n2);
                    entryNumero.Text = Convert.ToString(resultado);
                    break;

                default:
                    DisplayAlert("Ops...","HOUVE UM ERRO!\n TENTE NOVAMENTE","OK");
                    break;

            }
        }

        private void ButtonDividir_Clicked(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(entryNumero.Text);
            operacao = "Dividir";
            entryNumero.Text = "";
        }

        private void ButtonUm_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(1);
        }

        private void ButtonDois_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(2);
        }

        private void ButtonTres_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(3);
        }

        private void ButtonQuatro_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(4);
        }

        private void ButtonCinco_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(5);
        }

        private void ButtonSeis_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(6);
        }

        private void ButtonSete_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(7);
        }

        private void ButtonOito_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(8);
        }

        private void ButtonNove_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(9);
        }

        private void ButtonZero_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += Convert.ToString(0);
        }
    }
}
