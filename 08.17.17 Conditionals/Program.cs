using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._17._17_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            if(age >= 17)
            {
                Console.WriteLine("You are allowed to see the movie.");
            }

            else
            {
                Console.WriteLine("Sorry, you are too young to watch this movie!");
            }
        }
    }
}
