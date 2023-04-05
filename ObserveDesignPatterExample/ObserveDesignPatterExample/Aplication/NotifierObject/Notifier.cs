using ObserveDesignPatterExample.Aplication.Interface;
using ObserveDesignPatterExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveDesignPatterExample.Aplication.NotifierObject
{

    //https://www.youtube.com/watch?v=2On-b8f7DHk&t=14s
    //46:28
    public class Notifier : ISubject
    {
        private Tweet _tweet = new();
        private List<IObserver> observers = new();



        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Dettach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(_tweet);
            }
        }
    }
}
