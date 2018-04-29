namespace AutoD
{
    using AutoD.Model;
    using AutoD.View;

    public static class Start
    {
        public static AutoDjogo game;
        static void Main()
        {
            using (game = new AutoDjogo())
            {
                try
                {
                    game.Tester();
                }
                catch (TestFileNotFoundException ex)
                {
                    ExceptionMessage.Message($"Error Starting Game:\n {ex.Message}\n {ex.FileName}");
                    return;
                }
                
                game.Run();
            }

            
        }
    
    }
}

