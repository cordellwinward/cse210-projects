using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool over = false;
        while (!over)
        {
            string activity = menu.OpenMenu();
            if (activity == "1")
            {
                //breathing activity
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.RunActivity();
            }
            else if (activity == "2")
            {
                //reflecting activity
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.RunActivity();
            }
            else if (activity == "3")
            {
                //listing activity
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.RunActivity();
            }
            else if (activity == "4")
            {
                over = true;
            }
            
        }

    }
}