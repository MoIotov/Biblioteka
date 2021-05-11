using System;
using System.Collections.Generic;
using Biblioteka;

namespace Biblioteka
{
    class Program
    {
        static List<Book> bookList = new List<Book>();
        static Book book = new Book();
        static void Main(string[] args)
        {
            Console.WriteLine("\nMenu\n" +
                    "1)Dodaj książkę\n" +
                    "2)Znajdź książkę po tytule\n" +
                    "3)znajdź książki po imieniu i nazwisku autora\n" +
                    "4)Zamknij\n\n");
            Console.Write("Wybierz jedną opcję :");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                GetBook();
            }
            else if (option == 2)
            {
                FindBookTitle();
            }
            else if (option == 3)
            {
                FindBookName();
            }
            else if (option == 4)
            {
                Console.WriteLine("Do widzenia!");
                close = false;
                break;
            }
            else
            {
                Console.WriteLine("Nie poprawny wybór\nSpróbuj ponownie!!!");
            }
        }

        public static void GetBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
            Console.Write("Nazwa Książki:");
            book.bookNazwa = Console.ReadLine();
            Console.Write("Cena Książki:");
            book.bookCena = int.Parse(Console.ReadLine());
            Console.Write("Ilość książek:");
            book.x = book.bookLiczba = int.Parse(Console.ReadLine());
            Console.Write("Imię Autora:");
            book.bookAutorImie = Console.ReadLine();
            Console.Write("Nazwisko Autora:");
            book.bookAutorNazwisko = Console.ReadLine();
            Console.Write("Rok wydania:");
            book.y = book.bookRok = int.Parse(Console.ReadLine());
            bookList.Add(book);
        }

        public static void FindBookName()
        {
            Book book = new Book();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.bookId, searchId.bookNazwa, searchId.bookCena, searchId.bookLiczba);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        public static void FindBookTitle()
        {
            Book book = new Book();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.bookId, searchId.bookNazwa, searchId.bookCena, searchId.bookLiczba);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

    }
}
