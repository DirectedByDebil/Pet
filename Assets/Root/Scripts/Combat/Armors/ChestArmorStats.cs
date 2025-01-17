using Characters;
using Inventories;
using Movement;
using UnityEngine;

namespace Combat.Armors
{

    [CreateAssetMenu(fileName ="New Chest Stats", 
        menuName = "Characters/Armors/Chest Stats", order = 2)]

    public sealed class ChestArmorStats : ScriptableObject, IChestArmor
    {

        public ArmorType Type => ArmorType.Chest;


        [field: SerializeField, Space]
        public Fractions Fraction {  get; private set; }


        [field: SerializeField, Space]
        public InventorySize InventorySize {  get; private set; }


        [field: SerializeField, Range(1, 100), Space]
        public int MaxArmorHp { get; private set; }
    }
}
