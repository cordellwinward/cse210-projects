using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        int response = 0;
        while (response != 5){
        Menu myMenu = new Menu();
        response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.WriteLine("Create");
                    // Call CreateJournalEntry()
                    break;
                case 2: 
                    Console.WriteLine("Display");
                    // call display Journal
                    break;
                case 3:
                    Console.WriteLine("Save");
                    // Call ReadFromFile
                    break;
                case 4:
                    Console.WriteLine("Write");
                    //call write to file
                    break;
            }
        }

    }
}