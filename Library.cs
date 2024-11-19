using Microsoft.AspNetCore.Routing.Constraints;

class Library
{
    List<Book> books;
    private List<Person> persons;

    public Library()
    {
        books = new List<Book>();
        persons = new List<Person>();
    }


    public void AddNewBook(Book newBook)
    {
        books.Add(newBook);
    }

    public List<Book> ListAvailableBooks()
    {
        List<Book> availableBooks = books.FindAll((book) => !book.IsBorrowed);

        return availableBooks;
    }
    public List<Book> ListUnavailableBooks()
    {
        List<Book> unavailableBooks = books.FindAll((book) => book.IsBorrowed);

        return unavailableBooks;
    }
    public List<Book> ListAllBooks()
    {
        return books;
    }

    public Book BorrowBook(string title)
    {
        List<Book> availableBooks = ListAvailableBooks();
        Book? book = availableBooks.Find((book) => book.Title == title);
        book.IsBorrowed = true;

        return book;
    }

    public Book ReturnBook(string title)
    {
        List<Book> availableBooks = ListUnavailableBooks();
        Book? book = availableBooks.Find((book) => book.Title == title);
        book.IsBorrowed = false;

        return book;
    }

    // public Person AddNewPerson(string fname, string lname, string bdate, string phone)
    // {
    //     Person newPerson = new Person(fname, lname, bdate, phone);
    //     persons.Add(newPerson);

    //     return newPerson;
    // }

    public void AddNewPerson(Person person)
    {
        // Person newPerson = new Person(fname, lname, bdate, phone);
        persons.Add(person);


    }
    public List<Person> ListAllCustomers()
    {
        return persons;
    }





}