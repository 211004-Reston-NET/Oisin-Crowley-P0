using System.Collections.Generic;
using SupplyShopModels;

namespace SupplyShopBL
{
    public interface IStoreFrontBL 
    {
        List<StoreFront> GetAllStores();

        StoreFront AddStoreFront (StoreFront p_store);
        
        
    }
}