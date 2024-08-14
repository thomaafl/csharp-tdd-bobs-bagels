namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;
public class Tests
{


    [Test]
    public void addBagelTest()
    {
        Basket basket = new Basket();
        string bagel = "cheese";

        basket.addBagel(bagel);

        Assert.Pass();
    }
}