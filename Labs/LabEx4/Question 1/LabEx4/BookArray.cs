namespace LabEx4
{
    internal class BookArray
    {

        // init a private readonly books array with a size of 10
        private readonly Book[] books = new Book[10];

        // Define an AddBook method that takes a Book object and an index as arguments
        public void AddBook(Book book, int index)
        {
            // Add the Book object to the books at index
            _ = books[index] = book;
        }

        //  method that returns the books array
        public Book[] GetBooks()
        {
            return books;
        }

        // constructor 
        public BookArray() { }


    }
}
