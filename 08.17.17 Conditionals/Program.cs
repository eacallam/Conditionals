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

        //Console.WriteLine("Enter your age:");
        //int age = int.Parse(Console.ReadLine());

        //if(age == 21)
        //{
        //    Console.WriteLine("Let's get a drink"); 
        //}

        //else if (age == 18)
        //{
        //    Console.WriteLine("You are now an adult");
        //}

        //else if (age >= 17)
        //{
        //    Console.WriteLine("You are allowed to see the movie.");
        //}
        //else
        //{
        //    Console.WriteLine("Sorry, you are too young to watch this movie!");
        //}

        //Console.WriteLine("Enter your percentage");
        //int grade = int.Parse(Console.ReadLine());
        //if (grade >= 90 && grade <= 100)
        //{
        //    Console.WriteLine("You got an A!!");
        //}

        //else if (grade >= 80 && grade <= 89)
        //{
        //    Console.WriteLine("You got a B!");
        //}

        /*PROBLEM: At a restaurant, Mike and his three friends decided to divide the bill evenly. 
        If each person paid $13 then what was the total bill?*/

        //Console.WriteLine("How many people are in your party?");
        //int partySize = int.Parse(Console.ReadLine());

        //Console.WriteLine("How much was the total bill?");
        //double totalBill = double.Parse(Console.ReadLine());


        ////METHOD ONE
        //if(totalBill >= 50)
        //{
        //    decimal tenPercentDiscounted = totalBill - (totalBill * 0.10m);
        //    decimal splitBillTen = tenPercentDiscounted / partySize;
        //    Console.WriteLine("Oh, congrats! You get a 10% discount! Your bill was $" + totalBill + ". Your new bill is $" + tenPercentDiscounted + "." + " Each person pays $" + splitBillTen + ".");
        //}

        //else
        //{
        //    decimal fivePercentDiscounted = totalBill - (totalBill * 0.05m);
        //    decimal splitBillFive = fivePercentDiscounted / partySize;
        //    Console.WriteLine("You get a discount! Your bill is 5% off. Your bill was $" + totalBill + ". Your new bill is $" + fivePercentDiscounted + "." + " Each person pays $" + splitBillFive + ".");

        //METHOD TWO
        //double discount = 0.0;
        //if (totalBill >= 50.0d)
        //{
        //    discount = 1.10;
        //    totalBill = totalBill / discount;
        //}

        //else
        //{
        //    discount = 1.05;
        //    totalBill /= discount; 
        //}

        //double perPerson = totalBill / partySize;
        //Console.WriteLine("Thank you for dining with us! Your new total is $" + totalBill + ". Each person will pay $" + perPerson + ".");


// PROBLEM: You're responsible for providing a demographic report for your local school district based on age. 
//To do this, you're going to determine which 'category' each person fits into based on their age. The person's age will determine which category they should be in.

            //Console.WriteLine("How old are you?");
            //int personAge = int.Parse(Console.ReadLine());

            //if (personAge >= 0 && personAge <= 2)
            //{
            //    Console.WriteLine("Still in Mama's Arms");
            //}

            //else if (personAge >= 3 && personAge <= 4)
            //{
            //    Console.WriteLine("Preschool Maniac");
            //}

            //else if (personAge >= 5 && personAge <= 11)
            //{
            //    Console.WriteLine("Elementary School");

            //}
            //else if (personAge >= 12 && personAge <= 14)
            //{
            //    Console.WriteLine("Middle School");
            //}

            //else if (personAge >= 15 && personAge <= 18)
            //{
            //    Console.WriteLine("High School");
            //}

            //else if (personAge >= 19 && personAge <= 22)
            //{
            //    Console.WriteLine("College");
            //}

            //else if (personAge >= 23 && personAge <= 65)
            //{
            //    Console.WriteLine("Working for the Man");
            //}

            //else if (personAge >= 66 && personAge <= 100)
            //{
            //    Console.WriteLine("The Golden Years");
            //}

            //else
            //{
            //    Console.WriteLine("This program is for humans.");
            //}
            
            //PROBLEM: Write a console application that asks the user for a number. Tell the user if that number is even or odd.

            Console.WriteLine("Tell me a number and I'll tell you if it's even or odd.");

            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine(userNumber + " is an even number.");
            }

            else
            {
                Console.WriteLine(userNumber + " is an odd number.");
            }
        }
    }
}

