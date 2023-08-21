// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        string[] orders = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        foreach (string order in orders)
        {
            if (order.StartsWith("B"))
            {
                Console.WriteLine(order);
            }
        }
    }
}