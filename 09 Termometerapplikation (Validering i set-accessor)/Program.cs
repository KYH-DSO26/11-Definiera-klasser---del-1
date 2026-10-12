namespace _09_Termometerapplikation__Validering_i_set_accessor_;
internal class Program
{
    static void Main(string[] args)
    {
        Termometer t = new Termometer();
        t.Celsius = -300;
        Console.WriteLine($"Temperatur: {t.Celsius}");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
