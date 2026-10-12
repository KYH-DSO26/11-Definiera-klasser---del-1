namespace _12_Biluthyrning__Objektinteraktion_;

public class Hyrbil
{
    public string RegNummer { get; set; }
    public bool ÄrTillgänglig { get; set; }
}

public class Kund
{
    public string Namn { get; set; }
}

public class Uthyrning
{
    public void GenomförUthyrning(Hyrbil bil, Kund kund)
    {
        if (bil.ÄrTillgänglig)
        {
            bil.ÄrTillgänglig = false;
            Console.WriteLine($"{kund.Namn} har hyrt {bil.RegNummer}.");
        }
        else Console.WriteLine("Bilen är tyvärr upptagen.");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Hyrbil bil = new Hyrbil { RegNummer = "MBL512", ÄrTillgänglig = true };
        Kund kund = new Kund { Namn = "Jonas" };

        Console.WriteLine("Jonas vill hyra bilen");
        Uthyrning u = new Uthyrning();

        u.GenomförUthyrning(bil, kund);

        Kund k2 = new Kund { Namn = "Emilia" };
        Uthyrning u2 = new Uthyrning();

        Console.WriteLine("\nEmilia vill hyra samma bil");
        u2.GenomförUthyrning(bil, k2);




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
