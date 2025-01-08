using UnityEngine;

namespace Movement
{
    [CreateAssetMenu(fileName ="New Movement Preset",     
        menuName = "Characters/Movement Preset", order = 1)]
    
    public sealed class MovementPreset : ScriptableObject
    {

        [field: SerializeField, Space]
        public MovementSettings Settings { get; private set; }
    }
}