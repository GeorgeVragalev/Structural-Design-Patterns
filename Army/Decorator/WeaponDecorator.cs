using Army.Models.Army;
using Army.Models.Weaponry;

namespace Army.Decorator;

public class WeaponDecorator : SoldierDecorator
{
    private readonly IWeapon _weapon;
    
    public WeaponDecorator(ISoldier soldier, IWeapon weapon) : base(soldier)
    {
        _weapon = weapon;
    }

    public override string Attack()
    {
        return $"{base.Attack()} {_weapon.Fire()}";
    }
    
    public override string Defend()
    {
        return $"{base.Defend()} {_weapon.Fire()}";
    }
}