using System;
using UnityEngine;

namespace Combat.Armors
{

    [Serializable]
    public sealed class ArmorSet
    {

        [field: SerializeField, Space]
        public HeadGadget HeadGadget { get; private set; }


        [field: SerializeField, Space]
        public ChestArmor ChestArmor { get; private set; }


        [field: SerializeField, Space]
        public LegsArmor LegsArmor {  get; private set; }
    }
}
