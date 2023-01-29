using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace BookParsingDownloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog folder;
        List<Book> books;
        public MainWindow()
        {
            InitializeComponent();
            folder = new OpenFileDialog();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LB.Items.Clear();
            SiteToString siteToString = new SiteToString();
            string site = siteToString.GetSite("https://tululu.org/search/?q="+ TB.Text);
            BooksParser parser = new BooksParser();
            books = parser.GetBooks(site);

            foreach (Book x in books)
            {
                LB.Items.Add(x.Name);
                LB.Items.Add(x.Url);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //var pathFile = OpenFile();
            folder.ShowDialog();
        }
        /*private string OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            return openFileDialog.ShowDialog() == true ? openFileDialog.FileName : string.Empty;
        }*/
        string GenerateFilename(string songName)
        {
            string result = "";
            for (int i = 0; i < songName.Length; i++)
            {
                if (songName[i] == '?' || songName[i] == '\"' || songName[i] == '|'
                    || songName[i] == '\\' || songName[i] == ' ' || songName[i] == '*'
                    || songName[i] == '«'
                    || songName[i] == '»' || songName[i] == '>' || songName[i] == '<'
                    || songName[i] == ':' || songName[i] == '/' || songName[i] == '\n')
                    continue;
                result += songName[i];
            }
            if (result.Length == 0)
                result = "song";
            result += ".mp3";
            return result;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (LB.SelectedIndex < 0)
                return;
            folder.Filter = "Text Files (*.txt)|*.txt";
            if (folder.FileName.Length == 0 || folder.FileName == null)
            {
                if (folder.ShowDialog() != true)
                    return;
            }
            WebClient client = new WebClient();
            string path = folder.FileName + "\\"
                 + GenerateFilename(books[LB.SelectedIndex].Name);

            client.DownloadFileAsync(new Uri(books[LB.SelectedIndex].Url), path);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
