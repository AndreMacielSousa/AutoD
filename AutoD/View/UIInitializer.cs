

namespace AutoD.View.UI
{ 
        using Microsoft.Xna.Framework;
        using Microsoft.Xna.Framework.Content;
        using Microsoft.Xna.Framework.Graphics;

    class UIInitializer
    {
        public static Background CreateBackground(ContentManager content)
        {
            Texture2D backgroundImage = content.Load<Texture2D>("pista");
            Rectangle backgroundRectangle = new Rectangle(0, 0, 700, 700);
            Sprite backgroundSprite = new Sprite(backgroundRectangle, backgroundImage);

            Background background = new Background(backgroundSprite);
            return background;
        }
    }
}
