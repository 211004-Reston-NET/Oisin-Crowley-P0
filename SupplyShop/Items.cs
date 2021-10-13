using System;


namespace SupplyShopModels
{
    public class Items
    {
        public int itemId { get; set; }
        public int itemQuanity { get; set; }

        public int itemPrice { get; set; }

        public string itemName {get; set;}


        public Items ()
        {
            itemQuanity = 0;
            itemPrice = 0;
            itemName = "Nothing yet";

           

        }

        public Items(string a,int b, int c)
        {
            itemName = a;
            itemPrice = b;
            itemQuanity = c;
        }


}




}
