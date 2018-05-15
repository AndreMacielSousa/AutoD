namespace AutoD.View.UI
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Button
    {
        public Button(Sprite sprite, Texture2D hoverImage, Texture2D clickedImage, Texture2D inactiveImage)
        {
            Sprite = sprite;
            this.hoverImage = hoverImage;
            this.clickedImage = clickedImage;
            this.inactiveImage = inactiveImage;
        }

        public Sprite Sprite { get; set; }
        private Texture2D hoverImage { get; set; }
        private Texture2D clickedImage { get; set; }
        private Texture2D inactiveImage { get; set; }

        public void ChangeToHoverImage() => Sprite.Image = hoverImage;

        public void ChangeToClickedImage() => Sprite.Image = clickedImage;

        public void ChangeToInactiveImage() => Sprite.Image = inactiveImage;

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Sprite.Image, Sprite.Rectangle, Color.White);
        }
    }
}
