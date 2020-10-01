using System;
using Xamarin.Forms;
using Button = Xamarin.Forms.Button;
using Xamarin.Forms.Xaml;


namespace grid_Myapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        Label[,] zeroandcross = new Label[3, 3];
        string l;
        public MainPage()
        {
            Resi();
            spt = 0;
        }
        Label algus, info;
        Button newGame, randomPlayer;

        void Resi()
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
            randomPlayer = new Button
            {
                BackgroundColor = Color.FromHex("#7e12e3"),
                BorderWidth = 4,
                BorderColor = Color.FromHex("#bde312"),
                Text = "Who is First?"
            };
            randomPlayer.Clicked += randomPlayer_Clicked;
            newGame = new Button
            {
                BackgroundColor = Color.DarkCyan,
                BorderWidth = 4,
                BorderColor = Color.DarkCyan,
                Text = "new game?"
            };
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
                    zeroandcross[j, f] = algus;
                    l = "X";
                    var tap = new TapGestureRecognizer();
                    tap.Tapped += Tap_Tapped;
                    grid.Children.Add(algus, j, f);
                    algus.GestureRecognizers.Add(tap);
                }
            }
            grid.Children.Add(randomPlayer, 0, 3);
            grid.Children.Add(newGame, 2, 3);
            grid.Children.Add(info, 1, 3);
            Content = grid;
        }
        private void newGame_Clicked(object sender, EventArgs e)
        {
            Resi();
            chck = 0;
            spt = 0;
        }
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Label algus = sender as Label;
            if (algus.Text == "")

                if(chck % 2 == 0)
                {
                    randomPlayer.Text = "O";
                    algus.Text = l;
                    chck++;
                    spt++;
                }
                else if (chck % 2 != 0)
                {
                    randomPlayer.Text = "X";
                    chck++;
                    spt++;
                    algus.Text = "0";
                }
        if (checkDraw() == true)
        {
            DisplayAlert("End of the game")
        }


        }

        private void RandomPlayer_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
