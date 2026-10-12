namespace _02_Hundapplikation__Konstruktorer_;

public class Hund
{
    public string namn;
    public string ras;

    public Hund(string namn, string ras)
    {
        this.namn = namn;
        this.ras  = ras;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 2: Klassen Hund ---");
        Hund minHund = new Hund("Buster", "Labrador");

        Console.WriteLine($"Hunden heter {minHund.namn} och är en {minHund.ras}");






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
