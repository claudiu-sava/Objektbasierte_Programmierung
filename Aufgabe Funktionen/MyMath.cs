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
}