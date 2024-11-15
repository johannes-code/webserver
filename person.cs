class Person
{
    private List<Book> books;
    public string fname;
    public string lname;
    private string bdate;
    private string phone;
    public Guid CostumerId;

    public Person(string fname, string lname, string bdate, string phone)
    {
        Fname = fname;
        Lname = lname;
        Bdate = bdate;
        Phone = phone;
    
    public Person()
    {
        Person = new List<Person>();
    }
    }

    public void PersonBorrowBook(Book borrowedBook)
    {
        books.Add(borrowedBook);

    }
    public void PersonReturnBook(Book returnedBook)
    {
        books.return(returnedBook);
    }

    
    
    public List<Person> ListAllCustomers()
    {
        return person;
    }


    
}