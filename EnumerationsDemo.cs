using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPracticeNew
{
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum Level
    {
        Low = 1,
        Medium = 5,
        High = 10
    }

    public enum Directions
    {
        North,
        East,
        South,
        West
    }

    public enum Status
    {
        Pending,
        Approved,
        Rejected
    }

    public enum Months
    {
        January,
        February,
        March
    }

    public enum Weather
    {
        Sunny,
        Cloudy,
        Rainy,
        Snowy
    }

    public class EnumerationsDemo
    {
        public static void BasicEnumDemo()
        {
            Days today = Days.Wednesday;
            Console.WriteLine($"Today is: {today}");
            Console.WriteLine($"Numeric Value of {today}: {(int)today}");
        }

        public static void EnumWithExplicitValues()
        {
            Level myLevel = Level.Medium;
            Console.WriteLine($"Level: {myLevel}, Value: {(int)myLevel}");
        }

        public static void IterateEnumValues()
        {
            foreach (var direction in Enum.GetValues(typeof(Directions)))
            {
                Console.WriteLine(direction);
            }
        }

        public static void EnumComparison()
        {
            Status currentStatus = Status.Pending;
            if (currentStatus == Status.Pending)
            {
                Console.WriteLine("The status is Pending.");
            }
        }

        public static void EnumToStringConversion()
        {
            Months currentMonth = Months.February;
            Console.WriteLine($"Month: {currentMonth.ToString()}");
        }

        public static void EnumDefaultValue()
        {
            Weather defaultWeather = default;
            Console.WriteLine($"Default Weather: {defaultWeather}");
        }

        public static void RunAllExamples()
        {
            Console.WriteLine("=== Basic Enum Demo ===");
            BasicEnumDemo();
            Console.WriteLine("\n=== Enum with Explicit Values ===");
            EnumWithExplicitValues();
            Console.WriteLine("\n=== Iterate Enum Values ===");
            IterateEnumValues();
            Console.WriteLine("\n=== Enum Comparison ===");
            EnumComparison();
            Console.WriteLine("\n=== Enum to String Conversion ===");
            EnumToStringConversion();
            Console.WriteLine("\n=== Enum Default Value ===");
            EnumDefaultValue();
        }
    }
}
