using Movement;
using UnityEngine;

namespace Combat.Armors
{

    [CreateAssetMenu(fileName = "New Legs Stats",
        menuName = "Characters/Armors/Legs Stats", order = 2)]

    public sealed class LegsArmorStats : ScriptableObject, ILegsArmor
    {
        public ArmorType Type => ArmorType.Legs;


        [field: SerializeField, Space]
        public MovementSpeed Speed { get; private set; }


        [field: SerializeField, Space]
        public MovementVolume Volume { get; private set; }
    }
}