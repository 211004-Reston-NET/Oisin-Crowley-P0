using System;


namespace SupShopUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            IStoreFront page = new StoreFront();

            while (repeat)
            {
                //This will clear the termanel
                Console.Clear();

                page.Display();
                DirectoryChoice currentPage = page.YourChoice();

                switch(currentPage)
                {
                    case DirectoryChoice.StoreFloor:

                    page = new StoreFloor();
                    break;


                    case DirectoryChoice.MainInventory:
                    page = new MainInventory();
                    break;

                    

                    case DirectoryChoice.StoreFront:
                    page = new StoreFront();
                    break;

                    //exit the store 
                    case DirectoryChoice.Exit:

                    Console.WriteLine("Thank you for visiting the Store");
                    Console.WriteLine("You are exiting the application");
                    Console.WriteLine("Press Enter to Continue");
                    Console.ReadLine();
                    repeat = false;
                    break;

                    default: 
                    Console.WriteLine("You forgot to add a page that should be here");
                    repeat = false;
                    break;
                }






            }








        }
        }
        }
            
        

        
        
        
    

