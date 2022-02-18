using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using JogoVelhaMobile.Views;
using JogoDaVelhaXamarin.ViewModels;

namespace JogoVelhaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IATelaJogo : ContentPage
    {
        public TelaJogoViewModel jogoViewModel = new TelaJogoViewModel();
        public bool escolhaJogador;
        public bool jogoIniciado = false;

        public IATelaJogo()
        {
            InitializeComponent();
            BindingContext = jogoViewModel;
            Iniciar();
            jogoViewModel.atribuiCaracteres(escolhaJogador);
        }
        private async void button_Clicked(object sender, EventArgs e)
        {

            Button botao = sender as Button;
            botao.Text = jogoViewModel.IAvalidaCaractere(botao.ClassId);
            bool resultado = await jogoViewModel.validaResultado(button1.Text, button2.Text, button3.Text, button4.Text, button5.Text, button6.Text, button7.Text, button8.Text, button9.Text);
            if (resultado)
            {
                voltaBotoes();
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
            }
            else
            {
                jogoViewModel.IAJogada();
                resultado = await jogoViewModel.validaResultado(button1.Text, button2.Text, button3.Text, button4.Text, button5.Text, button6.Text, button7.Text, button8.Text, button9.Text);
                if (resultado)
                {
                    voltaBotoes();
                    button1.Text = "";
                    button2.Text = "";
                    button3.Text = "";
                    button4.Text = "";
                    button5.Text = "";
                    button6.Text = "";
                    button7.Text = "";
                    button8.Text = "";
                    button9.Text = "";
                }
                if (jogoViewModel.Vencedor != "")
                {
                    button1.Clicked -= button_Clicked;
                    button2.Clicked -= button_Clicked;
                    button3.Clicked -= button_Clicked;
                    button4.Clicked -= button_Clicked;
                    button5.Clicked -= button_Clicked;
                    button6.Clicked -= button_Clicked;
                    button7.Clicked -= button_Clicked;
                    button8.Clicked -= button_Clicked;
                    button9.Clicked -= button_Clicked;
                }
                else
                {
                    botao.Clicked -= button_Clicked;
                }
            }

            if (jogoViewModel.ContadorX >= 10)
                lblX.BackgroundColor = Color.Transparent;
            if (jogoViewModel.ContadorO >= 10)
                lblO.BackgroundColor = Color.Transparent;
        }



        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            button1.Clicked += button_Clicked;
            button2.Clicked += button_Clicked;
            button3.Clicked += button_Clicked;
            button4.Clicked += button_Clicked;
            button5.Clicked += button_Clicked;
            button6.Clicked += button_Clicked;
            button7.Clicked += button_Clicked;
            button8.Clicked += button_Clicked;
            button9.Clicked += button_Clicked;
            jogoViewModel.Vencedor = "";
            jogoIniciado = false;
        }

        public void voltaBotoes()
        {
            if (jogoViewModel.Vencedor != "")
            {
                button1.Clicked += button_Clicked;
                button2.Clicked += button_Clicked;
                button3.Clicked += button_Clicked;
                button4.Clicked += button_Clicked;
                button5.Clicked += button_Clicked;
                button6.Clicked += button_Clicked;
                button7.Clicked += button_Clicked;
                button8.Clicked += button_Clicked;
                button9.Clicked += button_Clicked;
                jogoViewModel.Vencedor = "";
                jogoIniciado = false;
            }
        }

        public async void Iniciar()
        {
            if (jogoIniciado == false)
            {
                escolhaJogador = await DisplayAlert("Vamos começar!!", "Escolha quem você quer ser:", "X", "O");
                jogoIniciado = true;
            }
        }

    }
}