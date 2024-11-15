
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
