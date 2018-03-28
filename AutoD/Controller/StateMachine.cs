using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoD.Controller
{
    using States;
    using System.Collections.Generic;

    public static class StateMachine
    {
        public static State CurrentState;
        public static Dictionary<string, State> States = new Dictionary<string, State>();
        private static InitialState initialState;
        private static PlayerTurnState playerTurnState;

        public static void Initialize()
        {

            initialState = new InitialState(playerTurnState);

            States.Add("InitialState", initialState);

        }
        public static void ChangeState()
        {
            CurrentState = CurrentState.NextState;
        }
    }
}
