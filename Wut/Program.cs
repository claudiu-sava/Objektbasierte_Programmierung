// See https://aka.ms/new-console-template for more information

using System.Net;
using Wut;

class Program
{
    public static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("1 für provozieren\n" +
                              "2 für essen zu geben\n" +
                              "3 für essen zu verweigern\n" +
                              "4 für ein Arbeitsauftrag zu geben\n" +
                              "0 für exit");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("Wie fest willst du provozieren?");
                Person.Provozieren(Convert.ToInt32(Console.ReadLine()));
            }
            else if (answer == "2")
            {
                Person.EssenGeben();
            }
            else if (answer == "3")
            {
                Person.EssenVerweigern();
            }
            else if (answer == "4")
            {
                Person.ArbeitsauftragGeben();
            }
            else
            {
                break;
            }
        } while (true);
    }
}