using System;
namespace ForTest
{
    public class MenuItem
    {
        public string Description;
        public Func<bool> Action;
        public ConsoleKey Key;
    }

}