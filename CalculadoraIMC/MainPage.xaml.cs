using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) &&
                !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura); //PESO EN KILOGRAMOS Y ALTURA EN METRO.
                IMC.Text = imc.ToString();

                string resultado = "";

                if (imc < 16)
                {
                    resultado = "Desnutricion Servera";
                }
                else if (imc >= 16.1 && imc <= 18.4)
                {
                    resultado = "Desnutricion Moderada";
                }
                else if (imc >= 18.5 && imc <= 22)
                {
                    resultado = "Bajo Peso";
                }
                else if (imc >= 22.1 && imc < 25)
                {
                    resultado = "Peso Normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Sobre Peso";
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    resultado = "Obesidad Tipo I";
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    resultado = "Obesidad Tipo II";
                }
                else if (imc > 40)
                {
                    resultado = "Obesidad Tipo III";
                }
                else
                {
                    resultado = "Tienes Obesidad, !Tienes que Cuidarte Mucho!";
                }

                DisplayAlert("Resultado", resultado, "OK");
            }
            else
            {
                DisplayAlert("Datos Erroneos", "Rellena los Campos", "OK");
            }

        }
    }
}
