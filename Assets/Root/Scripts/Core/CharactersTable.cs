using Characters;
using UnityEngine;
using System.Collections.Generic;

namespace Core
{
    public sealed class CharactersTable : MonoBehaviour
    {

        [SerializeField]
        private List<Character> _characters = new ();
    }
}
