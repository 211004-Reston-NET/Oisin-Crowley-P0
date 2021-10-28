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
        
        private double _itemPrice;
        public double itemPrice
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

      private string _itemdesc;
      public string ItemDesc
      {
          get { return _itemdesc; }
          set { _itemdesc = value; }
      }

      private string _category;
      public string Category
      {
          get { return _category; }
          set { _category = value; }
      }
      
      
       
        
        
        

        public override string ToString()
        {
            string Items = $@"Item Id: {itemId}
Item Price: ${itemPrice}
Item Name: {itemName}";
            return Items;     
            
            }

      


}




}
