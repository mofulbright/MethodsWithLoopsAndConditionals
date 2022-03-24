using System;
using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selection;
            string wantToContinue;
            do
            {
                Console.WriteLine("Which task do you want to perform?");
                Console.WriteLine("1. Print -1000 through 1000 \n2. Print 3 through 999 by 3" +
                    "\n3. Are they equal\n4. Is it even or odd\n5. Can you vote" +
                    "\n6. Is it between -10 and 10\n7. Multiplication Table");

                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        PrintNeg1000Through1000();
                        Space();
                        break;
                    case 2:
                        Print3Through999By3();
                        Space();
                        break;
                    case 3:
                        AreTheyEqual();
                        Space();
                        break;
                    case 4:
                        IsItEvenOrOdd();
                        Space();
                        break;
                    case 5:
                        CanYouVote();
                        Space();
                        break;
                    case 6:
                        IfBetweenNeg10And10();
                        Space();
                        break;
                    case 7:
                        MultiplicationTable();
                        Space();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        Space();
                        break;
                }
                Console.WriteLine("Hit enter to perform another task, type 'exit' to exit");
                wantToContinue = Console.ReadLine().ToLower();
            } while (wantToContinue != "exit");
        }
        static void PrintNeg1000Through1000()
        {
            Space();
            //var list = new List<int>();
            //int num = -1000;
            //while (num <= 1000)
            //{
            //    list.Add(num);
            //    num++;
            //}
            //foreach(var printNumber in list)
            //{
            //    Console.WriteLine(printNumber);
            //}
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void Print3Through999By3()
        {
            Space();
            //var list = new List<int>();
            //int num = 3;
            //while (num <= 999)
            //{
            //    list.Add(num);
            //    num += 3;
            //}
            //foreach (int printNumber in list)
            //{
            //    Console.WriteLine(printNumber);
            //}
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        static void AreTheyEqual()
        {
            Space();
            Console.WriteLine("What is the value of x?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the value of y?");
            int y = Convert.ToInt32(Console.ReadLine());

            var equalOrNot = (x == y) ? $"{x} and {y} are equal" : $"{x} and {y} are not equal";
            Console.WriteLine(equalOrNot);
        }
        static void IsItEvenOrOdd()
        {
            Space();
            Console.WriteLine("Enter a number to check if it is even or odd");
            int num = Convert.ToInt32(Console.ReadLine());

            var evenOrOdd = (num % 2 == 0) ? $"{num} is even" : $"{num} is odd";
            Console.WriteLine(evenOrOdd);
        }
        static void CanYouVote()
        {
            Space();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            var ableToVote = (age >= 18) ? $"Congratulations, you can vote!!" : $"Sorry, you are unable to vote.";
            Console.WriteLine(ableToVote);
        }
        static void IfBetweenNeg10And10()
        {
            Space();
            Console.WriteLine("Enter a number to check if it is between -10 and 10");
            int num = Convert.ToInt32(Console.ReadLine());

            var between = (num <= 10 && num >= -10) ? $"{num} is between -10 and 10" : $"{num} is not between -10 and 10";
            Console.WriteLine(between);
        }
        static void MultiplicationTable()
        {
            Space();
            Console.WriteLine("Enter an integer to make a multiplication table with multiples 1-12");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{num}x{x}={num*x}");
            }
        }
        static void Space()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
