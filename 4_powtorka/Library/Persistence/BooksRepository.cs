using Domain;

namespace Persistence;

public class BooksRepository
{
    private readonly List<Book> _database;

    public BooksRepository()
    {
        _database = new List<Book>
        {
            new("Stary człowiek i morze", "Ernest Hemingway", 1986, "AAAA", 10, 19.99m),
            new("Komu bije dzwon", "Ernest Hemingway", 1997, "BBBB", 0, 119.99m),
            new("Alicja w krainie czarów", "C.K. Lewis", 1998, "CCCC", 53, 39.99m),
            new("Opowieści z Narnii", "C.K. Lewis", 1999, "DDDD", 33, 49.99m),
            new("Harry Potter", "J.K. Rowling", 2000, "EEEE", 23, 69.99m),
            new("Paragraf 22", "Joseph Heller", 2001, "FFFF", 5, 45.99m),
            new("Lalka", "Bolesław Prus", 2002, "GGGG", 7, 76.99m),
            new("To", "Stephen King", 2003, "HHHH", 2, 12.99m),
            new("Idiota", "Fiodor Dostojewski", 1950, "IIII", 89, 25.99m),
            new("Mistrz i Małgorzata", "Michaił Bułhakow", 1965, "JJJJ", 41, 36.99m)
        };
    }

    public void Insert(Book book)
    {
        _database.Add(book);
    }

    public List<Book> GetAll()
    {
        return _database;
    }

    public void RemoveByTitle(string title)
    {
        var bookToRemove = _database.FirstOrDefault(x => x.Title == title);
        if (bookToRemove != null) _database.Remove(bookToRemove);
    }

    public void ChangeState(string title, int stateChange)
    {
        var bookToChange = _database.FirstOrDefault(x => x.Title == title);
        if (bookToChange != null) bookToChange.ProductsAvailable += stateChange;
    }
}