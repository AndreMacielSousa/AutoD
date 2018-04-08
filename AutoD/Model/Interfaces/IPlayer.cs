using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoD.Model.Interfaces
{
    public interface IPlayer
    {
        int CurrentPosition { get; }
        int Index { get; }
        void SetPosition(int newPosition);
    }
}

