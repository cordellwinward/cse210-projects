using System;
using System.Net;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();
        int response = 0;
        while (response != 5){
        try{
            response = myMenu.ProcessMenu();
        }
            catch (FormatException)
            {
                continue;
            }
            switch(response)
            {
                case 1:
                    // Call CreateJournalEntry()
                    myJournal.CreateJournalEntry();
                    break;
                case 2: 
                    // Console.WriteLine("Display");
                    // call display Journal
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    // Console.WriteLine("save");
                    //call write to file
                    Console.WriteLine("What would you like to name your file?");
                    string filename = Console.ReadLine();
                    myJournal.WriteToFile(filename);
                    break;
                case 4:
                    // Console.WriteLine("write");
                    // Call ReadFromFile
                    try {
                        Console.WriteLine("What is your journals filename?");
                        string file = Console.ReadLine();
                        myJournal.ReadFromFile(file);
                        break;
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("That file doesn't exsist");
                        break;
                    }
            }
        }

    }
}