using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class ClassWork
    {
        //1. Write a program that merges two sorted arrays into a single sorted array.
        public static void MergeArray()
        {
            int[] arr = CreateArray();
            Console.WriteLine("===================");
            int[] ar2 = CreateArray();

            int n1 = arr.Length;
            int n2 = ar2.Length;

            int[] result = new int[n1 + n2];
            int i = 0;
            int j = 0;
            int k = 0;

            //Compare both arrays element to store the smallest
            while (i < n1 && j < n2)
            {
                if (arr[i] <= ar2[j])
                {
                    result[k++] = arr[i++];
                }
                else
                {
                    result[k++] = ar2[j++];
                }
            }

            //To store the remaining elements from the array
            while (i < n1)
            {
                result[k++] = arr[i++];
            }

            while (j < n2)
            {
                result[k++] = ar2[j++];
            }

            Console.WriteLine("Merged Sorted Array:");
            foreach (int val in result)
            {
                Console.Write(val+" ");
            }
            Console.WriteLine("\n==============");
        }

        //2. Write a program that finds the second largest element in an array of integers.
        public static void SecondLargest()
        {
            int[] result = CreateArray();

            int h1 = int.MinValue;
            int h2 = int.MinValue;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > h1)
                {
                    //Found the 1st highest
                    h2 = h1;
                    h1 = result[i];
                }
                else if (result[i] > h2 && result[i] != h1)
                {
                    //2nd highest will be found by comparing to 1st highest with other elements
                    h2 = result[i];
                }
            }
            Console.WriteLine("Second Highest is: " + h2);
        }

        //3. Write a program that removes duplicate elements from an array and prints the result
        public static void RemoveDuplicates()
        {
            int[] arr = CreateArray();

            Console.WriteLine("\nAfter removing duplicates: ");
            //Distinct()-'LINQ' will remove all the duplicates from the given collection of data
            var result = arr.Distinct();
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        //4. Write a program that finds the missing number in an array of integers from 1 to n.
        public static void FindMissingNumber()
        {
            int[] arr = CreateArray(); 
            int n = arr.Length + 1; 

            //Calculate the sum of element starting from 1 to n+1 
            int expectedSum = n * (n + 1) / 2;

            //actual sum of the entered element
            int actualSum = arr.Sum();

            //By subtracting the sum it will get the missing number
            int missingNumber = expectedSum - actualSum;

            Console.WriteLine("The missing number is: " + missingNumber);
        }

        //5. Write a program that finds the common elements between two arrays.
        public static void FindCommonElements()
        {
            int[] arr1 = CreateArray();
            Console.WriteLine("===================");
            int[] arr2 = CreateArray();

            Console.WriteLine("Common elements:");
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        //If duplicates will be found then printed and break the loop
                        Console.WriteLine(arr1[i]);
                        break;
                    }
                }
            }
        }

        public static int[] CreateArray()
        {
            Console.WriteLine("Enter the size of an Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element for " + (i + 1) + " position: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe Elements are: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            return arr;
        }

        //1   Write a program that calculates the sum of the digits of a given integer.
        public static void SumOfDigits()
        {
            Console.WriteLine("Enter the Num:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (n > 0)
            {
                //stores the remainder
                int rem = n % 10;
                //sum with the remainder (last digit)
                sum += rem;
                //remove the last digit after summation
                n = n / 10;
            }
            Console.WriteLine("The sum is: " + sum);
        }

        //2   Write a program that converts a given decimal number to its binary equivalent.
        public static void ConvertToBinary()
        {
            Console.WriteLine("Enter the Num:");
            int n = Convert.ToInt32(Console.ReadLine());

            //empty string to store the binary
            string bin = "";
            //loop will continue till the number becomes zero
            while (n > 0)
            {
                //remainder will be stored by dividing to 2
                int rem = n % 2;
                //concats with the empty string
                bin = rem+bin;
                //Decrease the actual number 
                n = n / 2;
            }
            Console.WriteLine("The Binary of "+n+" is: "+bin);
        }

        //3   Write a program that generates all permutations of a given string.
        public static void GeneratePermutations(string prefix, string str)
        {
            // Base case: If the string is empty, print the current prefix (which is a permutation)
            if (str.Length == 0)
            {
                Console.WriteLine(prefix);
            }
            else
            {
                // Iterate through each character in the string
                for (int i = 0; i < str.Length; i++)
                {
                    // Create a new prefix by adding the current character 
                    string newPrefix = prefix + str[i];

                    // Create a new string by removing the current character 
                    string newStr = str.Substring(0, i) + str.Substring(i + 1);

                    // Recursively generate permutations for the new prefix and string
                    GeneratePermutations(newPrefix, newStr);
                }
            }
        }

        //4   Write a program that removes all vowels from a given string.
        public static void RemoveVowels()
        {
            Console.WriteLine("Enter the String:");
            string str = Console.ReadLine();
            //Taking empty string to store string after removing vowels
            string vowels = "";
            //Converts to lower case
            str.ToLower();
            for(int i = 0; i < str.Length; i++)
            {
                //iterate through each character
                if (str[i] != 'a' && str[i] != 'e' && str[i] != 'i' && str[i] != 'o' && str[i] != 'u')
                {
                    //concat only if it is not a vowel
                    vowels = vowels + str[i];
                }
            }

            Console.WriteLine("After Removing Vowels: " + vowels);
        }

        //5   Write a program that calculates the compound interest for a given principal, rate, and time period.
        public static void FindCompoundInterest()
        {
            Console.WriteLine("Enter the Principal: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Time Period: ");
            double t = double.Parse(Console.ReadLine());

            double amount = p*(Math.Pow((1 + r / 100), t));
            Console.WriteLine("The CI: " + (amount-p));
        }

        //1 Write a program that checks if a given string has all unique characters
        public static bool CheckUnique()
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            char[] str1 = str.ToCharArray();
            for(int i = 0; i < str1.Length; i++)
            {
                for(int j = i+1; j < str1.Length; j++)
                {
                    if (str1[i] == str1[j])
                    {
                        //if anywhere the character found to be same it will return false
                        return false;
                    }
                }
              
            }
            //if the loop is completed and it comes out then it will return true as it didn't find any matching characters
            return true;
        }

        //2 Write a program that generates and prints all prime numbers up to a given number n. 
        public static void PrintPrime(int n)
        {
            for(int i = 2; i <= n; i++)
            {
                if (PrimeCheck(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static bool PrimeCheck(int n)
        {
            //Loop till the square root of a number to check the divisibilty 
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    //if divides then it will not be a prime
                    return false;
                }
            }
            return true;
        }

        //3 Write a program that checks if two given strings are anagrams of each other.
        public static bool CheckAnagrams()
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();

            if (str1.Length != str2.Length)
            {
                //if both the strings are of different length then not an anagram 
                return false;
            }

            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            // if strings after sorting and converting to char [] equals then it is anagram
            return new string(charArray1) == new string(charArray2);
        }

        //5 Write a program that reverses the words in a given sentence without changing the order of the words.
        public static void ReverseEachWord()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            //split the sentence with spaces
            string[] words = sentence.Split(' ');
            //empty string to store the reversed sentence
            string reversedSentence = "";

            foreach (string word in words)
            {
                //iterate on array after split
                string reversedWord = "";

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    //concat the words after reversing 
                    reversedWord += word[i];
                }
                //each words after reversing concats to the final sentence
                reversedSentence += reversedWord + " ";
            }
            
            //trim the final sentence if there are an empty spaces
            reversedSentence.Trim();
            Console.WriteLine("The sentence with reversed words is:");
            Console.WriteLine(reversedSentence);
        }

        //4 Write a program that finds the longest substring in a given string that does not contain any repeating characters. 
        public static void LongestUniqueSubstring()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Initialize variables to store the longest and current substrings
            string longest = "";
            string current = "";

            // Iterate through each character in the input string
            foreach (char c in input)
            {
                // If the current character is already present in the current substring
                if (current.Contains(c))
                {
                    // Check if the current substring is longer than the longest substring found so far
                    if (current.Length > longest.Length)
                    {
                        longest = current;
                    }

                    // Find the index of the duplicate character in the current substring
                    int index = current.IndexOf(c);

                    // Remove the characters up to and including the duplicate character
                    current = current.Substring(index + 1);
                }

                // Append the current character to the current substring
                current += c;
            }

            // Check if the final current substring is longer than the longest substring
            if (current.Length > longest.Length)
            {
                longest = current;
            }

            Console.WriteLine("Longest unique substring: " + longest);
        }

    }
}
