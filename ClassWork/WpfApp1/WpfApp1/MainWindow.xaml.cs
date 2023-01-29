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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LabeA.Content = A.Content; 
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            LabeB.Content = B.Content;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            LabeC.Content = C.Content;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            LabeA.Content = string.Empty;
            LabeB.Content = string.Empty;
            LabeC.Content = string.Empty;
        }
    }
}
