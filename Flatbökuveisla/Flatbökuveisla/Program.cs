using System;

namespace Pizza

{
    class Flatbökuveisla
    {
        static void Main(string[] args)
        {
            // number of pizza slices is "n"
            // number of members in the household are "m"

            Console.WriteLine("Enter the number of Pizza slices that was delivered:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of people that will eat the pizza:");
            int m = int.Parse(Console.ReadLine());

            if (n % m == 0)
            {
                Console.WriteLine("Everyone is happy");

            }
            else
            {
                Console.WriteLine(n % m);
            }
        }
    }
}