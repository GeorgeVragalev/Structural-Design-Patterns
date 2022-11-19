namespace Army.Models.Weaponry;

public class Firearm : IWeapon
{
    private readonly int Id;
    private readonly WeaponEnum _weaponEnum;

    public Firearm(WeaponEnum weaponEnum, int id)
    {
        _weaponEnum = weaponEnum;
        Id = id;
    }

    public string Fire()
    {
        return $"Firing {_weaponEnum} with id: {Id}\n";
    }

    public string Clean()
    {
        return $"Cleaning {_weaponEnum} with id: {Id}\n";
    }
    
    public string Test()
    {
        var test = Random.Shared.Next(1, 10);
        return $"The {_weaponEnum} with id: {Id} {(test < 4 ? "Malfunctioned" : "Is working")}\n";
    }
}