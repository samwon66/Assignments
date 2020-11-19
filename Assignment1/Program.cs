using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operator1, operator2;
            int term1, term2, term3;
            //Be användaren att ange ett par operatorer
            Console.WriteLine("Enter 2 operators, choose between +, -, *, /");
            Console.Write("Enter the first operator: ");
            operator1 = Console.ReadLine();
            Console.Write("Enter the second operator: ");
            operator2 = Console.ReadLine();
            //Be användaren om ett par termer att använda operatorer på
            Console.WriteLine("Enter 3 integers.");
            Console.Write("Enter the first integer: ");
            term1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            term2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third integer: ");
            term3 = Convert.ToInt32(Console.ReadLine());


        }
    }
}
