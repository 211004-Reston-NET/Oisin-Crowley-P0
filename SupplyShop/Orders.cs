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
        
      
        
        

        
        public double totalPrice { get; set; } 

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

        
        private int _customerid;
        public int CustomerID
        {
            get { return _customerid; }
            set { _customerid = value; }
        }
        
        
        
           
        
        

        
    }
}