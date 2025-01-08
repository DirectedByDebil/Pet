using UnityEngine;

namespace Combat.Armors
{

    [CreateAssetMenu(fileName = "New Legs Preset",
        menuName = "Characters/Armors/Legs Armor", order = 2)]
    
    public sealed class LegsArmorPreset : ScriptableObject
    {

        [field: SerializeField, Space]
        public LegsArmor Armor { get; private set; }
    }
}