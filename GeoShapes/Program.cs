namespace GeoShapes;

class Program
{
    public static void Main(string[] args)
    {

        Linie rechteckLinie1 = new Linie(90);
        Linie rechteckLinie2 = new Linie(90);
        Linie rechteckLinie3 = new Linie(90);
        Linie rechteckLinie4 = new Linie(90);
        Linie rechteckLinie5 = new Linie(20);
        Linie rechteckLinie6 = new Linie(20);
        Linie kreisLinie1 = new Linie(12.8);
        Linie kreisLinie2 = new Linie(100);
        Linie dreieckLinie1 = new Linie(20);
        Linie dreieckLinie2 = new Linie(20);
        Linie dreieckLinie3 = new Linie(20);
        
        Rechteck rechteck1 = new Rechteck(rechteckLinie1, rechteckLinie2, rechteckLinie3, rechteckLinie4);
        Rechteck rechteck2 = new Rechteck(rechteckLinie5, rechteckLinie1, rechteckLinie6, rechteckLinie2);
        
        Kreis kreis1 = new Kreis(kreisLinie1);
        Kreis kreis2 = new Kreis(kreisLinie2);

        Dreieck dreieck1 = new Dreieck(dreieckLinie1, dreieckLinie2, dreieckLinie3);
        
        
        // At this point, the Formenbehaelter has 2 Rechteck und 1 Kreis
        Formenbehaelter form = new Formenbehaelter(rechteck1, rechteck2, kreis1);
        
        
        // Add kreis to Formenbehaelter
        form.AddKreis(kreis2);
        
        // Add dreieck to Formenbehaelter
        form.AddDreieck(dreieck1);
        
        // EXTRA 
        
        // Create Rechteck WITHOUT adding it to Formenbehaelter
        Rechteck rechteck3 = new Rechteck(rechteckLinie1, rechteckLinie5, rechteckLinie2, rechteckLinie6);
        
        // Calculations
        Console.WriteLine($"Dreieck Flaeche: {dreieck1.CalculateFlaeche()}");
        Console.WriteLine($"Rechteck Umfang: {rechteck1.CalculateUmfang()}");
        Console.WriteLine($"Kreis Fläche: {kreis1.CalculateFlaeche()}");

    }
}