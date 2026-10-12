namespace _13_Lagerapplikation__Affärsregler_i_property_;

public class LagerArtikel
{
    public double Inkopsspris { get; private set; }
    private double utpris;
    public double Utpris
    {
        get { return utpris; }
        set
        {
            double minPris = Inkopsspris * 1.25;
            if (value < minPris) utpris = minPris;
            else utpris = value;
        }
    }
    public LagerArtikel(double inkop) { Inkopsspris = inkop; }
}


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Projekt 13: Lagerartikel ---");
        LagerArtikel art = new LagerArtikel(100);
        art.Utpris = 110; // För lågt, korrigeras till 125
        Console.WriteLine($"Konsumentpris: {art.Utpris} kr");



        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
