using System;
using System.Collections.Generic;
using SupplyShopModels; 
using SupplyShopDL;
using System.Linq;

namespace SupplyShopBL

    

{
    public class OrdersBL : IOrdersBL
    {
            private Repository _repo;

                //passing the  repo object p_repo
            public OrdersBL(Repository p_repo)
            {

                //setting private repository to pub
                _repo = p_repo;
            }

            public Orders AddOrders(Orders p_orders)
            {
                return _repo.AddOrders(p_orders);
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