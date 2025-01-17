using UnityEngine;
using Movement;
using Combat;
using Combat.Armors;

namespace Characters
{

    [RequireComponent(typeof(Rigidbody2D))]
    public class Character : MonoBehaviour, ICharacter
    {

        public Rigidbody2D Rigidbody { get; private set; }


        [field: SerializeField, Space]
        public MovementStats BaseMovement { get; private set; }


        [field: SerializeField, Space]
        public HealthStats BaseHealth { get; private set; }


        [field: SerializeField, Space]
        public ArmorSet ArmorSet {  get; private set; }


        private void OnValidate()
        {

            Rigidbody = GetComponent<Rigidbody2D>();
        }
    }
}