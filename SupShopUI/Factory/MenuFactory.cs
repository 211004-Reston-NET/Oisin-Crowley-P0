using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SupplyShopBL;
using SupplyShopDL;
using SupplyShopDL.Entities;


namespace SupShopUI
{
    public class MenuFactory : IMenuFactory
    {     
        public IStoreFront GetMenu(DirectoryChoice p_menu)
        {
            var configuration = new ConfigurationBuilder()//Configurationbuilder is the class that came from microsoft.extension.configuration package
                .SetBasePath(Directory.GetCurrentDirectory())//
                .AddJsonFile("appsetting.json")//adds the appsetting.json file in our supshop ui
                .Build(); ///builds our configuration
                 
                
                DbContextOptions<SupplyShopDatabaseContext> options = new DbContextOptionsBuilder<SupplyShopDatabaseContext>()
                .UseSqlServer(configuration.GetConnectionString("Reference2DB"))
                .Options;
            
            
            
               // creating my directory objects in the factory 
        //parameter is p_menu 
        /// 
            switch (p_menu)
            {
                 case DirectoryChoice.StoreFloor:
                    return new StoreFloor();
                    

                    case DirectoryChoice.ShowStoreFront:
                    return new ShowStoreFront(new StoreFrontBL(new Repository()));
                    

                    case DirectoryChoice.ProductSearch:
                    return new ProductSearch(new ItemsBL(new Repository()));
                    

                    case DirectoryChoice.ProdSearchResult:
                    return  new ProdSearchResult(new ItemsBL(new Repository()));
                    

                    case DirectoryChoice.ProductPage:
                    return new ProductPage();
                    


                    case DirectoryChoice.MainInventory:
                    return new MainInventory(new ItemsBL(new Repository()));
                    

                    case DirectoryChoice.NewCustomer:
                    return new NewCustomer(new CustomersBL(new Repository()));
                    
                    
                    case DirectoryChoice.ShowCustomers:
                    return new ShowCustomers(new CustomersBL(new Repository()));
                    

                    case DirectoryChoice.CustomerPage:
                    return new CustomerPage();
                    

                    
                    case DirectoryChoice.ShowProduct:
                    return new ShowProduct(new ItemsBL(new Repository()));
                    
                    case DirectoryChoice.SearchCustomer:
                    return new SearchCustomer(new CustomersBL( new Repository()));
                    
                    case DirectoryChoice.SearchResult:
                    return new SearchResult(new CustomersBL(new Repository()));
                    

                    case DirectoryChoice.StoreFrontMain:
                    return new StoreFrontMain();
                    
                   

                    
                    

                    default:
                    return null;
            }
        }
    }
}