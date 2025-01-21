using Combat;
using Movement;
using Inventories;

namespace Characters
{
    public sealed class CharacterModel
    {

        public CharacterMovement Movement { get => _movement; }

        public Inventory Inventory { get => _inventory; }

        public CombatModel Combat { get => _combat; }

        public CharacterFractions Fractions { get => _fractions; }


        private readonly CharacterMovement _movement;

        private readonly Inventory _inventory;

        private readonly CombatModel _combat;

        private readonly CharacterFractions _fractions;


        public CharacterModel(ICharacter character)
        {

            _movement = new CharacterMovement(character.BaseMovement);

            _inventory = new Inventory();

            _combat = new CombatModel(character.BaseHealth);

            _fractions = new CharacterFractions();
        }


        public void SetModel()
        {

            _inventory.MovementChanged += _movement.OnMovementChanged;

            _inventory.ArmorHpChanged += _combat.OnArmorChanged;

            _inventory.VisibleFractionChanged += _fractions.OnVisibleFractionChanged;


            _combat.ArmorHPChanged += _inventory.OnArmorHpChanged;
        }


        public void UnsetModel()
        {

            _inventory.MovementChanged -= _movement.OnMovementChanged;

            _inventory.ArmorHpChanged -= _combat.OnArmorChanged;

            _inventory.VisibleFractionChanged -= _fractions.OnVisibleFractionChanged;


            _combat.ArmorHPChanged -= _inventory.OnArmorHpChanged;
        }
    }
}
