using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibararySystem
{
   public  class Libarary
   {
    private Book[] books =new Book[100];

        private int currentBookCont = 0; 
    private Book[] Borrowbooks =new Book[50];
        private int currentBorredBookCont = 0;

        public void Display()
        {
            //AddLogic 
            for (int i = 0; i < currentBookCont; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }
        public void Add(Book book)
        {
            if (currentBookCont < books.Length ) {
                books[currentBookCont] = book;
                currentBookCont++;
                Console.WriteLine("Book added succesflly");
            }else
            {
                Console.WriteLine("The Libarary is full , can add new books ");
            }

        }
        public void Remove(Book book)
        {
            if (currentBookCont > 0)
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] != null && books[i].Title == book.Title)
                    {
                        books[i] = null;
                        currentBookCont--;
                        Console.WriteLine("Book removed successfully.");
                        return; // وقف بعد حذف أول نسخة مطابقة
                    }
                }

                Console.WriteLine("Book not found.");
            }
            else
            {
                Console.WriteLine("The library is empty.");
            }
        }


        public void BorrowBook (Book book)
        {
            if (currentBorredBookCont < Borrowbooks.Length)
            {
                Borrowbooks[currentBorredBookCont] = book;
                currentBookCont++;
                Console.WriteLine("Book Borrowed succesflly");
            }
            else
            {
                Console.WriteLine("Sorry cant borrow More");
            }

        }
    }
}
