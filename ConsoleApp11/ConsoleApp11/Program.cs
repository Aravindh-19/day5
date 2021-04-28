using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Program
    {
        public static void Main()
        {
            int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
            Array.Sort(array); 
            Array.Reverse(array);  
            foreach (var result in array)
            {
                Console.WriteLine(result + " ");  
            }
            Console.WriteLine("Second Highest Value In Array " + array[1]);
            Console.ReadLine();
        }
    }
}
