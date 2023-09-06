namespace Aufgabe_Funktionen;

public class MyMath
{
    public static int calc_ggT(int a, int b)
    {
        int z = 0;
        while (b != 0)
        {
            z = a % b;
            a = b;
            b = z;
        }

        return a;
    }
    
    public static int calc_kgV(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return calc_ggT(b, a%b);
        }
    }

    public static void Swap(int a, int b)
    {
        int z = a;
        a = b;
        b = z;

    }

    public static double MittelWert(int[] numbers)
    {
        double sum = 0;

        foreach (int i in numbers)
        {
            sum += i;
        }
        return sum / numbers.Length;
    }

    public static int MaxNumber(int[] numbers)
    {
        return numbers.Max();
    }

    public static int MinNumber(int[] numbers)
    {
        return numbers.Min();
    }
}