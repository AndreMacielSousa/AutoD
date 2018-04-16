namespace AutoD.View.Renderers
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using AutoD.View.UI;
    using System.Collections.Generic;
    using System;

    //EVENTS AN DELEGATES
    public delegate void ClosedEventHandler(object source, EventArgs args);


    public class MonoGameRenderer : AbstractRenderer
    {
      
        private ContentManager Content = Start.game.Content;
        private SpriteBatch SpriteBatch;
        
        //todo buttons and dice
        public Button RollButton;
        public Button EndTurnButton;

        public Dice FirstDice;
        public Dice SecondDice;

        public List<PlayerUI> PlayersUI;
        public PlayerUI FirstPlayer;
        public PlayerUI SecondPlayer;
        private int Velocity;
        private Rectangle TileDestination;
        public bool ShouldPlayerMove;

        private Background background;

        //todo
        public string PlayerOneLaps;
        public string PlayerTwoLaps;

        public Rectangle[] TileColliders;
        private SpriteFont font;
        public string NotificationText;

        public MonoGameRenderer()
        {
            background = UIInitializer.CreateBackground(Content);
            RollButton = UIInitializer.CreateRollButton(Content);
            EndTurnButton = UIInitializer.CreateEndTurnButton(Content);
            FirstDice = UIInitializer.CreateDice(Content, 1);
            SecondDice = UIInitializer.CreateDice(Content, 2);
            FirstPlayer = UIInitializer.CreatePlayer(Content, 1);
            SecondPlayer = UIInitializer.CreatePlayer(Content, 2);


            PlayersUI = new List<PlayerUI>();
            PlayersUI.Add(FirstPlayer);
            PlayersUI.Add(SecondPlayer);


            TileColliders = UIInitializer.CreateTileColliders();
            Velocity = 200;
            ShouldPlayerMove = false;

            //Test

            NotificationText = "AutoD BRRRRRRRumm";
            PlayerOneLaps = "0 Lap";
            PlayerTwoLaps = "0 Lap";
            font = Content.Load<SpriteFont>("Font");

                                             
        }

        public override void DrawBoard()
        {
            SpriteBatch = Start.game.SpriteBatch;
            background.Draw(SpriteBatch);
            RollButton.Draw(SpriteBatch);
            EndTurnButton.Draw(SpriteBatch);

            FirstDice.Draw(SpriteBatch);
            SecondDice.Draw(SpriteBatch);

            foreach (var player in PlayersUI)
            {
                player.Draw(SpriteBatch);
            }


            //Test
            SpriteBatch.DrawString(font, NotificationText, new Vector2(105, 105), Color.DarkMagenta);
            SpriteBatch.DrawString(font, PlayerOneLaps, new Vector2(150, 525), Color.Blue);
            SpriteBatch.DrawString(font, PlayerTwoLaps, new Vector2(150, 560), Color.Red);


        }

        public override void MovePlayer(int playerIndex, int currentPosition, int newPosition)
        {

            //TODO
                        
            PlayerUI currentPlayer = PlayersUI[playerIndex];
            TileDestination = TileColliders[newPosition];
            if (TileDestination.Contains(currentPlayer.Sprite.Rectangle))
            {
                ShouldPlayerMove = false;
            }
            else
            {

                if (currentPlayer.Sprite.Rectangle.Y > 606 && currentPlayer.Sprite.Rectangle.X > 30)
                {
                    currentPlayer.Sprite.Rectangle.X -= (int)(Velocity * Start.game.Elapsed);
                }
                else if (currentPlayer.Sprite.Rectangle.X <= 50 && currentPlayer.Sprite.Rectangle.Y > 30)
                {
                    currentPlayer.Sprite.Rectangle.Y -= (int)(Velocity * Start.game.Elapsed);
                }
                else if (currentPlayer.Sprite.Rectangle.Y <= 50 && currentPlayer.Sprite.Rectangle.X < 650)
                {
                    currentPlayer.Sprite.Rectangle.X += (int)(Velocity * Start.game.Elapsed);
                }
                else if (currentPlayer.Sprite.Rectangle.X >= 620 && currentPlayer.Sprite.Rectangle.Y < 680)
                {
                    currentPlayer.Sprite.Rectangle.Y += (int)(Velocity * Start.game.Elapsed);
                }
            }
            
        }


        //EVENTS AN DELEGATES

        
        public event ClosedEventHandler Closed;

        public virtual void OnClosed(EventArgs e)
        {
            if (Closed != null)
                Closed(this, e );
        }

        public void Change()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                OnClosed(new EventArgs());
        }

    }


}
