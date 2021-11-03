using System;
using System.Text.RegularExpressions;

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
            set { 
                
               
                
                
                
                _itemQuanity = value; }
        }
        
        private string _itemName;
        public string itemName
        {
            get { return _itemName; }
            set { 
                
                
                        //Regex expression to only hold letters 
                   if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Item Name can only hold letters!");
                }
                
                
                
                
                _itemName = value; }
        }

      private string _itemdesc;
      public string ItemDesc
      {
          get { return _itemdesc; }
          set { 
              
                       //Regex expression to only hold letters 
                   if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Item Description can only hold letters!");
                }
              
              
              
              
              _itemdesc = value; }
      }

      private string _category;
      public string Category
      {
          get { return _category; }
          set { 
              
                     //Regex expression to only hold letters 
                   if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Category can only hold letters!");
                }
              
              
              
              _category = value; }
      }

      private int _storeid;
      public int StoreID
      {
          get { return _storeid; }
          set { _storeid = value; }
      }
      
      
      
       
        
        
        

        public override string ToString()
        {
            string Items = $@"Item Id: {itemId}
Item Price: ${itemPrice}
Item Name: {itemName}
Stock Quantity:  {itemQuanity}
Product Category {Category}
Description: {ItemDesc}";
            return Items;     
            
            }

      


}




}
