class Person
{
    private List<Book> books;
    public string fname;
    public string lname;
    private string bdate;
    private string phone;
    public Guid CustomerId;

    public Person(string fname, string lname, string bdate, string phone)
    {
        fname = this.fname;
        lname = this.lname;
        bdate = this.bdate;
        phone = this.phone;
    }

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
    books.return (returnedBook);
}



public List<Person> ListAllCustomers()
{
    return person;
}


}
