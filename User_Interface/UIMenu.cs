namespace User_Interface
{
    public enum MenuType
    {
        MainMenu,
        StoreMenu,
        ShowStore,
        Exit,
    }

    public interface UIMenu
    {
        void Menu();

        MenuType YourChoice();
    }

}