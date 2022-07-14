using Weapons.Interfaces;

namespace Weapons.Models;

public class Crossbow: NonFirearm, IDamage, IRecharge
{
   
    public void Damage()
    {
        Console.WriteLine($"Shot {DmgOfShot}");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharge 5 sec!");
    }
}