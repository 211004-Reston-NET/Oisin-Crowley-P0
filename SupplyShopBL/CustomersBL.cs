using System;
using System.Collections.Generic;
using SupplyShopModels; 
using SupplyShopDL;


namespace SupplyShopBL
{
    public class CustomersBL : ICustomersBL
    {

            private IRepository _repo;

                //passing the  repo object 
            public CustomersBL(IRepository p_repo)
            {

                //setting private repository to pub
                _repo = p_repo;
            }

            public Customers AddCustomer(Customers p_cust)
            {
                return _repo.AddCustomer(p_cust);
            }

            public List<Customers> GetAllCustomers()
            {
                List<Customers>listOfCustomers = _repo.GetAllCustomers();
                for (int i = 0; i< listOfCustomers.Count; i++)
                {
                    listOfCustomers[i].Name = listOfCustomers[i].Name.ToUpper();
                }


                return listOfCustomers;
            }

            



    }
}
