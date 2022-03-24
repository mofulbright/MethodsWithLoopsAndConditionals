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
                        Answer();
                        break;
                    case 2:
                        Print3Through999By3();
                        Answer();
                        break;
                    case 3:
                        AreTheyEqual();
                        Answer();
                        break;
                    case 4:
                        IsItEvenOrOdd();
                        Answer();
                        break;
                    case 5:
                        CanYouVote();
                        Answer();
                        break;
                    case 6:
                        IfBetweenNeg10And10();
                        Answer();
                        break;
                    case 7:
                        MultiplicationTable();
                        Answer();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        Answer();
                        break;
                }
                Console.WriteLine("Hit enter to perform another task, type 'exit' to exit");
                wantToContinue = Console.ReadLine().ToLower();
            } while (wantToContinue != "exit");
        }
        static void PrintNeg1000Through1000()
        {
            var list = new List<int>();
            int num = -1000;
            while (num <= 1000)
            {
                list.Add(num);
                num++;
            }
            foreach(var printNumber in list)
            {
                Console.WriteLine(printNumber);
            }

        }

        static void Print3Through999By3()
        {
            var list = new List<int>();
            int num = 3;
            while (num <= 999)
            {
                list.Add(num);
                num += 3;
            }
            foreach (int printNumber in list)
            {
                Console.WriteLine(printNumber);
            }
        }
        static void AreTheyEqual()
        {
            Console.WriteLine("What is the value of x?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the value of y?");
            int y = Convert.ToInt32(Console.ReadLine());

            var equalOrNot = (x == y) ? $"{x} and {y} are equal" : $"{x} and {y} are not equal";
            Console.WriteLine(equalOrNot);
        }
        static void IsItEvenOrOdd()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            var evenOrOdd = (num % 2 == 0) ? $"{num} is even" : $"{num} is odd";
            Console.WriteLine(evenOrOdd);
        }
        static void CanYouVote()
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            var ableToVote = (age >= 18) ? $"Congratulations, you can vote!!" : $"Sorry, you are unable to vote.";
            Console.WriteLine(ableToVote);
        }
        static void IfBetweenNeg10And10()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            var between = (num <= 10 && num >= -10) ? $"{num} is between -10 and 10" : $"{num} is not between -10 and 10";
            Console.WriteLine(between);
        }
        static void MultiplicationTable()
        {
            Console.WriteLine("Enter an integer to make a multiplication table");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{num}x{x}={num*x}");
            }
        }
        static void Answer()
        {
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
        }
    }
}
