using System;
using System.Collections.Generic;
using SupplyShopModels; 
using SupplyShopDL;


namespace SupplyShopBL
{
    public class ItemsBL : IItemsBL
    {

            private Repository _repo;

                //passing the  repo object p_repo
            public ItemsBL(Repository p_repo)
            {

                //setting private repository to pub
                _repo = p_repo;
            }

            public Items AddItems(Items p_items)
            {
                return _repo.AddItems(p_items);
            }

            public List<Items> GetAllItems()
            {
                List<Items>listOfItems = _repo.GetAllItems();
                for (int i = 0; i< listOfItems.Count; i++)
                {
                    listOfItems[i].itemName = listOfItems[i].itemName.ToUpper();
                }


                return listOfItems;
            }

          

            



    }
}
