// See https://aka.ms/new-console-template for more information

using Aufgabe_Funktionen;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber = readInt();
        int secondNumber = readInt();
        Console.WriteLine(MyMath.calc_ggT(firstNumber,secondNumber));
    }

    static int readInt()
    {
        bool isZeroOrLess = true;
        int value = 0;
        while (isZeroOrLess)
        {
            Console.WriteLine("Enter any number greater than 0");
            Console.Write(">> ");
            value = Convert.ToInt32(Console.ReadLine());
            if (value <= 0)
            {
                Console.WriteLine("Please enter any number greater than 0");
            }
            else
            {
                isZeroOrLess = false;
            }
            
        }

        return value;
    }
}