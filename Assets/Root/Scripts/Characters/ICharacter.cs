using Combat.Armors;
using Combat;
using Movement;
using UnityEngine;

namespace Characters
{
    public interface ICharacter
    {

        public Rigidbody2D Rigidbody { get;}

        public MovementStats BaseMovement { get; }

        public HealthStats BaseHealth { get; }

        public ArmorSet ArmorSet { get; }
    }
}
