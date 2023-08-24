namespace Auto;

public class Motor
{
    public static void Starten()
    {
        Console.WriteLine("Motor starten");
        Benzinpumpe.Pumpen();
        Anlasser.Starten();
        Regeln();
    }

    private static void Regeln()
    {

    int i = 0;
    
    while (i <= 7)
    {
        Console.WriteLine("Motor regeln");
        i += 1;
    }
    Anlasser.Stoppen();
}
}