using SupplyShopModels;
using System.Collections.Generic;
using SupplyShopDL;
using System;
using System.IO;

namespace SupplyShopBL

{
    public class SearchCustomerBL
    {

        Repository SearchItem = new Repository(); 
        private Repository _repo;

        //passing the  repo object p_repo
        public SearchCustomerBL(Repository p_repo)
        {

            //setting private repository to pub
            _repo = p_repo;
        }
        public List<Customers> GetAllCustomers()
        {
            List<Customers> listOfCustomers = _repo.GetAllCustomers();
            for (int i = 0; i < listOfCustomers.Count; i++)
            {
                listOfCustomers[i].Name = listOfCustomers[i].Name.ToUpper();
            }


            return listOfCustomers;
        }

       
    }
}