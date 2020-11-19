using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOperator;
            double term1, term2, term3, sum = 0;
            List<double> resultList = new List<double>();
            bool keepGoing = false;

            //Console.WriteLine("Default Title: {0}", Console.Title);
            //Byt ut titeln i konsolen till Accounter
            Console.Title = "Accounter";
            //Console.WriteLine()
            do
            {

                //Be användaren att ange en operator
                Console.WriteLine("Enter operator, choose between +, -, *, /");
                Console.Write("Enter the operator: ");
                userOperator = Console.ReadLine();
                //Be användaren om ett par termer att använda operatorer på
                Console.WriteLine("Enter 3 integers.");
                Console.Write("Enter the first integer: ");
                term1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second integer: ");
                term2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the third integer: ");
                term3 = Convert.ToDouble(Console.ReadLine());

                //Räkna ut resultatet
                switch (userOperator)
                {
                    case "+":
                        sum = term1 + term2 + term3;
                        break;

                    case "-":
                        sum = term1 - term2 - term3;
                        break;

                    case "*":
                        sum = term1 * term2 * term3;
                        break;

                    case "/":
                        sum = term1 / term2  / term3;
                        break;
                }

                //Skriv ut resultatet och lägga resultatet i en lista
                Console.WriteLine($"{term1} {userOperator} {term2} {userOperator} {term3} = {sum}");
                resultList.Add(sum);
                
                //
                if (sum < 100)
                {
                    Console.WriteLine("Less then a hundred");
                }
                else if (sum > 100)
                {
                    Console.WriteLine("More then a hundred");
                }
                else if (sum == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
                }

               //Användaren får välja om hen vill fortsätta eller avsluta.
               //Om hen vill avsluta, så skrivs summan av alla resultat ut.
                Console.Write("Another try? (y/n) ");
                char userChoice = Convert.ToChar(Console.ReadLine());
                if (userChoice == 'y' || userChoice == 'Y')
                {
                    keepGoing = true;
                }
                else if (userChoice == 'n' || userChoice == 'N')
                {
                    keepGoing = false;
                    Console.WriteLine("Thank you for playing. The sum of all round is . Bye!");
                }

            } while (keepGoing == true);   
        }
    }
}