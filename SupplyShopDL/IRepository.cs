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
    }
}