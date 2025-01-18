using System;
using UnityEngine;

namespace Movement
{

    [Serializable]
    public struct MovementSpeed
    {

        [Range(1, 10), Space]
        public int Crouch;


        [Range(1, 10), Space]
        public int Walk;


        [Range(1, 10), Space]
        public int Sprint;


        public MovementSpeed(int crouch, int walk, int sprint)
        {

            Crouch = crouch;

            Walk = walk;

            Sprint = sprint;
        }


        public static MovementSpeed operator+(MovementSpeed left,
            MovementSpeed right)
        {

            return new MovementSpeed(left.Crouch + right.Crouch,

                left.Walk + right.Walk, left.Sprint + right.Sprint);
        }
    }
}
