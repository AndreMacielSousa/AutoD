namespace AutoD.Controller.States
{
    using Model;

    public class InitialState : State
    {
        public InitialState(State nextState)
            : base(nextState) { }

        public override void Execute() => Board.InitializeBoard();
    }
}
