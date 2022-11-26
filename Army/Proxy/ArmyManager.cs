using Army.Models.Army;

namespace Army.Proxy;

public class ArmyManager
{
    private readonly IArmy _armyProxy;
    
    public ArmyManager(IArmy armyProxy)
    {
        _armyProxy = armyProxy;
    }

    public string AttackWithArmy()
    {
        return _armyProxy.Attack();
    }
    
    public string DefendWithArmy()
    {
        return _armyProxy.Defend();
    }
}