using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.UI.Xaml;
using System.Runtime.CompilerServices;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Button = Xamarin.Forms.Button;

namespace grid_Myapp
{
    public partial class MainPage : ContentPage
    {
        BoxView box;
        Button new_game, random_player;
        public MainPage()
        {
            New_game_Clicked();
        }
        void New_game_Clicked()
        {


            /*
            {
                RowDefinitions=
                {
                    
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions=
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
               

            };*/


            Grid grid = new Grid();
            for (int i = 0; i < 4; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    box = new BoxView { Color = Color.FromRgb(200, 100, 50) };
                    grid.Children.Add(box, i, j);
                    var tap = new TapGestureRecognizer();
                    box.GestureRecognizers.Add(tap);
                    tap.Tapped += Tap_Tapped;
                }
                       
            }
            new_game = new Button { Text = "New Game" };
            grid.Children.Add(new_game, 0, 3);
            Grid.SetColumnSpan(new_game, 2);
            random_player = new Button { Text = "Who is first?" };
            grid.Children.Add(random_player, 2, 3);
            Grid.SetColumnSpan(random_player, 2);
            Content = grid;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /* private void Tap_Tapped(object sender, EventArgs e)
         {
             BoxView box = sender as BoxView;
             box.Color = Color.FromRgb(0,0,0);

         }*/
    }
}
/*
                            BoxView box = sender as BoxView;
                            if (box.Color == new Color(0, 0, 0))
                            {
                            box.Color = Color.FromRgb(200, 100, 50);
                            }
                            else
                            {
                                box.Color = new Color(0, 0, 0);
                            }
                            Image img1 = sender as image;
                            if(img1.Source=="nolik.png")
                            {
                                img1.Source = "nuul.png";
                            }
                            else
                            {
                                img1.Source = "krest.png";
                            }
                            */