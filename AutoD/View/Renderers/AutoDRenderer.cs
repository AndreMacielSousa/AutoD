
namespace AutoD.View.Renderers
{

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using UI;
    using AutoD.Controller;
    using System.Collections.Generic;
    using System.Linq;

    public class AutoDRenderer : AbstractRenderer
    {
        private ContentManager Content = Start.game.Content;
        private SpriteBatch SpriteBatch;

        private Background background;

        public AutoDRenderer()
        {
            this.background = UIInitializer.CreateBackground(Content);
        }
        public override void DrawBoard()
        {
            this.SpriteBatch = Start.game.SpriteBatch;

            background.Draw(SpriteBatch);
        }
    }
}
