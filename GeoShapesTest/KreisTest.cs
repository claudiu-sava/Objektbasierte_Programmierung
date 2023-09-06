using GeoShapes;
namespace GeoShapesTest;

[TestClass()]
public class KreisTest
{
    [TestMethod()]
    public void Test_Umfang_Kreis()
    {

        Linie linie1 = new Linie(20);
        
        Kreis kreis = new Kreis(linie1);

        double value = kreis.CalculateUmfang();

        Assert.AreEqual(value, 20);
    }
}