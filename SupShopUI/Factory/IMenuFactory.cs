namespace SupShopUI
{
    public interface IMenuFactory
    {
        IStoreFront GetMenu(DirectoryChoice p_menu);
    }
}