

namespace AutoD.View.UI
{ 
        using Microsoft.Xna.Framework;
        using Microsoft.Xna.Framework.Content;
        using Microsoft.Xna.Framework.Graphics;

    public static class UIInitializer
    {
        public static Background CreateBackground(ContentManager content)
        {
            Texture2D backgroundImage = content.Load<Texture2D>("FInalBoard");
            Rectangle backgroundRectangle = new Rectangle(0, 0, 700, 700);
            Sprite backgroundSprite = new Sprite(backgroundRectangle, backgroundImage);

            Background background = new Background(backgroundSprite);
            return background;
        }

        public static Button CreateRollButton(ContentManager content)
        {
            Texture2D rollActive = content.Load<Texture2D>("Active");
            Texture2D rollClicked = content.Load<Texture2D>("Clicked");
            Texture2D rollHover = content.Load<Texture2D>("Hover");
            Rectangle rollRectangle = new Rectangle(300, 450, 120, 120);

            Sprite rollButtonSprite = new Sprite(rollRectangle, rollActive);
            Button rollButton = new Button(rollButtonSprite, rollHover, rollClicked, rollActive);

            return rollButton;
        }

        public static Button CreateEndTurnButton(ContentManager content)
        {
            Texture2D endTurnActive = content.Load<Texture2D>("EndTurn");
            Texture2D endTurnClicked = content.Load<Texture2D>("EndTurnClicked");
            Texture2D endTurnHover = content.Load<Texture2D>("EndTurnHover");
            Rectangle endTurnRectangle = new Rectangle(450, 450, 120, 120);

            Sprite endTurnSprite = new Sprite(endTurnRectangle, endTurnActive);
            Button buyButton = new Button(endTurnSprite, endTurnHover, endTurnClicked, endTurnActive);

            return buyButton;
        }

        public static Dice CreateDice(ContentManager content, int index)
        {
            Texture2D[] diceImages = new Texture2D[6];
            for (int i = 0; i < 6; i++)
            {
                diceImages[i] = content.Load<Texture2D>((i + 1).ToString());
            }

            Rectangle diceRectangle = new Rectangle(298 + index * 32, 560, 30, 30);
            Sprite diceSprite = new Sprite(diceRectangle, diceImages[0]);
            Dice dice = new Dice(diceSprite, diceImages);
            return dice;
        }

        public static PlayerUI CreatePlayer(ContentManager content, int index)
        {
            Texture2D playerImage = content.Load<Texture2D>("pawn" + index.ToString());
            Rectangle playerRectangle = new Rectangle(620, 590 + index * 33, 30, 30);
            Sprite playerSprite = new Sprite(playerRectangle, playerImage);
            PlayerUI playerUI = new PlayerUI(playerSprite, index);
            return playerUI;
        }

        public static Rectangle[] CreateTileColliders()
        {
            Rectangle[] tileColliders = new Rectangle[40];
            int xIncrement = 57;
            int WINDOW_WIDTH = 700;
            int WINDOW_HEIGHT = 700;

            tileColliders[0] = new Rectangle(607, 607, WINDOW_WIDTH - 607, WINDOW_HEIGHT - 607);
            tileColliders[1] = new Rectangle(607 - xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[2] = new Rectangle(607 - 2 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[3] = new Rectangle(607 - 3 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[4] = new Rectangle(607 - 4 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[5] = new Rectangle(607 - 5 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[6] = new Rectangle(607 - 6 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[7] = new Rectangle(607 - 7 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[8] = new Rectangle(607 - 8 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[9] = new Rectangle(607 - 9 * xIncrement, 607, xIncrement, WINDOW_HEIGHT - 607);
            tileColliders[10] = new Rectangle(0, 607, 93, WINDOW_HEIGHT - 607);
            tileColliders[11] = new Rectangle(0, 607 - xIncrement, 93, xIncrement);
            tileColliders[12] = new Rectangle(0, 607 - 2 * xIncrement, 93, xIncrement);
            tileColliders[13] = new Rectangle(0, 607 - 3 * xIncrement, 93, xIncrement);
            tileColliders[14] = new Rectangle(0, 607 - 4 * xIncrement, 93, xIncrement);
            tileColliders[15] = new Rectangle(0, 607 - 5 * xIncrement, 93, xIncrement);
            tileColliders[16] = new Rectangle(0, 607 - 6 * xIncrement, 93, xIncrement);
            tileColliders[17] = new Rectangle(0, 607 - 7 * xIncrement, 93, xIncrement);
            tileColliders[18] = new Rectangle(0, 607 - 8 * xIncrement, 93, xIncrement);
            tileColliders[19] = new Rectangle(0, 607 - 9 * xIncrement, 93, xIncrement);
            tileColliders[20] = new Rectangle(0, 0, 93, 93);
            tileColliders[21] = new Rectangle(93, 0, xIncrement, 93);
            tileColliders[22] = new Rectangle(93 + xIncrement, 0, xIncrement, 93);
            tileColliders[23] = new Rectangle(93 + 2 * xIncrement, 0, xIncrement, 93);
            tileColliders[24] = new Rectangle(93 + 3 * xIncrement, 0, xIncrement, 93);
            tileColliders[25] = new Rectangle(93 + 4 * xIncrement, 0, xIncrement, 93);
            tileColliders[26] = new Rectangle(93 + 5 * xIncrement, 0, xIncrement, 93);
            tileColliders[27] = new Rectangle(93 + 6 * xIncrement, 0, xIncrement, 93);
            tileColliders[28] = new Rectangle(93 + 7 * xIncrement, 0, xIncrement, 93);
            tileColliders[29] = new Rectangle(93 + 8 * xIncrement, 0, xIncrement, 93);
            tileColliders[30] = new Rectangle(607, 0, WINDOW_WIDTH - 607, 93);
            tileColliders[31] = new Rectangle(607, 93, 93, xIncrement);
            tileColliders[32] = new Rectangle(607, 93 + xIncrement, 93, xIncrement);
            tileColliders[33] = new Rectangle(607, 93 + 2 * xIncrement, 93, xIncrement);
            tileColliders[34] = new Rectangle(607, 93 + 3 * xIncrement, 93, xIncrement);
            tileColliders[35] = new Rectangle(607, 93 + 4 * xIncrement, 93, xIncrement);
            tileColliders[36] = new Rectangle(607, 93 + 5 * xIncrement, 93, xIncrement);
            tileColliders[37] = new Rectangle(607, 93 + 6 * xIncrement, 93, xIncrement);
            tileColliders[38] = new Rectangle(607, 93 + 7 * xIncrement, 93, xIncrement);
            tileColliders[39] = new Rectangle(607, 93 + 8 * xIncrement, 93, xIncrement);

            return tileColliders;
        }

    }


}
