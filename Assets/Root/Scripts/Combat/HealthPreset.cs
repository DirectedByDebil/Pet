using UnityEngine;

namespace Combat
{

    [CreateAssetMenu(fileName = "New Health Preset",
    menuName = "Characters/Health Preset", order = 1)]

    public sealed class HealthPreset : ScriptableObject
    {

        [field: SerializeField, Space]
        public HealthSettings Settings { get; private set; }
    }
}
