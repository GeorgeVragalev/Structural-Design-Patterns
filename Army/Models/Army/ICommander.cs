namespace Army.Models.Army;

public interface ICommander
{
    public void Add(ISoldier soldier);
    public void Remove(ISoldier soldier);
    public ISoldier? GetSoldier(ISoldier soldier);
}