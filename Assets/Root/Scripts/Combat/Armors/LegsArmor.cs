using UnityEngine;
using Movement;
using System;


namespace Combat.Armors
{

    [Serializable]
    public sealed class LegsArmor: Armor
    {

        public override ArmorType Type => ArmorType.Legs;


        [Space]
        public MovementSettings Movement;
    }
}
