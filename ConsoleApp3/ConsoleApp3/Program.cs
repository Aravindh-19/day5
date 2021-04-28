using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface Ivechile
    {
        void drive();
        bool refuel(int refill);
    }
    public class Car:Ivechile
    {
        public void drive()
        {
        
            Console.WriteLine("refuel amount:");
            int refill = Convert.ToInt32(Console.ReadLine());
            Car a = new Car();
            a.refuel(refill);
            Console.ReadLine();
        }
        public bool refuel(int refill)
        {
            if (refill == 0)
            {
                Console.WriteLine("Not refueled");
            }
            else
            {


                Console.WriteLine("Car refueled");
                refill = refill + 1;
                Console.WriteLine("Gasoline amount:" + refill);
                Console.WriteLine("Car is driving");
                Console.ReadLine();
            }
            return true;
        }
        static void Main()
        {
           
            int gasoline = 0;
            Car a = new Car();
            a.drive();
           




            Console.ReadLine();
        }
    }
}