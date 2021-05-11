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

    }
}
