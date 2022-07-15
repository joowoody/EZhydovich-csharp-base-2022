namespace Weapons.Models;

public abstract class Weapon
{
    public abstract string Name { get; set; }
    public abstract int Price { get; set; }
    public abstract int DmgOfShot { get; set; }
}
