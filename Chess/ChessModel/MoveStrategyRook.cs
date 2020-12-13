namespace Chess.ChessModel
{
    internal class MoveStrategyRook : IMoveStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return IsStraightMove(currentCoord, nextCoord);
        }

        private bool IsStraightMove(string currentCoord, string nextCoord)
        {
            return nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1];
        }
    }
}
