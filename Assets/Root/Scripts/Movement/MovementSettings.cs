using System;
using UnityEngine;

namespace Movement
{

    [Serializable]
    public struct MovementSettings
    {

        [Space]
        public MovementSpeed Speed;


        [Space]
        public MovementVolume Volume;

    }
}
