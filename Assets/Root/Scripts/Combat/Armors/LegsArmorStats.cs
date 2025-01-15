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
        public MovementStats Movement { get; private set; }
    }
}