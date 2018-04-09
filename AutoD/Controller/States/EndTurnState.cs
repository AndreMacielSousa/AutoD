namespace AutoD.Controller.States
{
    using View.UI;
    using Microsoft.Xna.Framework.Input;
    using Model;

    public class EndTurnState : State
    {
        public EndTurnState(State nextState)
            : base(nextState) { }

        public override void Execute()
        {
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
                Board.CurrentPlayerIndex = (Board.CurrentPlayerIndex + 1) % 2;
                StateMachine.ChangeState();
            }
        }
    }
}
