using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
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
using System.Windows.Threading;
using Timer.HelperClasses;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private double getDoubleValueFromTextBox(TextBox textbox)
        {
            var textBoxValue = textbox.Text;
            double textBoxIntValue = Double.Parse(textBoxValue);
            return textBoxIntValue;

        }

        private double getRandomTimeBeetwenTwoValues()
        {
            var firstValue = getDoubleValueFromTextBox(StartValue);
            var secondValue = getDoubleValueFromTextBox(EndValue);

            return RandomGenerator.generateRandomBeetwenTwoValues(firstValue, secondValue);
        }



        private void Start_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(getRandomTimeBeetwenTwoValues());
            timer.Tick += Timer_Tick;
            timer.Start();


        }





        private void Timer_Tick(object sender, EventArgs e)
        {


            string path = @"D:\GitHub\Projekty C#\Timer\Timer\Resources\bomb-falling-and-exploding-02.wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Load();
            soundPlayer.Play();
            MessageBox.Show("Jupi, działa");
            DispatcherTimer timer = (DispatcherTimer)sender;
            timer.Stop();
        }
    }
}
