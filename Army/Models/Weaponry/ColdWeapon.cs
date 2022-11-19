namespace Army.Models.Weaponry;

public class ColdWeapon : IWeapon
{
    private readonly int Id;
    private readonly ColdWeaponEnum _weapon;

    public ColdWeapon(ColdWeaponEnum weapon, int id)
    {
        _weapon = weapon;
        Id = id;
    }

    public string Fire()
    {
        return $"Attacking with {_weapon} with id: {Id}\n";
    }

    public string Clean()
    {
        return $"Cleaning {_weapon} with id: {Id}\n";
    }
    
    public string Test()
    {
        var test = Random.Shared.Next(1, 10);
        return $"The {_weapon} with id: {Id} {(test < 2 ? "bent" : "in good condition")}\n";
    }
}