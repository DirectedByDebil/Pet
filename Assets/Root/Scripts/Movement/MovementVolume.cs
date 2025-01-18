using System;
using UnityEngine;

namespace Movement
{
    [Serializable]
    public struct MovementVolume
    {

        [Range(1, 20), Space]
        public int Crouch;


        [Range(1, 20), Space]
        public int Walk;


        [Range(1, 20), Space]
        public int Sprint;


        public MovementVolume(int crouch, int walk, int sprint)
        {

            Crouch = crouch;

            Walk = walk;

            Sprint = sprint;
        }


        public static MovementVolume operator +(MovementVolume left,
            MovementVolume right)
        {

            return new MovementVolume(left.Crouch + right.Crouch,

                left.Walk + right.Walk, left.Sprint + right.Sprint);
        }

    }
}
