using System;
using BookshelfComposite.Models;

namespace BookshelfComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component bigBookShelf = new Shelf("Literature 18 century");

            Component bookShelfRussian = new Shelf("Russian authors");
            Component bookShelfFrance = new Shelf("France authors");

            Component book1 = new Book("Antiokh Dmitrievich Kantemir Petrida");
            Component book2 = new Book("Alexander Nikolayevich Radishchev, All novels");


            Component book3 = new Book("Samuel Richardson, novels");
            Component book4 = new Book("Daniel Defoe, novels");

            bigBookShelf.Add(bookShelfRussian);
            bigBookShelf.Add(bookShelfFrance);

            bookShelfRussian.Add(book1);
            bookShelfRussian.Add(book2);


            bookShelfFrance.Add(book3);
            bookShelfFrance.Add(book4);

            bigBookShelf.Operation();

            Console.ReadKey();
        }
    }
}
