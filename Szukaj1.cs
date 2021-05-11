using System;
using System.Collections.Generic;
using System.Text;
using Biblioteka;

namespace Biblioteka
{
    public static void SearchBook()
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
                    "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                }
            }
        }
        else
        {
            Console.WriteLine("Book id {0} not found", find);
        }
    }
}
