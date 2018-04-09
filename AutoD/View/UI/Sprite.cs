namespace AutoD.View.UI
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Sprite
    {
        public Sprite(Rectangle rectangle, Texture2D image)
        {
            Rectangle = rectangle;
            Image = image;
        }

        public Rectangle Rectangle;
        public Texture2D Image { get; set; }
    }
}
