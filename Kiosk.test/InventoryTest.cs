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
}