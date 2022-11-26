using Army.Models.Army;

namespace Army.Proxy;

public class ArmyProxy : IArmy
{
    private readonly IArmy _armyService;
    private string _armyAttackResponse;
    private string _armyDefenceResponse;
    private bool _needReset = true;

    public ArmyProxy(IArmy armyService)
    {
        _armyService = armyService;
    }

    public string Attack()
    {
        //atacking with service of army
        if (_armyAttackResponse == null || _needReset)
        {
            _armyAttackResponse = _armyService.Attack();
        }

        return _armyAttackResponse;
    }

    public string Defend()
    {
        //defending with service of army
        if (_armyDefenceResponse == null || _needReset)
        {
            _armyDefenceResponse = _armyService.Defend();
        }

        return _armyDefenceResponse;
    }

    public void SetReset(bool value)
    {
        _needReset = value;
    }
}