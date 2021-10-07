namespace SupShopUI
{
    public enum DirectoryChoice
    {
        MainInventory,
        StoreFloor,
        Exit
    }

    public interface IStoreFront
    {
        //will display inventory of the Store

        void Display();

        /// will be user choice

        DirectoryChoice YourChoice();
    }
}