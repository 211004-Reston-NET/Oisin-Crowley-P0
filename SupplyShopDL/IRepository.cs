using System.Collections.Generic;
using System;
using SupplyShopModels;

namespace SupplyShopDL
{
    public interface IRepository
    {
        Customers AddCustomer(Customers p_cust);

        Customers GetAllCustomers(Customers p_cust);
    }
}