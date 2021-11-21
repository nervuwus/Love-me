namespace LoveMe
{
    class Petal
    {
        static void Main()
        {
            Console.WriteLine("Choose a number of petal");
            var prompt = Console.ReadLine();
            Dictionary<int, string> petal = new Dictionary<int, string>();

            for (int i = 0; i < Int16.Parse(prompt); i++)
            {
                int even = CheckEven(i);
                if (even == 0)
                    petal.Add(i, "Love me");
                else
                    petal.Add(i, "Love me not");
            }


            foreach (KeyValuePair<int, string> keys in petal)
            {
                int max = Int16.Parse(prompt) - 1;
                if (keys.Key.Equals(max))
                    Console.WriteLine(keys.Value.ToUpper());
                else Console.WriteLine(keys.Value);
            }
        }

        static int CheckEven(int key)
        {
            int remainder = ((key % 2 == 0) ? 1 : 0 );
            return remainder;
        }

    }
}
