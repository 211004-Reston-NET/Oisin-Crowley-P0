using System;


namespace SupplyShopModels
{
    public class Orders
    {

        //fields for Order information 
        private int _orderID;
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        
      
        private string _itemname;
        public string itemName
        {
            get { return _itemname; }
            set { _itemname = value; }
        }
        

        public int orderQuanity {get ; set;}
        public int totalPrice { get; set; } 

        public string storeLocation { get; set; }   
        
        

        
    }
}