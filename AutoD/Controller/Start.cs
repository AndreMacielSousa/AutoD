using AutoD.Controller;

namespace AutoD
{
    
    public static class Start
    {
        public static AutoDjogo game;
        static void Main()
        {
            using (game = new AutoDjogo())
                game.Run();
        }
    }
}
