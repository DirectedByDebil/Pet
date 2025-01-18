using UnityEngine;

namespace Combat.Armors
{
    public sealed class LegsArmor: MonoBehaviour
    {
        
        [field: SerializeField, Space]
        public LegsArmorStats Stats { get; private set; }
    }
}
