using System;

namespace Chess.ChessModel
{
    internal class MoveStrategyQueen : IMoveStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return IsDiagonalMove(currentCoord, nextCoord) || IsStraightMove(currentCoord, nextCoord);
        }

        private bool IsDiagonalMove(string currentCoord, string nextCoord)
        {
            return Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]);
        }

        private bool IsStraightMove(string currentCoord, string nextCoord)
        {
            return nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1];
        }
    }
}
