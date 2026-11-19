class Menu
{
    public int DisplayMainMenu()
    {
        Console.Write(
        """
        Menu Options:
            1. Create New Goal
            2. List Goals
            3. Save Goals
            4. Load Goals
            5. Record Event
            6. Quit
        Select a choice from the menu: 
        """);
         return int.Parse(Console.ReadLine());
    }
    public int DisplayGoalTypeMenu()
    {
        Console.Write(
        """
        The Types of GOals are:
            1. Simple Goal
            2. Eternal Goal
            3. Checklist Goal
        Which type of goal would you like to create?  
        """);
         return int.Parse(Console.ReadLine());
    }
}