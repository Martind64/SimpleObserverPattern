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

            Teacher Ebbe = new Teacher("Ebbe");

           
            Ebbe.AddObserver(Martin);
            Ebbe.GiveOrder("Do your homework");

            Console.ReadLine();
            Console.WriteLine();
            Student Bob = new Student("Bob");
            Ebbe.AddObserver(Bob);
            Ebbe.GiveOrder("Så er det tid til julemusik!");

            
            Console.ReadLine();
            Console.WriteLine();

            Ebbe.RemoveObserver(Bob);
            Console.ReadLine();

        }
    }
}
