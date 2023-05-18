using Domain;
using Persistence;

namespace ConsoleApp;

public class Program
{
    private static void Main()
    {
        var book = new Book("Basnie", "Jan", 2022, "1234-test-5678", 5, 22);
        var repository = new BooksRepository();
        var booksService = new BooksService(repository);
        var ordersRepository = new OrdersRepository();
        var orderService = new OrderService(ordersRepository);

        Console.WriteLine("Podaj login:");
        var login = Console.ReadLine();

        Console.WriteLine("Podaj hasło:");
        var password = Console.ReadLine();

        if (login != "Admin" || password != "password")
        {
            Console.WriteLine("Access Denied");
            Environment.Exit(1);
            return;
        }

        Console.WriteLine("Access Granted");


        // Umieść breakpoint (przez F9) na powyższym if-ie, aby zatrzymać wykonanie programu
        Console.ReadKey();

        var command = "";

        while (command != "wyjdz")
        {
            Console.Clear();
            Console.WriteLine("Menu aplikacji:");
            Console.WriteLine("dodaj");
            Console.WriteLine("usun");
            Console.WriteLine("wypisz");
            Console.WriteLine("zmien");
            Console.WriteLine("dodaj zamowienie");
            Console.WriteLine("lista zamowien");
            Console.WriteLine("wyjdz");
            Console.WriteLine();

            Console.WriteLine("Wprowadź komendę:");
            command = Console.ReadLine().ToLower();

            Console.Clear();

            switch (command)
            {
                case "dodaj":
                    booksService.AddBook();
                    break;
                case "usun":
                    booksService.RemoveBook();
                    break;
                case "wypisz":
                    booksService.ListBooks();
                    break;
                case "zmien":
                    booksService.ChangeState();
                    break;
                case "dodaj zamowienie":
                    orderService.PlaceOrder();
                    break;
                case "lista zamowien":
                    orderService.ListAll();
                    break;
                case "wyjdz":
                    break;
                default:
                    Console.WriteLine("Podana komenda nie jest obsługiwana");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
            Console.ReadKey();
        }
    }
}