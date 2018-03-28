
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

        private Background background;

        //todo

        private SpriteFont font;
        public string NotificationText;

        public MonoGameRenderer()
        {
            this.background = UIInitializer.CreateBackground(Content);


            //Test
            this.NotificationText = "AutoD BRRRRRRRumm";
            this.font = Content.Load<SpriteFont>("Font");
                        
        }



        public override void DrawBoard()
        {
            this.SpriteBatch = Start.game.SpriteBatch;
            background.Draw(SpriteBatch);

            //Test
            SpriteBatch.DrawString(font, NotificationText, new Vector2(105, 105), Color.Black);
        }
    }
}
