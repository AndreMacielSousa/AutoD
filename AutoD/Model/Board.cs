using System.Collections.Generic;

namespace AutoD.Model
{
    using Players;
    using Tiles;

    public static class Board
    {
        public static List<Player> players;
        public static List<Tile> allTiles;
        public static int CurrentPlayerIndex;

        public static void InitializeBoard()
        {
            CurrentPlayerIndex = 0;

            players = new List<Player>()
            {
                new Player(1),
                new Player(2)
            };

        }


    }
}
