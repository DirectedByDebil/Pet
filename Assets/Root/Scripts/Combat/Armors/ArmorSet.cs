using System;
using UnityEngine;

namespace Combat.Armors
{

    [Serializable]
    public sealed class ArmorSet
    {

        [SerializeField, Space]
        private HeadGadget _headGadget;


        [SerializeField, Space]
        private ChestArmor _chestArmor;


        [SerializeField, Space]
        private LegsArmor _legsArmor;


        public bool TryGetChest(out IChestArmor armor)
        {

            if(_chestArmor)
            {

                armor = _chestArmor.Stats;

                return true;
            }

            armor = null;

            return false;
        }


        public bool TryGetLegs(out ILegsArmor armor)
        {

            if (_legsArmor)
            {

                armor = _legsArmor.Stats;

                return true;
            }

            armor = null;

            return false;
        }
    }
}
