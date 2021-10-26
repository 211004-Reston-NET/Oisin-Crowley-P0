using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace SupplyShopModels
{
    public class Customers
    {

        //fields for customer information 
       private int _customerid;
       public int CustomerID
       {
           get { return _customerid; }
           set { _customerid = value; }
       }
       
       
       private string _name;
       public string Name
       {
           get { return _name; }
           set { _name = value; }
       }

/// <summary>
/// street address 
/// </summary>
       private string _streetAdd;
       public string StreetAdd
       {
           get { return _streetAdd; }
           set { _streetAdd = value; }
       }
       
       
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
     

        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
          
        
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        

        

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

            private int _orderid;
            public int OrderID
            {
                get { return _orderid; }
                set { _orderid = value; }
            }
            
        

          public override string ToString()
        {
            string Customers = $@"Name: {Name}
Street Address: {StreetAdd}
City: {City}
State: {State}
Email : {Email}
Phone : {Phone}";
            return Customers;     
            
            }

        
    }
}