class Library
{
    List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddNewBook(Book newBook)
    {
        books.Add(newBook);
    }

    public List<Book> ListAvailableBooks()
    {
        List<Book> availableBooks = books.FindAll((book) => !book.IsBorrowed == true);

        return availableBooks;
    }

    public Book BorrowBook(string title)
    {
        List<Book> availableBooks = ListAvailableBooks();
        Book? book = availableBooks.Find((book) => book.Title == title);

        return book;
    }
}