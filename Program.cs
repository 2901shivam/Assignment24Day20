using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace Assignment24Day20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter manger name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Department Name");
            string depart = Console.ReadLine();

            Manger manger = new Manger(name, depart);

            manger.MangerDetails();

            Log log = new Log(10, "abc");


        }
    }
}
