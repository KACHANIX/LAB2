using System;

namespace ForTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var menu = new Menu();
            bool myProgramIsRunning = true;

            menu.AddItem("Check if year is leap", Functions.Check);
            menu.AddItem("Calculate interval between dates", Functions.Calc);
            menu.AddItem("Get the name of day of week", Functions.Day);
            menu.AddItem("Serialize interval from last query", Serializing.SerializeFrom);
            menu.AddItem("Quit", Functions.Quit);

            while (myProgramIsRunning)
            {
                Console.Clear();
                myProgramIsRunning = menu.Display();
                Console.ReadKey();
            }
        }
    }
}