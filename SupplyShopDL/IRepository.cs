using System.Collections.Generic;
using System;
using SupplyShopModels;

namespace SupplyShopDL
{
    public interface IRepository
    {
        /// <summary>
        /// it will add a customers in our database
        /// </summary>
        /// <param name="p_cust"> this is the customer we are returning </param>
        /// <returns> it will </returns>
        Customers AddCustomer(Customers p_cust);

        List<Customers> GetAllCustomers();


        Items AddItems(Items p_items);

        List<Items> GetAllItems();

        List<StoreFront> GetAllStores();

        StoreFront AddStoreFront(StoreFront p_stores);

        Items GetProductbyID(int p_id);
    }
}