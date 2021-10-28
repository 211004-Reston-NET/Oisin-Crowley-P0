using System;
using System.Collections.Generic;
using SupplyShopModels; 
using SupplyShopDL;
using System.Linq;

namespace SupplyShopBL
{
    public class CustomersBL : ICustomersBL
    {

            private IRepository _repo;

                //passing the  repo object p_repo
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
            /// <summary>
            /// this is getting the customer for the search we're carrying out for the customer
            /// </summary>
            /// <param name="p_Name"> passing the parameter of the name to search for. </param>
            /// <returns></returns>
            public List<Customers> GetCustomers(string p_Name)
            {
                List<Customers>listOfCustomers = _repo.GetAllCustomers();

                return listOfCustomers.Where(cust => cust.Name.ToUpper().Contains(p_Name.ToUpper())).ToList();
            }

        
    }
}
