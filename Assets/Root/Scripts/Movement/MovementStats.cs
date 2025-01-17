using UnityEngine;

namespace Movement
{
    [CreateAssetMenu(fileName = "New Movement Stats",
        menuName = "Characters/Movement Stats", order = 1)]

    public sealed class MovementStats : ScriptableObject, IMovementStats
    {

        [field: SerializeField, Space]
        public MovementSpeed Speed { get; private set; }


        [field: SerializeField, Space]
        public MovementVolume Volume { get; private set; }
    }
}