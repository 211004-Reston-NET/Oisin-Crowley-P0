using System.Collections.Generic;
using Model = SupplyShopModels;
using Entity = SupplyShopDL.Entities;
using System.Linq;
using SupplyShopModels;

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

        public Orders AddOrder(Orders p_orders)
        {
            _context.Orders.Add(
                new Entity.Order()
                {
                    ItemName = p_orders.itemName,
                    StoreId = p_orders.StoreId,
                    TotalPrice = p_orders.totalPrice,
                    LineItemId = p_orders.LineItemId,
                    

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

        public List<StoreFront> GetAllStores()
        {
            return _context.Storefronts.Select(stores => new Model.StoreFront()
            {
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
    }
}