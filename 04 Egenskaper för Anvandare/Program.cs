namespace _04_Egenskaper_för_Anvandare;

public class Användare
{
    public string? Användarnamn { get; set; }
    public string? Epost { get; set; }
}

internal class Program
{
    static void Main(string[] args)
    {
        Användare user = new Användare();
        user.Användarnamn = "dev_kalle";
        user.Epost = "kallekula@kyh.se";

        Console.WriteLine($"Användare: {user.Användarnamn} ({user.Epost})");






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
