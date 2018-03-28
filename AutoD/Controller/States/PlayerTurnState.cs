using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoD.Controller.States
{
    using View.Renderers;
    using View.UI;
    using Model;
    using Microsoft.Xna.Framework.Input;

    public class PlayerTurnState : State
    {

        public PlayerTurnState(State nextState)
    : base(nextState) { }

        public override void Execute()
        {
            StateMachine.ChangeState();
        }

    }
}
