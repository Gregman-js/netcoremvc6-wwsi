using Domain;
using Persistence;

namespace ConsoleApp;

public class OrderService
{
    private readonly OrdersRepository _orderRepository;

    public OrderService(OrdersRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public void PlaceOrder()
    {
        var order = new Order();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("add - dodaj pozycje do zamowienia");
            Console.WriteLine("end - zamknij zamowienie");
            var command = Console.ReadLine();

            if (command == "add")
            {
                Console.WriteLine("Id ksiązki: ");
                var bookId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ilosc: ");
                var quantity = Convert.ToInt32(Console.ReadLine());

                // Sprawdzenie dostępności książki
                var bookExists = CheckBookAvailability(bookId);
                if (!bookExists)
                {
                    Console.WriteLine("Książka o podanym Id nie istnieje w repozytorium.");
                    continue;
                }

                var bookOrdered = new BookOrdered
                {
                    BookId = bookId,
                    NumberOrdered = quantity
                };

                order.BooksOrderedList.Add(bookOrdered);
            }
            else if (command == "end")
            {
                _orderRepository.Insert(order);
                Console.WriteLine("Zamówienie zostało złożone.");
                break;
            }
            else
            {
                Console.WriteLine("Podana komenda jest niepoprawna. Spróbuj ponownie.");
            }
        }
    }

    public void ListAll()
    {
        var orders = _orderRepository.GetAll();

        Console.WriteLine("Lista zamówień:");
        foreach (var order in orders) Console.WriteLine(order.ToString());
    }

    private bool CheckBookAvailability(int bookId)
    {
        // Sprawdzenie dostępności książki w repozytorium
        // Można to zaimplementować w oparciu o BooksRepository lub dodać dodatkową metodę w BooksRepository do sprawdzania dostępności książki
        // W tym przypadku użyję prostej listy dostępnych książek w repozytorium

        var availableBooks = new List<int> { 1, 2, 3, 4, 5 }; // Przykładowa lista dostępnych książek

        return availableBooks.Contains(bookId);
    }
}