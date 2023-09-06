using GeoShapes;
namespace GeoShapesTest;

[TestClass()]
public class RechteckTest
{
    [TestMethod()]
    public void Test_Umfang_Rechteck()
    {

        Linie linie1 = new Linie(20);
        Linie linie2 = new Linie(20);
        Linie linie3 = new Linie(20);
        Linie linie4 = new Linie(20);
        
        Rechteck rechteck = new Rechteck(linie1, linie2, linie3, linie4);

        double value = rechteck.CalculateUmfang();

        Assert.AreEqual(value, 80);
    }
}