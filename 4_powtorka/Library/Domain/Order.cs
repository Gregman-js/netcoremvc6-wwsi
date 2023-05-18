namespace Domain;

public class Order
{
    public Order()
    {
        Date = DateTime.Now;
        BooksOrderedList = new List<BookOrdered>();
    }

    public DateTime Date { get; set; }
    public List<BookOrdered> BooksOrderedList { get; set; }

    public override string ToString()
    {
        var orderDetails = $"Order: {Date}\n";
        foreach (var bookOrdered in BooksOrderedList)
            orderDetails += $"Book: {bookOrdered.BookId} Count: {bookOrdered.NumberOrdered}\n";
        return orderDetails;
    }
}