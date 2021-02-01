using System;

namespace MovieRental
{
    class Program
    {
        static void Main(string[] args)
        {
            var BW = new Actor("Bruce Willis", 2);
            var AR = new Actor("Alan Rickman", 3);

            var DHPrice = new Rent(149, true);

            var DHDir = new Director("John McTiernan");

            var DieHard = new Movie("Die Hard", 1988, 1, DHPrice, DHDir, BW, AR);

            Console.WriteLine(DieHard.ShowMovie());

        }
        
    }
}
