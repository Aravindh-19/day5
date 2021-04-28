using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program

    {
        Program()
            {
            Console.WriteLine("Constructor");
            }
        ~Program()
        {
            Console.WriteLine("Destructor");
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            
                Console.ReadLine();
            
        }
    }
}
