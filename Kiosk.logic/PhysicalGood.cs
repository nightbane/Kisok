namespace Kiosk.logic;

public class PhysicalGood
{
    public string Name;
    public decimal Cost;
    public int Quantity;

    public Decimal Revenue{get; private set;}

    public PhysicalGood(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
        Quantity = 0;
    }

    public PhysicalGood(string name, decimal cost, int quantity)
        : this (name, cost)
    {
        Quantity = quantity;
    }

    public void Sold(){
        Quantity--;
        Revenue += Cost;
    }
}


// public class Item{
//     public int Count{get;}
//     public int Folds;
//     public int Folds2{get;set;}
//     public int Grip {get;private set;}
//     public readonly int Throws;
//     public int Yellow{get; init;}
//     public void Increment(){
//         Count ++;
//     }
// }