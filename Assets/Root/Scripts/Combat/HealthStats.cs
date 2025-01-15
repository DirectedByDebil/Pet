using UnityEngine;

namespace Combat
{

    [CreateAssetMenu(fileName = "New Health Stats",
    menuName = "Characters/Health Stats", order = 1)]

    public sealed class HealthStats : ScriptableObject, IHealthStats
    {

        [field: SerializeField, Range(1, 20), Space]
        public int MaxHp { get; private set; }
    }
}
