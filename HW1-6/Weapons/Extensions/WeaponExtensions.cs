using Weapons.Models;

namespace Weapons.Extensions;

public static class WeaponExtensions
{
    public static Bow Copy(this Bow bow)
    {
        return new Bow
        {
            Name = bow.Name,
            Price = bow.Price,
            DmgOfShot = bow.DmgOfShot,
            Range = bow.Range
        };
    } 
}

