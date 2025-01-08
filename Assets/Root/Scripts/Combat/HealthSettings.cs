using System;
using UnityEngine;

namespace Combat
{
    [Serializable]
    public struct HealthSettings
    {

        [Range(1, 200), Space]
        public int MaxHp;


        //#TODO maybe some perks
    }
}
