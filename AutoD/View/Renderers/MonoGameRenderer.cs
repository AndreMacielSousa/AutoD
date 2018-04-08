
namespace AutoD.View.Renderers
{

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using AutoD.View.UI;
    using AutoD.Controller;
    using System.Collections.Generic;
    using System.Linq;

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
        public Rectangle[] TileColliders;
        private SpriteFont font;
        public string NotificationText;

        public MonoGameRenderer()
        {
            this.background = UIInitializer.CreateBackground(Content);
            this.RollButton = UIInitializer.CreateRollButton(Content);
            this.EndTurnButton = UIInitializer.CreateEndTurnButton(Content);
            this.FirstDice = UIInitializer.CreateDice(Content, 1);
            this.SecondDice = UIInitializer.CreateDice(Content, 2);
            this.FirstPlayer = UIInitializer.CreatePlayer(Content, 1);
            this.SecondPlayer = UIInitializer.CreatePlayer(Content, 2);


            this.PlayersUI = new List<PlayerUI>();
            this.PlayersUI.Add(FirstPlayer);
            this.PlayersUI.Add(SecondPlayer);

           
            this.TileColliders = UIInitializer.CreateTileColliders();
            this.Velocity = 400;
            this.ShouldPlayerMove = false;

            //Test

            this.NotificationText = "AutoD BRRRRRRRumm";
            this.font = Content.Load<SpriteFont>("Font");


        }

        public override void DrawBoard()
        {
            this.SpriteBatch = Start.game.SpriteBatch;
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
            SpriteBatch.DrawString(font, NotificationText, new Vector2(105, 105), Color.Black);
        }

        public override void MovePlayer(int playerIndex, int currentPosition, int newPosition)
        {

            //TODO


            /*
            PlayerUI currentPlayer = PlayersUI[playerIndex];
            TileDestination = TileColliders[newPosition];
            if (TileDestination.Contains(currentPlayer.Sprite.Rectangle))
            {
                this.ShouldPlayerMove = false;
            }
            else
            {

                if (currentPlayer.Sprite.Rectangle.Y > 606 && currentPlayer.Sprite.Rectangle.X > 30)
                {
                    currentPlayer.Sprite.Rectangle.X -= (int)(Velocity * EntryPoint.game.Elapsed);
                }
                else if (currentPlayer.Sprite.Rectangle.X <= 50 && currentPlayer.Sprite.Rectangle.Y > 30)
                {
                    currentPlayer.Sprite.Rectangle.Y -= (int)(Velocity * EntryPoint.game.Elapsed);
                }
                else if (currentPlayer.Sprite.Rectangle.Y <= 50 && currentPlayer.Sprite.Rectangle.X < 650)
                {
                    currentPlayer.Sprite.Rectangle.X += (int)(Velocity * EntryPoint.game.Elapsed);
                }
                else if (currentPlayer.Sprite.Rectangle.X >= 620 && currentPlayer.Sprite.Rectangle.Y < 680)
                {
                    currentPlayer.Sprite.Rectangle.Y += (int)(Velocity * EntryPoint.game.Elapsed);
                }
            }
            */
        }
    }
}
