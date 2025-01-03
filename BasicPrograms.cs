using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class BasicPrograms
    {
        //Implementing Local Custom Exception
        public static void Calculate(double n)
        {
            try
            {
                if (n <= 0)
                {
                    //This msg will go through the construuctor
                    throw new ZeroNotAllowedException("Number less than Zero or Zero not allowed!");
                }

                double res = Math.Sqrt(n);
                Console.WriteLine($"Square Root of {n} is {res}");
            }
            catch(ZeroNotAllowedException e)
            {
                Console.WriteLine(e.Message); //Msg passed from the child constructor to the parent class constructor will get printed
                Console.WriteLine(e); //Calls the ToString method from custom exception class
            }
            
        }
        public static void GetAverageRandomNum()
        {
            Random r = new Random();
            int[] arr = new int[5];
            for(int i = 0; i <= 4; i++)
            {
                int n = r.Next(10, 51);
                Console.Write(n + " ");
                arr[i] = n;
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("\n\nAverage: " + (sum/arr.Length));
        }

        public static void AreaPeriOfCircle()
        {
            Console.WriteLine("Enter the diameter of a circle");
            double dia = Convert.ToInt64(Console.ReadLine());
            double radius = dia / 2;

            Console.WriteLine("Area is: " + (radius * 3.14 * radius)+" sq. unit");
            Console.WriteLine("Perimeter is: " + (2 * 3.14 * radius)+" unit");

        }

        public static void GenerateNextDay()
        {
            Console.Write("Input a year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Input a month [1-12]: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Input a day [1-31]: ");
            int day = int.Parse(Console.ReadLine());
            DateTime currentDate = new DateTime(year, month, day);

            DateTime nextDate = currentDate.AddDays(1);

            Console.WriteLine($"The next date is [yyyy-mm-dd] {nextDate:yyyy-MM-dd}");
        }

    }
}