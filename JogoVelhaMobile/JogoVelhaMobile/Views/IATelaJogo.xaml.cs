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
        public TelaInicial telaInicial = new TelaInicial();
        public bool escolhaJogador;
        public string caracterJogador;
        public string caracterIA;

        public IATelaJogo()
        {
            InitializeComponent();
            BindingContext = jogoViewModel;
        }
        private async void button_Clicked(object sender, EventArgs e)
        {

            escolhaJogador = await Application.Current.MainPage.DisplayAlert("Vamos começar!!", "Escolha quem você quer ser:", "X", "O");
            atribuiCaracteres(escolhaJogador);
            try
            {
                Button botao = sender as Button;
                botao.Text = jogoViewModel.validaCaractere(botao.ClassId);
                bool resultado = await jogoViewModel.IAvalidaResultado(button1.Text, button2.Text, button3.Text, button4.Text, button5.Text, button6.Text, button7.Text, button8.Text, button9.Text);
            }
            catch (Exception ex)
            {

            }
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
            }
        }

        public void atribuiCaracteres(bool caracterEscolhido)
        {
            if (caracterEscolhido == true)
            {
                caracterJogador = "X";
                caracterIA = "O";
            }
            else
            {
                caracterJogador = "O";
                caracterIA = "X";
            }
        }
    }
}