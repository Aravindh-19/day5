﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime moment = new System.DateTime(2021, 04, 28, 15, 15, 32, 11);
            Console.WriteLine("year = " + moment.Year);
            Console.WriteLine("month = " + moment.Month);
            Console.WriteLine("day = " + moment.Day);
            Console.WriteLine("hour = " + moment.Hour);
            Console.WriteLine("minute = " + moment.Minute);
            Console.WriteLine("second = " + moment.Second);
            Console.WriteLine("millisecond = " + moment.Millisecond);
            Console.ReadLine();
        }
    }
}
