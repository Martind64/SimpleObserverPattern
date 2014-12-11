using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObserverPattern
{
    public class Teacher
    {
        private static List<INotify> _ObserverList = new List<INotify>();

        public string _name;
        public Teacher(string name)
        {
            _name = name;
        }

        public void AddObserver(INotify observer)
        {
            _ObserverList.Add(observer);

            foreach (var s in _ObserverList)
            {
                s.Notify();
            }
        }

        public void RemoveObserver(INotify observer)
        {
            _ObserverList.Remove(observer);

            foreach (var s in _ObserverList)
            {
                s.Notify();
            }
        }

    }
}
