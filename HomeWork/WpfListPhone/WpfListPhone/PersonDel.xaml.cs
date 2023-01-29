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
    /// Interaction logic for PersonDel.xaml
    /// </summary>
    public partial class PersonDel : Window
    {
        private Person _person;
        public PersonDel(Person person)
        {
            _person = person;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            AddLastName.Text = _person.LastName;
            AddFirstName.Text = _person.FirstName;
            AddPhone.Text = _person.Phones;
        }
        private void Del()
        {
            Person person = new Person();
            LastName;
            AddFirstName.Text = _person.FirstName;
            AddPhone.Text = _person.Phones;
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            Init();
            
        }
    }
}
