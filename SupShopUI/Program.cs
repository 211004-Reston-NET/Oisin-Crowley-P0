using System;

namespace SupShopUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Store");

            int action = initialMessage();

            while (action != 0)
            {
                Console.WriteLine("you chose " + action);
                switch(action)
                {
                    case 1:
                    Console.WriteLine("You Picked 1");
                    string itemName = "";
                    Decimal itemPrice = 0;
                    int itemQuanity = 0;


                    Console.WriteLine("What is the supply item?");
                    Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("What is the item price?");
                    Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("How many are in stock?");
                    try{
                        int.Parse(Console.ReadLine());
                    }
                    catch{
                        Console.WriteLine("Please enter in a digit");
                    }
                }
                break






                action = initialMessage();
            }
            
        }

        static public int initialMessage()
        {
            int choice = 0;
            Console.WriteLine("Choose: [0] to exit, [1] to update inventory, [2] to make a purchase.");
           
           try{
                choice = int.Parse(Console.ReadLine()); 
           }
           catch{
              Console.WriteLine("please enter an int");
           }
             
           
           
           return choice;
        }
        
    }
}
