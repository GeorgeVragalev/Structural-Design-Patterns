using Army.Models.Army;

namespace Army.Decorator;

public class OutfitDecorator : SoldierDecorator
{
    public OutfitDecorator(ISoldier soldier) : base(soldier)
    {
        
    }

    public override string Salute()
    {
        return $"{base.Salute()}. Equipped with the finest and most durable armour! Ready for battle!";
    }
}