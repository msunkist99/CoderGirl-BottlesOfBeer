using System;

namespace BottlesOfBeer
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Output "99 bottles of beer on the wall.  99 bottles of beer.  Take 1 down and pass it around, 98 bottles of beer on the wall.";
            // Count down until there are no more bottles of beer on the wall.

            for (int i = 99; i > 0; i--)
            {
                Console.WriteLine("{0} bottles of beer on the wall.  {0} bottles of beer.   Take 1 down and pass it around, {1} bottles of beer on the wall.", i, (i-1));
            }
            Console.ReadLine();
        }
    }
}
