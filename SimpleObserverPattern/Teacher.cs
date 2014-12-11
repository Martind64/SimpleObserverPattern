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
        private static string _order;

        public static string Order
        {
            get { return _order; }
            set { _order = value; }
        }
      
        public Teacher(string name)
        {
            _name = name;
        }

        public void AddObserver(INotify observer)
        {
            _ObserverList.Add(observer);
            
        }

        public void RemoveObserver(INotify observer)
        {
            _ObserverList.Remove(observer);

            
        }


        public void GiveOrder(string order)
        {
            _order = order;
            foreach (var s in _ObserverList)
            {
                s.Notify();
            }
        }

    }
}
