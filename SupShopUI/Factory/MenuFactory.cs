using SupplyShopBL;
using SupplyShopDL;

using SupShopUI;

namespace SupShopUI
{
    public class MenuFactory : IMenuFactory
    {
        public IStoreFront GetMenu(DirectoryChoice p_menu)
        {
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
                    return new SearchCustomer(new CustomersBL(new Repository()));
                    
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