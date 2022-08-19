using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class ToyStore
    {
        private string[] _toys;

        public string Title { get; set; }
        public string[] Toys { get => _toys; }

        public ToyStore(string title)
        {
            Title = title;
            _toys = new string[0];
        }

        public void Add(string toy)
        {
            Array.Resize(ref _toys, _toys.Length + 1);
            _toys[_toys.Length - 1] = toy;
        }

        public void Search()
        {
            Console.WriteLine("Enter toy title:");
            string search = Console.ReadLine();

            string result = "";

            foreach (string toy in _toys)
            {
                if (toy == search)
                {
                    result += toy + "\r\n";
                }
            }
            Console.WriteLine("Search results:");
            Console.WriteLine(result);
        }

        public bool SearchSubstring(int index, string subString)
        {
            return _toys[index].Contains(subString);
        }

        public void InsertSubstring(int index, int position, int count)
        {
            string substring = "";

            for (int i = 0; i < count; i++)
            {
                substring += "qwerty";
            }

            _toys[index].Insert(position, substring);
        }

        public string GetSubstring(int index, int position, int count)
        {
            return _toys[index].Substring(position, count);
        }

        public void Print()
        {
            foreach (string toy in _toys)
            {
                Console.WriteLine(toy);
            }
        }
    }
}
