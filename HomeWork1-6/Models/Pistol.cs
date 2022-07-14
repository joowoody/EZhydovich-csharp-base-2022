using Weapons.Interfaces;

namespace Weapons.Models;

internal class Pistol: Gunshot, IDamage, IRecharge
{
    public void Damage()
    {
        Console.WriteLine($"Pif-paf: {DmgOfShot}");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharge pistol 3 sec!");
    }
}