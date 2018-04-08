using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoD.Controller.States
{
    using View.Renderers;
    using Model.Tiles;
    using Model;
    using View.UI;
    using Microsoft.Xna.Framework.Input;

    public class PlayerLandedState : State
    {
        public PlayerLandedState(State nextState)
            : base(nextState) { }

        public override void Execute()
        {
            int playerIndex = Board.CurrentPlayerIndex;
            var playerCurrentPosition = Board.players[playerIndex].CurrentPosition;
            Tile currentTile = Board.allTiles[playerCurrentPosition];
           
            ActivateEndTurnButton();

        }

        private void ActivateEndTurnButton()
        {
            Button endTurnButton = Start.game.renderer.EndTurnButton;

            bool mouseOverendTurn = endTurnButton.Sprite.Rectangle.Contains(Mouse.GetState().X, Mouse.GetState().Y);
            if (mouseOverendTurn)
            {
                endTurnButton.ChangeToHoverImage();
            }
            else
            {
                endTurnButton.ChangeToInactiveImage();
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && mouseOverendTurn)
            {
                endTurnButton.ChangeToClickedImage();
               
                StateMachine.ChangeState();
            }
        }

     }
}
