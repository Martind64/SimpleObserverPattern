using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Martin = new Student("Martin");

            Teacher teacher = new Teacher("Ebbe");

            
            teacher.AddObserver(Martin);
            Console.ReadLine();
            Console.WriteLine();
            Student Bob = new Student("Bob");

            teacher.AddObserver(Bob);
            Console.ReadLine();
            Console.WriteLine();

            teacher.RemoveObserver(Bob);
            Console.ReadLine();

        }
    }
}
