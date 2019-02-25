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
        private IDictionary<Point, Button> buttonsPoints = new Dictionary<Point, Button>();

        public MainWindow()
        {
            InitializeComponent();
            buttonsPoints.Add(new Point(1, 1), button11);
            buttonsPoints.Add(new Point(1, 2), button12);
            buttonsPoints.Add(new Point(1, 3), button13);
            buttonsPoints.Add(new Point(2, 1), button21);
            buttonsPoints.Add(new Point(2, 2), button22);
            buttonsPoints.Add(new Point(2, 3), button23);
            buttonsPoints.Add(new Point(3, 1), button31);
            buttonsPoints.Add(new Point(3, 2), button32);
            buttonsPoints.Add(new Point(3, 3), button33);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            ;
            ClearAllPlayGroundButtons();
            SetToAllPlayGroundButtonsStatus(true);
            startButton.IsEnabled = false;
            replayButton.IsEnabled = true;
            stopButton.IsEnabled = true;
        }

        private void ReplayButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton_Click(sender, null);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            ;
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
            foreach (Button button in buttonsPoints.Values)
            {
                button.IsEnabled = status;
            }
        }

        private void ClearAllPlayGroundButtons()
        {
            foreach (Button button in buttonsPoints.Values)
            {
                button.Content = "";
            }
        }

        private void DrawWinSeries(ISet<Point> winSeries)
        {
            foreach (Point point in winSeries)
            {
                buttonsPoints[point].Foreground = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
