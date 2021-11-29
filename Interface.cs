using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            interface Breathe
        {
            void Done();
        }
        class BasePerson : Breathe
        {
            public void Done()
            {
                Console.WriteLine("Person is Breathe");
            }
        }
        class SuperPerson : BasePerson
        {
            public new void Done()
            {
                Console.WriteLine("SuperPerson is Breathe");
            }


        }
           
         
       
    }
}
