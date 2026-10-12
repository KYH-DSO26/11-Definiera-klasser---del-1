namespace _03_Klassen_Produkt_med_en_Metod;

public class Produkt
{
    public string namn;
    public double pris;

    public void SkrivUtPris()
    {
        Console.WriteLine($"Produkten {namn} kostar {pris:C2}");
    }
}
internal class Program
{
    static void Main(string[] args)
    {

        Produkt produkt = new Produkt();
        produkt.namn = "Kaffebryggare";
        produkt.pris = 499.50d;

        produkt.SkrivUtPris();          // Be produkt att skriva ut sig.

        //SkrivUtProdukt(produkt);    // Skicka produkten till utskrift





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
