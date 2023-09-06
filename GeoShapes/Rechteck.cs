namespace GeoShapes;

public class Rechteck
{
    private Linie _linie1; // width
    private Linie _linie2; // height
    private Linie _linie3; // width
    private Linie _linie4; // height


    public Rechteck(Linie width1, Linie height1, Linie width2, Linie height2)
    {
        _linie1 = width1;
        _linie2 = height1;
        _linie3 = width2;
        _linie4 = height2;

        if (isChecked())
        {
            Console.WriteLine("Rechteck -- Done!");
        }
        else
        {
            Console.WriteLine("Please try with better numbers!");
        }
    }

    private bool isChecked()
    {
        if (_linie1.lenght == _linie3.lenght && _linie2.lenght == _linie4.lenght)
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
        return _linie1.lenght + _linie2.lenght + _linie3.lenght + _linie4.lenght;
    }
    
    
    /// <summary>
    /// Calculate the Flaeche
    /// </summary>
    /// <returns>Flaeche</returns>
    public double CalculateFlaeche()
    {
        return _linie1.lenght * _linie2.lenght; // width * height
    }
    
}