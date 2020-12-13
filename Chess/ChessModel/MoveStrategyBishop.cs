using System;

namespace Chess.ChessModel
{
    internal class MoveStrategyBishop : IMoveStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return IsDiagonalMove(currentCoord, nextCoord);
        }

        private bool IsDiagonalMove(string currentCoord, string nextCoord)
        {
            return Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]);
        }
    }
}
