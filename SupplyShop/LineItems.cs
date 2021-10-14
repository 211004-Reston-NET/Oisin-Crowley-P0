namespace SupplyShop
{
    public class LineItems
    {
        private int _lineItemID;
        public  int LineItemID 
        {
            get { return _lineItemID; }

            set 
            { 
                _lineItemID = value ;
                
            }
        
        }
       private string _itemName;
       public string ItemName
       {
           get { return _itemName; }
           set { _itemName = value; }
       }

       private int _quantity;
       public int Quantity
       {
           get { return _quantity; }
           set { _quantity = value; }
       }
       
       
    }

}