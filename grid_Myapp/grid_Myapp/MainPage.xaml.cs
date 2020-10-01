using System;
using Xamarin.Forms;
using Button = Xamarin.Forms.Button;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Runtime.ExceptionServices;

namespace grid_Myapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        Label[,] zeroandcross = new Label[3, 3];
        string l;
        public MainPage()
        {
            Res();
            stp = 0;
        }
        Label algus, info;
        Button newGame, randomPlayer;

        void Res()
        {
            Grid grid = new Grid();
            for (int j = 0; j < 3; j++)
            {
                BackgroundColor = Color.DarkCyan;
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            for (int f = 0; f < 3; f++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            randomPlayer.Clicked += randomPlayer_Clicked;
            newGame = new Button
            {
                BackgroundColor = Color.FromHex("#7e12e3"),
                BorderWidth = 4,
                BorderColor = Color.FromHex("#bde312"),
                Text = "Who is First?"
            };
            randomPlayer.Clicked += randomPlayer_Clicked;
            newGame = new Button
            {
                BackgroundColor = Color.darkcyan,
                border
            }
            newGame.Clicked += newGame_Clicked;
            info = new Label
            {
                FontSize = 20,
                TextColor = Color.DarkCyan,
                Text = ""
            };

            for (int j = 0; j < 3; j++)
            {
                for (int f = 0; f < 3; f++)
                {
                    algus = new Label
                    {
                        BackgroundColor = Color.DarkCyan,
                        FontSize = 100,
                        Text = "",
                        HorizontalTextAlignment = TextAlignment.Center,
                        TextColor = Color.DarkCyan,
                        VerticalTextAlignment = TextAlignment.Center,
                    };
                    zeroandcross[j, f] algus;
                    l = "X";

                }
            }





            }

        private void RandomPlayer_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
