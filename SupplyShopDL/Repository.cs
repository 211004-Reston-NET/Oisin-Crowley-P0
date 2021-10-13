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
        private const string _SfFilepath ="./../SupplyShopDL/Database/StoreFront.json";

        private string _jsonString;

        public Customers AddCustomer(Customers p_cust)
        {
            List<Customers> listOfCustomer = GetAllCustomers();

            listOfCustomer.Add(p_cust);

            _jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented = true});


            File.WriteAllText(_filepath,_jsonString);

            return p_cust;
        }
 public List<Customers> GetAllCustomers()
        {
                //  going to read all the customers.json file and conver it to a string to be interp
            _jsonString = File.ReadAllText(_filepath);


            //we are converting from a string to an object 
            return JsonSerializer.Deserialize<List<Customers>>(_jsonString);


        }
            //This is going to add store front
            // parameter being fed in is p_store
        public StoreFront AddStoreFront(StoreFront p_store)
        {
                List<StoreFront> listofStores = GetStoreFronts();

                listofStores.Add (p_store);

             _jsonString = JsonSerializer.Serialize(listofStores, new JsonSerializerOptions{WriteIndented = true});

             return p_store;
        }
        
        //getting all store fronts        
        public List<StoreFront> GetStoreFronts()
        {
            _jsonString = File.ReadAllText(_SfFilepath);

            return JsonSerializer.Deserialize<List<StoreFront>>(_jsonString);
        }
    }
}