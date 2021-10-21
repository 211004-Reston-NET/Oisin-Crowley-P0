using System;
using System.Collections.Generic;

namespace SupplyShopModels
{
    public class StoreFront
    {
        public string StoreName { get; set; }

      private string streetAdd;
      public string StreetAdd
      {
          get { return streetAdd; }
          set { streetAdd = value; }
      }
      
        

        public string City { get; set; } 

        public string State { get; set; }

        public string itemList { get; set; }

        public string OrderList { get; set; }

             public override string ToString()
        {
            string Stores = $@"Store Name: {StoreName}
Street Address: {StreetAdd}
City: {City}
State: {State}
Items : {itemList}
Orders : {OrderList}";
            return Stores;     
            
            }
    }
}