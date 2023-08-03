using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserver : IObserver
    {
        private string name;

        public ConcreteObserver(string name)
        {
            this.name = name;
        }

        public void Update(ISubject subject)
        {
            ConcreteSubject concreteSubject = (ConcreteSubject)subject;
            Console.WriteLine($"Observer {name} received an update. New state: {concreteSubject.State}");
        }
    }
}
