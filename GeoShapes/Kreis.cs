namespace GeoShapes;

public class Kreis
{

    private Linie _linie;
    
    public Kreis(Linie linie) 
    {
        this._linie = linie;
        Console.WriteLine("Kreis -- Done!");
    }
    
    


    public double CalculateUmfang()
    {
        return _linie.lenght;
    }

    public double CalculateFlaeche()
    {
        double radius = _linie.lenght / 2;
        return Math.Sqrt(radius) * Math.PI;
    }
}