using System;

namespace User_Interface
{
    public class MainMenu : UIMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Games Galore!");
            Console.WriteLine("Where Gamers Come To Get Good");
            Console.WriteLine("-------- Main Menu --------");
            Console.WriteLine("How would you like to proceed?");
            Console.WriteLine("[1] - Shop the store");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.RestaurantMenu;
                case "0:":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Command not recognized, please enter a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}
