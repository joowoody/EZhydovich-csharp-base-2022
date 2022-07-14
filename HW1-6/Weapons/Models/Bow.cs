using Weapons.Interfaces;

namespace Weapons.Models;

public class Bow: NonFirearm, IDamage, IRecharge
{
    public void Damage()
    {
        Console.WriteLine($"Shot {DmgOfShot}");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharge 2 sec!");
    }
}