using System.Globalization;

namespace LibararySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Libarary system ");
            Libarary libarary = new Libarary(); 
            Console.WriteLine("Are you libarian or regular user (L/R)");
            char UserType = Console.ReadLine().ToUpper()[0];
         
            if (UserType == 'L')
            {
                Console.WriteLine(" Welcome Librarian,  Enter Your Name ");
                string LibarianName = Console.ReadLine();
                Libararian libranian = new Libararian(LibarianName);

                Console.WriteLine($"Welcome {libranian.Name}");
                while (true)
                {
                    Console.WriteLine("Plese Choose to add book (A) / Remove book (R) / Display books (D)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book detailse");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());

                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            libranian.AddBook(book, libarary);
                            break;
                        case 'R':
                            Console.WriteLine("Enter book detalis to remove");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine());

                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            libranian.RemoveBook(book, libarary);
                            break;
                        case 'D':
                            Console.WriteLine("the books list : ");
                            libranian.DisplayBooks(libarary);
                            break;

                        default:
                            Environment.Exit(0);
                            break;


                    }
                }
            }
            else if (UserType == 'R')
            {
                //Regular Logic
                Console.WriteLine(" Welcome User,  Enter Your Name ");
                string name = Console.ReadLine();
                LibararyUser u1 = new LibararyUser(name);

                Console.WriteLine($"Welcome {u1.Name}");
                while (true)
                {
                    Console.WriteLine("Plese Choose to Display books (D) or Borrow Book (B)  ");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'D':
                            Console.WriteLine("the books list : ");
                            u1.DisplayBooks(libarary);
                            break;


                        case 'B':
                            Console.WriteLine("Enter book detailse to Borrow");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());

                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            u1.BorrowBook(book, libarary);
                            break;
                     
                        

                        default:
                            Environment.Exit(0);
                            break;


                    }
                }
            }
            else
            {

                Console.WriteLine("Plese enter correct value (L or R");
            }
            
        }
    }
}
