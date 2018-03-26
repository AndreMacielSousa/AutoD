namespace AutoD.Controller
{
    
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using AutoD.View.Renderers;
    using Controller;


    public class AutoDjogo : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch SpriteBatch;
        public AutoDRenderer renderer;

        public double Elapsed;

        public AutoDjogo()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferHeight = 668;
            graphics.PreferredBackBufferWidth = 1600;
        }
    }
}
