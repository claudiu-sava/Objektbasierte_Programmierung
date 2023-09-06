namespace GeoShapes;

public class Formenbehaelter
{
    private Rechteck _rechteck1;
    private Rechteck _rechteck2;
    private Kreis _kreis1;
    
    // Der Formenbehälter kann einen bis drei Kreise besitzen
    private int _maxKreis = 3;
    private int _minKreis = 1;
    private List<Kreis> _kreisNumber = new List<Kreis>();
    
    // Der Formenbehälter kann null bis vier Dreiecke besitzen
    private int _maxDreieck = 4;
    private int _minDreieck = 0;
    private List<Dreieck> _dreieckNumber = new List<Dreieck>();

    
    // Der Formenbehälter muss genau 2 Rechtecke besitzen
    public Formenbehaelter(Rechteck rechteck1, Rechteck rechteck2, Kreis kreis1)
    {
        _rechteck1 = rechteck1;
        _rechteck2 = rechteck2;
        _kreis1 = kreis1;
        _kreisNumber.Add(_kreis1);
    }

    /// <summary>
    /// Add a Kreis to Formenbehaelter
    /// </summary>
    public void AddKreis(Kreis kreis)
    {
        if (_kreisNumber.Count < _maxKreis)
        {
            _kreisNumber.Add(kreis);
            Console.WriteLine($"Kreis added successfully. You have {_kreisNumber.Count} Kreis inside the Formenbehälter");
        }
        else
        {
            Console.WriteLine($"You have reached the max number of Kreis! You have {_kreisNumber.Count} Kreis inside the Formenbehälter");
        }
    }
    
    /// <summary>
    /// Remove a Kreis from Formenbehaelter
    /// </summary>
    public void DeleteKreis(Kreis kreis)
    {
        if (_kreisNumber.Count > _minKreis)
        {
            _kreisNumber.Remove(kreis);
            Console.WriteLine($"Kreis removed successfully. You have {_kreisNumber.Count} Kreis inside the Formenbehälter");
        }
        else
        {
            Console.WriteLine($"You cannot have less than {_minKreis} Kreis! You have {_kreisNumber.Count} Kreis inside the Formenbehälter");
        }
    }

    
    /// <summary>
    /// Add a Dreieck to Formenbehaelter
    /// </summary>
    public void AddDreieck(Dreieck dreieck)
    {
        if (_dreieckNumber.Count < _maxDreieck)
        {
            _dreieckNumber.Add(dreieck);
            Console.WriteLine($"Dreieck added successfully. You have {_dreieckNumber.Count} Dreieck inside the Formenbehälter");
        }
        else
        {
            Console.WriteLine($"You have reached the max number of Dreieck! You have {_dreieckNumber.Count} Dreieck inside the Formenbehälter");
        }
    }
    

    /// <summary>
    /// Remove a Dreieck from Formenbehaelter
    /// </summary>
    public void DeleteDreieck(Dreieck dreieck)
    {
        if (_dreieckNumber.Count == 0)
        {
            Console.WriteLine($"You cannot have less than 0 Dreieck! You have {_dreieckNumber.Count} Dreieck inside the Formenbehälter");
        }
        else
        {
            _dreieckNumber.Remove(dreieck);
            Console.WriteLine($"Kreis removed successfully. You have {_kreisNumber.Count} Kreis inside the Formenbehälter");
        }
    }
        

}