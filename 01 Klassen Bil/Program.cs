public class Bil
{
    public string modell;
    public int årsmodell;
}


internal class Program
{
    static void Main(string[] args)
    {
        Bil bil1 = new Bil();
        bil1.modell = "Volvo V60";
        bil1.årsmodell = 2023;

        var bil2 = new Bil();
        bil2.modell = "Tesla Model 3";
        bil2.årsmodell = 2025;

        Console.WriteLine($"Bil 1: {bil1.modell}, Årsmodell: {bil1.årsmodell}");
        Console.WriteLine($"Bil 2: {bil2.modell}, Årsmodell: {bil2.årsmodell}");







        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
