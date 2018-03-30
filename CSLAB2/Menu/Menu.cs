using System;
using System.Collections.Generic;
namespace ForTest
{
    public class Menu
    {
        private List<MenuItem> _items = new List<MenuItem>();
        public void AddItem(string desc, Func<bool> a)
        {
            var item = new MenuItem
            {
                Action = a,
                Description = desc,
                Key = (ConsoleKey)(_items.Count + 49)
            };
            _items.Add(item);
        }
        public bool Display()
        {
            int i = 1;
            foreach (MenuItem item in _items)
            {
                Console.WriteLine($"{i++}. {item.Description}");
            }

            Console.Write("Your input : ");
            ConsoleKey input = Console.ReadKey().Key;

            foreach (MenuItem item in _items)
            {
                if (item.Key == input)
                {
                    return item.Action();
                }
            }
            return true;
        }
    }
}