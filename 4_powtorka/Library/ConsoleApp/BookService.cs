using Domain;
using Persistence;

namespace ConsoleApp;

public class BooksService
{
    private readonly BooksRepository _repository;
    private readonly List<Book> books;

    public BooksService(BooksRepository repository)
    {
        _repository = repository;
        books = new List<Book>();
    }

    public void AddBook()
    {
        Console.WriteLine("Dodawanie nowej książki:");
        Console.WriteLine("Podaj tytuł:");
        var title = Console.ReadLine();
        Console.WriteLine("Podaj autora:");
        var author = Console.ReadLine();
        Console.WriteLine("Podaj rok wydania:");
        var year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj ISBN:");
        var isbn = Console.ReadLine();

        Console.WriteLine("Podaj ilość produktów:");
        var productsAvailable = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podaj cene:");
        var price = Convert.ToDecimal(Console.ReadLine());

        var newBook = new Book(title, author, year, isbn, productsAvailable, price);
        books.Add(newBook);

        Console.WriteLine("Książka została dodana.");
    }

    public void RemoveBook()
    {
        Console.WriteLine("Usuwanie książki:");
        Console.WriteLine("Podaj tytuł książki do usunięcia:");
        var title = Console.ReadLine();

        var bookToRemove = books.Find(book => book.Title == title);

        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine("Książka została usunięta.");
        }
        else
        {
            Console.WriteLine("Nie znaleziono książki o podanym tytule.");
        }
    }

    public void ListBooks()
    {
        Console.WriteLine("Tutaj pojawi się lista książek:");
        foreach (var book in books) Console.WriteLine($"{book.Title} - {book.Author} ({book.PublicationYear})");
    }

    public void ChangeState()
    {
        Console.WriteLine("Zmiana stanu książki:");
        Console.WriteLine("Podaj tytuł książki:");
        var title = Console.ReadLine();
        Console.WriteLine("Podaj nowy rok książki:");
        var year = Convert.ToInt32(Console.ReadLine());

        var bookToChange = books.Find(book => book.Title == title);

        if (bookToChange != null)
        {
            bookToChange.PublicationYear = year;
            Console.WriteLine("Stan książki został zmieniony.");
        }
        else
        {
            Console.WriteLine("Nie znaleziono książki o podanym tytule.");
        }
    }
}