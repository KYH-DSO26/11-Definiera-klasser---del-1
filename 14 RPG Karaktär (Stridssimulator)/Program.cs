namespace _14_RPG_Karaktär__Stridssimulator_;

public class Hjaltar
{
    public string Namn { get; set; }
    public int Halsa { get; set; }
    public int Skada { get; set; }
    public void Anfall(Hjaltar mal)
    {
        if (this.Halsa <= 0) return;
        Console.WriteLine($"{this.Namn} attackerar {mal.Namn} och gör {this.Skada} skada!");
        mal.Halsa = Math.Max(0, mal.Halsa - this.Skada);
        if (mal.Halsa == 0)
        {
            Console.WriteLine($"{mal.Namn} har svimmat!");
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Projekt 14: RPG Karaktär ---");
        Hjaltar hercules = new Hjaltar { Namn = "Hercules", Halsa = 100, Skada = 40 };
        Hjaltar skurk = new Hjaltar { Namn = "Hades", Halsa = 50, Skada = 10 };
        hercules.Anfall(skurk);
        Console.WriteLine($"{skurk.Namn} hälsa kvar: {skurk.Halsa}");
        hercules.Anfall(skurk); // Denna attack bör sänka hälsan till 0 och få skurken att svimma




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
