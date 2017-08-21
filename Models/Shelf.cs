using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace BookshelfComposite.Models
{
    class Shelf : Component
    {
        ArrayList books = new ArrayList();
        public Shelf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            books.Add(component);
        }

        public override Component GetChild(int index)
        {
            return books[index] as Component;
        }

        public override void Operation()
        {
            Console.WriteLine($"Bookshelf '{name}' has follow books:");
            int i = 1;
            foreach (Component comp in books) {
                Console.Write($"{i++}. ");
                comp.Operation();
            }
        }

        public override void Remove(Component component)
        {
            books.Remove(component);
        }
    }
}
