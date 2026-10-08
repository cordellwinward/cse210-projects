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
        response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    // Call CreateJournalEntry()
                    myJournal.CreateJournalEntry();
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