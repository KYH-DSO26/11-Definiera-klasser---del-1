namespace _06_Bankapplikation__bibehålla_tillstånd_;

public class Bankkonto
{
    private double _saldo;
    public double Saldo { get { return _saldo; } }   // Egenskapen Saldo blir READ-ONLY för det finns ingen set

    public void Insättning(double belopp)
    {
        if (belopp > 0) _saldo += belopp;
    }

    public void Uttag(double belopp)
    {
        if (belopp > 0 && belopp <= _saldo)
        {
            _saldo -= belopp;
        }
        else
        {
            Console.WriteLine("Fel: Uttag medgavs ej");
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        var konto = new Bankkonto();
        konto.Insättning(1000);
        konto.Uttag(300);
        Console.WriteLine($"Saldo: {konto.Saldo} kr");

        Console.WriteLine("Försöker ta ut 100000");
        konto.Uttag(10000);
        Console.WriteLine($"Saldo: {konto.Saldo} kr");




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
