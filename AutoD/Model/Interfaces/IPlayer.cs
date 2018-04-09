namespace AutoD.Model.Interfaces
{
    public interface IPlayer
    {
        int CurrentPosition { get; }
        int Index { get; }
        int Laps { get; }
        void SetPosition(int newPosition);
    }
}

