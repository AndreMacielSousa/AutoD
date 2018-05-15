namespace AutoD.Controller.States
{
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
            Start.game.renderer.PlayerOneLaps = Board.players[0].Laps + " Lap";
            Start.game.renderer.PlayerTwoLaps = Board.players[1].Laps + " Lap";

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
