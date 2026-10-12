namespace _05_Maträtt__Enum_;

public enum Matkategori
{
    Kött,
    Fisk,
    Vegetariskt,
    Vegansk
}

public class Maträtt
{
    public string Namn { get; set; }
    public Matkategori Kategori { get; set; }
}

internal class Program
{
    static void Main(string[] args)
    {
        Maträtt mat = new Maträtt { Namn = "Laxplanka", Kategori = Matkategori.Fisk };

        Console.WriteLine($"Maträtt: {mat.Namn}, Kategori: {mat.Kategori}");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
