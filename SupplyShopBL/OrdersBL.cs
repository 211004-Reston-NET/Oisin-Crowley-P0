using System;
using System.Collections.Generic;
using SupplyShopModels; 
using SupplyShopDL;
using System.Linq;

namespace SupplyShopBL

    

{
    public class OrdersBL : IOrdersBL
    {
            private IRepository _repo;

                //passing the  repo object p_repo
            public OrdersBL(IRepository p_repo)
            {

                //setting private repository to pub
                _repo = p_repo;
            }

            

        
        public List<Orders> GetAllOrders()
            {
                List<Orders>listOfOrders = _repo.GetAllOrders();
                for (int i = 0; i< listOfOrders.Count; i++)
                {
                    listOfOrders[i].itemName = listOfOrders[i].itemName.ToUpper();
                }


                return listOfOrders;
            }

          
    }
}