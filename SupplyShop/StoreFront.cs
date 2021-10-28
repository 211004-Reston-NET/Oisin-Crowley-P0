using System;
using System.Collections.Generic;

namespace SupplyShopModels
{
    public class StoreFront
    {
        private int _storeID;
        public int StoreID
        {
            get { return _storeID; }
            set { _storeID = value; }
        }
        
        private string _storename;
        public string StoreName
        {
            get { return _storename; }
            set { _storename = value; }
        }
        

      private string _streetAdd;
      public string StreetAdd
      {
          get { return _streetAdd; }
          set { _streetAdd = value; }
      }
      
        

        public string City { get; set; } 

        public string State { get; set; }

        private int _zip;
        public int Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        

        private int _productID;
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        

        

        private int _orderid;
        public int OrderID
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        

             public override string ToString()
        {
            string Stores = $@"Store Name: {StoreName}
Street Address: {StreetAdd}
City: {City}
State: {State}
Zip: {Zip}
Items : {ProductID}
Orders : {OrderID}";
            return Stores;     
            
            }
    }
}