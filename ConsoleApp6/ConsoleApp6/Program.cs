using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class person
    {
        public string Name { get; set; }
        public  person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Hello! My name is:"+Name;
        }
        ~person()
        {
            Name = string.Empty;
        }

            

        static void Main(string[] args)
        {
            int total=3;
            person[] people = new person[total];
            for (int i=0;i<total;i++)
            {

                people[i] = new person(Console.ReadLine());
                
            }
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(people[i].ToString());
                Console.ReadLine();
            }
        }
    }
}
