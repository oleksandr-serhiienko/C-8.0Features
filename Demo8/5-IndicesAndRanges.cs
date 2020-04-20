using System;
using System.Collections.Generic;
using System.Text;

namespace Demo8
{
    public static class IndicesAndRanges
    {
        public static void Demo ()
        {
            var places = new string[] { "first", "second", "third", "forth", "fifth" };

            Console.WriteLine($"The last item is {places[^1]}");
            Console.WriteLine($"The second last item is {places[^2]}");

            foreach (var item in places[1..^2])
            {
                Console.WriteLine(item);                
            } 
        }
    }
}
