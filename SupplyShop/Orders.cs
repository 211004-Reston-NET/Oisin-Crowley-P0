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

        private int _storeid;
        public int StoreId
        {
            get { return _storeid; }
            set { _storeid = value; }
        }

        private int _lineitemid;
        public int LineItemId
        {
            get { return _lineitemid; }
            set { _lineitemid = value; }
        }

        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        
        
           
        
        

        
    }
}