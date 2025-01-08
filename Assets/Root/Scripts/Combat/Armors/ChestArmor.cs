using UnityEngine;
using Movement;
using Inventories;
using Characters;
using System;

namespace Combat.Armors
{
    [Serializable]
    public sealed class ChestArmor : Armor
    {

        public override ArmorType Type => ArmorType.Chest;


        [Space]
        public Fractions Fraction;
        
        [Space]
        public InventorySize InventorySize;


        [Range(1, 100), Space]
        public int MaxArmorHp;


        [Space]
        public MovementSettings Movement;
    }
}
