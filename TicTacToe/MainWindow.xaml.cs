using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            ;
            SetToAllPlayGroundButtonsStatus(true);
            startButton.IsEnabled = false;
            replayButton.IsEnabled = true;
            stopButton.IsEnabled = true;
        }

        private void ReplayButton_Click(object sender, RoutedEventArgs e)
        {
            ;
            ClearAllPlayGroundButtons();
            StartButton_Click(sender, null);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            ;
            ClearAllPlayGroundButtons();
            SetToAllPlayGroundButtonsStatus(false);
            startButton.IsEnabled = true;
            replayButton.IsEnabled = false;
            stopButton.IsEnabled = false;
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            ;
            button11.IsEnabled = false;
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            ;
            button12.IsEnabled = false;
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            ;
            button13.IsEnabled = false;
        }

        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            ;
            button21.IsEnabled = false;
        }

        private void Button22_Click(object sender, RoutedEventArgs e)
        {
            ;
            button22.IsEnabled = false;
        }

        private void Button23_Click(object sender, RoutedEventArgs e)
        {
            ;
            button23.IsEnabled = false;
        }

        private void Button31_Click(object sender, RoutedEventArgs e)
        {
            ;
            button31.IsEnabled = false;
        }

        private void Button32_Click(object sender, RoutedEventArgs e)
        {
            ;
            button32.IsEnabled = false;
        }

        private void Button33_Click(object sender, RoutedEventArgs e)
        {
            ;
            button33.IsEnabled = false;
        }

        private void SetToAllPlayGroundButtonsStatus(bool status)
        {
            button11.IsEnabled = status;
            button12.IsEnabled = status;
            button13.IsEnabled = status;
            button21.IsEnabled = status;
            button22.IsEnabled = status;
            button23.IsEnabled = status;
            button31.IsEnabled = status;
            button32.IsEnabled = status;
            button33.IsEnabled = status;
        }

        private void ClearAllPlayGroundButtons()
        {
            button11.Content = "";
            button12.Content = "";
            button13.Content = "";
            button21.Content = "";
            button22.Content = "";
            button23.Content = "";
            button31.Content = "";
            button32.Content = "";
            button33.Content = "";
        }
    }
}
