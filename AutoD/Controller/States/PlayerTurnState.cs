using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoD.Controller.States
{
    using View.Renderers;
    using Microsoft.Xna.Framework.Input;
    using View.UI;
    using Model;

    public class PlayerTurnState : State
    {

        public PlayerTurnState(State nextState)
    : base(nextState) { }

        public override void Execute()
        {
            Button rollButton = Start.game.renderer.RollButton;
            Start.game.renderer.NotificationText = "Player " + (Board.CurrentPlayerIndex + 1) + "'s turn. \nPlease roll!";

       /*     bool mouseOverRoll = rollButton.Sprite.Rectangle.Contains(Mouse.GetState().X, Mouse.GetState().Y);
            if (mouseOverRoll)
            {
                rollButton.ChangeToHoverImage();
            }
            else
            {
                rollButton.ChangeToInactiveImage();
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && mouseOverRoll)
            {
                rollButton.ChangeToClickedImage();
                Start.game.renderer.ShouldPlayerMove = true;
                StateMachine.ChangeState();
            } */
        }

    }
}
