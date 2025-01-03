using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicPractice
{
    internal class NumberBased
    {
        public static void Exceptions()
        {
            int n = 2;
            int n2 = 0;
            try
            {
                Console.WriteLine(2 / n2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exception Handled!!!");
            }
        }

        //Write a Program to to Find Roots of a Quadratic Equation. (using If Else statement or switch The roots of a Quadratic Equation(ax2+bx+c) depends upon the discriminant value.)
        public static void FindRootsOfQuadratic()
        {
            Console.Write("Enter coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);

            Console.WriteLine("The quadratic equation is: "+a+"x^2 + "+b+"x + "+c);

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Roots are real and distinct:");
                Console.WriteLine("Root 1: "+root1);
                Console.WriteLine("Root 2: "+root2);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("Roots are real and equal:");
                Console.WriteLine("Root: "+root);
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("Roots are complex:");
                Console.WriteLine("Root 1: "+realPart+" + "+imaginaryPart+"i");
                Console.WriteLine("Root 2: " + realPart + " - " + imaginaryPart + "i");
            }
        }

        /* Convert a number to a string, the contents of which depend on the number's factors.
         If the number has 3 as a factor, output 'Pling'.
         If the number has 5 as a factor, output 'Plang'.
         If the number has 7 as a factor, output 'Plong'.
         If the number does not have 3, 5, or 7 as a factor, just pass the number's digits straight through. 
         (Example :28 has 7 as a factor, but not 3 or 5, so the result would be “Plong”.
         30 has both 3 and 5 as factors, but not 7, so the result would be “PlingPlang”.
         34 is not factored by 3, 5, or 7, so the result would be “34”.)
        */
        public static void ConvertNumToString()
        {
            Console.WriteLine("Enter the Num: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 3 == 0)
            {
                Console.WriteLine("Pling");
            }
            if (n % 5 == 0)
            {
                Console.WriteLine("Plang");
            }
            if (n % 7 == 0)
            {
                Console.WriteLine("Plong");
            }
            else
            {
                Console.WriteLine(n);
            }
        }

        //Write a program which can compute the factorial of a given numbers.Develop this as function and call from main.function should return factorial.
        public static void FindFactorial()
        {
            Console.WriteLine("Enter Num: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of " + n + " is: " + fact);

        }

        //Write a program which will find all such numbers which are divisible by 7 but are not a multiple of 5, between 2000 and 3200 (both included).  The numbers obtained should be printed in a comma-separated sequence on a single line.
        public static void CheckNumDivisiblity()
        {
            Console.Write("The Num divisible by 7 but not 5: ");
            for(int i = 2000; i <= 3200; i++)
            {
                CheckDivisibility(i);
            }
        }

        public static void CheckDivisibility(int i)
        {
            if(i % 7==0 && i % 5 != 0)
            {
                Console.Write(i+",");
            }
        }

        public static void GenerateNumbers(int n)
        {
            if (n <= 100)
            {
                Console.Write(n + " ");
                n++;
            }
            else
            {
                return;
            }
            GenerateNumbers(n);
        }

        public static void PrintNum10Times()
        {
            Console.WriteLine("Enter the Num:");
            string num = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
            }
        }

        public static void SquareAndSum()
        {
            try
            {
                Console.WriteLine("Enter firstNum:");
                decimal n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter 2ndNum:");
                decimal n2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Square and Sum of num: " + ((n1 * n1) + (n2 * n2)));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter decimal or integer type value only!");
            }

        }

        public static void SquareAndDiff()
        {
            Console.WriteLine("Enter firstNum:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2ndNum:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square and Difference of num: " + ((n1 * n1) - (n2 * n2)));
        }
    }
}
