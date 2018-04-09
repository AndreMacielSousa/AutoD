namespace AutoD.Controller.States
{
    using System;
    using Model;

    public class PlayerRollState : State
    {
        public PlayerRollState(State nextState)
            : base(nextState) { }

        public override void Execute()
        {
            Random rng = new Random();

            int currentPlayerPosition = Board.players[Board.CurrentPlayerIndex].CurrentPosition;

            int firstDiceNumber = rng.Next(1, 7);
            int secondDiceNumber = rng.Next(1, 7);
            int totalPositionToMove = firstDiceNumber + secondDiceNumber;

            PlayerMoveState.PlayerOldPosition = currentPlayerPosition;
            Start.game.renderer.FirstDice.ChangeDiceImage(firstDiceNumber);
            Start.game.renderer.SecondDice.ChangeDiceImage(secondDiceNumber);
            Start.game.renderer.NotificationText = "Player " + (Board.CurrentPlayerIndex + 1) + " rolled " + totalPositionToMove;
            Board.players[Board.CurrentPlayerIndex].SetPosition(currentPlayerPosition + totalPositionToMove);

            StateMachine.ChangeState();
        }
    }
}
