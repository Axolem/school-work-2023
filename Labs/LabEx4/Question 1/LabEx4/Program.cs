using System;

namespace LabEx4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Prompt the user to enter the titles of a fiction and a non-fiction book
            Console.Write("Enter fiction book: ");
            string book1 = Console.ReadLine();
            Console.Write("Enter non-fiction book: ");
            string book2 = Console.ReadLine();

            // Create two Book objects, one for each book entered by the user
            Book fictionBook = new Fiction(book1);
            Book nonfiction = new NonFiction(book2);

            // Output the title and price of each book
            Console.WriteLine($"Fiction ::: Name: {fictionBook.Title} Price: {fictionBook.Price}");
            Console.WriteLine($"Non-Fiction ::: Name: {nonfiction.Title} Price: {nonfiction.Price}");

            _ = Console.ReadKey();

            //====================================================================================
            //                              Question 1.D
            //====================================================================================

            Console.WriteLine("");
            Console.WriteLine("==========Books Array===========");

            // Create an instance of BookArray called booksShelf
            BookArray booksShelf = new BookArray();

            // Prompt the user to enter 10 book titles and their types (fiction or non-fiction)
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter book title {i + 1}: ");
                string title = Console.ReadLine();
                Console.Write("Is the book Fiction or NonFiction (F/N)? ");
                string bookType = Console.ReadLine();
                while (bookType != "F" && bookType != "N")
                {
                    Console.Write("Invalid input. Please enter F or N: ");
                    bookType = Console.ReadLine();
                }
                // Add each book to the booksShelf object
                if (bookType == "F")
                {
                    Book newBook = new Fiction(title);
                    booksShelf.AddBook(newBook, i);
                }
                else
                {
                    Book newBook = new NonFiction(title);
                    booksShelf.AddBook(newBook, i);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");

            // read books from booksShelf and store it in a variable books
            Book[] books = booksShelf.GetBooks();
            string category;

            // Loop through the books array
            for (int i = 0; i < books.Length; i++)
            {
                // Determine the category of the book based on its price
                category = books[i].Price > 200 ? "NonFiction" : "Fiction";
                // Output the title, price, and category of each book
                Console.WriteLine($"Book {i + 1} Title: {books[i].Title},  Price: {books[i].Price:C}, Category: {category}");
            }

            // Wait for a key press before exiting
            _ = Console.ReadKey();
        }
    }
}
