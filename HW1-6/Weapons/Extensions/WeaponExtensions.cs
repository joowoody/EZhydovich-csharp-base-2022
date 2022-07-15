using Weapons.Models;

namespace Weapons.Extensions;

public static class WeaponExtensions
{
    public static Weapon Copy(this Weapon weapon)
    {
        return new Bow
        {
            Name = weapon.Name,
            Price = weapon.Price,
            DmgOfShot = weapon.DmgOfShot,
        };
    } 
}

