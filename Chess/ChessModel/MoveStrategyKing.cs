using System;

namespace Chess.ChessModel
{
    internal class MoveStrategyKing : IMoveStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return IsNeighbors(currentCoord, nextCoord);
        }

        private bool IsNeighbors(string currentCoord, string nextCoord)
        {
            return Math.Abs(nextCoord[0] - currentCoord[0]) <= 1 && Math.Abs(nextCoord[1] - currentCoord[1]) <= 1;
        }
    }
}
