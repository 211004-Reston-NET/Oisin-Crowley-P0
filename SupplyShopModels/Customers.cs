using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace SupplyShopModels
{
    public class Customers
    {

        //fields for customer information 
        public int CustomerID {get; set;}
        public string FName { get; set; }

        public string Lname { get; set; }

        public string city { get; set; }    
        
        public string state { get; set; }

        public string Email { get; set; }

        private string _phone;

        
        public string Phone
        {
            get { return _phone; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$"))
                {
                    //Phone number exception
                    throw new Exception("Not a valid phone number!");
                }
                _phone = value;
            }
        }

        public List<Orders> OrderList {get; set;}
        

        
    }
}