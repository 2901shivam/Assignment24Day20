using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace Assignment24Day20
{
    public class Manger
    {
        string name;
        string department;
        public Manger(string name,string department)
        {
            this.name = name;
            this.department = department;
            
        }


        public void MangerDetails()
        {
            Console.WriteLine($"Welcome {name} of this {department}");

          
        }

     
       



    }
}
