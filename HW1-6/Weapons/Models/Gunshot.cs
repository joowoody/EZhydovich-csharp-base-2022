namespace Weapons.Models;

public abstract class Gunshot : Weapon
{
    public readonly string  _friendlyname = "Undefined";

    protected Gunshot(string friendlyname)
    {
        _friendlyname = friendlyname;
    }

    protected Gunshot()
    {
    }

    public abstract int Cage { get; set; }

    public virtual void Holster()
    {
        Console.WriteLine("Holster");
    }
}