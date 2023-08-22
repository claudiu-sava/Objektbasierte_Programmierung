// See https://aka.ms/new-console-template for more information

using Aufgabe_Funktionen;

class Program
{
    static void Main(string[] args)
    {
        int[] testArr = {2,5,4,6};
        bool stop = false;

        while (!stop)
        {
            int firstNumber = readInt();
            int secondNumber = readInt();
            Console.WriteLine(MyMath.calc_ggT(firstNumber,secondNumber));
            Console.WriteLine("Do you want to continue? y/n");
            Console.Write(">> ");
            string userAnswer = Console.ReadLine();
            if (!(userAnswer is "y" or "Y"))
            {
                stop = true;
            }
        }
        
        Console.WriteLine($"The MittelWert from array is {MyMath.MittelWert(testArr)}");
        Console.WriteLine($"The max number from array is {MyMath.MaxNumber(testArr)}");
        Console.WriteLine($"The min number from array is {MyMath.MinNumber(testArr)}");
        
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