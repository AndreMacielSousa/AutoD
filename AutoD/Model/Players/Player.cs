using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoD.Model.Players
{
    using Interfaces;
    using System.Collections.Generic;

    public class Player : IPlayer
    {
        public const int TOTAL_NUMBER_OF_TILES = 40;

        public Player(int index)
        {
            this.Index = index;
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
            //    this.IncrementLap(1);
            }
            this.CurrentPosition = modifiedPosition;
        }


        public int CurrentPosition { get; private set; } = 0;

        public int Index { get; private set; }

    }
}
