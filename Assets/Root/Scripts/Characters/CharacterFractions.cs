using System.Collections.Generic;

namespace Characters
{
    public sealed class CharacterFractions
    {

        public Fractions VisibleFraction { get; private set; }



        private List<Fractions> _friends;

        private List<Fractions> _enemies;


        public SocialResponds GetRespond(Fractions fraction)
        {

            if(_friends.Contains(fraction))
            {

                return SocialResponds.Greetings;

            }
            else if (_enemies.Contains(fraction))
            {

                return SocialResponds.Warning;
            }


            return SocialResponds.Neutral;
        }


        public void OnVisibleFractionChanged(Fractions fraction)
        {

            VisibleFraction = fraction;
        }
    }
}
