using Movement;

namespace Combat.Armors
{
    public interface ILegsArmor : IArmor
    {

        public MovementStats Movement { get; }


        //#TODO maybe bool HasArmorBonus
        //#TODO maybe add armor hp
    }
}
