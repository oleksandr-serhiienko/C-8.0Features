using System;
using System.Collections.Generic;
using System.Text;

namespace Demo8
{
    public interface IShoppingCart
    {
        public static void SetDefaultName(string name)
        {
            defaultName = name;
        }
        private static string defaultName = "default";

        void CalculateSubTotal()
        {
            Console.WriteLine($"Calculating {defaultName} SubTotal...");
        }
        void CalculateTotal();
    }

    public interface ISubTatal
    {
        void CalculateSubTotal ()
        {
            Console.WriteLine("smth more else");
        }
    }

    public class ShoppingCart : IShoppingCart, ISubTatal 
    {
        public void CalculateTotal()
        {
            Console.WriteLine("Calculating...");
        }
    }

    public class BetterShoppingCart : IShoppingCart
    {
        //public BetterShoppingCart()
        //{
        //    IShoppingCart.SetDefaultName("DefaultBetterShopping"); 
        //}

        public void CalculateSubTotal()
        {
            Console.WriteLine("Smth new");
        }

        public void CalculateTotal()
        {
            Console.WriteLine("Calculating...");
        }
    }
}
