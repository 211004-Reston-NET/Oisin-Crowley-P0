﻿using System;


namespace SupplyShopModels
{
    public class SupplyShop
    {
        public int itemQuanity { get; set; }

        public int itemPrice { get; set; }

        public string itemName {get; set;}


        public SupplyShop ()
        {
            itemQuanity = 0;
            itemPrice = 0;
            itemName = "Nothing yet";

           

        }

        public SupplyShop(string a,int b, int c)
        {
            itemName = a;
            itemPrice = b;
            itemQuanity = c;
        }


}




}
