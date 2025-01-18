using Movement;
using Combat.Armors;
using Inventories;

namespace Characters
{
    public sealed class CharacterModel
    {

        #region Hp/Armor Hp

        public int Hp { get; private set; }

        public int ArmorHp { get; private set; }

        #endregion


        public InventorySize InventorySize { get; private set; }


        #region Total Speed/Volume

        public MovementSpeed TotalSpeed { get; private set; }
        
        public MovementVolume TotalVolume { get; private set; }

        #endregion


        private readonly ICharacter _character;



        public CharacterModel(ICharacter character)
        {

            _character = character;


            UseBaseStats();

            AddArmorStats();
        }


        #region Base Stats

        private void UseBaseStats()
        {

            Hp = _character.BaseHealth.MaxHp;    

            SetBaseMovement();
        }


        private void SetBaseMovement()
        {

            TotalSpeed = _character.BaseMovement.Speed;

            TotalVolume = _character.BaseMovement.Volume;
        }

        #endregion


        #region Use Armor Stats

        private void AddArmorStats()
        {

            UpdateChestArmor();

            TryUseLegsArmor();
        }


        private void UpdateChestArmor()
        {

            if (_character.ArmorSet.TryGetChest(out IChestArmor chest))
            {

                InventorySize = chest.InventorySize;

                ArmorHp = chest.MaxArmorHp;
            }
            else
            {

                InventorySize = InventorySize.Small;

                ArmorHp = 0;
            }
        }


        private void TryUseLegsArmor()
        {

            if(_character.ArmorSet.TryGetLegs(out ILegsArmor legs))
            {

                TotalSpeed += legs.Speed;

                TotalVolume += legs.Volume;
            }
        }
        
        #endregion
    }
}
