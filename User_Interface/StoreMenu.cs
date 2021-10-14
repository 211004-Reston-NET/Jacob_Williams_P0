using System;

namespace User_Interface
{
    public class StoreMenu : UIMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Store Menu!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[3] - Find a location near you");
            Console.WriteLine("[2] - Puchase a Product");
            Console.WriteLine("[1] - Checkout");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public MenuType YourChoise()
        {
            string userChoice = Console.ReadLine();
            switch(userChoice)
            {
                case "3":
                    return MenuType.ShowStore;
                case "2":
                    return MenuType.StoreMenu;
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Command not recognized, please enter a valid response!");
                    Console.WriteLine("Press Enter to conitnue");
                    Console.ReadLine();
                    return MenuType.StoreMenu;
            }
        }
    }
}