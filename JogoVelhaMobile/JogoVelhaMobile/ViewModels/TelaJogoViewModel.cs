using JogoDaVelhaXamarin.Models;
using JogoDaVelhaXamarin.Views;
using JogoVelhaMobile;
using JogoVelhaMobile.Helpers;
using JogoVelhaMobile.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace JogoDaVelhaXamarin.ViewModels
{
    public class TelaJogoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string Last = "O";
        public string Vencedor = "";
        public string caracterJogador;
        public string caracterIA;

        public int contadorX;
        public int ContadorX
        {
            get => contadorX;
            set
            {
                contadorX = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ContadorX"));
            }
        }
        public int contadorO;
        public int ContadorO
        {
            get => contadorO;
            set
            {
                contadorO = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ContadorO"));
            }
        }


        public bool _PassouDeDez;
        public bool PassouDeDez
        {
            get => _PassouDeDez;
            set
            {
                _PassouDeDez = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(PassouDeDez)));
            }
        }

        public string buttonPadrao;
        public string ButtonPadrao
        {
            get => buttonPadrao;
            set
            {
                buttonPadrao = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ButtonPadrao)));
            }
        }

        public string button1;
        public string Button1
        {
            get => button1;
            set
            {
                button1 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Button1"));
            }
        }

        public string button2;
        public string Button2
        {
            get => button2;
            set
            {
                button2 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Button2"));
            }
        }

        public string button3;
        public string Button3
        {
            get => button3;
            set
            {
                button3 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Button3"));
            }
        }

        public string button4;
        public string Button4
        {
            get => button4;
            set
            {
                button4 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Button4"));
            }
        }

        public string button5;
        public string Button5
        {
            get => button5;
            set
            {
                button5 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Button5"));
            }
        }

        public string button6;
        public string Button6
        {
            get => button6;
            set
            {
                button6 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Button6"));
            }
        }

        public string button7;
        public string Button7
        {
            get => button7;
            set
            {
                button7 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Button7"));
            }
        }

        public string button8;
        public string Button8
        {
            get => button8;
            set
            {
                button8 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Button8"));
            }
        }

        public string button9;
        public string Button9
        {
            get => button9;
            set
            {
                button9 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Button9"));
            }
        }


        public TelaJogoViewModel()
        {

        }

        public async Task<bool> validaResultado(string btn1, string btn2, string btn3, string btn4, string btn5, string btn6, string btn7, string btn8, string btn9)
        {
            if ((Vencedor != "Vencedor:X") && (Vencedor != "Vencedor:O"))
            {
                //valida as linhas
                if ((btn1 == btn2) && (btn2 == btn3) && !string.IsNullOrWhiteSpace(btn1))
                {
                    if (btn2.ToString() != "")
                    {
                        Vencedor = Last;
                        Partida partida = new Partida()
                        {
                            Ganhador = "Jogador: " + Vencedor,
                            Data = DateTime.Now.ToString()
                        };
                        await App.Database.Insert(partida);

                        bool conf = await Application.Current.MainPage.DisplayAlert($"Fim de Jogo! Vencedor:{Vencedor}!", "Deseja reiniciar o jogo?", "Sim", "Não");

                        if (Vencedor == "X")
                        {
                            ContadorX++;
                            PassouDeDez = ContadorO > 10;
                            
                        }
                        else if (Vencedor == "O")
                        {
                            ContadorO++;
                            PassouDeDez = ContadorO > 10;
                            
                        }

                        if (conf)
                        {
                            resetJogo();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
                else if ((btn4 == btn5) && (btn5 == btn6) && !string.IsNullOrWhiteSpace(btn4))
                {
                    if (btn5.ToString() != "")
                    {
                        Vencedor = Last;
                        Partida partida = new Partida()
                        {
                            Ganhador = "Jogador: " + Vencedor,
                            Data = DateTime.Now.ToString()
                        };
                        await App.Database.Insert(partida);
                        bool conf = await Application.Current.MainPage.DisplayAlert($"Fim de Jogo! Vencedor:{Vencedor}!", "Deseja reiniciar o jogo?", "Sim", "Não");

                        if (Vencedor == "X")
                        {
                            ContadorX++;
                            PassouDeDez = ContadorO > 10;
                            
                        }
                        else if (Vencedor == "O")
                        {
                            ContadorO++;
                            PassouDeDez = ContadorO > 10;
                            
                        }

                        if (conf)
                        {
                            resetJogo();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
                else if ((btn7 == btn8) && (btn8 == btn9) && !string.IsNullOrWhiteSpace(btn7))
                {
                    if (btn8.ToString() != "")
                    {
                        Vencedor = Last;
                        Partida partida = new Partida()
                        {
                            Ganhador = "Jogador: " + Vencedor,
                            Data = DateTime.Now.ToString()
                        };
                        await App.Database.Insert(partida);
                        bool conf = await Application.Current.MainPage.DisplayAlert($"Fim de Jogo! Vencedor:{Vencedor}!", "Deseja reiniciar o jogo?", "Sim", "Não");

                        if (Vencedor == "X")
                        {
                            ContadorX++;
                            PassouDeDez = ContadorO > 10;
                            
                        }
                        else if (Vencedor == "O")
                        {
                            ContadorO++;
                            PassouDeDez = ContadorO > 10;
                            
                        }

                        if (conf)
                        {
                            resetJogo();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
                //valida as colunas
                else if ((btn1 == btn4) && (btn4 == btn7) && !string.IsNullOrWhiteSpace(btn1))
                {
                    if (btn4.ToString() != "")
                    {
                        Vencedor = Last;
                        Partida partida = new Partida()
                        {
                            Ganhador = "Jogador: " + Vencedor,
                            Data = DateTime.Now.ToString()
                        };
                        await App.Database.Insert(partida);
                        bool conf = await Application.Current.MainPage.DisplayAlert($"Fim de Jogo! Vencedor:{Vencedor}!", "Deseja reiniciar o jogo?", "Sim", "Não");

                        if (Vencedor == "X")
                        {
                            ContadorX++;
                            PassouDeDez = ContadorO > 10;
                            
                        }
                        else if (Vencedor == "O")
                        {
                            ContadorO++;
                            PassouDeDez = ContadorO > 10;
                            
                        }

                        if (conf)
                        {
                            resetJogo();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
                else if ((btn2 == btn5) && (btn5 == btn8) && !string.IsNullOrWhiteSpace(btn2))
                {
                    if (btn5.ToString() != "")
                    {
                        Vencedor = Last;
                        Partida partida = new Partida()
                        {
                            Ganhador = "Jogador: " + Vencedor,
                            Data = DateTime.Now.ToString()
                        };
                        await App.Database.Insert(partida);
                        bool conf = await Application.Current.MainPage.DisplayAlert($"Fim de Jogo! Vencedor:{Vencedor}!", "Deseja reiniciar o jogo?", "Sim", "Não");

                        if (Vencedor == "X")
                        {
                            ContadorX++;
                            PassouDeDez = ContadorO > 10;
                            
                        }
                        else if (Vencedor == "O")
                        {
                            ContadorO++;
                            PassouDeDez = ContadorO > 10;
                            
                        }

                        if (conf)
                        {
                            resetJogo();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
                else if ((btn3 == btn6) && (btn6 == btn9) && !string.IsNullOrWhiteSpace(btn3))
                {
                    if (btn6.ToString() != "")
                    {
                        Vencedor = Last;
                        Partida partida = new Partida()
                        {
                            Ganhador = "Jogador: " + Vencedor,
                            Data = DateTime.Now.ToString()
                        };
                        await App.Database.Insert(partida);

                        if (Vencedor == "X")
                        {
                            ContadorX++;
                            PassouDeDez = ContadorO > 10;
                            
                        }
                        else if (Vencedor == "O")
                        {
                            ContadorO++;
                            PassouDeDez = ContadorO > 10;
                            
                        }

                        bool conf = await Application.Current.MainPage.DisplayAlert($"Fim de Jogo! Vencedor:{Vencedor}!", "Deseja reiniciar o jogo?", "Sim", "Não");
                        if (conf)
                        {
                            resetJogo();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
                //valida as diagonais
                else if ((btn1 == btn5) && (btn5 == btn9) && !string.IsNullOrWhiteSpace(btn1))
                {
                    if (btn5.ToString() != "")
                    {
                        Vencedor = Last;
                        Partida partida = new Partida()
                        {
                            Ganhador = "Jogador: " + Vencedor,
                            Data = DateTime.Now.ToString()
                        };
                        await App.Database.Insert(partida);
                        bool conf = await Application.Current.MainPage.DisplayAlert($"Fim de Jogo! Vencedor:{Vencedor}!", "Deseja reiniciar o jogo?", "Sim", "Não");

                        if (Vencedor == "X")
                        {
                            ContadorX++;
                            PassouDeDez = ContadorO > 10;
                            
                        }
                        else if (Vencedor == "O")
                        {
                            ContadorO++;
                            PassouDeDez = ContadorO > 10;
                            
                        }

                        if (conf)
                        {
                            resetJogo();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
                else if ((btn3 == btn5) && (btn5 == btn7) && !string.IsNullOrWhiteSpace(btn3))
                {
                    if (btn5.ToString() != "")
                    {
                        Vencedor = Last;
                        Partida partida = new Partida()
                        {
                            Ganhador = "Jogador: " + Vencedor,
                            Data = DateTime.Now.ToString()
                        };
                        await App.Database.Insert(partida);
                        bool conf = await Application.Current.MainPage.DisplayAlert($"Fim de Jogo! Vencedor:{Vencedor}!", "Deseja reiniciar o jogo?", "Sim", "Não");

                        if (Vencedor == "X")
                        {
                            ContadorX++;
                        }
                        else if (Vencedor == "O")
                        {
                            ContadorO++;
                        }

                        if (conf)
                        {
                            resetJogo();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
                else if (!string.IsNullOrWhiteSpace(btn1) && !string.IsNullOrWhiteSpace(btn2) && !string.IsNullOrWhiteSpace(btn3) && !string.IsNullOrWhiteSpace(btn4) &&
                    !string.IsNullOrWhiteSpace(btn5) && !string.IsNullOrWhiteSpace(btn6) && !string.IsNullOrWhiteSpace(btn7) && !string.IsNullOrWhiteSpace(btn8) &&
                    !string.IsNullOrWhiteSpace(btn9))
                {
                    Vencedor = "Deu velha!";
                    Partida partida = new Partida()
                    {
                        Ganhador = "Jogador: " + Vencedor,
                        Data = DateTime.Now.ToString()
                    };
                    await App.Database.Insert(partida);
                    bool conf = await Application.Current.MainPage.DisplayAlert($"Fim de Jogo! Vencedor:{Vencedor}!", "Deseja reiniciar o jogo?", "Sim", "Não");
                    if (conf)
                    {
                        resetJogo();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public string validaCaractere(string buttonPadrao)
        {
            if (buttonPadrao == "1")
            {
                if (Last == "X")
                {
                    Last = "O";
                    Button1 = "O";
                    return Button1;
                }
                else if (Last == "O")
                {
                    Last = "X";
                    Button1 = "X";
                    return Button1;
                }
                else
                {
                    return Button1;
                }
            }

            if (buttonPadrao == "2")
            {
                if (Last == "X")
                {
                    Last = "O";
                    Button2 = "O";
                    return Button2;
                }
                else if (Last == "O")
                {
                    Last = "X";
                    Button2 = "X";
                    return Button2;
                }
                else
                {
                    return Button2;
                }
            }

            if (buttonPadrao == "3")
            {
                if (Last == "X")
                {
                    Last = "O";
                    Button3 = "O";
                    return Button3;
                }
                else if (Last == "O")
                {
                    Last = "X";
                    Button3 = "X";
                    return Button3;
                }
                else
                {
                    return Button3;
                }
            }

            if (buttonPadrao == "4")
            {
                if (Last == "X")
                {
                    Last = "O";
                    Button4 = "O";
                    return Button4;
                }
                else if (Last == "O")
                {
                    Last = "X";
                    Button4 = "X";
                    return Button4;
                }
                else
                {
                    return Button4;
                }
            }

            if (buttonPadrao == "5")
            {
                if (Last == "X")
                {
                    Last = "O";
                    Button5 = "O";
                    return Button5;
                }
                else if (Last == "O")
                {
                    Last = "X";
                    Button5 = "X";
                    return Button5;
                }
                else
                {
                    return Button5;
                }
            }

            if (buttonPadrao == "6")
            {
                if (Last == "X")
                {
                    Last = "O";
                    Button6 = "O";
                    return Button6;
                }
                else if (Last == "O")
                {
                    Last = "X";
                    Button6 = "X";
                    return Button6;
                }
                else
                {
                    return Button6;
                }
            }

            if (buttonPadrao == "7")
            {
                if (Last == "X")
                {
                    Last = "O";
                    Button7 = "O";
                    return Button7;
                }
                else if (Last == "O")
                {
                    Last = "X";
                    Button7 = "X";
                    return Button7;
                }
                else
                {
                    return Button7;
                }
            }

            if (buttonPadrao == "8")
            {
                if (Last == "X")
                {
                    Last = "O";
                    Button8 = "O";
                    return Button8;
                }
                else if (Last == "O")
                {
                    Last = "X";
                    Button8 = "X";
                    return Button8;
                }
                else
                {
                    return Button8;
                }
            }

            if (buttonPadrao == "9")
            {
                if (Last == "X")
                {
                    Last = "O";
                    Button9 = "O";
                    return Button9;
                }
                else if (Last == "O")
                {
                    Last = "X";
                    Button9 = "X";
                    return Button9;
                }
                else
                {
                    return Button9;
                }
            }
            return buttonPadrao;
        }
        public ICommand ReiniciarJogo
        {
            get => new Command(async () =>
            {
                try
                {
                    resetJogo();
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Ops", ex.Message, "OK");
                }
            });
        }

        public ICommand Voltar
        {
            get => new Command(async () =>
            {
                try
                {
                    App.Current.MainPage = new TelaInicial();
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Ops", ex.Message, "OK");
                }
            });
        }
        public void resetJogo()
        {
            Button1 = "";
            Button2 = "";
            Button3 = "";
            Button4 = "";
            Button5 = "";
            Button6 = "";
            Button7 = "";
            Button8 = "";
            Button9 = "";
        }

        public async Task<bool> IAJogada()
        {
            //Verifica jogada do Jogador
            //Valida primeira coluna
            if ((Button1 == caracterJogador) && (Button2 == caracterJogador) && string.IsNullOrEmpty(Button3))
            {
                Last = caracterIA;
                Button3 = caracterIA;
                return true;
            }
            if ((Button2 == caracterJogador) && (Button3 == caracterJogador) && string.IsNullOrEmpty(Button1))
            {
                Last = caracterIA;
                Button1 = caracterIA;
                return true;
            }
            if ((Button1 == caracterJogador) && (Button3 == caracterJogador) && string.IsNullOrEmpty(Button2))
            {
                Last = caracterIA;
                Button2 = caracterIA;
                return true;
            }
            //Valida segunda coluna
            if ((Button4 == caracterJogador) && (Button5 == caracterJogador) && string.IsNullOrEmpty(Button6))
            {
                Last = caracterIA;
                Button6 = caracterIA;
                return true;
            }
            if ((Button5 == caracterJogador) && (button6 == caracterJogador) && string.IsNullOrEmpty(Button4))
            {
                Last = caracterIA;
                Button4 = caracterIA;
                return true;
            }
            if ((Button4 == caracterJogador) && (Button6 == caracterJogador) && string.IsNullOrEmpty(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Valida terceira coluna
            if ((Button7 == caracterJogador) && (Button8 == caracterJogador) && string.IsNullOrEmpty(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            if ((Button8 == caracterJogador) && (Button9 == caracterJogador) && string.IsNullOrEmpty(Button7))
            {
                Last = caracterIA;
                Button7 = caracterIA;
                return true;
            }
            if ((Button7 == caracterJogador) && (Button9 == caracterJogador) && string.IsNullOrEmpty(Button8))
            {
                Last = caracterIA;
                Button8 = caracterIA;
                return true;
            }
            //Valida primeira linha
            if ((Button1 == caracterJogador) && (Button4 == caracterJogador) && string.IsNullOrEmpty(Button7))
            {
                Last = caracterIA;
                Button7 = caracterIA;
                return true;
            }
            if ((Button4 == caracterJogador) && (Button7 == caracterJogador) && string.IsNullOrEmpty(Button1))
            {
                Last = caracterIA;
                Button1 = caracterIA;
                return true;
            }
            if ((Button1 == caracterJogador) && (Button7 == caracterJogador) && string.IsNullOrEmpty(Button4))
            {
                Last = caracterIA;
                Button4 = caracterIA;
                return true;
            }
            //Valida segunda linha
            if ((Button2 == caracterJogador) && (Button5 == caracterJogador) && string.IsNullOrEmpty(Button8))
            {
                Last = caracterIA;
                Button8 = caracterIA;
                return true;
            }
            if ((Button5 == caracterJogador) && (Button8 == caracterJogador) && string.IsNullOrEmpty(Button2))
            {
                Last = caracterIA;
                Button2 = caracterIA;
                return true;
            }
            if ((Button2 == caracterJogador) && (Button8 == caracterJogador) && string.IsNullOrEmpty(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Valida terceira linha
            if ((Button3 == caracterJogador) && (Button6 == caracterJogador) && string.IsNullOrEmpty(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            if ((Button6 == caracterJogador) && (Button9 == caracterJogador) && string.IsNullOrEmpty(Button3))
            {
                Last = caracterIA;
                Button3 = caracterIA;
                return true;
            }
            if ((Button3 == caracterJogador) && (Button9 == caracterJogador) && string.IsNullOrEmpty(Button6))
            {
                Last = caracterIA;
                Button6 = caracterIA;
                return true;
            }
            //Valida diagonal 1
            if ((Button1 == caracterJogador) && (Button5 == caracterJogador) && string.IsNullOrEmpty(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            if ((Button5 == caracterJogador) && (Button9 == caracterJogador) && string.IsNullOrEmpty(Button1))
            {
                Last = caracterIA;
                Button1 = caracterIA;
                return true;
            }
            if ((Button1 == caracterJogador) && (Button9 == caracterJogador) && string.IsNullOrEmpty(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Valida diagonal 2
            if ((Button3 == caracterJogador) && (Button5 == caracterJogador) && string.IsNullOrEmpty(Button7))
            {
                Last = caracterIA;
                Button7 = caracterIA;
                return true;
            }
            if ((Button5 == caracterJogador) && (Button7 == caracterJogador) && string.IsNullOrEmpty(Button3))
            {
                Last = caracterIA;
                Button3 = caracterIA;
                return true;
            }
            if ((Button3 == caracterJogador) && (Button7 == caracterJogador) && string.IsNullOrEmpty(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }

            //Primeiros movimentos caso o adversário não esteja engatilhado
            if (string.IsNullOrWhiteSpace(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            else if (Button5 == caracterJogador)
            {
                if (string.IsNullOrWhiteSpace(Button1))
                {
                    Last = caracterIA;
                    Button1 = caracterIA;
                    return true;
                }
                if (string.IsNullOrWhiteSpace(Button7))
                {
                    Last = caracterIA;
                    Button7 = caracterIA;
                    return true;
                }
                if (string.IsNullOrWhiteSpace(Button3))
                {
                    Last = caracterIA;
                    Button3 = caracterIA;
                    return true;
                }
                if (string.IsNullOrWhiteSpace(Button9))
                {
                    Last = caracterIA;
                    Button9 = caracterIA;
                    return true;
                }
                if ((Button1 == caracterIA) && (Button9 == caracterIA) && string.IsNullOrWhiteSpace(Button3))
                {
                    Last = caracterIA;
                    Button3 = caracterIA;
                    return true;
                }
                else if ((Button1 == caracterIA) && (Button9 == caracterIA) && string.IsNullOrWhiteSpace(Button7))
                {
                    Last = caracterIA;
                    Button7 = caracterIA;
                    return true;
                }
            }
            //Valida primeira coluna
            if ((Button1 == caracterIA) && (Button2 == caracterIA) && string.IsNullOrEmpty(Button3))
            {
                Last = caracterIA;
                Button3 = caracterIA;
                return true;
            }
            if ((Button2 == caracterIA) && (Button3 == caracterIA) && string.IsNullOrEmpty(Button1))
            {
                Last = caracterIA;
                Button1 = caracterIA;
                return true;
            }
            if ((Button1 == caracterIA) && (Button3 == caracterIA) && string.IsNullOrEmpty(Button2))
            {
                Last = caracterIA;
                Button2 = caracterIA;
                return true;
            }
            //Valida segunda coluna
            if ((Button4 == caracterIA) && (Button5 == caracterIA) && string.IsNullOrEmpty(Button6))
            {
                Last = caracterIA;
                Button6 = caracterIA;
                return true;
            }
            if ((Button5 == caracterIA) && (button6 == caracterIA) && string.IsNullOrEmpty(Button4))
            {
                Last = caracterIA;
                Button4 = caracterIA;
                return true;
            }
            if ((Button4 == caracterIA) && (Button6 == caracterIA) && string.IsNullOrEmpty(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Valida terceira coluna
            if ((Button7 == caracterIA) && (Button8 == caracterIA) && string.IsNullOrEmpty(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            if ((Button8 == caracterIA) && (Button9 == caracterIA) && string.IsNullOrEmpty(Button7))
            {
                Last = caracterIA;
                Button7 = caracterIA;
                return true;
            }
            if ((Button7 == caracterIA) && (Button9 == caracterIA) && string.IsNullOrEmpty(Button8))
            {
                Last = caracterIA;
                Button8 = caracterIA;
                return true;
            }
            //Valida primeira linha
            if ((Button1 == caracterIA) && (Button4 == caracterIA) && string.IsNullOrEmpty(Button7))
            {
                Last = caracterIA;
                Button7 = caracterIA;
                return true;
            }
            if ((Button4 == caracterIA) && (Button7 == caracterIA) && string.IsNullOrEmpty(Button1))
            {
                Last = caracterIA;
                Button1 = caracterIA;
                return true;
            }
            if ((Button1 == caracterIA) && (Button7 == caracterIA) && string.IsNullOrEmpty(Button4))
            {
                Last = caracterIA;
                Button4 = caracterIA;
                return true;
            }
            //Valida segunda linha
            if ((Button2 == caracterIA) && (Button5 == caracterIA) && string.IsNullOrEmpty(Button8))
            {
                Last = caracterIA;
                Button8 = caracterIA;
                return true;
            }
            if ((Button5 == caracterIA) && (Button8 == caracterIA) && string.IsNullOrEmpty(Button2))
            {
                Last = caracterIA;
                Button2 = caracterIA;
                return true;
            }
            if ((Button2 == caracterIA) && (Button8 == caracterIA) && string.IsNullOrEmpty(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Valida terceira linha
            if ((Button3 == caracterIA) && (Button6 == caracterIA) && string.IsNullOrEmpty(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            if ((Button6 == caracterIA) && (Button9 == caracterIA) && string.IsNullOrEmpty(Button3))
            {
                Last = caracterIA;
                Button3 = caracterIA;
                return true;
            }
            if ((Button3 == caracterIA) && (Button9 == caracterIA) && string.IsNullOrEmpty(Button6))
            {
                Last = caracterIA;
                Button6 = caracterIA;
                return true;
            }
            //Valida diagonal 1
            if ((Button1 == caracterIA) && (Button5 == caracterIA) && string.IsNullOrEmpty(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            if ((Button5 == caracterIA) && (Button9 == caracterIA) && string.IsNullOrEmpty(Button1))
            {
                Last = caracterIA;
                Button1 = caracterIA;
                return true;
            }
            if ((Button1 == caracterIA) && (Button9 == caracterIA) && string.IsNullOrEmpty(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Valida diagonal 2
            if ((Button3 == caracterIA) && (Button5 == caracterIA) && string.IsNullOrEmpty(Button7))
            {
                Last = caracterIA;
                Button7 = caracterIA;
                return true;
            }
            if ((Button5 == caracterIA) && (Button7 == caracterIA) && string.IsNullOrEmpty(Button3))
            {
                Last = caracterIA;
                Button3 = caracterIA;
                return true;
            }
            if ((Button3 == caracterIA) && (Button7 == caracterIA) && string.IsNullOrEmpty(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Validação por botão
            //Button 1
            //Coluna
            if ((Button1 == caracterIA) && string.IsNullOrWhiteSpace(Button2) && string.IsNullOrWhiteSpace(Button3))
            {
                Last = caracterIA;
                Button3 = caracterIA;
                return true;
            }
            //Linha
            if ((Button1 == caracterIA) && string.IsNullOrWhiteSpace(Button4) && string.IsNullOrWhiteSpace(Button7))
            {
                Last = caracterIA;
                Button7 = caracterIA;
                return true;
            }
            //Diagonal
            if ((Button1 == caracterIA) && string.IsNullOrWhiteSpace(Button5) && string.IsNullOrWhiteSpace(Button9))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Button 2
            //Coluna
            if ((Button2 == caracterIA) && string.IsNullOrWhiteSpace(Button1) && string.IsNullOrWhiteSpace(Button3))
            {
                Last = caracterIA;
                Button1 = caracterIA;
                return true;
            }
            //Linha
            if ((Button2 == caracterIA) && string.IsNullOrWhiteSpace(Button5) && string.IsNullOrWhiteSpace(Button8))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Button 3
            //Coluna
            if ((Button3 == caracterIA) && string.IsNullOrWhiteSpace(Button1) && string.IsNullOrWhiteSpace(Button2))
            {
                Last = caracterIA;
                Button1 = caracterIA;
                return true;
            }
            //Linha
            if ((Button3 == caracterIA) && string.IsNullOrWhiteSpace(Button6) && string.IsNullOrWhiteSpace(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            //Diagonal
            if ((Button3 == caracterIA) && string.IsNullOrWhiteSpace(Button5) && string.IsNullOrWhiteSpace(Button7))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Button 4
            //Coluna
            if ((Button4 == caracterIA) && string.IsNullOrWhiteSpace(Button5) && string.IsNullOrWhiteSpace(Button6))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Linha
            if ((Button4 == caracterIA) && string.IsNullOrWhiteSpace(Button1) && string.IsNullOrWhiteSpace(Button7))
            {
                Last = caracterIA;
                Button7 = caracterIA;
                return true;
            }
            //Button 5 
            //Coluna
            if ((Button5 == caracterIA) && string.IsNullOrWhiteSpace(Button4) && string.IsNullOrWhiteSpace(Button6))
            {
                Last = caracterIA;
                Button4 = caracterIA;
                return true;
            }
            //Linha
            if ((Button5 == caracterIA) && string.IsNullOrWhiteSpace(Button2) && string.IsNullOrWhiteSpace(Button8))
            {
                Last = caracterIA;
                Button2 = caracterIA;
                return true;
            }
            //Diagonais
            if ((Button5 == caracterIA) && string.IsNullOrWhiteSpace(Button1) && string.IsNullOrWhiteSpace(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            if ((Button5 == caracterIA) && string.IsNullOrWhiteSpace(Button3) && string.IsNullOrWhiteSpace(Button7))
            {
                Last = caracterIA;
                Button3 = caracterIA;
                return true;
            }
            //Button 6
            //Coluna
            if ((Button6 == caracterIA) && string.IsNullOrWhiteSpace(Button4) && string.IsNullOrWhiteSpace(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            if ((Button6 == caracterIA) && string.IsNullOrWhiteSpace(Button3) && string.IsNullOrWhiteSpace(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            //Button 7
            //Coluna
            if ((Button7 == caracterIA) && string.IsNullOrWhiteSpace(Button8) && string.IsNullOrWhiteSpace(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            //Linha
            if ((Button7 == caracterIA) && string.IsNullOrWhiteSpace(Button1) && string.IsNullOrWhiteSpace(Button4))
            {
                Last = caracterIA;
                Button1 = caracterIA;
                return true;
            }
            //Diagonal
            if ((Button7 == caracterIA) && string.IsNullOrWhiteSpace(Button5) && string.IsNullOrWhiteSpace(Button3))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Button 8
            //Coluna
            if ((Button8 == caracterIA) && string.IsNullOrWhiteSpace(Button7) && string.IsNullOrWhiteSpace(Button9))
            {
                Last = caracterIA;
                Button9 = caracterIA;
                return true;
            }
            //Linha
            if ((Button8 == caracterIA) && string.IsNullOrWhiteSpace(Button2) && string.IsNullOrWhiteSpace(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            //Button 9
            //Coluna
            if ((Button9 == caracterIA) && string.IsNullOrWhiteSpace(Button7) && string.IsNullOrWhiteSpace(Button8))
            {
                Last = caracterIA;
                Button7 = caracterIA;
                return true;
            }
            //Linha
            if ((Button9 == caracterIA) && string.IsNullOrWhiteSpace(Button3) && string.IsNullOrWhiteSpace(Button6))
            {
                Last = caracterIA;
                Button3 = caracterIA;
                return true;
            }
            //Diagonal
            if ((Button9 == caracterIA) && string.IsNullOrWhiteSpace(Button1) && string.IsNullOrWhiteSpace(Button5))
            {
                Last = caracterIA;
                Button5 = caracterIA;
                return true;
            }
            else
            {
                return false;
            }

        }
        public string IAvalidaCaractere(string buttonPadrao)
        {
            if (buttonPadrao == "1")
            {

                Last = caracterJogador;
                Button1 = caracterJogador;
                return Button1;

            }

            if (buttonPadrao == "2")
            {
                Last = caracterJogador;
                Button2 = caracterJogador;
                return Button2;

            }

            if (buttonPadrao == "3")
            {

                Last = caracterJogador;
                Button3 = caracterJogador;
                return Button3;

            }

            if (buttonPadrao == "4")
            {

                Last = caracterJogador;
                Button4 = caracterJogador;
                return Button4;

            }

            if (buttonPadrao == "5")
            {

                Last = caracterJogador;
                Button5 = caracterJogador;
                return Button5;

            }

            if (buttonPadrao == "6")
            {

                Last = caracterJogador;
                Button6 = caracterJogador;
                return Button6;

            }

            if (buttonPadrao == "7")
            {

                Last = caracterJogador;
                Button7 = caracterJogador;
                return Button7;

            }

            if (buttonPadrao == "8")
            {

                Last = caracterJogador;
                Button8 = caracterJogador;
                return Button8;

            }

            if (buttonPadrao == "9")
            {

                Last = caracterJogador;
                Button9 = caracterJogador;
                return Button9;

            }
            return buttonPadrao;
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

