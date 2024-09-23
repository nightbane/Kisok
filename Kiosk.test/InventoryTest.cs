using Kiosk.logic;

namespace Kiosk.test;

public class InventoryTest
{
    [Fact]
    public void InvertoryCreate(){
        Inventory inv = new Inventory();
        inv.AddPhysicalGood("item", 11.95M, 7);
        Assert.Equal(1, inv.Items.Count);
        Assert.Equal(7, inv.Items[0].Quantity);
    }

    [Fact]
    public void PurchaseItem(){
        int quantity = 7;
        Inventory inv = new Inventory();
        inv.AddPhysicalGood("item", 11.95M, quantity);
        decimal cost = inv.Purchase("item", 1);
        Assert.Equal(cost, 11.95M);
        Assert.Equal(quantity - 1, inv.Items[0].Quantity);
    }
}