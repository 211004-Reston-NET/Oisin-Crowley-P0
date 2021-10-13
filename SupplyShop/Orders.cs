using System;


namespace SupplyShopModels
{
    public class Orders
    {

        //fields for Order information 
        public int OrderId { get; set; }
        public string itemName { get; set; }

        public int itemQuanity {get ; set;}
        public decimal totalPrice { get; set; } 

        public string storeLocation { get; set; }   
        
        

        
    }
}