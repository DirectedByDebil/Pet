using UnityEngine;

namespace Combat.Armors
{
    public sealed class HeadGadget : MonoBehaviour, IHead
    {

        public ArmorType Type => ArmorType.Head;


        [field: SerializeField, Space]
        public HeadGadgets Gadget {  get; private set; }
    }
}
