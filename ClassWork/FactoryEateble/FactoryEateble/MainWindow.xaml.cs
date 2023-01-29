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

namespace FactoryEateble
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<IEateble> menu;
        public MainWindow()
        {
            InitializeComponent();
            menu = new List<IEateble>()
            {
                new IceCream("Пломбир"),  
                new IceCream("Эскимо"),   
                new Chocolate("Сникерс", 50),  
                new Chocolate("Марс", 100), 
                new Chocolate("Баунти", 100) 
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IEateble something = null;
            Factory factory = new Factory(menu);
            if (rb1.IsChecked == true)
                something = factory.GetEateble(0);
            if (rb2.IsChecked == true)
                something = factory.GetEateble(1);
            if (rb3.IsChecked == true)
                something = factory.GetEateble(2);
            if (rb4.IsChecked == true)
                something = factory.GetEateble(3);
            if (rb5.IsChecked == true)
                something = factory.GetEateble(4);
            MessageBox.Show(something.Eat());
        }
    }
}
