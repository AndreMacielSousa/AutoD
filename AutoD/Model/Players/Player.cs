namespace AutoD.Model.Players
{
    using Interfaces;

    public class Player : IPlayer
    {
        public const int TOTAL_NUMBER_OF_TILES = 40;
        public const int INITIAL_LAPS = 0;

        public Player(int index)
        {
            Index = index;
        }

        public void SetPosition(int newPosition)
        {
            int modifiedPosition = newPosition;

            if (modifiedPosition < 0)
            {
                modifiedPosition += TOTAL_NUMBER_OF_TILES;
               
            }
            if (modifiedPosition >= TOTAL_NUMBER_OF_TILES)
            {
                modifiedPosition = modifiedPosition - TOTAL_NUMBER_OF_TILES;
                IncrementLap(1);
            }
            CurrentPosition = modifiedPosition;
            
        }

        public void IncrementLap(int lap)
        {
            Laps += lap;
        }

        public int CurrentPosition { get; private set; } = 0;

        public int Index { get; private set; }

        public int Laps { get; private set; } = INITIAL_LAPS;


    }
}
