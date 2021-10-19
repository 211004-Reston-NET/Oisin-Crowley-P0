using System.Collections.Generic;
using SupplyShopModels;

namespace SupplyShopBL
{
    public interface IItemsBL 
    {
        List<Items> GetAllItems();

        Items AddItems (Items p_items);
        
        List<Items> GetItems(string p_itemName);
    }
}