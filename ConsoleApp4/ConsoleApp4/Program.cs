using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class animal
    {
        private string name;
        public void Setname(string name)
        {
            this.name = name;
        }
        public string Getname()
        {
            return name;
        }
        public abstract void eat();
    }
    class Dog : animal
    {
        public override void eat()
        {
            Console.WriteLine("dog is eating");
        }
        static void Main(string[] args)
        {
            Dog puppy = new Dog();
            puppy.Setname(Console.ReadLine());
            Console.WriteLine(puppy.Getname());
            puppy.eat();
            Console.ReadLine();
        }
    }


}