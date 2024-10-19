using RgbToHex;

namespace Test;

public class Tests
{
    [Test]
    public void AllZeroes_ReturnsAllZeroes()
    {
        var rgb = Kata.Rgb(0,0,0);
        Assert.That(rgb, Is.EqualTo("000000"));
    }
    
    [Test]
    public void All255s_ReturnsAllFs()
    {
        var rgb = Kata.Rgb(255,255,255);
        Assert.That(rgb, Is.EqualTo("FFFFFF"));
    }
    
    [Theory]
    [TestCase(1, 1, 1, "010101")]
    [TestCase(148,0,211, "9400D3")]
    public void RGB_TranslatesToHex(int r, int g, int b, string hex)
    {
        var rgb = Kata.Rgb(r, g, b);
        Assert.That(rgb, Is.EqualTo(hex));
    }
    
    [Test]
    public void TooHighValue_ReturnsClosestValidValue()
    {
        var rgb = Kata.Rgb(255, 255, 256);
        Assert.That(rgb, Is.EqualTo("FFFFFF"));
    }
    
    [Test]
    public void TooLowValue_ReturnsClosestValidValue()
    {
        var rgb = Kata.Rgb(-255, 255, 255);
        Assert.That(rgb, Is.EqualTo("00FFFF"));
    }
}