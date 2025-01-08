using UnityEngine;
using Movement;
using Combat;

namespace Characters
{

    [RequireComponent(typeof(Rigidbody2D))]
    public class Character : MonoBehaviour
    {

        public Rigidbody2D Rigidbody { get; private set; }

        public MovementSettings Movement {  get; private set; }


        [SerializeField, Space]
        private MovementPreset _baseMovement;


        [SerializeField, Space]
        private HealthPreset _baseHealth;



        private void OnValidate()
        {
            
            Rigidbody = GetComponent<Rigidbody2D>();
        }


        public void Construct(MovementSettings bonusMovement)
        {
            
            //Movement = movement + _baseMovement.Settings;
        }
    }
}