using System;

class Program
{

    static void Main(string[] args)
    {
        // Word myWord = new Word("Secret");
        // myWord.DisplayWord();
        // myWord.Hide();
        // myWord.DisplayWord();

        Scripture myScripture = new Scripture("Mosiah", 2, 41,
        "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");

        bool allWordsHidden = false;
        while (allWordsHidden == false)
        {
            Console.Clear();
            myScripture.ShowScripture();
            Console.WriteLine($"\n\n Press Enter to continue or type 'quit' to finish");
            string input = Console.ReadLine().ToLower().Trim();

                if (input == "")
                {
                    allWordsHidden = myScripture.HideWords();
                    
                }
                else if (input == "quit")
                {
                    break;
                }
        }
        Console.Clear();
        myScripture.ShowScripture();
        Console.WriteLine($"\n\n Press Enter to continue or type 'quit' to finish");
    }
}

    





