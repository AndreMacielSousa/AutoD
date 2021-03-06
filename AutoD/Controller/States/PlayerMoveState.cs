﻿namespace AutoD.Controller.States
{
    using Model;

    public class PlayerMoveState : State
    {
        public static int PlayerOldPosition { get; set; }

        public PlayerMoveState(State nextState)
            : base(nextState) { }

        public override void Execute()
        {
            Start.game.renderer.MovePlayer(Board.CurrentPlayerIndex, PlayerOldPosition, Board.players[Board.CurrentPlayerIndex].CurrentPosition);
            if (!Start.game.renderer.ShouldPlayerMove)
            {
                StateMachine.ChangeState();
            }
        }
    }
}
