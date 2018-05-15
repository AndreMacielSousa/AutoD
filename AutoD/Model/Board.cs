namespace AutoD.Model
{
    using Players;
    using System.Collections.Generic;

    public static class Board
    {
        public static List<Player> players;
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
