using System.Collections.Generic;
using Model = SupplyShopModels;
using Entity = SupplyShopDL.Entities;
using System.Linq;
using SupplyShopModels;
using SupplyShop;

namespace SupplyShopDL
{
    public class RepositoryCloud : IRepository
    {
       private Entity.SupplyShopDatabaseContext _context;

        public RepositoryCloud(Entity.SupplyShopDatabaseContext p_context)
        {
            _context = p_context;
        }
        public Model.Customers AddCustomer(Model.Customers p_cust)
        {
               _context.Customers.Add
                (
                    new Entity.Customer()
                   {
                        CustomerName = p_cust.Name,
                        CustStreetAdd = p_cust.StreetAdd,
                        CustCity = p_cust.City,
                        CustState = p_cust.State,
                        CustPhone = p_cust.Phone,
                        CustZip = p_cust.Zip,
                       CustEmail = p_cust.Email
                   }
                );
                _context.SaveChanges();

                return p_cust;
            
        }

        public Model.Items AddItems(Model.Items p_items)
        {
            _context.Products.Add
            (
                new Entity.Product()
                {
                    ItemName = p_items.itemName,
                    ItemPrice = p_items.itemPrice,
                    ItemDesc = p_items.ItemDesc,
                    Category = p_items.Category,
                    ProdQuantity = p_items.itemQuanity
                }
            );
            _context.SaveChanges();

            return p_items;
        }

        public LineItems AddLineItems(LineItems p_lineitem)
        {
            _context.LineItems.Add
            (
                new Entity.LineItem
                {
                    ProductId = p_lineitem.ProductID,
                    Quantity = p_lineitem.Quantity,
                    OrdersId = p_lineitem.OrdersID
                }
            );
            _context.SaveChanges();

            return p_lineitem;
        }

        public Orders AddOrder(Orders p_orders)
        {
            _context.Orders.Add(
                new Entity.Order()
                {
                    
                    StoreId = p_orders.StoreId,
                    TotalPrice = p_orders.totalPrice,
                    LineItemId = p_orders.LineItemId,
                    CustomerId = p_orders.CustomerID,
                    
                    
                    

                }
            );
            _context.SaveChanges();

            return p_orders;
        }

       

        public StoreFront AddStoreFront(StoreFront p_stores)
        {
           _context.Storefronts.Add
           (
               new Entity.Storefront()
               {
                   StoreName = p_stores.StoreName,
                   StoreAdd = p_stores.StreetAdd,
                   StoreCity = p_stores.City,
                   StoreState = p_stores.State,
                   StoreZip = p_stores.Zip,
               }
           );
           _context.SaveChanges();

           return p_stores;
        }

        public List<Model.Customers> GetAllCustomers()
        {
            return _context.Customers.Select(cust => new Model.Customers()
            {
                        Name = cust.CustomerName,
                        StreetAdd = cust.CustStreetAdd,
                        City =  cust.CustCity,
                        State = cust.CustState,
                        Phone = cust.CustPhone,
                        Email = cust.CustEmail,
                        CustomerID = cust.CustomerId
                
            }).ToList();
        }

        public List<Model.Items> GetAllItems()
        {
            return _context.Products.Select(items => new Model.Items()
            {
                itemName = items.ItemName,
                itemPrice = items.ItemPrice,
                itemQuanity = items.ProdQuantity,
                ItemDesc = items.ItemDesc,
                Category = items.Category,
                itemId = items.ProductId
            }).ToList();
        }

        public List<Orders> GetAllOrders()
        {
            return _context.Orders.Select(orders => new Model.Orders()
            {
                OrderID = orders.OrdersId,
                
                LineItemId = orders.LineItemId,
                CustomerID = orders.CustomerId,
                totalPrice = orders.TotalPrice,
                StoreId = orders.StoreId,
                

                
            }).ToList();
        }

        public List<StoreFront> GetAllStores()
        {
            return _context.Storefronts.Select(stores => new Model.StoreFront()
            {
                    StoreID = stores.StoreId,
                    StoreName = stores.StoreName,
                    StreetAdd = stores.StoreAdd,
                    City = stores.StoreCity,
                    State = stores.StoreState,
                    Zip = stores.StoreZip,
                    // ProductID = stores.ProductID,
                    // OrderID = stores.OrdersID
                    

            }).ToList();
        }

        public Items GetProductbyID(int p_id)
        {
            Entity.Product itemToFind = _context.Products.Find(p_id);
            return new Model.Items(){
                itemId = itemToFind.ProductId,
                itemName = itemToFind.ItemName,
                itemPrice = itemToFind.ItemPrice,
                ItemDesc = itemToFind.ItemDesc,
                Category = itemToFind.Category,
                itemQuanity = itemToFind.ProdQuantity
                
            };
        }

         public Customers GetCustomerbyID(int p_id)
        {
            Entity.Customer custToFind = _context.Customers.Find(p_id);
            return new Model.Customers(){
                CustomerID = custToFind.CustomerId,
                City = custToFind.CustCity,
                Phone = custToFind.CustPhone,
                Email = custToFind.CustEmail,
                Zip = custToFind.CustZip,
                State = custToFind.CustState,
                StreetAdd = custToFind.CustStreetAdd


                
            };
        }


         public LineItems GetLineItembyID(int p_id)
        {
            Entity.LineItem LineitemToFind = _context.LineItems.Find(p_id);
            return new LineItems(){
                LineItemID = LineitemToFind.LineItemId,
                ProductID = LineitemToFind.ProductId,
                Quantity = LineitemToFind.Quantity,



                
                
            };
        }
        /// <summary>
        /// This will give specific store based on the ID 
        /// </summary>
        /// <param name="p_id">this is the id it will look for </param>
        /// <returns>returns the store it has found </returns>
        public StoreFront GetStoreByID(int p_id)
        {
            Entity.Storefront storeToFind = _context.Storefronts.Find(p_id);
            return new Model.StoreFront(){
                StoreID = storeToFind.StoreId,
                StoreName = storeToFind.StoreName,
                StreetAdd = storeToFind.StoreAdd,
                City = storeToFind.StoreCity,
                State = storeToFind.StoreState,
                Zip = storeToFind.StoreZip
                
            };
        }

        public List<Model.Items> GetStoreProducts(Model.StoreFront p_store)
        {

            //Query Santax 
            var result = (from it in _context.Products
                            where it.StoreId == p_store.StoreID
                            select it);

                //mapping the queriable <entity.items> into a list<model.items> 
                  List<Items> listofItems = new List<Model.Items>();

                 foreach (Entity.Product it in result)
                 {
                     listofItems.Add(new Model.Items(){
                         itemId = it.ProductId,
                         itemName = it.ItemName,
                         itemQuanity = it.ProdQuantity,
                         ItemDesc = it.ItemDesc,
                         itemPrice = it.ItemPrice,
                         Category = it.Category,
                         StoreID = it.StoreId
                         
                     });
                 }

                 return listofItems;


                    
        }
        
        
    }
}