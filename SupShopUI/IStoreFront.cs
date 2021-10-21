namespace SupShopUI
{
    public enum DirectoryChoice
    {
       

       //showing store location choices
       ShowStoreFront,
        StoreFloor,
        //close application
        Exit,

        //product and inventory
        MainInventory,
        
       ProdSearchResult,
       ProductSearch,
        ShowProduct,
        ProductPage,


        //customer choices 
        SearchResult,
         NewCustomer,
        SearchCustomer,
        ShowCustomers,
        CustomerPage,

        //orders
        AddOrder,


        //initial page
        StoreFrontMain
    }

    public interface IStoreFront
    {
        //will display inventory of the Store

        void Display();

        /// will be user choice

        DirectoryChoice YourChoice();
    }
}