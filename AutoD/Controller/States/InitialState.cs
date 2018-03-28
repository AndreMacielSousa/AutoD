using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoD.Controller.States
{
    using View.Renderers;
    using Model;

    public class InitialState : State
    {
        public InitialState(State nextState)
            : base(nextState) { }

        public override void Execute()
        {
            Board.InitializeBoard();
        }
    }
}
