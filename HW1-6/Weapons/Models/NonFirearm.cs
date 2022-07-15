namespace Weapons.Models;

public abstract class NonFirearm : Weapon
{
   public abstract int Range { get; set; }
}