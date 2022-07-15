using Weapons.Interfaces;

namespace Weapons.Models;

public class Knife: Cutting, IDamage
{
    private int _sharpening;
    public override string Name { get; set; }
    public override int Price { get; set; }
    public override int DmgOfShot { get; set; }

    public Knife(int value)
    {
        _sharpening = value;
    }
    
    public void Damage()
    {
        Console.WriteLine($"Silent Strike +{DmgOfShot}");
    }

    
}