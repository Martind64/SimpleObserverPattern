using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObserverPattern
{
     public class Student : INotify
     {

         private readonly string _name;

         public Student(string name)
         {
             _name = name;
         }

         public void Notify()
         {
             Console.WriteLine("Opgave Modtaget af {0}", _name);
         }

       
    }
}
