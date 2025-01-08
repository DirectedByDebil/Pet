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
    }
}
