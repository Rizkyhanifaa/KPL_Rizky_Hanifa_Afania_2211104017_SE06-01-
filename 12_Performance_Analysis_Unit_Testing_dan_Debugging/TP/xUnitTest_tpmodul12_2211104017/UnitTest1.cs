using Xunit;
using tpmodul12_2211104017;

public class BilanganHelperTests
{
    [Fact]
    public void TestNegatif()
    {
        Assert.Equal("Negatif", BilanganHelper.CariTandaBilangan(-5));
    }

    [Fact]
    public void TestPositif()
    {
        Assert.Equal("Positif", BilanganHelper.CariTandaBilangan(10));
    }

    [Fact]
    public void TestNol()
    {
        Assert.Equal("Nol", BilanganHelper.CariTandaBilangan(0));
    }
}
