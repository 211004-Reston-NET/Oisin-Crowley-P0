using System;


namespace SupplyShopModels
{
    public class Orders
    {

        //fields for Order information 
        
        public string itemName { get; set; }

        public int itemAmount { get; set; }

        public decimal purchasePrice { get; set; }    
        
        public decimal totalPrice { get; set; }

        
    }
}