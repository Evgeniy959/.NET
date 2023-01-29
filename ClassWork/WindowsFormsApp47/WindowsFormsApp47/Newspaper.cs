using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp47
{
    class Newspaper : IObservable
    {
        List<IObserver> observers= new List<IObserver>();
        string news;
        public void NewNews(string text)
        {
            news = text;
            NotifyObservers();
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver obs in observers)
                obs.Notify(news);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
