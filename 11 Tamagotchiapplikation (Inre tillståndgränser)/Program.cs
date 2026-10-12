namespace _11_Tamagotchiapplikation__Inre_tillståndgränser_;

public class Husdjur
{
    private int _hunger = 50;

    public void Mata()
    {
        _hunger = Math.Max(0, _hunger - 20);
    }

    public void SkrivUtStatus()
    {
        Console.WriteLine($"Hunger: {_hunger}/100");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Husdjur pet = new Husdjur();

        pet.SkrivUtStatus();
        pet.Mata();

        Console.WriteLine("Efter matning:");
        pet.SkrivUtStatus();
        pet.Mata();

        Console.WriteLine("Efter matning 2:");
        pet.SkrivUtStatus();
        pet.Mata();

        Console.WriteLine("Efter matning 3:");
        pet.SkrivUtStatus();





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
