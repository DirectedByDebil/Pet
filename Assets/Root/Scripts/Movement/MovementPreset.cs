using UnityEngine;

namespace Movement
{
    [CreateAssetMenu(fileName ="New Movement Preset",     
        menuName = "Characters/Movement Preset", order = 1)]
    
    public sealed class MovementPreset : ScriptableObject
    {

        [field: SerializeField, Space]
        public MovementStats Settings { get; private set; }
    }
}