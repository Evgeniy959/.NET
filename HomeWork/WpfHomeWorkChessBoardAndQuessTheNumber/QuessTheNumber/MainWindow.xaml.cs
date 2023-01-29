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

namespace QuessTheNumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        Random rand = new Random();
        public int RandNumber { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            RandNext();
        }

        public void RandNext()
        {
            RandNumber = rand.Next(0, 10);
            //LableRendNubmer.Content = RandNumber.ToString();
        }
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageRes;
            var number1 = RandNumber;
            var number2 = Convert.ToInt32(TextNumber.Text);
                
            if (number1 - number2 >= 3 | number2 - number1 >= 3 && number2 <= 10 && number2 >= 0) 
            {
                //TextRes.Text = "Холодно";
                string messageBox = "Попробывать еще раз";
                string sign = "Холодно";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage window = MessageBoxImage.Hand;
                messageRes = MessageBox.Show(messageBox, sign, button, window, MessageBoxResult.Cancel);
                TextNumber.Clear();
                if (messageRes == MessageBoxResult.No)
                Environment.Exit(0);
            }
                
            if (number1 - number2 == 2 | number2 - number1 == 2) 
            {
                //TextRes.Text = "Тепло";
                string messageBox = "Попробывать еще раз";
                string sign = "Тепло";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage window = MessageBoxImage.Exclamation;
                messageRes = MessageBox.Show(messageBox, sign, button, window, MessageBoxResult.Cancel);
                TextNumber.Clear();
                if (messageRes == MessageBoxResult.No)
                Environment.Exit(0);
            }

            if (number1 - number2 == 1 | number2 - number1 == 1)
            {
                //TextRes.Text = "Горячо";
                string messageBox = "Попробывать еще раз";
                string sign = "Горячо";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage window = MessageBoxImage.Exclamation;
                messageRes = MessageBox.Show(messageBox, sign, button, window, MessageBoxResult.Cancel);
                TextNumber.Clear();                
                if (messageRes == MessageBoxResult.No)
                Environment.Exit(0);
            }

            if (number1 == number2)
            {
                //TextRes.Text = "молодец угадали";
                string messageBox = "Продолжить";
                string sign = "Молодец угадали";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage window = MessageBoxImage.Information;
                messageRes = MessageBox.Show(messageBox, sign, button, window, MessageBoxResult.Cancel);
                TextNumber.Clear();
                RandNext();
                if (messageRes == MessageBoxResult.No)
                Environment.Exit(0);
            }
            
            if (number2 > 10 | number2 < 0)
            {
                //TextRes.Text = "Выбран неверный диапазон чисел введите число от 0 до 10";
                string messageBox = "Попробывать еще раз";
                string sign = "Выбран неверный диапазон чисел введите число от 0 до 10";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage window = MessageBoxImage.Hand;
                messageRes = MessageBox.Show(messageBox, sign, button, window, MessageBoxResult.Cancel);
                TextNumber.Clear();
                if (messageRes == MessageBoxResult.No)
                Environment.Exit(0);
            }
        }

        private void TextNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextRes_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
