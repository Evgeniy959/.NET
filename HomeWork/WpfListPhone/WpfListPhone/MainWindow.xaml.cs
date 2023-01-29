using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfListPhone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Person _person;
        private static ObservableCollection<Person> _list;
        public MainWindow()
        {
            InitializeComponent();
            _list = new ObservableCollection<Person>();
            ListOfPhone.ItemsSource = _list;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainPerson form = new MainPerson();
            form.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //Person newPerson = new Person();
            /*var newPerson = (sender as ListView)?.SelectedItem as Person;
            PersonDel form = new PersonDel(newPerson);
            form.Show();*/
        }

        public static void AddToList(Person newPerson)
        {
            _list.Add(newPerson);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            _list.Clear();
        }

        private void ListOfStudents_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var newPerson = (sender as ListView)?.SelectedItem as Person;
            PersonDel form = new PersonDel(newPerson);
            form.Show();
        }
    }
    /*public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phones { get; set; }

    }*/
}
