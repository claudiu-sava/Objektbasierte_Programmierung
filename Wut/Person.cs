namespace Wut;

public class Person
{
    private int wutLevel;
    private int appetitLevel;
    private static string name = "Wladimir";
    

    public Person(int wutLevel, int appetitLevel)
    {
        this.wutLevel = wutLevel;
        this.appetitLevel = appetitLevel;
        
    }


    public static void Provozieren(int level)
    {
        Console.WriteLine($"Du hast {name} mit {level}% provoziert!");
        Ausrasten();
    }

    private static void Ausrasten()
    {
        Console.WriteLine($"{name} rastet sich aus! Renn!");
    }

    public static void EssenGeben()
    {
        Console.WriteLine($"Du hast {name} essen gegeben!\n{name} ist glücklich");
    }

    public static void EssenVerweigern()
    {
        Console.WriteLine($"Du hast {name} essen verweigert!\n{name} ist traurig");
    }

    public static void ArbeitsauftragGeben()
    {
        Console.WriteLine($"Du hast {name} ein Auftrag gegeben!\n{name} ist sehr wütend");
    }
}