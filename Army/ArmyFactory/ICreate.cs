using Army.Models.Army;

namespace Army.ArmyFactory;

public interface ICreate
{
    public ISoldier CreateSoldier(string name, Role role);
}