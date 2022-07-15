using Weapons.Interfaces;

namespace Weapons.Models;

internal class Pistol: Gunshot, IDamage, IRecharge
{
    public override string Name { get; set; }
    public override int Price { get; set; }
    public override int DmgOfShot { get; set; }
    public override int Cage { get; set; }
    
    public Pistol(string friendlyname) : base(friendlyname)
    {
    }
    
    public void Damage()
    {
        Console.WriteLine($"Pif-paf: disadvantage of health {DmgOfShot}");
    }

    public void Recharge()
    {
        Console.WriteLine($"Recharge {Name} 3 sec!");
    }

    public override void Holster()
    {
        for (var i = 0; i <= Cage; i++)
        {
            Damage();
        }
        Recharge();
        Console.WriteLine($"Holster {Name}");
    }

    
}