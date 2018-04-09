namespace AutoD.Model.Tiles
{
    using Interfaces;


    public abstract class Tile : ITile
    {
        public Tile(int index)
        {
            Index = index;
            
        }

        public int Index { get; private set; }

             

    }
}
