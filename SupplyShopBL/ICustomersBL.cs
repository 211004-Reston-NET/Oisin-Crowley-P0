using System.Collections.Generic;
using SupplyShopModels;

namespace SupplyShopBL
{
    public interface ICustomersBL
    {
       ///  This will return all customer store in the database  
        List<Customers> GetAllCustomers();


/// <summary>
/// Adding a customer to the database 
/// </summary>
/// <param name="p_cust"> this is the customer we are adding </param>
/// <returns></returns>
        Customers AddCustomer(Customers p_cust);
    }
}
