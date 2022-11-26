using Army.Models.Army;

namespace Army.Decorator;

public class SoldierDecorator : ISoldier
{
    private readonly ISoldier _soldier;

    public SoldierDecorator(ISoldier soldier)
    {
        _soldier = soldier;
    }

    public virtual string Attack()
    {
        return _soldier.Attack();
    }
    public virtual string Defend()
    {
        return _soldier.Defend();
    }

    public virtual string Salute()
    {
        return _soldier.Salute();
    }
}