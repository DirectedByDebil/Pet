using Movement;
using Characters;
using Combat.Armors;
using System;
using System.Collections.Generic;

namespace Inventories
{
    public class Inventory
    {

        public event Action<IMovementStats> MovementChanged;

        public event Action<int> ArmorHpChanged;

        public event Action<Fractions> VisibleFractionChanged;


        private ArmorSet _armorSet;

        //current weapon


        private InventorySize _size;


        public Inventory()
        {


        }


        public void OnArmorHpChanged(int diff)
        {

        }
    }
}
