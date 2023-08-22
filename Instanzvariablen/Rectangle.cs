namespace Instanzvarianlen;

public class Rectangle
{
    // Aufgabe 1: 
    private int width;

    // Aufgabe 2
    private readonly int height;

    // Aufgabe 3
    private string name = "Rectangle";

    // Aufgabe 4
    public double Area
    {
        get
        {
            return width * height;
        }
    }

    //public double Area => width * height;

    // Aufgabe 5:
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value > 0)
            {
                width = value;
            }
        }
    }

    // Aufgabe 6.
    private string description;

    public string Description
    {
        set
        {
            description = value;
        }
    }
    
    // Aufgabe 8
    public int Height { get; set; }

    // Aufgabe 9
    // public string Comment { set; } Not Possible


}
