namespace GeoShapes;

public class Dreieck
{
    private Linie _linie1;
    private Linie _linie2;
    private Linie _linie3;

    public Dreieck(Linie linie1, Linie linie2, Linie linie3)
    {
        _linie1 = linie1;
        _linie2 = linie2;
        _linie3 = linie3;

        if (isChecked())
        {
            Console.WriteLine("Dreieck -- Done!");
        }
        else
        {
            Console.WriteLine("Please try with better numbers!");
        }
        
    }

    // Checks if the 3 lines can build a triangle
    private bool isChecked()
    {
        if (_linie1.lenght + _linie2.lenght > _linie3.lenght && _linie1.lenght + _linie3.lenght > _linie2.lenght && _linie2.lenght + _linie3.lenght > _linie1.lenght)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Calculate the Umfang
    /// </summary>
    /// <returns>Umfang</returns>
    public double CalculateUmfang()
    {
        return _linie1.lenght + _linie2.lenght + _linie3.lenght;
    }
    

    /// <summary>
    /// Calculate the Flaeche
    /// </summary>
    /// <returns>Flaeche</returns>
    public double CalculateFlaeche()
    {
        double semiPerimeter = CalculateUmfang() / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _linie1.lenght) * (semiPerimeter - _linie2.lenght) * (semiPerimeter - _linie3.lenght));
    }
    
}