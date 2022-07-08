using Weapons.Interfaces;

namespace Weapons.Models;

public class Carbin: Gunshot, IDamage, IRecharge
{
    

    public void Damage()
    {
        Console.WriteLine($"Tra-ta-ta-ta-ta :) +{DmgOfShot}");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharge 5 sec!");
    }
}