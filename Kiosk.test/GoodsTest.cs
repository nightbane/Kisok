using Kiosk.logic;

namespace Kiosk.test;

public class GoodsTest
{
    [Fact]
    public void Test1()
    {
        PhysicalGood item = new PhysicalGood("small lego", 21.95M);
        Assert.Equal("small lego", item.Name);
        Assert.Equal(21.95M, item.Cost);
    }

    [Fact]
    public void CanPurchase() {
        PhysicalGood item = new PhysicalGood("small lego", 21.95M);
        item.Quantity = 10;
        item.Sold();
        Assert.Equal(9, item.Quantity);
        Assert.Equal(21.95M, item.Revenue);
    }

    [Fact]
    public void ReturnTest()
    {
        
    }
}