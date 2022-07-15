using Weapons.Interfaces;

namespace Weapons.Models;

public class Carbin: Gunshot, IDamage, IRecharge
{
    public override string Name { get; set; }
    public override int Price { get; set; }
    public override int DmgOfShot { get; set; }
    public override int Cage { get; set; }

    public void Damage()
    {
        Console.WriteLine($"Tra-ta-ta-ta-ta :) +{DmgOfShot}");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharge 5 sec!");
    }

    
}