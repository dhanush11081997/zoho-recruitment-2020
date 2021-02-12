using System;

namespace zoho_recruitment_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the input:");
            string input = Console.ReadLine();
            if (input.Length % 2 == 1)
            {
                var laststring = input.Substring(input.Length / 2);
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j < laststring.Length)
                            Console.Write(laststring[j]);
                        else
                            Console.Write(input[j - laststring.Length]);
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Entered input is doesn't has odd letter count");
        }
    }
}
