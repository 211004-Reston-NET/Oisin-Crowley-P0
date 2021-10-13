using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SupplyShopModels;

namespace  SupplyShopDL
{
    public class Repository
    {
        private const string _filepath ="./../SupplyShopDL/Database/Customers.json";

        private string _jsonString;

        public List<Customers> GetAllCustomers()
        {
                //  going to read all the customers.json file and conver it to a string to be interp
            _jsonString = File.ReadAllText(_filepath);


            //we are converting from a string to an object 
            return JsonSerializer.Deserialize<List<Customers>>(_jsonString);


        }
        public Customers AddCustomer(Customers p_cust)
        {
            List<Customers> listOfCustomer = GetAllCustomers();

            listOfCustomer.Add(p_cust);

            _jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented = true});


            File.WriteAllText(_filepath,_jsonString);

            return p_cust;
        }

    }
}