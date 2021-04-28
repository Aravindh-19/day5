using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        public static int CalculateAge(DateTime dateOfBirth)
        
            {
                int age = 0;
                age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                    age = age - 1;

                return age;

            }
            public static void Main()
            {
            Console.WriteLine("Enter dob in yy/mm/dd format:");
                DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                int age = CalculateAge( dateOfBirth);
                Console.WriteLine("Age is "+age);
            Console.ReadLine();

            }
        }
    }

