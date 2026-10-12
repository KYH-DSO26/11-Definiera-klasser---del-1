namespace _09_Termometerapplikation__Validering_i_set_accessor_;

public class Termometer
{
    private double _celsius;

    public double Celsius
    {
        get { return _celsius; }
        set 
        {
            if (value < -273.15)
            {
                Console.WriteLine("Fel! Under absoluta nollpunkten! Sätter till -273.15");
                _celsius = -273.15;
            }
            else _celsius = value;
        }
    }

}
