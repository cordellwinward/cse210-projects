using System;

class Program
{

    static void Main(string[] args)
    {
        // Word myWord = new Word("Secret");
        // myWord.DisplayWord();
        // myWord.Hide();
        // myWord.DisplayWord();

        Scripture myScripture = new Scripture("Moses", 1, 39,
        "Behold this is my work and my glory to bring to pass the immortality and eternal life of man");
        myScripture.ShowScripture();
    
    }







    // Code for Fraction.cs
    // static void Main(string[] args)
    // {
        // Fraction auto = new Fraction();
        // Fraction whole = new Fraction(5);
        // Fraction fraction34 = new Fraction(3, 4);
        // Fraction fraction13 = new Fraction(1, 3);

        // Console.WriteLine(auto.GetFractString());
        // Console.WriteLine(auto.GetDecimalValue());
        // Console.WriteLine(whole.GetFractString());
        // Console.WriteLine(whole.GetDecimalValue());
        // Console.WriteLine(fraction34.GetFractString());
        // Console.WriteLine(fraction34.GetDecimalValue());
        // Console.WriteLine(fraction13.GetFractString());
        // Console.WriteLine(fraction13.GetDecimalValue());

        // Random random = new Random();
        // Fraction randomInt = new Fraction();
        // int fract_num = 0;
        // for (int i = 21; i > 1; i -= 1)
        // {
        //     fract_num += 1;
        //     randomInt.SetTop(random.Next(1, 12));
        //     randomInt.SetBottom(random.Next(1, 12));
        //     Console.WriteLine($"Fraction {fract_num}: String: {randomInt.GetFractString()} Number: {randomInt.GetDecimalValue()}");

        // }
    
    // }
}