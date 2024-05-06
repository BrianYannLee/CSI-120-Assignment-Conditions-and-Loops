//Programmer: Brian Lee
//Date: 05/05/2024

//Title: Assignment Conditions and Loop
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace CSI_120_Assignment_Conditions_and_Loops
{
    internal class Program
    {
        delegate void ProblemMethod();
        static void Main(string[] args)
        {
            try
            {
                ProblemMethod[] methods = { Problem1, Problem2, Problem3, Problem4, Problem5, Problem6 };
                Console.WriteLine("Select the number of the problem to execute:");
                Console.WriteLine("1. Problem1");
                Console.WriteLine("2. Problem2");
                Console.WriteLine("3. Problem3");
                Console.WriteLine("4. Problem4");
                Console.WriteLine("5. Problem5");
                Console.WriteLine("6. Problem6");
                Console.WriteLine("7. Exit");

                int userInput;
                while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 7)
                    Console.WriteLine("Invalid Input. Try Again");
                methods[userInput - 1]();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error has occured in Main: {ex.Message}");
            }
        }//end of main
        public static void Problem1()
        {
            Console.WriteLine("Problem 1");
            Console.WriteLine();
            try
            {

                int userInput;

                Console.WriteLine("Enter a integer");
                while (!int.TryParse(Console.ReadLine(), out userInput))
                    Console.WriteLine("Invalid Input. Try Again.");
                if (userInput < 0)
                    Console.WriteLine("The number is negative");
                else if (userInput > 0)
                    Console.WriteLine("The number is positive");
                else
                    Console.WriteLine("The number is zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An Error has occred in Problem 1: {ex.Message}");
            }
            Console.WriteLine();
        }//end of Problem1

        public static void Problem2()
        {
            Console.WriteLine("Problem 2");
            Console.WriteLine();
            try 
            {
                int[] userInput = new int[3];
                int i = 0;
                do
                {
                    Console.WriteLine($"Enter Integer {i+1}");
                    while (!int.TryParse(Console.ReadLine(), out userInput[i]))
                        Console.WriteLine("Invalid Input. Try Again");

                    ++i;
                } while (i < 3);
                Console.WriteLine($"The largest integer is {userInput.Max()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error has occured in Problem 2: {ex.Message}");
            }


            Console.WriteLine();
        }//end of Problem2
        public static void Problem3()
        {
            Console.WriteLine("Problem 3");
            Console.WriteLine();
            try
            {
                string userInput;
                while(!Regex.IsMatch(userInput = Console.ReadLine(), @"^[a-zA-Z]$"))
                    Console.WriteLine("Invalid Input. Try Again");
                if (userInput == "a"|| userInput =="e"||userInput=="i"||userInput == "o"||userInput=="u")
                    Console.WriteLine("The character is a vowel");
                else
                    Console.WriteLine("The chracter is a constant");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured in Problem 3: {ex.Message}");
            }



            Console.WriteLine();
        }//end of Problem3
        public static void Problem4()
        {
            Console.WriteLine("Problem 4");
            Console.WriteLine();
            try
            {
                int userInput;
                Console.WriteLine("Enter an Integer.");
                while (!int.TryParse(Console.ReadLine(), out userInput))
                    Console.WriteLine("Invalid Input. Try Again");
                for (int i = 0; i < 10; i++)
                    Console.WriteLine($"{userInput} x {i+1} = {userInput*(i+1)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured in Problem 4: {ex.Message}");
            }



            Console.WriteLine();
        }//end of Problem4
        public static void Problem5()
        {
            Console.WriteLine("Problem 5");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Enter a integer.");
                int userInput;
                bool notPrime = false;
                while(!int.TryParse(Console.ReadLine(), out userInput))
                    Console.WriteLine("Invalid Input. Try Again.");
                for (int i = 2; i < userInput; i++)
                {
                    if(userInput % i == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }
                if(notPrime == false)
                    Console.WriteLine("The number is Prime");
                else
                    Console.WriteLine("The number is not a Prime");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured in Problem 5: {ex.Message}");
            }
            Console.WriteLine();
        }//end of Problem5
        public static void Problem6()
        {
            Console.WriteLine("Problem 6");
            Console.WriteLine();
            try
            {
                for (int i = 1; i < 100; i++)
                {
                    string output = "";

                    if (i % 3 == 0)
                        output += "Fizz";
                    if (i % 5 == 0)
                        output += "Buzz";
                    if (output == "")
                        output = i.ToString();
                    Console.WriteLine(output);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured in Problem 6: {ex.Message}");
            }



            Console.WriteLine();
        }//end of Problem6


    }//end of class
}//end of namespace
