using Weapons.Interfaces;

namespace Weapons.Models;

internal class Sword: Cutting, IDamage
{
    private int Lenght { get; set; }
    public Sword(int length)
    {
        Lenght = length;
    }
    
    public void Damage()
    {
        Console.WriteLine($"Herak, pizza :) {DmgOfShot}");
    }
}