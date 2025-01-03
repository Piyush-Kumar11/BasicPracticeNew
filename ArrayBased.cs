using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class ArrayBased
    {
        public static void SmallestGap()
        {
            int[] arr = CreateArray();
            int gap = int.MaxValue;

            if (arr.Length < 2)
            {
                Console.WriteLine("Array must have at least two elements.");
                return;
            }

            for(int i = 0; i < arr.Length-1; i++)
            {
                int currentGap = Math.Abs(arr[i] - arr[i + 1]);
                if (currentGap < gap)
                {
                    gap = currentGap;
                }
            }
            Console.WriteLine("The smallest Gap between elements is : " + gap);
        }

        public static void RemoveDuplicates()
        {
            //Object[] arr = {"Hey",2.5,'C',"Java","Hey",'D','c',55,2 };
            int[] arr = CreateArray();

            Console.WriteLine("\nAfter removing duplicates: ");
            var newArr = arr.Distinct();
            foreach ( var item in newArr )
            {
                Console.Write( item+" " );
            }
        }

        public static void SecondLargest()
        {
            int[] arr = CreateArray();

            int h1 = int.MinValue;
            int h2 = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > h1)
                {
                    h1 = arr[i];
                }else if (arr[i] > h2 && arr[i]<h1)
                {
                    h2 = arr[i];
                }
            }
            Console.WriteLine("2nd Highest is: " + h2);
        }

        public static void Exceptions()
        {
            int[] arr = { 2, 4, 8, 9 };

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);

            try
            {
                Console.WriteLine(arr[4]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exception Handled");
            }
            
        }

        public static int[] CreateArray()
        {
            Console.WriteLine("Enter the size of an Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element for " + (i + 1) + " position: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }

            Console.WriteLine("\nThe Elements are: ");
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            return arr;
        }

        public static void FindFirstRepeatedElement()
        {
            int[] arr = CreateArray();
            int index = 0;

            for(int i = 0;i < arr.Length;i++)
            {
                for(int j = i+1; i<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        index = i;
                        Console.WriteLine("First Repeated Element is: " + arr[i]);
                        return;
                    }
                }
            }
        }

        //Write a Program to shift all zero to the end of array.
        public static void ShiftZerosToEnd()
        {
            int[] ar = { 23, 4, 0, 2, 0, 89 };
            int[] ar2 = new int[ar.Length];

            int j = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] != 0)
                {
                    ar2[j] = ar[i];
                    j++;
                }
            }

            foreach (int i in ar2)
            {
                Console.Write(i + " ");
            }

        }

        //Write a program that takes an array of floats and returns the average of these numbers
        public static void AvgOfNumber()
        {
            float sum = 0.0f;
            float[] num = { 2.5f, 5.8f, 88.4f, 52f };
            foreach (float f in num)
            {
                sum += f;
            }
            Console.WriteLine("Avg is: " + (sum / num.Length));
        }
    }
}
