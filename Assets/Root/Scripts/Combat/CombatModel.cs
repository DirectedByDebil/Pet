using System;

namespace Combat
{
    public sealed class CombatModel
    {

        public event Action<int> HPChanged;

        public event Action<int> ArmorHPChanged;


        public event Action HPEnded;

        public event Action ArmorHPEnded;


        public int HP { get; private set; }

        public int ArmorHP { get; private set; }


        private readonly IHealthStats _baseStats;


        public CombatModel(IHealthStats baseStats)
        {

            _baseStats = baseStats;

            HP = _baseStats.MaxHp;
        }


        public void OnArmorChanged(int armorHp)
        {

            ArmorHP = armorHp;
        }
    }
}
