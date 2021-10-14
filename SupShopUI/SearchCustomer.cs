using SupShopUI;
using System;

namespace SupShopUi
{
    public class SearchCustomer : IStoreFront
    {
        public void Display()
        {
            Console.WriteLine("Search for a customer");
        }

        public DirectoryChoice YourChoice()
        {
            throw new System.NotImplementedException();
        }
    }
}