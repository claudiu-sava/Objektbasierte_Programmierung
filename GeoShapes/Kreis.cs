namespace GeoShapes;

public class Kreis
{

    private Linie _linie;
    
    public Kreis(Linie linie) 
    {
        _linie = linie;
        Console.WriteLine("Kreis -- Done!");
    }
    
    

    /// <summary>
    /// Calculate the Umfang
    /// </summary>
    /// <returns>Umfang</returns>
    public double CalculateUmfang()
    {
        return _linie.lenght;
    }
    

    /// <summary>
    /// Calculate the Flaeche
    /// </summary>
    /// <returns>Flaeche</returns>
    public double CalculateFlaeche()
    {
        double radius = _linie.lenght / 2;
        return Math.Sqrt(radius) * Math.PI;
    }
}