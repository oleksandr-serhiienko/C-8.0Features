using System;
using System.Collections.Generic;
using System.Text;

namespace Demo8
{
    public static class NullCoalescingAssigment
    {
        public static void Deme()
        {
            var example = new ListDemo();

            //if (example.LuckyNumbers == null)
            //{
            //    example.LuckyNumbers = new List<int>();
            //}

            example.LuckyNumbers ??= new List<int>();

            example.LuckyNumbers.Add(27);
            foreach (var item in example.LuckyNumbers)
            {
                Console.WriteLine($"Lucky Number: {item}");
            }
        }
    }

    public class ListDemo
    {
        public List<int> LuckyNumbers { get; set; }
    }
}
