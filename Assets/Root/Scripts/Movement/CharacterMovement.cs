namespace Movement
{
    public class CharacterMovement
    {

        public MovementSpeed TotalSpeed { get; private set; }

        public MovementVolume TotalVolume { get; private set; }


        private readonly IMovementStats _baseStats;


        public CharacterMovement(IMovementStats baseStats)
        {
            
            _baseStats = baseStats;
        }


        public void OnMovementChanged(IMovementStats bonus)
        {

            TotalSpeed = _baseStats.Speed + bonus.Speed;

            TotalVolume = _baseStats.Volume + bonus.Volume;
        }
    }
}
