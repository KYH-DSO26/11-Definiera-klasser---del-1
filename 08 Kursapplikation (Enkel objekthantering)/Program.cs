namespace _08_Kursapplikation__Enkel_objekthantering_;

public class Student
{
    public string Namn { get; set; }
    public bool AktivStatus { get; set; }
}

public class Kurs
{
    public string KursNamn { get; set; }
    public void RegistreraStudent(Student student)
    {
        if (student.AktivStatus)
        {
            Console.WriteLine($"Lyckat: {student.Namn} är registrerad på {KursNamn}");
        }
        else
        {
            Console.WriteLine($"Misslyckades: {student.Namn} är inaktiv");
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        var k = new Kurs { KursNamn = "Grundläggande C#" };
        var s = new Student { Namn = "Kalle Kula", AktivStatus = true };

        k.RegistreraStudent(s);

        var s2 = new Student { Namn = "Claes", AktivStatus = false };
        k.RegistreraStudent(s2);




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
