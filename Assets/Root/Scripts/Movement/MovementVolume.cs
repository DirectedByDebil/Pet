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
    }
}
