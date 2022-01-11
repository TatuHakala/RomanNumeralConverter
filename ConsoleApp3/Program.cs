using System;

namespace NumbersToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string Roman = "";
            //User types number between 1 and 3999.
            Console.WriteLine("Enter a numberbetween 1 and 3999: ");
            string input = Console.ReadLine();
            //Checks if the given value is a number between 1 and 3999.
            bool isParsable = Int32.TryParse(input, out number);
            if (!isParsable || number <= 1 || number >= 3999)
            {
                //Program closes if the given value is incorrect.
                Console.WriteLine("Incorrect number or not number at all. Try again.");
                System.Environment.Exit(0);
            }

            while (number > 0)
            {
                //Adds the biggest possible roman numeral to the string and removes the added value from the number int
                while (number >= 1000) { Roman += "M"; number -= 1000; }
                while (number >= 900) { Roman += "CM"; number -= 900; }
                while (number >= 500) { Roman += "D"; number -= 500; }
                while (number >= 400) { Roman += "CD"; number -= 400; }
                while (number >= 100) { Roman += "C"; number -= 100; }
                while (number >= 90) { Roman += "XC"; number -= 90; }
                while (number >= 50) { Roman += "L"; number -= 50; }
                while (number >= 40) { Roman += "XL"; number -= 40; }
                while (number >= 10) { Roman += "X"; number -= 10; }
                while (number >= 9) { Roman += "IX"; number -= 9; }
                while (number >= 5) { Roman += "V"; number -= 5; }
                while (number >= 4) { Roman += "IV"; number -= 4; }
                while (number >= 1) { Roman += "I"; number -= 1; }


            }

            Console.WriteLine("Roman numeral: " + Roman);
            Console.ReadLine();

        }


    }
}