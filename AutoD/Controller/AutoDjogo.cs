namespace AutoD.Controller
{
    
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Content;
    using AutoD.View.Renderers;
    using Controller;

    using View.UI;

    public class AutoDjogo : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch SpriteBatch;
        public MonoGameRenderer renderer;

        public double Elapsed;

        public AutoDjogo()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferHeight = 668;
            graphics.PreferredBackBufferWidth = 1600;

        }



        protected override void Initialize()
        {
            renderer = new MonoGameRenderer();
            StateMachine.Initialize();
            StateMachine.CurrentState = StateMachine.States["InitialState"];
            StateMachine.CurrentState.Execute();
            StateMachine.ChangeState();
            base.Initialize();

        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            Elapsed = (double)gameTime.ElapsedGameTime.TotalSeconds;
        //    StateMachine.CurrentState.Execute();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            SpriteBatch.Begin();
         //   StateMachine.CurrentState.Draw(renderer);
            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
