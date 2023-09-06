using System.Runtime.CompilerServices;

namespace GeoShapes;

public class Linie
{
    private double _lenght;
    public double lenght { get { return _lenght; } }

    public Linie(double lenght)
    {
        if (_lenght <= 0)
        {
            Console.WriteLine("The number have to bigger than 0!");
        }
        else
        {
            _lenght = lenght;
        }
    }
}