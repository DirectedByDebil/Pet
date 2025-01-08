using UnityEngine;

namespace Combat.Armors
{

    [CreateAssetMenu(fileName ="New Chest Preset", 
        menuName = "Characters/Armors/Chest Armor", order = 2)]

    public sealed class ChestArmorPreset : ScriptableObject
    {

        [field: SerializeField, Space]
        public ChestArmor Armor { get; private set; }
    }
}
