namespace Auto;

public class Motor
{
    


    
    public static void Starten()
    {
        Benzinpumpe benzinpumpe = new Benzinpumpe();
        Anlasser analsser = new Anlasser();
        
        Console.WriteLine("Motor starten");
        benzinpumpe.Pumpen();
        analsser.Starten();
        Regeln();
    }

    private static void Regeln()
    {

    int i = 0;
    
    while (i < 7)
    {
        Console.WriteLine("Motor regeln");
        i += 1;
    }
    
    Anlasser.Stoppen();
}
}