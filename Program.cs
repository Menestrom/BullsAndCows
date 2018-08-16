using System;

namespace ConsoleApplication2
{
    class BullsandCows
    {
        int value;
        string random;
        static void Main()
        {
            random = Random();
            value = Input();
        }

        public int Input()
        {
            Console.WriteLine("Insert value lenght");
            int finalValue;
            string input = Console.ReadLine();
            bool value = Int32.TryParse(input, out finalValue);
            if (value)
            {
                return finalValue;
            }
            else
            {
                Console.WriteLine("Wrong value - {0}, please intup number", input);
                return finalValue;
            }
        }
        public string Random()
            {
            string RandomString = "";
            Random rnd = new Random();
            for (int i = 0; i < value; i++)
            {            
                RandomString += rnd.Next(0, 9);
            }
            Console.WriteLine(RandomString);
            return RandomString;
            }
        public void Bulls()
        {

        }
        public void Cows()
        {

        }
        public void PlayerTry()
        {
            string n = "";
            while (n != random)
            {
                Console.WriteLine("Try u'r luck");
                n = Console.ReadLine();
            }
        }

    }
}