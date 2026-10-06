class Menu
{
    public int ProcessMenu()
    {
        Console.WriteLine("Write menu");

        int input = 0;
        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal program:");
            Console.WriteLine("Create, Display, Save, or Read Journal Entries.");
            Console.WriteLine("1. Create new journal entry.");
            Console.WriteLine("2. Display all journal entrys");
            Console.WriteLine("3. Save Journal to file.");
            Console.WriteLine("4. Read journal from a file.");
            Console.WriteLine("5. Quit");
            input = (int.Parse(Console.ReadLine()));
        }
        return input;
    }
}