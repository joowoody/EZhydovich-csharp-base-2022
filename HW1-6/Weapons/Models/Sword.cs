using Weapons.Interfaces;

namespace Weapons.Models;

internal class Sword: Cutting, IDamage
{
    public const int DamageOfHelth = 20;
    private int _lenght { get; set; }
    public override string Name { get; set; }
    public override int Price { get; set; }
    public override int DmgOfShot { get; set; }
    
    public Sword(int length)
    {
        _lenght = length;
    }
    
    public void Damage()
    {
        Console.WriteLine($"Herak, pizza :) disadvantage of health {DamageOfHelth}");
    }

   
}