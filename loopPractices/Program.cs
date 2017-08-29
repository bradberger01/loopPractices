using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loops -iterate through a collection "goes through each array"
            //string[] months = { "Jan", "Feb", "March", "April", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec"};
            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //    if(month == "Dec")
            //    {
            //        Console.WriteLine("That's the best month");
            //    }
            //    else
            //    {
            //        Console.WriteLine("That month is okay I guess");
            //    }



            //}
            //string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            //foreach (string band in musicians) 
            //Console.WriteLine(band);

            //Create a program that asks the user for their fav food and stores those values in an array

            //string[] favFoods = new string[3];
            //Console.WriteLine("What is your favorite food?");
            //favFoods[0] = Console.ReadLine();
            //Console.WriteLine("What is another favorite food?");
            //favFoods[1] = Console.ReadLine();
            //Console.WriteLine("Give me one more favorite food.");
            //favFoods[2] = Console.ReadLine();



            //// loop through the array and print all of the foods.

            //Console.WriteLine("Your favoite foods are:");
            //foreach (string items in favFoods)
            //    Console.WriteLine(items);




            //Create an array of lucky numbers using a foreach loop print the following: You lucky number is: 4
            int[] luckyNumbers = {7,13,21,19,36,80};

            foreach (int myNumber in luckyNumbers)

                Console.WriteLine(" Your lucky number is: " + myNumber);


        }
    }
}
