

namespace AutoD.View.UI
{ 
        using Microsoft.Xna.Framework;
        using Microsoft.Xna.Framework.Content;
        using Microsoft.Xna.Framework.Graphics;

    public static class UIInitializer
    {
        public static Background CreateBackground(ContentManager content)
        {
            Texture2D backgroundImage = content.Load<Texture2D>("Pista0");
            Rectangle backgroundRectangle = new Rectangle(0, 0, 668, 1600);
            Sprite backgroundSprite = new Sprite(backgroundRectangle, backgroundImage);

            Background background = new Background(backgroundSprite);
            return background;
        }
    }
}
