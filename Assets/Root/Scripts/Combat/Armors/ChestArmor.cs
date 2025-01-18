using UnityEngine;

namespace Combat.Armors
{

    public sealed class ChestArmor : MonoBehaviour
    {

        [field: SerializeField, Space]
        public ChestArmorStats Stats { get; private set; }

    }
}
