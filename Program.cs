
//oppsett av webserveren
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


Library library = new Library();

Book martian = new Book("Martian", "Jack Black", new DateTime());
library.AddNewBook(martian);
Book flakse = new Book("Flakse", "Fly High", new DateTime());
library.AddNewBook(flakse);
Book bumps = new Book("Bumps", "Hard Hitting Hole", new DateTime());
library.AddNewBook(bumps);



Person bob = new Person("Bob", "Marley", "18.02.2022", "34554334");
Person leif = new Person("Leif", "Olsen", "17.08.1942", "22334422");
Person odd = new Person("Odd", "Pettersen", "14.03.1933", "45443312");
Person bjartmar = new Person("Bjartmar", "Torfredsson", "22.10.1912", "74229900");

library.AddNewPerson(bob);
library.AddNewPerson(leif);
library.AddNewPerson(odd);
library.AddNewPerson(bjartmar);

//konfigurerer endepunkter(hvilke meldinger vi skal respondere på og hvilken logikk som skal kjøres)
//Metode GET
//URI /book



app.MapGet("/AllBook", () =>
{
    return library.ListAllBooks();
});

app.MapGet("/AvailableBook", () =>
{
    return library.ListAvailableBooks();
});

app.MapGet("/UnavailableBook", () =>
{
    return library.ListUnavailableBooks();
});

app.MapGet("/Allcustomers", () =>
{
    return library.ListAllCustomers();
});


//Medtode POST
//URI /
app.MapPost("/Allbook/borrow", (BorrowRequest request) =>
{
    Book? book = library.BorrowBook(request.Title);

    if (book == null)
    {
        return Results.NotFound();
    }
    else
    {
        return Results.Ok(book);
    }

});


app.MapPost("/Allbook/return", (ReturnRequest request) =>
{
    Book? book = library.ReturnBook(request.Title);

    if (book == null)
    {
        return Results.NotFound();
    }
    else
    {
        return Results.Ok(book);
    }
});




app.Run();
