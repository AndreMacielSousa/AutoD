namespace AutoD.View.Renderers
{
    public abstract class AbstractRenderer
    {
        public abstract void DrawBoard();
        public abstract void MovePlayer(int index, int currentPosition, int newPosition);
    }
}



