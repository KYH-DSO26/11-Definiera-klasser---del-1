namespace _10_Orderapplikation__Tillstånd_via_Enum_;

public enum OrderStatus { Skapad, Skickad, Levererad}

public class Order
{
    public int OrderNummer { get; set; }
    public OrderStatus Status { get; private set; } = OrderStatus.Skapad;

    public void UppdateraStatus()
    {
        if (Status == OrderStatus.Skapad)
        {
            Status = OrderStatus.Skickad;
        }
        else if (Status == OrderStatus.Skickad) Status = OrderStatus.Levererad;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Order o = new Order { OrderNummer = 55 };

        Console.WriteLine($"Order {o.OrderNummer} är nu {o.Status}");

        o.UppdateraStatus();
        Console.WriteLine($"Order {o.OrderNummer} är nu {o.Status}");

        o.UppdateraStatus();
        Console.WriteLine($"Order {o.OrderNummer} är nu {o.Status}");






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
