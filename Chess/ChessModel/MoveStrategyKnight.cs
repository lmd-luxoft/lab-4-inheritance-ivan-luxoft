using System;

namespace Chess.ChessModel
{
    internal class MoveStrategyKnight : IMoveStrategy
    {
        public bool CanMove(string currentCoord, string nextCoord)
        {
            return IsMoveLShape(currentCoord, nextCoord);
        }

        private bool IsMoveLShape(string currentCoord, string nextCoord)
        {
            var dx = Math.Abs(nextCoord[0] - currentCoord[0]);
            var dy = Math.Abs(nextCoord[1] - currentCoord[1]);

            return dx == 1 && dy == 2 || dx == 2 && dy == 1;
        }
    }
}
