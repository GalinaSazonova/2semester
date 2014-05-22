using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TicTacToeWillWork
{
    /// <summary>
    /// Class for TicTacToe Game.
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeNewGame(string message)
        {
            Label label1 = new Label();
            label1.Content = message;
            label1.FontSize = 60;
            label1.HorizontalAlignment = HorizontalAlignment.Left;
            label1.VerticalAlignment = VerticalAlignment.Top;
            label1.Margin = new Thickness(100, 0, 0, 0);
            this.LayoutRoot.Children.Add(label1);

            Button wantToContinue = new Button();
            wantToContinue.Content = "Play";
            wantToContinue.FontSize = 30;
            wantToContinue.HorizontalAlignment = HorizontalAlignment.Left;
            wantToContinue.VerticalAlignment = VerticalAlignment.Top;
            wantToContinue.Margin = new Thickness(130, 100, 0, 0);
            wantToContinue.Click += new RoutedEventHandler((object sender, RoutedEventArgs e) => ButtonWantToContinueClick());
            this.LayoutRoot.Children.Add(wantToContinue);
        }

        private void InitializeButtons()
        {
            computerMove = new ComputerMoves();
            button = new Button[9];
            markedButton = new bool[9];
            crossButton = new bool[9];
            toeButton = new bool[9];
            for (int i = 0; i < 9; i++)
            {
                markedButton[i] = false;
                crossButton[i] = false;
                toeButton[i] = false;
                button[i] = new Button();
                button[i].Width = 167;
                button[i].Height = 167;
                button[i].FontSize = 30;
                button[i].HorizontalAlignment = HorizontalAlignment.Left;
                button[i].VerticalAlignment = VerticalAlignment.Top;
                button[i].Margin = new Thickness((i % 3) * 167, (i / 3) * 167, 0, 0);
                int temp = i;
                button[i].Click += new RoutedEventHandler((object sender, RoutedEventArgs e) => ButtonClick(temp));
                this.LayoutRoot.Children.Add(button[i]);
            }
        }

        private void ButtonClick(int i)
        {
            if (!markedButton[i])
            {
                button[i].Content = "X";
                markedButton[i] = true;
                crossButton[i] = true;
            }
            if (ThereIsAWinner())
            {
                this.LayoutRoot.Children.Clear();
                InitializeNewGame("You are winner!");
                return;
            }
            int temp = computerMove.PutToe(crossButton, markedButton, toeButton);
            if (temp != -1)
            {
                button[temp].Content = "O";
                markedButton[temp] = true;
                toeButton[temp] = true;
            }
            if (ThereIsAWinner())
            {
                this.LayoutRoot.Children.Clear();
                InitializeNewGame("You are loser!");
                return;
            }
            else
            {
                if (Full())
                {
                    this.LayoutRoot.Children.Clear();
                    InitializeNewGame("Draw!");
                }
            }
        }

        private bool ThereIsAWinner()
        {
            if (Equals(button[0].Content, button[4].Content) && Equals(button[0].Content, button[8].Content) && PushedButtons(0, 4, 8))
                return true;

            if (Equals(button[2].Content, button[4].Content) && Equals(button[4].Content, button[6].Content) && PushedButtons(2, 4, 6))
                return true;
            for (int i = 0; i < 3; i++)
            {
                if (Equals(button[i % 3].Content, button[i % 3 + 3].Content) && Equals(button[i % 3 + 6].Content,button[i % 3].Content) && PushedButtons(i % 3, i % 3 + 3, i % 3 + 6))
                    return true;
                if (Equals(button[i * 3].Content, button[i * 3 + 1].Content) && Equals(button[i * 3 + 1].Content, button[i * 3 + 2].Content) && PushedButtons(i * 3, i * 3 + 1, i * 3 + 2))
                    return true;
            }
            return false;
        }

        private bool PushedButtons(int a, int b, int c)
        {
            if (markedButton[a] && markedButton[b] && markedButton[c])
                return true;
            return false;
        }

        private void ButtonWantToContinueClick()
        {
            this.LayoutRoot.Children.Clear();
            InitializeButtons();
        }

        private bool Full()
        {
            bool check = true;
            for (int i = 0; i < 9; i++)
            {
                if (!markedButton[i])
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        private Button[] button;
        private bool[] markedButton;
        private bool[] crossButton;
        private bool[] toeButton;
        private ComputerMoves computerMove;
    }
}
