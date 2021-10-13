using System;
using System.Collections.Generic;
using SupplyShopModels; 
using SupplyShopDL;


namespace SupplyShopBL
{
    public class StoreFrontBL 
    {
        private Repository _repo;

        public StoreFrontBL(Repository p_repo)
        {
            _repo = p_repo;
        }

        public StoreFront AddStoreFront(StoreFront p_store)
        {
            return _repo.AddStoreFront(p_store);
        }

        public List<StoreFront>GetStoreFronts()
        {
            List<StoreFront>listAllStoreFront = _repo.GetStoreFronts();

            return listAllStoreFront;
        }

        
    }
}