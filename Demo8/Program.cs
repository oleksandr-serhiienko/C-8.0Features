using System;

namespace Demo8
{
    class Program
    {
        static void Main(string[] args)
        {

            ISubTatal cart2 = new ShoppingCart();
            cart2.CalculateSubTotal();
            IShoppingCart cart1 = new BetterShoppingCart();
            cart1.CalculateSubTotal();

            Console.ReadLine();
        }
    }
}
