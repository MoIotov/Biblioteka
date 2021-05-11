using System;
using System.Collections.Generic;
using Biblioteka;
using System.Linq;

namespace Biblioteka
{
    class Program
    {
        static List<Book> bookList = new List<Book>();
        static Book book = new Book();
        static void Main(string[] args)
        {
            

            bool eexit = false;
            while (
                !eexit
            )

            {
                Console.WriteLine("\nMenu\n" +
                    "1)Dodaj książkę\n" +
                    "2)Znajdź książkę po tytule\n" +
                    "3)znajdź książki po imieniu i nazwisku autora\n" +
                    "4)Lista książek\n" +
                    "5)Zamknij\n\n" 
                    
                    
                    );
                Console.Write("Wybierz jedną opcję :");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    GetBook();
                }
                else if (option == 3)
                {
                    FindBookAutorName();
                }
                else if (option == 2)
                {
                    FindBookTytul();

                }
                else if (option == 4) 
                {
                    ListBooks();
                }
                else if (option == 5)
                {
                    Console.WriteLine("Do widzenia!");
                    eexit = true;
                }
                else
                {
                    Console.WriteLine("Nie poprawny wybór\nSpróbuj ponownie!!!");
                };
                Console.Clear();
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

        public static void FindBookTytul()
        {
            
            Console.Write("Wyszukaj książkę po Tytule :");
            string sFind = (Console.ReadLine());

            if (bookList.Exists(x => x.bookNazwa == sFind))
            {
                Book oBook = bookList.Find(x => x.bookNazwa == sFind);

                
                
                    
                    {
                        Console.WriteLine("Numer książki :{0}\n" +
                        "Tytuł Książki :{1}\n" +
                        "Imię Autora :{2}\n" +
                        "Nazwisko autora :{3}\n" +
                        "Rok wydania :{4}\n" +
                        "Cena Książki :{5}\n" +
                        "Liczba książek :{6}", oBook.bookId, oBook.bookNazwa, oBook.bookAutorImie, oBook.bookAutorNazwisko, oBook.bookRok, oBook.bookCena, oBook.bookLiczba);
                    }
                
            }
            else
            {
                Console.WriteLine("Nazwa nie znaleziona", sFind);
            }
            Console.ReadKey();
        }

        public static void ListBooks()
        {
            foreach (Book searchId in bookList)
            {
                
                
                    Console.WriteLine("Numer książki :{0}\n" +
                    "Tytuł Książki :{1}\n" +
                    "Imię Autora :{2}\n" +
                    "Nazwisko autora :{2}\n" +
                    "Rok wydania :{2}\n" +
                    "Cena Książki :{2}\n" +
                    "Liczba książek :{3}", searchId.bookId, searchId.bookNazwa, searchId.bookAutorImie, searchId.bookAutorNazwisko, searchId.bookRok, searchId.bookCena, searchId.bookLiczba);
                
            };
            Console.WriteLine("Naciśnij dowolny klawisz");
            Console.ReadKey();
        }

        public static void FindBookAutorName()
        {
            
            Console.Write("Wyszukaj książkę po Autorze :");
            Console.WriteLine("Imię Autora");
            string sFind = (Console.ReadLine());
            Console.WriteLine("nazwisko Autora");
            string nFind = (Console.ReadLine());

            if (bookList.Exists(x => x.bookAutorImie == sFind & x.bookAutorNazwisko == nFind))

            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookAutorImie == sFind)
                    {
                        Console.WriteLine("Numer książki :{0}\n" +
                    "Tytuł Książki :{1}\n" +
                    "Imię Autora :{2}\n" +
                    "Nazwisko autora :{2}\n" +
                    "Rok wydania :{2}\n" +
                    "Cena Książki :{2}\n" +
                    "Liczba książek :{3}", searchId.bookId, searchId.bookNazwa, searchId.bookAutorImie, searchId.bookAutorNazwisko, searchId.bookRok, searchId.bookCena, searchId.bookLiczba);
                    }
                }
            }
            else
            {
                Console.WriteLine("Autor nie znaleziony", sFind);
            }
            Console.ReadKey();
        }
        

    }
}
