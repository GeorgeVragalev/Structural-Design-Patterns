using Army.Models.Weaponry;

namespace Army.Models.Army;

//Fascade pattern IArmy simplified interface
//Composite pattern - hierarchical structure of army 
public class Army : IArmy
{
    private readonly string _armyName;
    private readonly IList<General> _generals;
    private readonly WeaponsStack _weaponsStack;

    public Army(IList<General> generals, string armyName, WeaponsStack weaponsStack)
    {
        _generals = generals;
        _armyName = armyName;
        _weaponsStack = weaponsStack;
    }

    public string Attack()
    {
        var attack = $"Army {_armyName} is attacking!\n";
        foreach (var general in _generals)
        {
            attack += $"{general.Attack()}\n";
        }

        attack += _weaponsStack.FireWeapons();

        return attack;
    }

    public string Defend()
    {
        var defend = $"Army {_armyName} is defending!\n";
        foreach (var general in _generals)
        {
            defend += $"{general.Defend()}\n";
        }

        defend += _weaponsStack.FireWeapons();
        defend += _weaponsStack.CleanWeapons();
        
        return defend;
    }
    
    public WeaponsStack GetWeapons()
    {
        return _weaponsStack;
    }
}