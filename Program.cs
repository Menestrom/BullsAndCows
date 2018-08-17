using System;
using System.Linq;


namespace BullsAndCows
{
    class BullsAndCows
    {
        static int numberLength;
        static string finalRandom;
        static string CheckNumber;
        static int Bulls;
        static int Cows;
        static void Main()
        {
            BullsAndCows Start = new BullsAndCows();
            numberLength = Start.Input();
            Start.Randomizer();
            Console.WriteLine("FinalRandom = {0}", finalRandom);
            Start.Looped_call();
        }
        public int Input()
        {
            Console.WriteLine("Enter length to generate the number: ");
            bool check = int.TryParse(Console.ReadLine(), out numberLength);
            if (check)
            {
                return numberLength;
            }
            else
            {
                Console.WriteLine("Wrong type! Use integer to enter length to generate the number:");
                return numberLength;
            }
        }
        public string Randomizer()
        {
            
            Random rnd = new Random();
            for (int i = 0; i < numberLength; i++)
            {
                finalRandom += rnd.Next(0,9);
            }
            return finalRandom;
        }

        public void BullsNumber()
        {
            char[] random_array = finalRandom.ToCharArray();
            char[] input_number = CheckNumber.ToCharArray();
            for (int i = 0; i < (random_array.Length); i++)
            {
                if (random_array[i] == input_number[i])
                {
                    Bulls += 1;        
                }
            }
        }
        public void CowsNumber()
        {
            var finalRandom_string = finalRandom.Select(c => c.ToString()).ToList();
            var CheckNumber_string = CheckNumber.Select(c => c.ToString()).ToList();
            int Cows_number = finalRandom_string.Intersect(CheckNumber_string).Count();
            Cows += Cows_number;
            if (Bulls >= Cows)
            {
                Cows -= Cows_number;
            }
        }
        public void Looped_call()
        {
            while (finalRandom != CheckNumber)
            {
                Console.WriteLine("Please enter number with {0} - symbols length", numberLength);
                CheckNumber = Console.ReadLine();
                BullsNumber();
                CowsNumber();
                if (CheckNumber.Length > numberLength)
                {
                    Console.WriteLine("Wrong length!!!U entered {0}", CheckNumber.Length);
                    
                }
                else if (finalRandom != CheckNumber)
                {
                    Console.WriteLine("Cows = {0}, Bulls = {1}", Cows, Bulls);
                }
                else
                {
                    Console.WriteLine("Congratulate, u guess the number! It's {0}", CheckNumber);
                }
            }
        }
    }
}
