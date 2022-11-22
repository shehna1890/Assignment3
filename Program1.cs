using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    internal class Program1
    {
        class student
        {
            public string name;
            public int roll_number;
            public void displaydetails()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Roll Number: " + roll_number);

            }
        }
        static void Main(string[] args)
        {
            student a = new student();
            a.name = "Shehna";
            a.roll_number = 1;
            student b = new student();
            b.name = "Fathima";
            b.roll_number = 2;
            a.displaydetails();
            b.displaydetails();
            Console.ReadLine();

        }
    }
}

