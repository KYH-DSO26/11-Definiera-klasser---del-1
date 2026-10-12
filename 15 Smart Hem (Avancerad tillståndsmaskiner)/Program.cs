namespace _15_Smart_Hem__Avancerad_tillståndsmaskiner_;

public enum LampStatus { Av, Lag, Medium, Max }
public class SmartLampa
{
    public LampStatus Status { get; private set; } = LampStatus.Av;
    public int AntalTimmarTand { get; private set; }
    public void Klick()
    {
        // Cyklar igenom tillstånden sekventiellt
        if (Status == LampStatus.Av) Status = LampStatus.Lag;
        else if (Status == LampStatus.Lag) Status = LampStatus.Medium;
        else if (Status == LampStatus.Medium) Status = LampStatus.Max;
        else Status = LampStatus.Av;
        // Om lampan blev tänd, räkna upp drifttimmar
        if (Status != LampStatus.Av)
        {
            AntalTimmarTand++;
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Projekt 15: Smart Hem ---");
        SmartLampa vardagsrum = new SmartLampa();
        Console.WriteLine($"Startläge: {vardagsrum.Status}");
        vardagsrum.Klick(); // Blir Låg
        vardagsrum.Klick(); // Blir Medium
        Console.WriteLine($"Efter två klick: {vardagsrum.Status}");
        Console.WriteLine($"Totalt antal aktiva drifttimmar: {vardagsrum.AntalTimmarTand}");
        vardagsrum.Klick(); // Blir Max
        vardagsrum.Klick(); // Blir Av
        Console.WriteLine($"Efter ytterligare klick: {vardagsrum.Status}");



        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
