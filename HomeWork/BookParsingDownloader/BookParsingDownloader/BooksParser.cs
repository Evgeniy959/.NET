using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParsingDownloader
{
    class BooksParser
    {
        List<Book> books;

        public List<Book> GetBooks(string site)
        {
            books = new List<Book>();
            string name = "";
            string url = "";
            int index = site.IndexOf("href=\"/b");
            while (index >= 0)
            {
                site = site.Remove(0, index + 6);
                index = site.IndexOf("\">");
                if (index >= 0)
                {
                    url = site.Remove(index);
                    site = site.Remove(0, index + 2);
                    name = site.Remove(site.IndexOf("</a>"));
                    books.Add(new Book() { Name = name, Url = url });
                    index = site.IndexOf("href=\"/b");
                }
            }
            return books;
        }
    }
}
