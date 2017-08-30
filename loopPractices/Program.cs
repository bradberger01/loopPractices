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
            //int[] luckyNumbers = {7,13,21,19,36,80};

            //foreach (int myNumber in luckyNumbers)

            //    Console.WriteLine(" Your lucky number is: " + myNumber);

            //FOR LOOPS

            //string[] Names = { "Jordan", "Max", "Peter" };
            //for (int i = 0; i < Names.Length; i++)
            //{
            //    //Names[i] = Names[i].ToLower();
            //    //Console.WriteLine(Names[i]);

            //}

            //for (int counter = 1; counter <=10; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //strings and chars are similar and can be grouped together
            //string words = "I like cake";
            //foreach(char letter in words)
            //{
            //    Console.WriteLine(letter);
            //}

            //string greetings = "My name is Brad";
            //string[] words = greetings.Split();
            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //    if(words[i] == "Brad")
            //    {
            //        words[i] = "Max";
            //    }
            //}
            //Console.WriteLine(words[words.Length - 1]);

            //Create an array called days, with the elements monday, tuesday, etc. Use a for loop to print the elements to the console

            //string[] DaysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //for(int i = 0; i < DaysOfWeek.Length; i++)
            //{
            //    Console.WriteLine(DaysOfWeek[i]);
            //}
            //Create an int array size 25, put the numbers 1-25 in the array and print those numbers to the console.

            //int[] moreNumbers = new int[25];
            //for (int i = 0; i <= moreNumbers.Length; i++)
            //{
            //    moreNumbers[i] = i +1;
            //    Console.WriteLine(moreNumbers[i]);
            //}

            //Start with the string "Once upon a time" and create an array called storyWords using the split method. Reverse the order
            //of the elements in the array using a for loop, print each word.

            //string beginning = "Once upon a time";
            //string[] storyWords = beginning.Split();//SPLITING ON THE WHITE SPACE   
            //for (int i = 0; i < storyWords.Length; i++) ;
            //{
            //    Console.WriteLine(storyWords);
            //}
            //Array.Reverse(storyWords);// DOESN'T WORK. NEEDS FIXING
            //{
            //    Console.WriteLine(storyWords);
            //}

            //WHILE LOOPS

            //Console.WriteLine("Do you want to play a game?");
            //string playAgain = Console.ReadLine();

            //while(playAgain == "Yes")
            //{
            //    Console.WriteLine("It's a rematch");
            //    Console.WriteLine("Do you want to play again?");
            //    playAgain = Console.ReadLine();
            //}

            //Console.WriteLine("What is your fav ROYGBIV color?");
            //string userColor = Console.ReadLine();
            ////bool isRoygbivColor = false;

            //while(userColor != "red" )
            //{
            //    Console.WriteLine("Sorry that is not the correct color. Please try again");
            //    userColor = Console.ReadLine();
            //}

            //DO WHILE
            //string playAgan;
            //do
            //{
            //    Console.WriteLine("Do you want to build a snowman");
            //    Console.WriteLine("That was fun");
            //    Console.WriteLine("Do you want to build another snowman?");
            //    playAgan = Console.ReadLine();
            //}
            //while (playAgan == "yes");

            //USING A BREAK
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i==5)
                {
                    break;
                }
            }

        }
    }
}
