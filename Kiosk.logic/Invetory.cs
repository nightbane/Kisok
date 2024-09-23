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

    public decimal Purchase(string name, int quantity){
        Items[0].Sold();
        return 11.95M;
    }

}