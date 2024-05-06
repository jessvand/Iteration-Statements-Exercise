using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void ShowNums1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void IncByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void SameTwoNums(int numOne, int numTwo)
        {
            if (numOne == numTwo)
            {
                Console.WriteLine($"{numOne} and {numTwo} are the same numbers.");
            }
            else
            {
                Console.WriteLine($"{numOne} and{numTwo} are NOT the same numbers.");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EveOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is EVEN!");
            }
            else
            {
                Console.WriteLine($"{num} is ODD!");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PosOrNeg(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is Positive.");
            }
            else
            {
                Console.WriteLine($"{number} is Negative.");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanVote()
        {
            Console.WriteLine("Hi! PLease tell me how old you are:");
            bool canParse = int.TryParse(Console.ReadLine(), result: out int userAge);

            while (canParse == false)
            {
                Console.WriteLine("Invalid input, please enter your age:");
                canParse = int.TryParse(Console.ReadLine(), out userAge);

            }

            if (userAge > 18)
            {
                Console.WriteLine($"You're {userAge}, and eligible to vote in the US...not that it nmatters. We're all screwed!");
            }
            else
            {
                Console.WriteLine($"Sorry not sorry! You're {userAge} and cannot vote until you're 18 years old - but don't worry. In the US, we make exceptions for certain things! You'll see...");

            }
        }

                     
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
       
        public static void InRangeOfTen(int number) 
        {
            if (number <= 10 && number >= -10)
                Console.WriteLine($"{number} is in the ten range");
            else 
            {
                Console.WriteLine($"{number} is NOT in ten range!");
            }
        }
        

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable12 (int num) 
        {
            for (int i = 1; i <= 12; i++)
            { 
                Console.WriteLine($"{i} x {num} = {i * num}"); 
            }
        }

        //Call the methods to test them in the Main method below

        static void Main(string[] args)
        {
            //ShowNums1000();
            //IncByThree(9);
            //SameTwoNums(8, 14);
            //EveOrOdd(11);
            //PosOrNeg(12);
            //CanVote(16);
            //InRangeOfTen(6);
            //MultTable12(3);
        }

    }
}