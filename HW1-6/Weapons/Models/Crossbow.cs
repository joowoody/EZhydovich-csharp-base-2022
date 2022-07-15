using Weapons.Interfaces;

namespace Weapons.Models;

public class Crossbow: NonFirearm, IDamage, IRecharge
{
    public override string Name { get; set; }
    public override int Price { get; set; }
    public override int DmgOfShot { get; set; }
    public override int Range { get; set; }
   
    public void Damage()
    {
        Console.WriteLine($"Shot {DmgOfShot}");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharge 5 sec!");
    }

    
}