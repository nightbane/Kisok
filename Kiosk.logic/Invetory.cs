namespace Kiosk.logic;

public class Inventory
{

    public List<PhysicalGood> Items;
    public Inventory(){
        Items = new List<PhysicalGood>();
    }
    public void AddPhysicalGood(string name, decimal cost, int quantity)
    {
        PhysicalGood good = new PhysicalGood(name, cost, quantity);
        Items.Add(good);
    }
}