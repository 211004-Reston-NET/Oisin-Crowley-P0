namespace SupShopUI
{
    public enum DirectoryChoice
    {
        MainInventory,
        StoreFloor,
        Exit,
        EnterCustomerInfo,
        EnterInventory,

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