namespace SupShopUI
{
    public enum DirectoryChoice
    {
       

       //showing store location choices
        StoreFloor,
        //close application
        Exit,

        //product and inventory
        MainInventory,
        
       ProdSearchResult,
       ProductSearch,
        ShowProduct,


        //customer choices 
        SearchResult,
         NewCustomer,
        SearchCustomer,
        ShowCustomers,
        //initial page
        StoreFront
    }

    public interface IStoreFront
    {
        //will display inventory of the Store

        void Display();

        /// will be user choice

        DirectoryChoice YourChoice();
    }
}