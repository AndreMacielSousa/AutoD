namespace AutoD.View.UI
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class PlayerUI
    {
        public int Index { get; private set; }
        public Sprite Sprite { get; set; }

        public PlayerUI(Sprite sprite, int index)
        {
            Sprite = sprite;
            Index = index;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite.Image, Sprite.Rectangle, Color.White);
        }
    }
}
