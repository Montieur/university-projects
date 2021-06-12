using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Checkers
{
    public partial class MainWindow : Window
    {
        public double BorderSize { get; set; }
        public double BoardSize { get; set; }
        public double WindowWidth { get; set; }
        public double WindowHeight { get; set; }
        public double WindowContentHeight { get; set; }
        public double TitleBarHeight { get; set; }

        public bool vsAI = true;
        public bool BackStrikes = true;
        public bool ForceStrikes = true;
        Board board;

        public MainWindow()
        {
            InitializeComponent();
            SetDimensions();
            
            DataContext = this;
        }

        private void SetDimensions()
        {
            TitleBarHeight = SystemParameters.WindowCaptionButtonHeight;
            WindowHeight = SystemParameters.PrimaryScreenHeight * 3 / 4;
            WindowWidth = WindowHeight;
            WindowContentHeight = WindowHeight - TitleBarHeight * 4;
            window.Width = WindowWidth;
            window.Height = WindowHeight;
            BorderSize = WindowContentHeight;
            BoardSize = BorderSize - 4;
        }

        private void ButtonNewGame_Click(object sender, RoutedEventArgs e)
        {
            MainMenuScreen.Visibility = Visibility.Collapsed;
            SettingsScreen.Visibility = Visibility.Visible;
        }

        private void ButtonStartGame_Click(object sender, RoutedEventArgs e)
        {
            board = new Board(this);
            SettingsScreen.Visibility = Visibility.Collapsed;
            GameScreen.Visibility = Visibility.Visible;
        }

        private void ButtonBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainMenuScreen.Visibility = Visibility.Visible;
            SettingsScreen.Visibility = Visibility.Collapsed;
        }

        private void ButtonVsAI_Click(object sender, RoutedEventArgs e)
        {
            vsAI = !vsAI;
            if (vsAI) ImageVS.Source = (ImageSource)FindResource("robot");
            else ImageVS.Source = (ImageSource)FindResource("human");
        }

        private void ButtonBackStriking_Click(object sender, RoutedEventArgs e)
        {
            BackStrikes = !BackStrikes;
            if (BackStrikes) ImageBackStrikes.Source = (ImageSource)FindResource("ok");
            else ImageBackStrikes.Source = (ImageSource)FindResource("not_ok");
        }

        private void ButtonForceStriking_Click(object sender, RoutedEventArgs e)
        {
            ForceStrikes = !ForceStrikes;
            if (ForceStrikes) ImageForceStrikes.Source = (ImageSource)FindResource("ok");
            else ImageForceStrikes.Source = (ImageSource)FindResource("not_ok");
        }

        private void ButtonExitGame_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonExitToMenu_Click(object sender, RoutedEventArgs e)
        {
            board.CleanUpGrid();
            board = null;
            GameScreen.Visibility = Visibility.Collapsed;
            EndGameScreen.Visibility = Visibility.Collapsed;
            MainMenuScreen.Visibility = Visibility.Visible;
        }

        private void ButtonPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            board.CleanUpGrid();
            board = null;
            board = new Board(this);
            EndGameScreen.Visibility = Visibility.Collapsed;

        }
    }

}