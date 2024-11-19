class Person
{
    private List<Book> books;
    public string Fname { get; set; }
    public string Lname { get; set; }
    private string Bdate { get; set; }
    private string Phone { get; set; }
    public Guid CustomerId { get; set; }

    public Person(string fname, string lname, string bdate, string phone)
    {
        Fname = fname;
        Lname = lname;
        Bdate = bdate;
        Phone = phone;
        books = new List<Book>();
        CustomerId = Guid.NewGuid();
    }

    public void PersonBorrowBook(Book borrowedBook)
    {
        books.Add(borrowedBook);
    }
    public void PersonReturnBook(Book returnedBook)
    {
        books.Remove(returnedBook);
    }
}
