namespace classlib;

public class ContactMenu
{
    private int selectedIndex = 0;
    private string[] _menuItems = new string[]{
        "Read",
        "Add",
        "Delete"
    };

    private string selector = " <";
    private string blank = "";
    private Contacts _contacts;

    public ContactMenu()
    {
        _contacts = new Contacts();
        drawMenu();
    }

    public void drawMenu()
    {
        foreach (string option in _menuItems)
        {
            Console.WriteLine("{0} {1}",option, (_menuItems[selectedIndex] == option ? selector:blank));
        }
        
        ConsoleKeyInfo _keyPressed = Console.ReadKey();
        if (_keyPressed.Key == ConsoleKey.Enter)
        {
            Console.WriteLine(_menuItems[selectedIndex]);
        } 
        else if (_keyPressed.Key == ConsoleKey.DownArrow)
            if (selectedIndex >= 2)
            {
                selectedIndex = 0;
            }
            else
            {
                selectedIndex += 1;
            }
        else if (_keyPressed.Key == ConsoleKey.UpArrow)
        {
            if (selectedIndex <= 0)
            {
                selectedIndex = 2;
            }
            else
            {
                selectedIndex -= 1;
            }
        }
        else
        {
            Console.ReadKey(true);
        }

        Console.Clear();
        drawMenu();
        
    }
    
}

