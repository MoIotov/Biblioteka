using System;
using System.Collections.Generic;
using System.Text;
using Biblioteka;

namespace Biblioteka
{
    
    public static void GetBook()
    {
        Book book = new Book();
        Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
        Console.Write("Book Name:");
        book.bookNazwa = Console.ReadLine();
        Console.Write("Book Price:");
        book.bookCena = int.Parse(Console.ReadLine());
        Console.Write("Number of Books:");
        book.x = book.bookLiczba = int.Parse(Console.ReadLine());
        bookList.Add(book);
    }
}
