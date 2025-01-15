using UnityEngine;
using Movement;
using Combat;

namespace Characters
{

    [RequireComponent(typeof(Rigidbody2D))]
    public class Character : MonoBehaviour
    {

        public Rigidbody2D Rigidbody { get; private set; }

        public MovementStats Movement {  get; private set; }


        [SerializeField, Space]
        private MovementPreset _baseMovement;


        [SerializeField, Space]
        private HealthStats _baseHealth;



        private void OnValidate()
        {
            
            Rigidbody = GetComponent<Rigidbody2D>();
        }


        public void Construct(MovementStats bonusMovement)
        {
            
            //Movement = movement + _baseMovement.Settings;
        }
    }
}