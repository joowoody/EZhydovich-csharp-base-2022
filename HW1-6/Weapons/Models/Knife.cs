using Weapons.Interfaces;

namespace Weapons.Models;

public class Knife: Cutting, IDamage
{
    private int Sharpening { get; set; }

    public Knife(int value)
    {
        Sharpening = value;
    }
    


    public void Damage()
    {
        Console.WriteLine($"Silent Strike +{DmgOfShot}");
    }

}