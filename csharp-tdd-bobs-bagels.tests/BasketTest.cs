namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;
public class Tests
{


    [Test]
    public void addBagelTest()
    {
        Basket basket = new Basket();
        string bagel = "cheese";
        bool expected = true;
        bool result = basket.addBagel(bagel);

        Assert.That(expected == result);
    }
}