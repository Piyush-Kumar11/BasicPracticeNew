using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class StringBased
    {
        /* Write a program which takes a string as user input and checks presence of a, e and p.If all these three  characters are present , it prints  "All Present" or if any one of these three is present, it print "One or more - Present", if none is present, it prints "None Present". 
        Test this with different combination of strings.
        Plan using logical AND n OR
       */
        public static void CheckString()
        {
            Console.WriteLine("Enter the String: ");
            string s = Console.ReadLine();
            s.ToLower();
            int aCount = 0;
            int eCount = 0;
            int pCount = 0;
            int other = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                    aCount++;
                else if(s[i] == 'e')
                    eCount++;
                else if (s[i] == 'p')
                    pCount++;

                else if (s[i] == 'a' || s[i] == 'e' || s[i] == 'p')
                {
                    other++;
                }
            }
            if (aCount > 0 && eCount>0 && pCount>0)
                Console.WriteLine("All Present");

            else if(other > 0)
                Console.WriteLine("One/More Present");
            
            else
                Console.WriteLine("None");
        }

        public static void PrintPlaceName()
        {
            Console.WriteLine("Enter the place:");
            string place = Console.ReadLine();
            Console.WriteLine(place.ToUpper());
            Console.WriteLine(place.ToLower());
        }
        public static void PrintNames()
        {
            Console.WriteLine("Harry");
            Console.WriteLine("Jack");
            Console.WriteLine("Piyush");
            Console.WriteLine("Anmol");
            Console.WriteLine("Kellen");

        }
    }
}
