using Characters;
using Inventories;

namespace Combat.Armors
{
    public interface IChestArmor: IArmor
    {

        public Fractions Fraction { get; }

        public InventorySize InventorySize { get; }


        public int MaxArmorHp { get; }
    }
}
