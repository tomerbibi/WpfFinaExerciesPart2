using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using Prism.Commands;


namespace WpfFinaExerciesPart2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        public MainWindow()
        {
            InitializeComponent();

            _time = TimeSpan.FromSeconds(30);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                timeLeft.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero)
                {
                    _timer.Stop();
                    wrongButton1.IsEnabled = false;
                    wrongButton2.IsEnabled = false;
                    wrongButton3.IsEnabled = false;
                    correctButton.IsEnabled = false;
                    this.Background = new SolidColorBrush(Colors.Red);
                }
                if (_time.Seconds <= 15)
                {
                    timeLeft.Foreground = new SolidColorBrush(Colors.Red);
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        private void correctButton_Click(object sender, RoutedEventArgs e)
        {
            wrongButton1.IsEnabled = false;
            wrongButton2.IsEnabled = false;
            wrongButton3.IsEnabled = false;
            correctButton.IsEnabled = false;
            _timer.Stop();
            this.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void wrongButton3_Click(object sender, RoutedEventArgs e)
        {
            wrongButton1.IsEnabled = false;
            wrongButton2.IsEnabled = false;
            wrongButton3.IsEnabled = false;
            correctButton.IsEnabled = false;
            _timer.Stop();
            this.Background = new SolidColorBrush(Colors.Red);
        }

        private void wrongButton2_Click(object sender, RoutedEventArgs e)
        {
            wrongButton1.IsEnabled = false;
            wrongButton2.IsEnabled = false;
            wrongButton3.IsEnabled = false;
            correctButton.IsEnabled = false;
            _timer.Stop();
            this.Background = new SolidColorBrush(Colors.Red);
        }

        private void wrongButton1_Click(object sender, RoutedEventArgs e)
        {
            wrongButton1.IsEnabled = false;
            wrongButton2.IsEnabled = false;
            wrongButton3.IsEnabled = false;
            correctButton.IsEnabled = false;
            _timer.Stop();
            this.Background = new SolidColorBrush(Colors.Red);
        }
    }
}
