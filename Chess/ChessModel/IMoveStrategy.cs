namespace Chess.ChessModel
{
    public interface IMoveStrategy
    {
        bool CanMove(string currentCoord, string nextCoord);
    }
}