using System;


namespace SupplyShopModels
{
    public class Items
    {
        
        public int itemId { get; set; }
        

        public int itemPrice { get; set; }
        public int itemQuanity {get ; set;}
        public string itemName {get; set;}

        public override string ToString()
        {
            string Items = $@"{itemId}
{itemPrice}
{itemQuanity}
{itemName}";
            return Items;     
            
            }

      


}




}
