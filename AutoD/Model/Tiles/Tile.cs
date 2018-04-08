using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoD.Model.Tiles
{
    using Interfaces;


    public abstract class Tile : ITile
    {
        public Tile(int index)
        {
            this.Index = index;
            
        }

        public int Index { get; private set; }

             

    }
}
