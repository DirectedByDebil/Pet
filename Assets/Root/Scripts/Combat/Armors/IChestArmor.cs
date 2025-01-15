using Characters;
using Inventories;
using Movement;

namespace Combat.Armors
{
    public interface IChestArmor: IArmor
    {

        public Fractions Fraction { get; }

        public InventorySize InventorySize { get; }


        public int MaxArmorHp { get; }

        public MovementStats Movement { get; }
    }
}
