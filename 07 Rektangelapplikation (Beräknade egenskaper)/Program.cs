namespace _07_Rektangelapplikation__Beräknade_egenskaper_;

public class Rektangel
{
    public double Bredd { get; set; }
    public double Höjd { get; set; }
    public double Area { get { return Bredd * Höjd; } }
}
internal class Program
{
    static void Main(string[] args)
    {
        //Rektangel r = new Rektangel { Bredd = 5, Höjd = 4 };
        //Rektangel r = new () { Bredd = 5, Höjd = 4 };
        var r = new Rektangel { Bredd = 5, Höjd = 4 };
        //Rektangel r = new Rektangel();
        //r.Bredd = 5;
        //r.Höjd = 4;
        Console.WriteLine($"Rektangelns area: {r.Area}");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
