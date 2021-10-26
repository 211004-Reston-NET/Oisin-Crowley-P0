using System.Collections.Generic;
using Model = SupplyShopModels;
using Entity = SupplyShopDL.Entities;
using System.Linq;

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
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }
    }
}