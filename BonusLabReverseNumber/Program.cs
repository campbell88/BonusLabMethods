using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 50000;


            string name = "";
            name = GetName();
            Console.WriteLine($"Hi, {name}!");

            Console.WriteLine("Please type a number between 1 and 50000: \n");
            int number = GetIntWithinRange(Min,Max); 
            int Reverse = 0;
            while (number > 0)
            {
                int rem = number % 10;
                number = number / 10;
                Reverse = (Reverse * 10) + rem;

            }
                Console.WriteLine("Reverse Number is " + Reverse); 

        
            
        }

        public static int GetIntWithinRange(int Min, int Max)  
        {
            int number;
            number = GetValidInteger();
            if ((number < Min) || (number > Max))
            {
                Console.WriteLine("Error: Number not between 1 and 5000");
                number = int.Parse(Console.ReadLine());
             
            } return number;
        }


        public static int GetValidInteger()
        {
            int input;

           // Console.WriteLine("Please enter an Integer: ");

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("The input is not an integer! Please enter an integer! ");
            }

            return input;
        }

        public static string GetName()
        {
            // Name Input
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            return name;
        }
    }
}