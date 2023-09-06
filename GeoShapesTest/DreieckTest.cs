using GeoShapes;
namespace GeoShapesTest;


[TestClass()]
public class DreieckTest
{
    [TestMethod()]
    public void Test_Umfang_Dreieck()
    {

        Linie linie1 = new Linie(20);
        Linie linie2 = new Linie(20);
        Linie linie3 = new Linie(20);
        
        Dreieck dreieck = new Dreieck(linie1, linie2, linie3);

        double value = dreieck.CalculateUmfang();

        Assert.AreEqual(value, 60);
    }
}