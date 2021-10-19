using System;


namespace SupplyShopModels
{
    public class Items
    {
        private int _itemId;
        public int itemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        
        private int _itemPrice;
        public int itemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; }
        }
        
        

        private int _itemQuanity;
        public int itemQuanity
        {
            get { return _itemQuanity; }
            set { _itemQuanity = value; }
        }
        
        private string _itemName;
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        
        

        public override string ToString()
        {
            string Items = $@"Item Id: {itemId}
Item Price: ${itemPrice}
Item Quantity: {itemQuanity}
Item Name: {itemName}";
            return Items;     
            
            }

      


}




}
