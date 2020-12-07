using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            char userOperator1, userOperator2;
            int term1, term2, term3, sum = 0;
            List<int> resultList = new List<int>();
            bool keepGoing = false;

            
            //Byt ut titeln i konsolen till Accounter
            Console.Title = "Accounter";
            
            do
            {
                //Be användaren att ange 2 operator
                Console.WriteLine("Enter 2 operator, choose between +, -, *, /");
                Console.Write("Enter the first operator: ");
                userOperator1 = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter the second operator: ");
                userOperator2 = Convert.ToChar(Console.ReadLine());

                //Be användaren om ett par termer att använda operatorer på
                Console.WriteLine("Enter 3 numbers.");
                Console.Write("Enter the first number: ");
                term1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                term2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the third number: ");
                term3 = Convert.ToInt32(Console.ReadLine());


                //Räkna ut resultatet
                switch (userOperator1)
                {
                    case '+':
                        if (userOperator2 == '+')
                        {
                            sum = term1 + term2 + term3;
                        }
                        else if (userOperator2 == '-')
                        {
                            sum = term1 + term2 - term3;
                        }
                        else if (userOperator2 == '*')
                        {
                            sum = term1 + (term2 * term3);
                        }
                        else if (userOperator2 == '/')
                        {
                            sum = term1 + (term2 / term3);
                        }
                        break;

                    case '-':
                        if (userOperator2 == '+')
                        {
                            sum = term1 - term2 + term3;
                        }
                        else if (userOperator2 == '-')
                        {
                            sum = term1 - term2 - term3;
                        }
                        else if (userOperator2 == '*')
                        {
                            sum = term1 - (term2 * term3);
                        }
                        else if (userOperator2 == '/')
                        {
                            sum = term1 - (term2 / term3);
                        }
                        break;

                    case '*':
                        if (userOperator2 == '+')
                        {
                            sum = (term1 * term2) + term3;
                        }
                        else if (userOperator2 == '-')
                        {
                            sum = (term1 * term2) - term3;
                        }
                        else if (userOperator2 == '*')
                        {
                            sum = term1 * term2 * term3;
                        }
                        else if (userOperator2 == '/')
                        {
                            sum = (term1 * term2) / term3;
                        }
                        break;

                    case '/':
                        if (userOperator2 == '+')
                        {
                            sum = (term1 / term2) + term3;
                        }
                        else if (userOperator2 == '-')
                        {
                            sum = (term1 / term2) - term3;
                        }
                        else if (userOperator2 == '*')
                        {
                            sum = (term1 / term2) * term3;
                        }
                        else if (userOperator2 == '/')
                        {
                            sum = (term1 / term2) / term3;
                        }
                        break;
                }
                

                //Skriv ut resultatet och lägga resultatet i en lista
                Console.WriteLine($"{term1} {userOperator1} {term2} {userOperator2} {term3} = {sum}");
                resultList.Add(sum);
                //Kolla om resultat är större än, mindre än eller lika med 100
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
                    int i = 0, sumOfList = 0;

                    while( i < resultList.Count)
                    {
                        sumOfList = sumOfList + resultList[i];
                        i++;
                    }
                    Console.WriteLine($"Thank you for playing. The sum of all round is {sumOfList}. Bye!");
                }

            } while (keepGoing == true);   
        }
    }
}