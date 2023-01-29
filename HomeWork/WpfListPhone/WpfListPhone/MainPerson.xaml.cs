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
using System.Windows.Shapes;

namespace WpfListPhone
{
    /// <summary>
    /// Interaction logic for MainPerson.xaml
    /// </summary>
    public partial class MainPerson : Window
    {
        public MainPerson()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Person newPerson = new Person
            {
                LastName = AddLastName.Text,
                FirstName = AddFirstName.Text,
                Phones = AddPhone.Text,
            };
            MainWindow.AddToList(newPerson);
        }
    }
}
