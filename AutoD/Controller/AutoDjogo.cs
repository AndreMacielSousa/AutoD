namespace AutoD.Controller
{

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using AutoD.View.Renderers;
    using System;

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
            graphics.PreferredBackBufferHeight = 700;
            graphics.PreferredBackBufferWidth = 700;

            

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
            //EVENTS AN DELEGATES
            renderer.Closed += new ClosedEventHandler(EscapePressd);
            renderer.Change();
            Elapsed = (double)gameTime.ElapsedGameTime.TotalSeconds;
            StateMachine.CurrentState.Execute();
            base.Update(gameTime);
        }

           //EVENTS AN DELEGATES
        
        void EscapePressd (object source, EventArgs e)
        {
            MonoGameRenderer renderer = (MonoGameRenderer)source;
            Exit();
        }



        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            SpriteBatch.Begin();
            StateMachine.CurrentState.Draw(renderer);
            SpriteBatch.End();
            base.Draw(gameTime);
        }


    }
}
